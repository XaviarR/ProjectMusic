namespace ProjectMusic
{
    partial class Forgot_password
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
            this.TB_Question = new System.Windows.Forms.TextBox();
            this.TB_Answer = new System.Windows.Forms.TextBox();
            this.BT_Cancel = new System.Windows.Forms.Button();
            this.BT_Reset = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Security question: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Answer:";
            // 
            // TB_Question
            // 
            this.TB_Question.Location = new System.Drawing.Point(308, 103);
            this.TB_Question.Name = "TB_Question";
            this.TB_Question.Size = new System.Drawing.Size(195, 22);
            this.TB_Question.TabIndex = 2;
            // 
            // TB_Answer
            // 
            this.TB_Answer.Location = new System.Drawing.Point(308, 170);
            this.TB_Answer.Name = "TB_Answer";
            this.TB_Answer.Size = new System.Drawing.Size(195, 22);
            this.TB_Answer.TabIndex = 3;
            // 
            // BT_Cancel
            // 
            this.BT_Cancel.Location = new System.Drawing.Point(257, 273);
            this.BT_Cancel.Name = "BT_Cancel";
            this.BT_Cancel.Size = new System.Drawing.Size(75, 23);
            this.BT_Cancel.TabIndex = 4;
            this.BT_Cancel.Text = "Cancel";
            this.BT_Cancel.UseVisualStyleBackColor = true;
            this.BT_Cancel.Click += new System.EventHandler(this.BT_Cancel_Click);
            // 
            // BT_Reset
            // 
            this.BT_Reset.Location = new System.Drawing.Point(439, 273);
            this.BT_Reset.Name = "BT_Reset";
            this.BT_Reset.Size = new System.Drawing.Size(75, 23);
            this.BT_Reset.TabIndex = 5;
            this.BT_Reset.Text = "Reset";
            this.BT_Reset.UseVisualStyleBackColor = true;
            this.BT_Reset.Click += new System.EventHandler(this.BT_Reset_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username:";
            // 
            // TB_UserName
            // 
            this.TB_UserName.Location = new System.Drawing.Point(308, 52);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(195, 22);
            this.TB_UserName.TabIndex = 7;
            // 
            // Forgot_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 348);
            this.Controls.Add(this.TB_UserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BT_Reset);
            this.Controls.Add(this.BT_Cancel);
            this.Controls.Add(this.TB_Answer);
            this.Controls.Add(this.TB_Question);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Forgot_password";
            this.Text = "Forgot_password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Question;
        private System.Windows.Forms.TextBox TB_Answer;
        private System.Windows.Forms.Button BT_Cancel;
        private System.Windows.Forms.Button BT_Reset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_UserName;
    }
}