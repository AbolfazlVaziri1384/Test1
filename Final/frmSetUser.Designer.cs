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
            txtFirstName.Location = new Point(485, 36);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(485, 94);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 1;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(485, 144);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(100, 23);
            txtUserName.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(485, 188);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(100, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(485, 232);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(100, 23);
            txtConfirmPassword.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(485, 273);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 5;
            // 
            // numNationalCode
            // 
            numNationalCode.Location = new Point(465, 302);
            numNationalCode.Name = "numNationalCode";
            numNationalCode.Size = new Size(120, 23);
            numNationalCode.TabIndex = 6;
            // 
            // numStu_Per_Code
            // 
            numStu_Per_Code.Location = new Point(465, 331);
            numStu_Per_Code.Name = "numStu_Per_Code";
            numStu_Per_Code.Size = new Size(120, 23);
            numStu_Per_Code.TabIndex = 7;
            // 
            // numPhone
            // 
            numPhone.Location = new Point(465, 360);
            numPhone.Name = "numPhone";
            numPhone.Size = new Size(120, 23);
            numPhone.TabIndex = 8;
            // 
            // mskbirthday
            // 
            mskbirthday.Location = new Point(236, 36);
            mskbirthday.Name = "mskbirthday";
            mskbirthday.Size = new Size(100, 23);
            mskbirthday.TabIndex = 9;
            // 
            // radWoman
            // 
            radWoman.AutoSize = true;
            radWoman.Location = new Point(236, 79);
            radWoman.Name = "radWoman";
            radWoman.Size = new Size(94, 19);
            radWoman.TabIndex = 11;
            radWoman.TabStop = true;
            radWoman.Text = "radioButton1";
            radWoman.UseVisualStyleBackColor = true;
            // 
            // radMan
            // 
            radMan.AutoSize = true;
            radMan.Location = new Point(236, 104);
            radMan.Name = "radMan";
            radMan.Size = new Size(94, 19);
            radMan.TabIndex = 12;
            radMan.TabStop = true;
            radMan.Text = "radioButton2";
            radMan.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(639, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 13;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmSetUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "frmSetUser";
            Text = "frmSetUser";
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