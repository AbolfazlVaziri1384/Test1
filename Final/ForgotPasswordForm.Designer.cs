namespace Final
{
    partial class ForgotPasswordForm
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
            txtStu_Per_Code = new TextBox();
            label2 = new Label();
            txtNationalCode = new TextBox();
            btnVerify = new Button();
            label3 = new Label();
            txtNewPassword = new TextBox();
            label4 = new Label();
            txtConfirmPassword = new TextBox();
            btnSubmit = new Button();
            chkShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(370, 59);
            label1.Name = "label1";
            label1.Size = new Size(167, 29);
            label1.TabIndex = 0;
            label1.Text = ":شماره پرسنلی / دانشجویی";
            // 
            // txtStu_Per_Code
            // 
            txtStu_Per_Code.Location = new Point(221, 58);
            txtStu_Per_Code.Name = "txtStu_Per_Code";
            txtStu_Per_Code.Size = new Size(143, 27);
            txtStu_Per_Code.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(370, 111);
            label2.Name = "label2";
            label2.Size = new Size(58, 29);
            label2.TabIndex = 2;
            label2.Text = ":کد ملی";
            // 
            // txtNationalCode
            // 
            txtNationalCode.Location = new Point(221, 113);
            txtNationalCode.Name = "txtNationalCode";
            txtNationalCode.Size = new Size(143, 27);
            txtNationalCode.TabIndex = 3;
            // 
            // btnVerify
            // 
            btnVerify.BackColor = Color.AliceBlue;
            btnVerify.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnVerify.ForeColor = Color.MediumBlue;
            btnVerify.Location = new Point(221, 168);
            btnVerify.Name = "btnVerify";
            btnVerify.Size = new Size(143, 34);
            btnVerify.TabIndex = 4;
            btnVerify.Text = "بررسی اطلاعات";
            btnVerify.UseVisualStyleBackColor = false;
            btnVerify.Click += btnVerify_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label3.ForeColor = Color.RoyalBlue;
            label3.Location = new Point(370, 233);
            label3.Name = "label3";
            label3.Size = new Size(105, 29);
            label3.TabIndex = 5;
            label3.Text = ":رمز عبور جدید";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Enabled = false;
            txtNewPassword.Location = new Point(221, 235);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(143, 27);
            txtNewPassword.TabIndex = 6;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            label4.ForeColor = Color.RoyalBlue;
            label4.Location = new Point(370, 286);
            label4.Name = "label4";
            label4.Size = new Size(106, 29);
            label4.TabIndex = 7;
            label4.Text = ":تکرار رمز عبور";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Enabled = false;
            txtConfirmPassword.Location = new Point(221, 288);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(143, 27);
            txtConfirmPassword.TabIndex = 8;
            txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.AliceBlue;
            btnSubmit.Enabled = false;
            btnSubmit.Font = new Font("B Koodak", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 178);
            btnSubmit.ForeColor = Color.MediumBlue;
            btnSubmit.Location = new Point(221, 346);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(143, 34);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "ثبت اطلاعات";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Enabled = false;
            chkShowPassword.Location = new Point(197, 241);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(18, 17);
            chkShowPassword.TabIndex = 10;
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // ForgotPasswordForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 450);
            Controls.Add(chkShowPassword);
            Controls.Add(btnSubmit);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label4);
            Controls.Add(txtNewPassword);
            Controls.Add(label3);
            Controls.Add(btnVerify);
            Controls.Add(txtNationalCode);
            Controls.Add(label2);
            Controls.Add(txtStu_Per_Code);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "ForgotPasswordForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "فراموشی رمز عبور";
            Load += ForgotPasswordForm_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtStu_Per_Code;
        private Label label2;
        private TextBox txtNationalCode;
        private Button btnVerify;
        private Label label3;
        private TextBox txtNewPassword;
        private Label label4;
        private TextBox txtConfirmPassword;
        private Button btnSubmit;
        private CheckBox chkShowPassword;
    }
}