using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaiXe.DAO
{
    public class DataProvider
    {
        private static DataProvider instance; // Ctrl + R + E

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }

        private DataProvider() { }

        private string connectionSTR = "Data Source=.;Initial Catalog=QuanLyDoXe;Integrated Security=True";

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionSTR))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }
        public void AutoFitColumns(DataGridView dataGridView)
        {
            // Loop through all columns
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                DataGridViewColumn column = dataGridView.Columns[i];
                int headerWidth = TextRenderer.MeasureText(column.HeaderText, dataGridView.Font).Width;
                int maxWidth = headerWidth;

                // Loop through all rows to find the maximum cell content width
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (!row.IsNewRow && row.Cells[column.Index].Value != null)
                    {
                        int cellWidth = TextRenderer.MeasureText(row.Cells[column.Index].Value.ToString(), dataGridView.Font).Width;
                        if (cellWidth > maxWidth)
                        {
                            maxWidth = cellWidth;
                        }
                    }
                }

                // Set the column width to the maximum of header and cell content width
                int columnWidth = Math.Max(maxWidth + 10, headerWidth + 10);
                column.Width = columnWidth;
            }

            // Set the AutoSizeMode property of the last column to Fill
            DataGridViewColumn lastColumn = dataGridView.Columns[dataGridView.Columns.Count - 1];
            lastColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
