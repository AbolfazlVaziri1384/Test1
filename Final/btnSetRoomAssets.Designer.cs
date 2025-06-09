namespace Final
{
    partial class btnSetRoomAssets
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
            txtAssetNumber = new TextBox();
            cmbPartNumber = new ComboBox();
            cmbStatus = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtAssetNumber
            // 
            txtAssetNumber.Location = new Point(367, 23);
            txtAssetNumber.Name = "txtAssetNumber";
            txtAssetNumber.Size = new Size(100, 23);
            txtAssetNumber.TabIndex = 0;
            // 
            // cmbPartNumber
            // 
            cmbPartNumber.FormattingEnabled = true;
            cmbPartNumber.Location = new Point(346, 65);
            cmbPartNumber.Name = "cmbPartNumber";
            cmbPartNumber.Size = new Size(121, 23);
            cmbPartNumber.TabIndex = 1;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(346, 94);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(380, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSetRoomAssets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(cmbStatus);
            Controls.Add(cmbPartNumber);
            Controls.Add(txtAssetNumber);
            Name = "btnSetRoomAssets";
            Text = "btnSetRoomAssets";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAssetNumber;
        private ComboBox cmbPartNumber;
        private ComboBox cmbStatus;
        private Button btnSave;
    }
}