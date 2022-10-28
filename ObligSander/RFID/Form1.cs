using Microsoft.Data.SqlClient;
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
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
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
        //
        private string Encrypt(string clearText)
        {
            string EncryptionKey = "MAKV2SPBNI99212";
            byte[] clearBytes = Encoding.Unicode.GetBytes(clearText);
            using (Aes encryptor = Aes.Create())
            {
                Rfc2898DeriveBytes pdb = new Rfc2898DeriveBytes(EncryptionKey, new byte[] { 0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76 });
                encryptor.Key = pdb.GetBytes(32);
                encryptor.IV = pdb.GetBytes(16);
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream cs = new CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(clearBytes, 0, clearBytes.Length);
                        cs.Close();
                    }
                    clearText = Convert.ToBase64String(ms.ToArray());
                }
            }
            return clearText;
        }
        //

        public static string Username;
        public static string recby
        {
            get { return Username; }
            set { Username = value; }
        }
        private void LoginUser()
        {
            recby = txtBoxTag.Text;
            string UserName = txtBoxTag.Text;
            string Password = Encrypt(txtBoxPin.Text);


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