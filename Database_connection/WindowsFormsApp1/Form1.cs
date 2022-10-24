using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Excel = Microsoft.Office.Interop.Excel;



namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string LibraryConfig =
        ConfigurationManager.ConnectionStrings["RFID_Library"].ConnectionString;

        

        
        public Form1()
        {
            InitializeComponent();
            
        }
        void viewResultInDataGridView (string sqlQuery)
        {
            try
            {
                SqlConnection con = new SqlConnection(LibraryConfig);
                SqlDataAdapter sda;
                DataTable dt;
                con.Open();
                sda = new SqlDataAdapter(sqlQuery, con);
                dt = new DataTable();
                sda.Fill(dt);
                dgvAllValues.DataSource = dt;
                con.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnShowValues_Click(object sender, EventArgs e)
        {

            string sqlQuery = @"SELECT* FROM PERSON";
            viewResultInDataGridView(sqlQuery);

        }

        public void dgvAllValues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        //  Skriver til EXCEL
        private void btnReadToFile_Click(object sender, EventArgs e)
        {
            if (dgvAllValues.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application xcelApp =
                    new Microsoft.Office.Interop.Excel.Application();
                xcelApp.Application.Workbooks.Add(Type.Missing);

                //find values to every Column and row in dgv
                for (int i = 1; i < dgvAllValues.Columns.Count + 1; i++)
                {
                    xcelApp.Cells[1, i] = dgvAllValues.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dgvAllValues.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvAllValues.Columns.Count; j++)
                    {
                        xcelApp.Cells[i + 2, j + 1] = dgvAllValues.Rows[i].Cells[j].Value?.ToString();
                    }
                }
                //Formatting Excel to auto size columns
                xcelApp.Columns.AutoFit();
                xcelApp.Visible = true;


            }
        }
        
    }
}
