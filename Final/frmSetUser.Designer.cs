namespace Final
{
    partial class frmSetUser
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            txtAddress = new TextBox();
            numNationalCode = new NumericUpDown();
            numStu_Per_Code = new NumericUpDown();
            numPhone = new NumericUpDown();
            mskbirthday = new MaskedTextBox();
            radWoman = new RadioButton();
            radMan = new RadioButton();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numNationalCode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStu_Per_Code).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPhone).BeginInit();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(554, 48);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(114, 27);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(554, 125);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(114, 27);
            txtLastName.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(554, 192);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(114, 27);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(554, 251);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(114, 27);
            txtPassword.TabIndex = 3;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(554, 309);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(114, 27);
            txtConfirmPassword.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(554, 364);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(114, 27);
            txtAddress.TabIndex = 5;
            // 
            // numNationalCode
            // 
            numNationalCode.Location = new Point(531, 403);
            numNationalCode.Margin = new Padding(3, 4, 3, 4);
            numNationalCode.Name = "numNationalCode";
            numNationalCode.Size = new Size(137, 27);
            numNationalCode.TabIndex = 6;
            // 
            // numStu_Per_Code
            // 
            numStu_Per_Code.Location = new Point(531, 441);
            numStu_Per_Code.Margin = new Padding(3, 4, 3, 4);
            numStu_Per_Code.Name = "numStu_Per_Code";
            numStu_Per_Code.Size = new Size(137, 27);
            numStu_Per_Code.TabIndex = 7;
            // 
            // numPhone
            // 
            numPhone.Location = new Point(531, 480);
            numPhone.Margin = new Padding(3, 4, 3, 4);
            numPhone.Name = "numPhone";
            numPhone.Size = new Size(137, 27);
            numPhone.TabIndex = 8;
            // 
            // mskbirthday
            // 
            mskbirthday.Location = new Point(270, 48);
            mskbirthday.Margin = new Padding(3, 4, 3, 4);
            mskbirthday.Mask = "0000/00/00";
            mskbirthday.Name = "mskbirthday";
            mskbirthday.Size = new Size(114, 27);
            mskbirthday.TabIndex = 9;
            mskbirthday.ValidatingType = typeof(DateTime);
            // 
            // radWoman
            // 
            radWoman.AutoSize = true;
            radWoman.Location = new Point(270, 105);
            radWoman.Margin = new Padding(3, 4, 3, 4);
            radWoman.Name = "radWoman";
            radWoman.Size = new Size(117, 24);
            radWoman.TabIndex = 11;
            radWoman.TabStop = true;
            radWoman.Text = "radioButton1";
            radWoman.UseVisualStyleBackColor = true;
            radWoman.CheckedChanged += radWoman_CheckedChanged;
            // 
            // radMan
            // 
            radMan.AutoSize = true;
            radMan.Location = new Point(270, 139);
            radMan.Margin = new Padding(3, 4, 3, 4);
            radMan.Name = "radMan";
            radMan.Size = new Size(117, 24);
            radMan.TabIndex = 12;
            radMan.TabStop = true;
            radMan.Text = "radioButton2";
            radMan.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(730, 553);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 13;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmSetUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnSave);
            Controls.Add(radMan);
            Controls.Add(radWoman);
            Controls.Add(mskbirthday);
            Controls.Add(numPhone);
            Controls.Add(numStu_Per_Code);
            Controls.Add(numNationalCode);
            Controls.Add(txtAddress);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmSetUser";
            Text = "frmSetUser";
            Load += frmSetUser_Load;
            ((System.ComponentModel.ISupportInitialize)numNationalCode).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStu_Per_Code).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPhone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
        private TextBox txtAddress;
        private NumericUpDown numNationalCode;
        private NumericUpDown numStu_Per_Code;
        private NumericUpDown numPhone;
        private MaskedTextBox mskbirthday;
        private RadioButton radWoman;
        private RadioButton radMan;
        private Button btnSave;
    }
}