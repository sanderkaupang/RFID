using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace RFID
{
    public partial class UserProfile : Form
    {
        public UserProfile()
        {
            InitializeComponent();
        }


        public void DelUser()
        {
            string phone = textBoxDeleteAccount.Text;
            DeleteUser deleteUser = new DeleteUser();
            deleteUser.ClassDeleteUser(phone);
        }

        private void btnUploadProfilePic_Click(object sender, EventArgs e)
        {

            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbProfilePic.Image = new Bitmap(open.FileName);


            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            var m = new UpdatePersonlia();     // Choose form is will open after registration
            m.Show();
            this.Hide();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            DelUser();

            var m = new Form1();     // Choose form is will open after registration
            m.Show();
            this.Hide();
        }

        private void btnUpdateUsernamePassword_Click(object sender, EventArgs e)
        {
           
            
            var m = new UpdateUsernamePassword();     // Choose form is will open after registration
            m.Show();
            this.Hide();
        }

        private void buttonBackToMenu_Click(object sender, EventArgs e)
        {
            var m = new MenuForm();     // Choose form is will open after registration
            m.Show();
            this.Hide();
        }
    }
}

