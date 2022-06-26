namespace ProjectMusic
{
    partial class New_User
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.TB_Question = new System.Windows.Forms.TextBox();
            this.TB_Answer = new System.Windows.Forms.TextBox();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_SignUp = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TB_Captcha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_Captcha_Enter = new System.Windows.Forms.TextBox();
            this.CB_Policy = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Security question: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Answer: ";
            // 
            // TB_UserName
            // 
            this.TB_UserName.Location = new System.Drawing.Point(241, 50);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(194, 22);
            this.TB_UserName.TabIndex = 5;
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(241, 117);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(194, 22);
            this.TB_Email.TabIndex = 6;
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(241, 175);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.Size = new System.Drawing.Size(194, 22);
            this.TB_Password.TabIndex = 7;
            // 
            // TB_Question
            // 
            this.TB_Question.Location = new System.Drawing.Point(241, 304);
            this.TB_Question.Name = "TB_Question";
            this.TB_Question.Size = new System.Drawing.Size(194, 22);
            this.TB_Question.TabIndex = 8;
            // 
            // TB_Answer
            // 
            this.TB_Answer.Location = new System.Drawing.Point(241, 373);
            this.TB_Answer.Name = "TB_Answer";
            this.TB_Answer.Size = new System.Drawing.Size(194, 22);
            this.TB_Answer.TabIndex = 9;
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Location = new System.Drawing.Point(125, 527);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(102, 49);
            this.BT_Cancel.TabIndex = 10;
            this.BT_Cancel.Text = "Cancel";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_SignUp
            // 
            this.BT_SignUp.Location = new System.Drawing.Point(450, 527);
            this.BT_SignUp.Name = "BT_SignUp";
            this.BT_SignUp.Size = new System.Drawing.Size(100, 49);
            this.BT_SignUp.TabIndex = 11;
            this.BT_SignUp.Text = "Sign up";
            this.BT_SignUp.UseVisualStyleBackColor = true;
            this.BT_SignUp.Click += new System.EventHandler(this.BT_SignUp_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(241, 428);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(194, 28);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Privacy Policy";
            // 
            // TB_Captcha
            // 
            this.TB_Captcha.Enabled = false;
            this.TB_Captcha.Location = new System.Drawing.Point(241, 220);
            this.TB_Captcha.Name = "TB_Captcha";
            this.TB_Captcha.Size = new System.Drawing.Size(194, 22);
            this.TB_Captcha.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Captcha";
            // 
            // TB_Captcha_Enter
            // 
            this.TB_Captcha_Enter.Location = new System.Drawing.Point(241, 261);
            this.TB_Captcha_Enter.Name = "TB_Captcha_Enter";
            this.TB_Captcha_Enter.Size = new System.Drawing.Size(194, 22);
            this.TB_Captcha_Enter.TabIndex = 15;
            // 
            // CB_Policy
            // 
            this.CB_Policy.AutoSize = true;
            this.CB_Policy.Location = new System.Drawing.Point(241, 477);
            this.CB_Policy.Name = "CB_Policy";
            this.CB_Policy.Size = new System.Drawing.Size(215, 20);
            this.CB_Policy.TabIndex = 16;
            this.CB_Policy.Text = "You agree to the Privacy Policy";
            this.CB_Policy.UseVisualStyleBackColor = true;
            this.CB_Policy.CheckedChanged += new System.EventHandler(this.CB_Policy_CheckedChanged);
            // 
            // New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 597);
            this.Controls.Add(this.CB_Policy);
            this.Controls.Add(this.TB_Captcha_Enter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_Captcha);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BT_SignUp);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.TB_Answer);
            this.Controls.Add(this.TB_Question);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.TB_UserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "New_User";
            this.Text = "New_User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.TextBox TB_Question;
        private System.Windows.Forms.TextBox TB_Answer;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_SignUp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TB_Captcha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_Captcha_Enter;
        private System.Windows.Forms.CheckBox CB_Policy;
    }
}