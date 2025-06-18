namespace Final
{
    partial class frmSetRoomAssets
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
            cmbPartNumber = new ComboBox();
            cmbStatus = new ComboBox();
            btnSave = new Button();
            lblAssetNumber = new Label();
            SuspendLayout();
            // 
            // cmbPartNumber
            // 
            cmbPartNumber.FormattingEnabled = true;
            cmbPartNumber.Location = new Point(395, 87);
            cmbPartNumber.Margin = new Padding(3, 4, 3, 4);
            cmbPartNumber.Name = "cmbPartNumber";
            cmbPartNumber.Size = new Size(138, 28);
            cmbPartNumber.TabIndex = 1;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(395, 125);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(138, 28);
            cmbStatus.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(434, 553);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 3;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblAssetNumber
            // 
            lblAssetNumber.AutoSize = true;
            lblAssetNumber.Location = new Point(434, 36);
            lblAssetNumber.Name = "lblAssetNumber";
            lblAssetNumber.Size = new Size(50, 20);
            lblAssetNumber.TabIndex = 4;
            lblAssetNumber.Text = "label1";
            // 
            // frmSetRoomAssets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblAssetNumber);
            Controls.Add(btnSave);
            Controls.Add(cmbStatus);
            Controls.Add(cmbPartNumber);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmSetRoomAssets";
            Text = "btnSetRoomAssets";
            Load += btnSetRoomAssets_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cmbPartNumber;
        private ComboBox cmbStatus;
        private Button btnSave;
        private Label lblAssetNumber;
    }
}