namespace Final
{
    partial class frmSetStudentAssets
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
            txtName = new TextBox();
            txtDiscription = new TextBox();
            lblGuid = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(350, 54);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // txtDiscription
            // 
            txtDiscription.Location = new Point(350, 100);
            txtDiscription.Name = "txtDiscription";
            txtDiscription.Size = new Size(100, 23);
            txtDiscription.TabIndex = 1;
            // 
            // lblGuid
            // 
            lblGuid.AutoSize = true;
            lblGuid.Location = new Point(397, 162);
            lblGuid.Name = "lblGuid";
            lblGuid.Size = new Size(38, 15);
            lblGuid.TabIndex = 2;
            lblGuid.Text = "label1";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(375, 210);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmSetStudentAssets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(lblGuid);
            Controls.Add(txtDiscription);
            Controls.Add(txtName);
            Name = "frmSetStudentAssets";
            Text = "frmSetStudentAssets";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtDiscription;
        private Label lblGuid;
        private Button btnSave;
    }
}