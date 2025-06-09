namespace Final
{
    partial class frmRepairRoomAsset
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
            cmbStatus = new ComboBox();
            txtDiscription = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(355, 25);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 0;
            // 
            // txtDiscription
            // 
            txtDiscription.Location = new Point(376, 88);
            txtDiscription.Name = "txtDiscription";
            txtDiscription.Size = new Size(100, 23);
            txtDiscription.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(376, 170);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmRepairRoomAsset
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtDiscription);
            Controls.Add(cmbStatus);
            Name = "frmRepairRoomAsset";
            Text = "frmRepairRoomAsset";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStatus;
        private TextBox txtDiscription;
        private Button btnSave;
    }
}