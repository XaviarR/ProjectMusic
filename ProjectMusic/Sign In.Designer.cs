namespace ProjectMusic
{
    partial class Form1
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
            this.Link_ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Link_SignUp = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Captcha = new System.Windows.Forms.TextBox();
            this.TB_Capthcha_Enter = new System.Windows.Forms.TextBox();
            this.BT_Refresh = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Link_ForgotPassword
            // 
            this.Link_ForgotPassword.AutoSize = true;
            this.Link_ForgotPassword.Location = new System.Drawing.Point(328, 356);
            this.Link_ForgotPassword.Name = "Link_ForgotPassword";
            this.Link_ForgotPassword.Size = new System.Drawing.Size(119, 16);
            this.Link_ForgotPassword.TabIndex = 0;
            this.Link_ForgotPassword.TabStop = true;
            this.Link_ForgotPassword.Text = "Forgot Password? ";
            this.Link_ForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password: ";
            // 
            // TB_UserName
            // 
            this.TB_UserName.Location = new System.Drawing.Point(287, 67);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(206, 22);
            this.TB_UserName.TabIndex = 3;
            // 
            // TB_Password
            // 
            this.TB_Password.Location = new System.Drawing.Point(287, 130);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(206, 22);
            this.TB_Password.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sign In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Link_SignUp
            // 
            this.Link_SignUp.AutoSize = true;
            this.Link_SignUp.Location = new System.Drawing.Point(311, 260);
            this.Link_SignUp.Name = "Link_SignUp";
            this.Link_SignUp.Size = new System.Drawing.Size(153, 16);
            this.Link_SignUp.TabIndex = 6;
            this.Link_SignUp.TabStop = true;
            this.Link_SignUp.Text = "Not a user? Sign up here";
            this.Link_SignUp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Captcha";
            // 
            // TB_Captcha
            // 
            this.TB_Captcha.Enabled = false;
            this.TB_Captcha.Location = new System.Drawing.Point(287, 174);
            this.TB_Captcha.Name = "TB_Captcha";
            this.TB_Captcha.Size = new System.Drawing.Size(206, 22);
            this.TB_Captcha.TabIndex = 8;
            // 
            // TB_Capthcha_Enter
            // 
            this.TB_Capthcha_Enter.Location = new System.Drawing.Point(287, 213);
            this.TB_Capthcha_Enter.Name = "TB_Capthcha_Enter";
            this.TB_Capthcha_Enter.Size = new System.Drawing.Size(206, 22);
            this.TB_Capthcha_Enter.TabIndex = 9;
            // 
            // BT_Refresh
            // 
            this.BT_Refresh.Location = new System.Drawing.Point(531, 172);
            this.BT_Refresh.Name = "BT_Refresh";
            this.BT_Refresh.Size = new System.Drawing.Size(75, 23);
            this.BT_Refresh.TabIndex = 10;
            this.BT_Refresh.Text = "Refresh";
            this.BT_Refresh.UseVisualStyleBackColor = true;
            this.BT_Refresh.Click += new System.EventHandler(this.BT_Refresh_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Accessability";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 437);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BT_Refresh);
            this.Controls.Add(this.TB_Capthcha_Enter);
            this.Controls.Add(this.TB_Captcha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Link_SignUp);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_UserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Link_ForgotPassword);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel Link_ForgotPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel Link_SignUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Captcha;
        private System.Windows.Forms.TextBox TB_Capthcha_Enter;
        private System.Windows.Forms.Button BT_Refresh;
        private System.Windows.Forms.Button button2;
    }
}

