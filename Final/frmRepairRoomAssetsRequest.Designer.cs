namespace Final
{
    partial class frmRepairRoomAssetsRequest
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
            dgvRequests = new DataGridView();
            txtSearch = new TextBox();
            btnDelete = new Button();
            btnPrint = new Button();
            btnRepair = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            SuspendLayout();
            // 
            // dgvRequests
            // 
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Location = new Point(14, 16);
            dgvRequests.Margin = new Padding(3, 4, 3, 4);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.RowHeadersWidth = 51;
            dgvRequests.Size = new Size(274, 200);
            dgvRequests.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(443, 41);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(114, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(443, 207);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "button3";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(443, 168);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(86, 31);
            btnPrint.TabIndex = 12;
            btnPrint.Text = "button2";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnRepair
            // 
            btnRepair.Location = new Point(443, 129);
            btnRepair.Margin = new Padding(3, 4, 3, 4);
            btnRepair.Name = "btnRepair";
            btnRepair.Size = new Size(86, 31);
            btnRepair.TabIndex = 11;
            btnRepair.Text = "button1";
            btnRepair.UseVisualStyleBackColor = true;
            btnRepair.Click += btnRepair_Click;
            // 
            // frmRepairRoomAssetsRequest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnDelete);
            Controls.Add(btnPrint);
            Controls.Add(btnRepair);
            Controls.Add(txtSearch);
            Controls.Add(dgvRequests);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRepairRoomAssetsRequest";
            Text = "frmRepairRoomAssetsRequest";
            Load += frmRepairRoomAssetsRequest_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRequests;
        private TextBox txtSearch;
        private Button btnDelete;
        private Button btnPrint;
        private Button btnRepair;
    }
}