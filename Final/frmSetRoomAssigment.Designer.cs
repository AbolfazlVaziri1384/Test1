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
            dgvStudents.Location = new Point(12, 12);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(240, 150);
            dgvStudents.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(367, 27);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 1;
            // 
            // lblRoomAssets
            // 
            lblRoomAssets.AutoSize = true;
            lblRoomAssets.Location = new Point(397, 104);
            lblRoomAssets.Name = "lblRoomAssets";
            lblRoomAssets.Size = new Size(38, 15);
            lblRoomAssets.TabIndex = 2;
            lblRoomAssets.Text = "label1";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(392, 159);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmSetRoomAssigment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(lblRoomAssets);
            Controls.Add(txtSearch);
            Controls.Add(dgvStudents);
            Name = "frmSetRoomAssigment";
            Text = "frmSetRoomAssigment";
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