namespace DesktopCrud
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            loginbtn = new Button();
            label5 = new Label();
            label4 = new Label();
            userpassword = new TextBox();
            label3 = new Label();
            useremail = new TextBox();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.Gold;
            loginbtn.FlatStyle = FlatStyle.System;
            loginbtn.ForeColor = Color.FromArgb(255, 255, 128);
            loginbtn.Location = new Point(115, 365);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(75, 23);
            loginbtn.TabIndex = 19;
            loginbtn.Text = "LOGIN";
            loginbtn.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(178, 319);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 18;
            label5.Text = "Registration";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(77, 319);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 17;
            label4.Text = "have an acoount";
            // 
            // userpassword
            // 
            userpassword.Location = new Point(77, 277);
            userpassword.Name = "userpassword";
            userpassword.PasswordChar = '*';
            userpassword.Size = new Size(187, 23);
            userpassword.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(77, 230);
            label3.Name = "label3";
            label3.Size = new Size(99, 16);
            label3.TabIndex = 15;
            label3.Text = "loginPassword";
            // 
            // useremail
            // 
            useremail.Location = new Point(77, 187);
            useremail.Name = "useremail";
            useremail.Size = new Size(189, 23);
            useremail.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(77, 146);
            label2.Name = "label2";
            label2.Size = new Size(74, 16);
            label2.TabIndex = 13;
            label2.Text = "LoginEmail";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(67, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 99);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(359, 450);
            Controls.Add(loginbtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(userpassword);
            Controls.Add(label3);
            Controls.Add(useremail);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "login";
            Text = "APTECH EDUCATION SYSTEM";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginbtn;
        private Label label5;
        private Label label4;
        private TextBox userpassword;
        private Label label3;
        private TextBox useremail;
        private Label label2;
        private PictureBox pictureBox1;
    }
}