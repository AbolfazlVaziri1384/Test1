namespace Final
{
    partial class frmTransferRoomAssetHistory
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
            dgvOwner = new DataGridView();
            txtSearch = new TextBox();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOwner).BeginInit();
            SuspendLayout();
            // 
            // dgvOwner
            // 
            dgvOwner.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOwner.Location = new Point(12, 12);
            dgvOwner.Name = "dgvOwner";
            dgvOwner.Size = new Size(240, 150);
            dgvOwner.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(374, 38);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(414, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 2;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmTransferRoomAssetHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtSearch);
            Controls.Add(dgvOwner);
            Name = "frmTransferRoomAssetHistory";
            Text = "frmTransferRoomAssetHistory";
            ((System.ComponentModel.ISupportInitialize)dgvOwner).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvOwner;
        private TextBox txtSearch;
        private Button btnSave;
    }
}