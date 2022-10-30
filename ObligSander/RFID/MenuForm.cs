using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID
{
    // MenuForm is just a hub to connect all the forms together. is shows youre username and direct user to other 
    // functions of the code. 
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }
        private void MenuForm_Load(object sender, EventArgs e)
        {
            textBoxUsername.Text = LoginForm.recby;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            var m = new LoginForm();
            m.Show();
            this.Hide();
        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void pbViewProfile_Click(object sender, EventArgs e)
        {
            var m = new UserProfile();
            m.Show();
            this.Hide();
        }

        private void pbBorrowBooks_Click(object sender, EventArgs e)
        {
            var m = new BorrowBook();
            m.Show();
            this.Hide();
        }

        private void pbViewBook_Click(object sender, EventArgs e)
        {
            var m = new Books();
            m.Show();
            this.Hide();
        }
    }
}
