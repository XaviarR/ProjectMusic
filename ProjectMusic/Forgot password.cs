using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMusic
{
    public partial class Forgot_password : Form
    {
        public Forgot_password()
        {
            InitializeComponent();
        }

        private void BT_Reset_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 signin = new Form1();
            signin.Show();
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 signin = new Form1();
            signin.Show();
        }
    }
}
