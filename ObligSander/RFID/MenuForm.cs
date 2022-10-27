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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            var m = new Form1();
            m.Show();
            this.Hide();
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            var m = new UserProfile();
            m.Show();
            this.Hide();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            var m = new Books();
            m.Show();
            this.Hide();
        }

        private void bntBorrowBook_Click(object sender, EventArgs e)
        {
            var m = new BorrowBook();
            m.Show();
            this.Hide();
        }
    }
}
