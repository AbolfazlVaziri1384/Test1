namespace Final
{
    partial class frmSetRoomAssigment
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
            dgvStudents = new DataGridView();
            txtSearch = new TextBox();
            lblRoomAssets = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(14, 16);
            dgvStudents.Margin = new Padding(3, 4, 3, 4);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 51;
            dgvStudents.Size = new Size(274, 200);
            dgvStudents.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(419, 36);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(114, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblRoomAssets
            // 
            lblRoomAssets.AutoSize = true;
            lblRoomAssets.Location = new Point(454, 139);
            lblRoomAssets.Name = "lblRoomAssets";
            lblRoomAssets.Size = new Size(50, 20);
            lblRoomAssets.TabIndex = 2;
            lblRoomAssets.Text = "label1";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(448, 212);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 3;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmSetRoomAssigment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnSave);
            Controls.Add(lblRoomAssets);
            Controls.Add(txtSearch);
            Controls.Add(dgvStudents);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmSetRoomAssigment";
            Text = "frmSetRoomAssigment";
            Load += frmSetRoomAssigment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private TextBox txtSearch;
        private Label lblRoomAssets;
        private Button btnSave;
    }
}