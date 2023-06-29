using QuanLyBaiXe.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using System.Reflection.Emit;
using QuanLyBaiXe.VControls;
using System.Threading;
using System.Xml.Serialization;
using QuanLyBaiXe.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QuanLyBaiXe
{
    public partial class vInOut : Form
    {
        private FilterInfoCollection cameras;
        private VideoCaptureDevice cam;
        private VideoCaptureDevice cam2;

        public vInOut()
        {
            InitializeComponent();
            Icon = Properties.Resources.icon;

            // bật camera
            cameras = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (cam != null && cam.IsRunning)
            {
                cam.Stop();
            }
            cam = cam2 = new VideoCaptureDevice(cameras[0].MonikerString);
            cam.NewFrame += Cam_NewFrame;
            cam2.NewFrame += Cam_NewFrame2;
            cam.Start();

            string imagesFolderPath = Path.Combine(Application.StartupPath, "images");
            string XeVaoFolderPath = Path.Combine(Application.StartupPath, "AnhXeVao");

            if (!Directory.Exists(imagesFolderPath))
            {
                Directory.CreateDirectory(imagesFolderPath);
            }

            if (!Directory.Exists(XeVaoFolderPath))
            {
                Directory.CreateDirectory(XeVaoFolderPath);
            }

            Loading();
            ClosedForm();
        }

        #region Method
        void Loading()
        {
            GetCurrentDate();
        }

        void ClosedForm()
        {
            this.FormClosing += new FormClosingEventHandler(vInOut_FormClosing);
            this.FormClosed += new FormClosedEventHandler(vInOut_FormClosed);
        }
        public void GetCurrentDate()
        {
            DateTimePicker dateTimePicker1 = new DateTimePicker();

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            dt_date.Texts = dateTimePicker1.Value.ToString(dateTimePicker1.CustomFormat);
        }
        #endregion

        #region Event
        private void bt_VIP_Click(object sender, EventArgs e)
        {
            vVIP v = new vVIP();
            this.Hide();
            v.ShowDialog();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            vSearch v = new vSearch();
            this.Hide();
            v.ShowDialog();
        }

        private void bt_Revenue_Click(object sender, EventArgs e)
        {
            vRevenue v = new vRevenue();
            this.Hide();
            v.ShowDialog();
        }

        private void bt_Log_Click(object sender, EventArgs e)
        {
            vLog v = new vLog();
            this.Hide();
            v.ShowDialog();
        }
        private void bt_Money_Click(object sender, EventArgs e)
        {
            vThamSo v = new vThamSo();
            this.Hide();
            v.ShowDialog();
        }

        private void bt_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LoggDAO.Instance.LogDangXuat();
                Environment.Exit(0);
            }
        }

        private void vInOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có thực sự muốn đăng xuất?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            LoggDAO.Instance.LogDangXuat();
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void vInOut_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void bt_xevao_Click(object sender, EventArgs e)
        {
            GetCurrentDate();
            string bienso = tb_biensoxevao.Texts;
            if (bienso == null || bienso.Length == 0)
            {
                return;
            }

            // lưu ảnh xe vào qua folder AnhXeVao
            string oldImgPath = Path.Combine(Application.StartupPath, "images", "temp.jpg");
            string newImgPath = Path.Combine(Application.StartupPath, "AnhXeVao", bienso + ".jpg");

            File.Copy(oldImgPath, newImgPath, true);

            bool xe = XeDAO.Instance.AddXe(bienso);

            LoggDAO.Instance.LogInOut(bienso, 0);
            XeDAO.Instance.AddXe(bienso);
        }


        private void bt_xera_Click(object sender, EventArgs e)
        {
            string bienso = tb_biensoxera.Texts;
            if (bienso == null || bienso.Length == 0)
            {
                return;
            }

            // xóa ảnh xe vào
            string tempImgPath = Path.Combine(Application.StartupPath, "images", "temp.jpg");
            string deleteImgPath = Path.Combine(Application.StartupPath, "AnhXeVao", bienso + ".jpg");

            XoaAnh(pic_AnhXeVao, deleteImgPath, tempImgPath);
            LoggDAO.Instance.LogInOut(bienso, 1);
        }

        // đọc biển số xe + camera
        public async void RunPythonScript(string imagePath, PictureBox ptb, VTextbox tb, int checkNum)
        {
            string result = "";
            await Task.Run(() =>
            {
                string program2Path = AppDomain.CurrentDomain.BaseDirectory;
                string folderName = "LicensePlateRecognization";

                for (int i = 1; i <= 3; i++)
                    program2Path = Path.GetDirectoryName(program2Path);
                program2Path = Path.Combine(program2Path, folderName);

                string pythonNameFile = @"main.py";

                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = "cmd.exe";
                start.Arguments = $"/C cd /D \"{program2Path}\" && python \"{pythonNameFile}\" --image_path=\"{imagePath}\""; // '/K' - mo cmd
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;
                start.CreateNoWindow = true;


                using (Process process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        result = reader.ReadToEnd();
                        result = result.Replace("\r", "");
                        result = result.Replace("\n", "");
                        Invoke((MethodInvoker)(() =>
                        {
                            if (string.IsNullOrEmpty(result))
                                tb.Texts = "Khong doc duoc";

                            tb.Texts = result;
                            ptb.Image = null;
                        }));
                    }
                }
            });

            if (checkNum == 2)
            {
                KiemTraBienXe(result);
            }

        }

        private void Cam_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bm = (Bitmap)eventArgs.Frame.Clone();
            pic_CamXeVao.Image = bm;
        }

        private void Cam_NewFrame2(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            Bitmap bm = (Bitmap)eventArgs.Frame.Clone();
            pic_CamXeRa.Image = bm;
        }

        #endregion
        private void KiemTraBienXe(String str)
        {
            string imgFolder = Path.Combine(Application.StartupPath, "AnhXeVao");
            string imgName = str + ".jpg";
            string imgPath = Path.Combine(imgFolder, imgName);

            if (File.Exists(imgPath))
            {
                pic_AnhXeVao.Image = new Bitmap(imgPath);
                MessageBox.Show("Xe tồn tại trong bãi!", "Thông báo");


                // Tính doanh thu
                if (KiemTraVIP(str))
                {
                    tb_tienthu.Texts = "0";
                    cb_vevip.Checked = true;
                }

                else
                {
                    Xe xe = XeDAO.Instance.FindXe(str);
                    DateTime ngay = xe.NgayVao;
                    float TienThu = TinhTienThu(ngay);
                    tb_tienthu.Texts = TienThu.ToString();
                    cb_vevip.Checked = false;
                }
            }

            else
            {
                MessageBox.Show("Xe không tồn tại trong bãi!", "Thông báo");
            }
        }

        private void XoaAnh(PictureBox ptb, String deleteImgPath, String newImgPath)
        {
            File.Copy(deleteImgPath, newImgPath, true);
            ptb.Image.Dispose();
            ptb.ImageLocation = newImgPath;
            ptb.Image = new Bitmap(newImgPath);
            File.Delete(deleteImgPath);
        }

        private float TinhTienThu(DateTime time)
        {
            ThamSo ts = ThamSoDAO.Instance.GetThamSo();
            float stamp1 = ts.MocThoiGian1;
            float stamp2 = ts.MocThoiGian2;
            float stamp3 = ts.MocThoiGian3;
            float temp1, temp2;
            float MocTien1 = ts.MocTien1;
            float MocTien2 = ts.MocTien2;
            float res = 0;
            DateTime now = DateTime.Now;

            if (time.Hour >= stamp1 && time.Hour < stamp2)
                temp1 = 0;
            else if (time.Hour >= stamp2 && time.Hour < stamp3)
                temp1 = 1;
            else temp1 = 2;

            if (time.Hour >= stamp1 && time.Hour < stamp2)
                temp2 = 0;
            else if (time.Hour >= stamp2 && time.Hour < stamp3)
                temp2 = 1;
            else temp2 = 2;

            if (temp1 == temp2)
            {
                if (temp1 == 3)
                    res += MocTien2;
                else res += MocTien1;
            }
            else
            {
                for (; temp1 != temp2; temp1++)
                {
                    if (temp1 == 3)
                        res += MocTien2;
                    else res += MocTien1;
                    temp1 %= 3;
                }
            }
            res += Math.Max(0, now.DayOfYear - time.DayOfYear - 1) * (MocTien1 + MocTien1 + MocTien2);
            return res;
        }

        private bool KiemTraVIP(String bienso)
        {
            List<VIP> VIPList = VIPDAO.Instance.SearchVIP(bienso);
            if (VIPList.Count > 0)
                return true;
            else
                return false;
        }

        private void bt_ChupHinhXeVao_Click(object sender, EventArgs e)
        {
            string gifFilePath = AppDomain.CurrentDomain.BaseDirectory;
            string gifName = "loading.gif";
            gifFilePath = Path.Combine(gifFilePath, gifName);
            pic_Loading1.Image = Image.FromFile(gifFilePath);

            string imagesFolderPath = Path.Combine(Application.StartupPath, "images");

            DateTime currentTime = DateTime.Now;
            string timeString = currentTime.ToString("HH_mm_ss");
            string dateString = currentTime.ToString("dd_MM_yyyy");
            string uniqueId = Guid.NewGuid().ToString("N"); // Sử dụng Guid để tạo một chuỗi duy nhất
            string fileName = Path.Combine(imagesFolderPath, $"{timeString}_{dateString}_{uniqueId}.jpg");

            string tempImgPath = Path.Combine(Application.StartupPath, "images", "temp.jpg");

            pic_CamXeVao.Image.Save(fileName);
            pic_CamXeVao.Image.Save(tempImgPath);


            pic_AnhXeVao.ImageLocation = fileName;
            pic_AnhXeVao.Image = new Bitmap(fileName);

            if (pic_AnhXeVao.Image != null)
            {
                RunPythonScript(fileName, pic_Loading1, tb_biensoxevao, 1);
            }

            else
            {
                string imgFilePath = AppDomain.CurrentDomain.BaseDirectory;
                string imgName = "error_img.png";
                imgFilePath = Path.Combine(imgFilePath, imgName);
                pic_CamXeVao.Image = new Bitmap(imgFilePath);
            }
        }

        private void bt_ChupHinhXeRa_Click(object sender, EventArgs e)
        {
            string imagesFolderPath = Path.Combine(Application.StartupPath, "images");

            if (!Directory.Exists(imagesFolderPath))
            {
                Directory.CreateDirectory(imagesFolderPath);
            }
            DateTime currentTime = DateTime.Now;
            string timeString = currentTime.ToString("HH_mm_ss");
            string dateString = currentTime.ToString("dd_MM_yyyy");
            string uniqueId = Guid.NewGuid().ToString("N"); // Sử dụng Guid để tạo một chuỗi duy nhất
            string fileName = Path.Combine(imagesFolderPath, $"{timeString}_{dateString}_{uniqueId}.jpg");

            string tempImgPath = Path.Combine(Application.StartupPath, "images", "temp.jpg");

            pic_CamXeVao.Image.Save(tempImgPath);

            pic_CamXeRa.Image.Save(fileName);
            pic_AnhXeRa.ImageLocation = fileName;
            pic_AnhXeRa.Image = new Bitmap(fileName);

            string gifFilePath = AppDomain.CurrentDomain.BaseDirectory;
            string gifName = "loading.gif";
            gifFilePath = Path.Combine(gifFilePath, gifName);
            pic_Loading2.Image = Image.FromFile(gifFilePath);

            if (pic_CamXeRa.Image != null)
            {
                RunPythonScript(fileName, pic_Loading2, tb_biensoxera, 2);
            }

            else
            {
                string imgFilePath = AppDomain.CurrentDomain.BaseDirectory;
                string imgName = "error_img.png";
                imgFilePath = Path.Combine(imgFilePath, imgName);

                pic_CamXeRa.Image = new Bitmap(imgFilePath);
            }
        }

        private void bt_SuaBienXeVao_Click(object sender, EventArgs e)
        {
            if (pic_AnhXeVao.Image == null)
                return;
            vChangeLicensePlate enterLicensePlate = new vChangeLicensePlate(pic_AnhXeVao.ImageLocation);
            enterLicensePlate.ShowDialog();
            tb_biensoxevao.Texts = enterLicensePlate.getNewLicensePlate();
        }

        private void bt_SuaBienXeRa_Click(object sender, EventArgs e)
        {
            if (pic_AnhXeRa.Image == null)
                return;
            vChangeLicensePlate enterLicensePlate = new vChangeLicensePlate(pic_AnhXeRa.ImageLocation);
            enterLicensePlate.ShowDialog();
            tb_biensoxera.Texts = enterLicensePlate.getNewLicensePlate();

            Thread.Sleep(1000);
            KiemTraBienXe(tb_biensoxera.Texts);
        }
    }
}
