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

        private void LoginUser()
        {

            string UserName = txtBoxTag.Text;
            string Password = txtBoxPin.Text;


            Login login = new Login();
            login.CheckLoginDetails(UserName,Password);
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LoginUser();
            this.Hide();


        }


        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            var m = new Registrate();
            m.Show();
            this.Hide();
        }
    }
}