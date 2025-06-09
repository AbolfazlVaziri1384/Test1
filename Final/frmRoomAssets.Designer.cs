namespace Final
{
    partial class frmRoomAssets
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
            btnRepairRoomAssetsRequest = new Button();
            btnSetRoomAssets = new Button();
            btnRepairRoomAsset = new Button();
            btnDelete = new Button();
            btnPrint = new Button();
            btnEdit = new Button();
            txtSearch = new TextBox();
            dgvRoomAssets = new DataGridView();
            btnDeleteOwner = new Button();
            btnSetOwner = new Button();
            btnEditOwner = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRoomAssets).BeginInit();
            SuspendLayout();
            // 
            // btnRepairRoomAssetsRequest
            // 
            btnRepairRoomAssetsRequest.Location = new Point(388, 220);
            btnRepairRoomAssetsRequest.Name = "btnRepairRoomAssetsRequest";
            btnRepairRoomAssetsRequest.Size = new Size(75, 23);
            btnRepairRoomAssetsRequest.TabIndex = 21;
            btnRepairRoomAssetsRequest.Text = "button6";
            btnRepairRoomAssetsRequest.UseVisualStyleBackColor = true;
            // 
            // btnSetRoomAssets
            // 
            btnSetRoomAssets.Location = new Point(388, 191);
            btnSetRoomAssets.Name = "btnSetRoomAssets";
            btnSetRoomAssets.Size = new Size(75, 23);
            btnSetRoomAssets.TabIndex = 20;
            btnSetRoomAssets.Text = "button5";
            btnSetRoomAssets.UseVisualStyleBackColor = true;
            // 
            // btnRepairRoomAsset
            // 
            btnRepairRoomAsset.Location = new Point(388, 162);
            btnRepairRoomAsset.Name = "btnRepairRoomAsset";
            btnRepairRoomAsset.Size = new Size(75, 23);
            btnRepairRoomAsset.TabIndex = 19;
            btnRepairRoomAsset.Text = "button4";
            btnRepairRoomAsset.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(388, 133);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "button3";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(388, 104);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 17;
            btnPrint.Text = "button2";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(388, 75);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 16;
            btnEdit.Text = "button1";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(363, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 15;
            // 
            // dgvRoomAssets
            // 
            dgvRoomAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomAssets.Location = new Point(12, 12);
            dgvRoomAssets.Name = "dgvRoomAssets";
            dgvRoomAssets.Size = new Size(240, 150);
            dgvRoomAssets.TabIndex = 14;
            // 
            // btnDeleteOwner
            // 
            btnDeleteOwner.Location = new Point(388, 249);
            btnDeleteOwner.Name = "btnDeleteOwner";
            btnDeleteOwner.Size = new Size(75, 23);
            btnDeleteOwner.TabIndex = 22;
            btnDeleteOwner.Text = "button6";
            btnDeleteOwner.UseVisualStyleBackColor = true;
            // 
            // btnSetOwner
            // 
            btnSetOwner.Location = new Point(388, 278);
            btnSetOwner.Name = "btnSetOwner";
            btnSetOwner.Size = new Size(75, 23);
            btnSetOwner.TabIndex = 23;
            btnSetOwner.Text = "button6";
            btnSetOwner.UseVisualStyleBackColor = true;
            // 
            // btnEditOwner
            // 
            btnEditOwner.Location = new Point(388, 307);
            btnEditOwner.Name = "btnEditOwner";
            btnEditOwner.Size = new Size(75, 23);
            btnEditOwner.TabIndex = 24;
            btnEditOwner.Text = "button6";
            btnEditOwner.UseVisualStyleBackColor = true;
            // 
            // frmRoomAssets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditOwner);
            Controls.Add(btnSetOwner);
            Controls.Add(btnDeleteOwner);
            Controls.Add(btnRepairRoomAssetsRequest);
            Controls.Add(btnSetRoomAssets);
            Controls.Add(btnRepairRoomAsset);
            Controls.Add(btnDelete);
            Controls.Add(btnPrint);
            Controls.Add(btnEdit);
            Controls.Add(txtSearch);
            Controls.Add(dgvRoomAssets);
            Name = "frmRoomAssets";
            Text = "frmRoomAssets";
            ((System.ComponentModel.ISupportInitialize)dgvRoomAssets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRepairRoomAssetsRequest;
        private Button btnSetRoomAssets;
        private Button btnRepairRoomAsset;
        private Button btnDelete;
        private Button btnPrint;
        private Button btnEdit;
        private TextBox txtSearch;
        private DataGridView dgvRoomAssets;
        private Button btnDeleteOwner;
        private Button btnSetOwner;
        private Button btnEditOwner;
    }
}