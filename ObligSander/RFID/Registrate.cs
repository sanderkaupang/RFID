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
    public partial class Registrate : Form
    {
        public Registrate()
        {
            InitializeComponent();
        }

        private void btnRegistrate_Click(object sender, EventArgs e)
        {
            ClassConnectionSQL classConnectionSQL = new ClassConnectionSQL();
            classConnectionSQL.ConnectionToDatabase();
            //this.Hide();



            
            var m = new Form1();     // Choose form is will open after registration
            m.Show();
            
        }
    }
}
