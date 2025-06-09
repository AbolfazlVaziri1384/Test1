namespace Final
{
    partial class frmStudentAssets
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
            dgvStudentAssets = new DataGridView();
            txtSearch = new TextBox();
            btnRepairRoomAsset = new Button();
            btnSetTransfer = new Button();
            btnSetStudentAsset = new Button();
            btnDelete = new Button();
            btnPrint = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudentAssets).BeginInit();
            SuspendLayout();
            // 
            // dgvStudentAssets
            // 
            dgvStudentAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentAssets.Location = new Point(12, 12);
            dgvStudentAssets.Name = "dgvStudentAssets";
            dgvStudentAssets.Size = new Size(240, 150);
            dgvStudentAssets.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(363, 22);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnRepairRoomAsset
            // 
            btnRepairRoomAsset.Location = new Point(388, 220);
            btnRepairRoomAsset.Name = "btnRepairRoomAsset";
            btnRepairRoomAsset.Size = new Size(75, 23);
            btnRepairRoomAsset.TabIndex = 13;
            btnRepairRoomAsset.Text = "button6";
            btnRepairRoomAsset.UseVisualStyleBackColor = true;
            // 
            // btnSetTransfer
            // 
            btnSetTransfer.Location = new Point(388, 191);
            btnSetTransfer.Name = "btnSetTransfer";
            btnSetTransfer.Size = new Size(75, 23);
            btnSetTransfer.TabIndex = 12;
            btnSetTransfer.Text = "button5";
            btnSetTransfer.UseVisualStyleBackColor = true;
            // 
            // btnSetStudentAsset
            // 
            btnSetStudentAsset.Location = new Point(388, 162);
            btnSetStudentAsset.Name = "btnSetStudentAsset";
            btnSetStudentAsset.Size = new Size(75, 23);
            btnSetStudentAsset.TabIndex = 11;
            btnSetStudentAsset.Text = "button4";
            btnSetStudentAsset.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(388, 133);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "button3";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(388, 104);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 9;
            btnPrint.Text = "button2";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(388, 75);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "button1";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // frmStudentAssets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(523, 450);
            Controls.Add(btnRepairRoomAsset);
            Controls.Add(btnSetTransfer);
            Controls.Add(btnSetStudentAsset);
            Controls.Add(btnDelete);
            Controls.Add(btnPrint);
            Controls.Add(btnEdit);
            Controls.Add(txtSearch);
            Controls.Add(dgvStudentAssets);
            Name = "frmStudentAssets";
            Text = "frmStudentAssets";
            ((System.ComponentModel.ISupportInitialize)dgvStudentAssets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudentAssets;
        private TextBox txtSearch;
        private Button btnRepairRoomAsset;
        private Button btnSetTransfer;
        private Button btnSetStudentAsset;
        private Button btnDelete;
        private Button btnPrint;
        private Button btnEdit;
    }
}