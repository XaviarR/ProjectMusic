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
    public partial class Form1 : Form
    {
        Login_Class Obj_data = new Login_Class();

        public Form1()
        {
            InitializeComponent();
            TB_Captcha.Text = Obj_data.GenerateCaptcha();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Users input for captcha is pass thorough Validation function
            bool val_Captcha = Obj_data.ValidateCaptcha(TB_Capthcha_Enter.Text);
            if (val_Captcha)
            {
                string message = Obj_data.Login(TB_UserName.Text, TB_Password.Text);
                if (message == "User Login Successfully")
                {
                    MessageBox.Show(message);
                    this.Hide();
                    var Homepage_Obj = new Homepage();
                    Homepage_Obj.Closed += (s, args) => this.Close();
                    Homepage_Obj.Show();
                }
                else
                {
                    MessageBox.Show(message);
                }
            }
            else
            {
                MessageBox.Show("Invalid Captcha");
            }

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Forgot_password forgot_Password = new Forgot_password();
            forgot_Password.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            New_User new_User = new New_User();
            new_User.Show();
        }

        private void BT_Refresh_Click(object sender, EventArgs e)
        {
            TB_Captcha.Text = Obj_data.GenerateCaptcha();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.BackColor == Color.White)
            {
                label1.BackColor = Color.Black;
                label2.BackColor = Color.Black;
                label3.BackColor = Color.Black;

                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
            }
            else
            {
                label1.BackColor = Color.White;
                label2.BackColor= Color.White;
                label3.BackColor= Color.White;

                label1.ForeColor= Color.Black;
                label2.ForeColor= Color.Black;
                label3.ForeColor= Color.Black;
            }
           
        }
    }
}
