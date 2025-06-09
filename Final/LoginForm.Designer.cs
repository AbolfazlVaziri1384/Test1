namespace Final
{
    partial class LoginForm
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
            label1 = new Label();
            label2 = new Label();
            txtUserName = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            chkShowPassword = new CheckBox();
            pictureBox1 = new PictureBox();
            btnLogin = new Button();
            linkLabel1 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(467, 84);
            label1.Name = "label1";
            label1.Size = new Size(132, 39);
            label1.TabIndex = 0;
            label1.Text = "ورود به سیستم";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(605, 157);
            label2.Name = "label2";
            label2.Size = new Size(76, 29);
            label2.TabIndex = 1;
            label2.Text = ":نام کاربری";
            // 
            // txtUserName
            // 
            txtUserName.BackColor = SystemColors.Window;
            txtUserName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(453, 159);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(146, 30);
            txtUserName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("B Koodak", 10.2F, FontStyle.Bold);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(611, 217);
            label3.Name = "label3";
            label3.Size = new Size(70, 29);
            label3.TabIndex = 3;
            label3.Text = ":رمز عبور";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(453, 216);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(146, 27);
            txtPassword.TabIndex = 4;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.BackColor = Color.White;
            chkShowPassword.ForeColor = SystemColors.ActiveCaptionText;
            chkShowPassword.Location = new Point(429, 222);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(18, 17);
            chkShowPassword.TabIndex = 5;
            chkShowPassword.UseVisualStyleBackColor = false;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Image = Properties.Resources.finalIcon1;
            pictureBox1.Location = new Point(81, 84);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(314, 280);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.AliceBlue;
            btnLogin.Font = new Font("B Koodak", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnLogin.ForeColor = Color.MediumBlue;
            btnLogin.Location = new Point(453, 298);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(146, 42);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "ورود";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("B Koodak", 9F, FontStyle.Bold, GraphicsUnit.Point, 178);
            linkLabel1.LinkColor = Color.DeepPink;
            linkLabel1.Location = new Point(506, 246);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(93, 26);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "بازیابی رمز عبور";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(btnLogin);
            Controls.Add(pictureBox1);
            Controls.Add(chkShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ورود به سامانه مدیریت خوابگاه";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUserName;
        private Label label3;
        private TextBox txtPassword;
        private CheckBox chkShowPassword;
        private PictureBox pictureBox1;
        private Button btnLogin;
        private LinkLabel linkLabel1;
    }
}