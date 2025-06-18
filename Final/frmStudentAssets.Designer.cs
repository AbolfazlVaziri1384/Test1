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
            btnRepairRoomAsset = new Button();
            btnSetTransfer = new Button();
            btnSetStudentAsset = new Button();
            btnDelete = new Button();
            btnPrint = new Button();
            btnEdit = new Button();
            dgvRoomAssets = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvStudentAssets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomAssets).BeginInit();
            SuspendLayout();
            // 
            // dgvStudentAssets
            // 
            dgvStudentAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudentAssets.Location = new Point(14, 16);
            dgvStudentAssets.Margin = new Padding(3, 4, 3, 4);
            dgvStudentAssets.Name = "dgvStudentAssets";
            dgvStudentAssets.RowHeadersWidth = 51;
            dgvStudentAssets.Size = new Size(274, 200);
            dgvStudentAssets.TabIndex = 0;
            // 
            // btnRepairRoomAsset
            // 
            btnRepairRoomAsset.Location = new Point(443, 293);
            btnRepairRoomAsset.Margin = new Padding(3, 4, 3, 4);
            btnRepairRoomAsset.Name = "btnRepairRoomAsset";
            btnRepairRoomAsset.Size = new Size(86, 31);
            btnRepairRoomAsset.TabIndex = 13;
            btnRepairRoomAsset.Text = "button6";
            btnRepairRoomAsset.UseVisualStyleBackColor = true;
            btnRepairRoomAsset.Click += btnRepairRoomAsset_Click;
            // 
            // btnSetTransfer
            // 
            btnSetTransfer.Location = new Point(443, 255);
            btnSetTransfer.Margin = new Padding(3, 4, 3, 4);
            btnSetTransfer.Name = "btnSetTransfer";
            btnSetTransfer.Size = new Size(86, 31);
            btnSetTransfer.TabIndex = 12;
            btnSetTransfer.Text = "button5";
            btnSetTransfer.UseVisualStyleBackColor = true;
            btnSetTransfer.Click += btnSetTransfer_Click;
            // 
            // btnSetStudentAsset
            // 
            btnSetStudentAsset.Location = new Point(443, 216);
            btnSetStudentAsset.Margin = new Padding(3, 4, 3, 4);
            btnSetStudentAsset.Name = "btnSetStudentAsset";
            btnSetStudentAsset.Size = new Size(86, 31);
            btnSetStudentAsset.TabIndex = 11;
            btnSetStudentAsset.Text = "button4";
            btnSetStudentAsset.UseVisualStyleBackColor = true;
            btnSetStudentAsset.Click += btnSetStudentAsset_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(443, 177);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "button3";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(443, 139);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(86, 31);
            btnPrint.TabIndex = 9;
            btnPrint.Text = "button2";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(340, 39);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 31);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "button1";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // dgvRoomAssets
            // 
            dgvRoomAssets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRoomAssets.Location = new Point(14, 237);
            dgvRoomAssets.Margin = new Padding(3, 4, 3, 4);
            dgvRoomAssets.Name = "dgvRoomAssets";
            dgvRoomAssets.RowHeadersWidth = 51;
            dgvRoomAssets.Size = new Size(274, 200);
            dgvRoomAssets.TabIndex = 14;
            // 
            // frmStudentAssets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 600);
            Controls.Add(dgvRoomAssets);
            Controls.Add(btnRepairRoomAsset);
            Controls.Add(btnSetTransfer);
            Controls.Add(btnSetStudentAsset);
            Controls.Add(btnDelete);
            Controls.Add(btnPrint);
            Controls.Add(btnEdit);
            Controls.Add(dgvStudentAssets);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmStudentAssets";
            Text = "frmStudentAssets";
            Load += frmStudentAssets_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudentAssets).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvRoomAssets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStudentAssets;
        private Button btnRepairRoomAsset;
        private Button btnSetTransfer;
        private Button btnSetStudentAsset;
        private Button btnDelete;
        private Button btnPrint;
        private Button btnEdit;
        private DataGridView dgvRoomAssets;
    }
}