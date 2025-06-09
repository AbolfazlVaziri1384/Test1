namespace Final
{
    partial class frmSetRole
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
            dgvUsers = new DataGridView();
            txtSearch = new TextBox();
            btnSet = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // dgvUsers
            // 
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new Point(12, 12);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.Size = new Size(240, 150);
            dgvUsers.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(363, 33);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSet
            // 
            btnSet.Location = new Point(388, 91);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(75, 23);
            btnSet.TabIndex = 2;
            btnSet.Text = "button1";
            btnSet.UseVisualStyleBackColor = true;
            // 
            // frmSetRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSet);
            Controls.Add(txtSearch);
            Controls.Add(dgvUsers);
            Name = "frmSetRole";
            Text = "frmSetRole";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsers;
        private TextBox txtSearch;
        private Button btnSet;
    }
}