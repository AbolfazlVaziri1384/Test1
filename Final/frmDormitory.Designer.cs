namespace Final
{
    partial class frmDormitory
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
            dgvDormitory = new DataGridView();
            txtSearch = new TextBox();
            btnStudentPrint = new Button();
            btnPrint = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnsetDormitory = new Button();
            btnSetBlock = new Button();
            btnAddOwner = new Button();
            btnDeleteOwner = new Button();
            btnShowBlocks = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDormitory).BeginInit();
            SuspendLayout();
            // 
            // dgvDormitory
            // 
            dgvDormitory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDormitory.Location = new Point(12, 12);
            dgvDormitory.Name = "dgvDormitory";
            dgvDormitory.Size = new Size(240, 150);
            dgvDormitory.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(339, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnStudentPrint
            // 
            btnStudentPrint.Location = new Point(403, 65);
            btnStudentPrint.Name = "btnStudentPrint";
            btnStudentPrint.Size = new Size(75, 23);
            btnStudentPrint.TabIndex = 2;
            btnStudentPrint.Text = "button1";
            btnStudentPrint.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(403, 94);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "button2";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(403, 123);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "button3";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(403, 152);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "button4";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnsetDormitory
            // 
            btnsetDormitory.Location = new Point(403, 181);
            btnsetDormitory.Name = "btnsetDormitory";
            btnsetDormitory.Size = new Size(75, 23);
            btnsetDormitory.TabIndex = 6;
            btnsetDormitory.Text = "button5";
            btnsetDormitory.UseVisualStyleBackColor = true;
            // 
            // btnSetBlock
            // 
            btnSetBlock.Location = new Point(403, 210);
            btnSetBlock.Name = "btnSetBlock";
            btnSetBlock.Size = new Size(75, 23);
            btnSetBlock.TabIndex = 7;
            btnSetBlock.Text = "button6";
            btnSetBlock.UseVisualStyleBackColor = true;
            // 
            // btnAddOwner
            // 
            btnAddOwner.Location = new Point(403, 241);
            btnAddOwner.Name = "btnAddOwner";
            btnAddOwner.Size = new Size(75, 23);
            btnAddOwner.TabIndex = 8;
            btnAddOwner.Text = "button7";
            btnAddOwner.UseVisualStyleBackColor = true;
            // 
            // btnDeleteOwner
            // 
            btnDeleteOwner.Location = new Point(403, 270);
            btnDeleteOwner.Name = "btnDeleteOwner";
            btnDeleteOwner.Size = new Size(75, 23);
            btnDeleteOwner.TabIndex = 9;
            btnDeleteOwner.Text = "button8";
            btnDeleteOwner.UseVisualStyleBackColor = true;
            // 
            // btnShowBlocks
            // 
            btnShowBlocks.Location = new Point(403, 309);
            btnShowBlocks.Name = "btnShowBlocks";
            btnShowBlocks.Size = new Size(75, 23);
            btnShowBlocks.TabIndex = 10;
            btnShowBlocks.Text = "button9";
            btnShowBlocks.UseVisualStyleBackColor = true;
            // 
            // frmDormitory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowBlocks);
            Controls.Add(btnDeleteOwner);
            Controls.Add(btnAddOwner);
            Controls.Add(btnSetBlock);
            Controls.Add(btnsetDormitory);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnPrint);
            Controls.Add(btnStudentPrint);
            Controls.Add(txtSearch);
            Controls.Add(dgvDormitory);
            Name = "frmDormitory";
            Text = "frmDormitory";
            ((System.ComponentModel.ISupportInitialize)dgvDormitory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDormitory;
        private TextBox txtSearch;
        private Button btnStudentPrint;
        private Button btnPrint;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnsetDormitory;
        private Button btnSetBlock;
        private Button btnAddOwner;
        private Button btnDeleteOwner;
        private Button btnShowBlocks;
    }
}