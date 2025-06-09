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
            dgvRequests.Location = new Point(12, 12);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.Size = new Size(240, 150);
            dgvRequests.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(388, 31);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(388, 155);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "button3";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(388, 126);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 12;
            btnPrint.Text = "button2";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnRepair
            // 
            btnRepair.Location = new Point(388, 97);
            btnRepair.Name = "btnRepair";
            btnRepair.Size = new Size(75, 23);
            btnRepair.TabIndex = 11;
            btnRepair.Text = "button1";
            btnRepair.UseVisualStyleBackColor = true;
            // 
            // frmRepairRoomAssetsRequest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnPrint);
            Controls.Add(btnRepair);
            Controls.Add(txtSearch);
            Controls.Add(dgvRequests);
            Name = "frmRepairRoomAssetsRequest";
            Text = "frmRepairRoomAssetsRequest";
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