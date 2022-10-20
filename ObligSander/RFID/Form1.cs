using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RFID
{
    public partial class Form1 : Form
    {
        private Form MenuForm;
        private Form Registrate;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            //string myCon = ConfigurationManager.ConnectionStrings["conRFID"].ConnectionString;
            //SqlConnection sqlConnection = new SqlConnection(myCon);
            ClassConnectionSQL classConnectionSQL = new ClassConnectionSQL();
            classConnectionSQL.ConnectionToDatabase();
            //SqlConnection sqlConnection = new SqlConnection();

            string sqlQuery = @"SELECT* FROM PERSON WHERE Username= '" + txtBoxTag.Text +
                                 "' AND Password = '" + txtBoxPin.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlQuery,ClassConnectionSQL.myCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            if (dt.Rows.Count == 1)
            {
                MenuForm = new MenuForm();
                this.Hide();
                MenuForm.Show();

            }
            else
            {
                MessageBox.Show("Incorrect Username or password");
            }

        }


        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            var m = new Registrate();
            m.Show();
        }
    }
}