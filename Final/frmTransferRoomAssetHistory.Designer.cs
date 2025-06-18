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
            dgvOwner.Location = new Point(14, 16);
            dgvOwner.Margin = new Padding(3, 4, 3, 4);
            dgvOwner.Name = "dgvOwner";
            dgvOwner.RowHeadersWidth = 51;
            dgvOwner.Size = new Size(274, 200);
            dgvOwner.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(427, 51);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(114, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(473, 553);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 2;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmTransferRoomAssetHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnSave);
            Controls.Add(txtSearch);
            Controls.Add(dgvOwner);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmTransferRoomAssetHistory";
            Text = "frmTransferRoomAssetHistory";
            Load += frmTransferRoomAssetHistory_Load;
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