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

            Loading();
            ClosedForm();
        }

        #region Method
        void Loading()
        {
            GetCurrentDate();
            cb_vevip.CheckedChanged += cb_vevip_CheckedChanged;
            tb_biensoxera.TextChanged += tb_biensoxera_TextChanged;
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
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
            LoggDAO.Instance.LogDangXuat();
        }

        private void vInOut_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void bt_xevao_Click(object sender, EventArgs e)
        {
            GetCurrentDate();

            string bienso = tb_biensoxevao.Texts;

            string gifFilePath = AppDomain.CurrentDomain.BaseDirectory;
            string gifName = "loading.gif";

            gifFilePath = Path.Combine(gifFilePath, gifName);

            pic_Loading1.Image = Image.FromFile(gifFilePath);

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

            pic_CamXeVao.Image.Save(fileName);
            pic_AnhXeVao.ImageLocation = fileName;
            pic_AnhXeVao.Image = new Bitmap(fileName);

            if (pic_AnhXeVao.Image != null)
            {
                RunPythonScript(fileName, pic_Loading1, tb_biensoxevao);
            }

            else
            {
                string imgFilePath = AppDomain.CurrentDomain.BaseDirectory;
                string imgName = "error_img.png";
                imgFilePath = Path.Combine(imgFilePath, imgName);

                pic_CamXeVao.Image = new Bitmap(imgFilePath);
            }


            while (string.IsNullOrEmpty(bienso))
            {
                Application.DoEvents();///////////////them event vo 
                bienso = tb_biensoxevao.Text;
            }

            LoggDAO.Instance.LogInOut(bienso, 0);
            XeDAO.Instance.AddXe(bienso);
        }

        private void bt_xera_Click(object sender, EventArgs e)
        {
            string bienso = tb_biensoxera.Texts;

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

            pic_CamXeRa.Image.Save(fileName);

            pic_AnhXeRa.Image = new Bitmap(fileName);

            string gifFilePath = AppDomain.CurrentDomain.BaseDirectory;
            string gifName = "loading.gif";
            gifFilePath = Path.Combine(gifFilePath, gifName);

            pic_Loading2.Image = Image.FromFile(gifFilePath);
            if (pic_CamXeRa.Image != null)
            {
                RunPythonScript(fileName, pic_Loading2, tb_biensoxera);
            }

            else
            {
                string imgFilePath = AppDomain.CurrentDomain.BaseDirectory;
                string imgName = "error_img.png";
                imgFilePath = Path.Combine(imgFilePath, imgName);

                pic_CamXeRa.Image = new Bitmap(imgFilePath);
            }
            LoggDAO.Instance.LogInOut(bienso, 1);
        }

        // đọc biển số xe + camera
        public async void RunPythonScript(string imagePath, PictureBox ptb, VTextbox tb)
        {
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
                        string result = reader.ReadToEnd();
                        Invoke((MethodInvoker)(() =>
                        {
                            if (result == "" || result == null)
                            {
                                result = "Không đọc được";
                            }

                            tb.Texts = result;
                            ptb.Image = null;

                            if (string.IsNullOrEmpty(result))
                                tb.Text = "Khong doc duoc";
                        }));
                    }
                }
            });
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

        private void btn_SuaBienSo_Click(object sender, EventArgs e)
        {
            vChangeLicensePlate enterLicensePlate = new vChangeLicensePlate(pic_AnhXeVao.ImageLocation);
            enterLicensePlate.ShowDialog();
            tb_biensoxevao.Texts = enterLicensePlate.getNewLicensePlate();
        }


        #endregion

        private void cb_vevip_CheckedChanged(object sender, EventArgs e)
        {
            string bienso = tb_biensoxera.Texts;
            if(VIPDAO.Instance.CheckVIP(bienso) == 1)
            {
                cb_vevip.Checked = true;
            }    
        }

        private void tb_biensoxera_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("haha");
            string bienso = tb_biensoxera.Texts;
            if (VIPDAO.Instance.CheckVIP(bienso) == 1)
            {
                cb_vevip.CheckState = CheckState.Checked;
            }
        }


    }
}
