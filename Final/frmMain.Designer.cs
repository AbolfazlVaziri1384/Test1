namespace Final
{
    partial class frmMain
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
            mnuSetUser = new Button();
            mnuUsers = new Button();
            SuspendLayout();
            // 
            // mnuSetUser
            // 
            mnuSetUser.Location = new Point(478, 535);
            mnuSetUser.Margin = new Padding(3, 4, 3, 4);
            mnuSetUser.Name = "mnuSetUser";
            mnuSetUser.Size = new Size(102, 49);
            mnuSetUser.TabIndex = 0;
            mnuSetUser.Text = "button1";
            mnuSetUser.UseVisualStyleBackColor = true;
            mnuSetUser.Click += mnuSetUser_Click;
            // 
            // mnuUsers
            // 
            mnuUsers.Location = new Point(330, 535);
            mnuUsers.Margin = new Padding(3, 4, 3, 4);
            mnuUsers.Name = "mnuUsers";
            mnuUsers.Size = new Size(102, 49);
            mnuUsers.TabIndex = 1;
            mnuUsers.Text = "button1";
            mnuUsers.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(mnuUsers);
            Controls.Add(mnuSetUser);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button mnuSetUser;
        private Button mnuUsers;
    }
}