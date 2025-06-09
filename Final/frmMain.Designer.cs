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
            mnuSetUser.Location = new Point(418, 401);
            mnuSetUser.Name = "mnuSetUser";
            mnuSetUser.Size = new Size(89, 37);
            mnuSetUser.TabIndex = 0;
            mnuSetUser.Text = "button1";
            mnuSetUser.UseVisualStyleBackColor = true;
            // 
            // mnuUsers
            // 
            mnuUsers.Location = new Point(289, 401);
            mnuUsers.Name = "mnuUsers";
            mnuUsers.Size = new Size(89, 37);
            mnuUsers.TabIndex = 1;
            mnuUsers.Text = "button1";
            mnuUsers.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuUsers);
            Controls.Add(mnuSetUser);
            Name = "frmMain";
            Text = "frmMain";
            ResumeLayout(false);
        }

        #endregion

        private Button mnuSetUser;
        private Button mnuUsers;
    }
}