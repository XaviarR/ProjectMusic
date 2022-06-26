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
    public partial class New_User : Form
    {
        Registration_Class Obj_Reg = new Registration_Class();
        public New_User()
        {
            InitializeComponent();
            BT_SignUp.Enabled = false;
        }

        private void BT_SignUp_Click(object sender, EventArgs e)
        {
            string message = Obj_Reg.Registration(TB_UserName.Text, TB_Email.Text, TB_Password.Text, TB_Question.Text, TB_Answer.Text);
            MessageBox.Show(message);
            TB_UserName.Text = "";
            TB_Email.Text = "";
            TB_Password.Text = "";
            this.Hide();
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CB_Policy_CheckedChanged(object sender, EventArgs e)
        {
            if(CB_Policy.Checked)
            {
                BT_SignUp.Enabled = true;
            }
            else
            {
                BT_SignUp.Enabled = false;
            }
            
        }
    }
}
