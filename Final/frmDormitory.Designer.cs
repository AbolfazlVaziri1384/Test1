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
            dgvDormitory.Location = new Point(14, 16);
            dgvDormitory.Margin = new Padding(3, 4, 3, 4);
            dgvDormitory.Name = "dgvDormitory";
            dgvDormitory.RowHeadersWidth = 51;
            dgvDormitory.Size = new Size(274, 200);
            dgvDormitory.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(387, 48);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(114, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnStudentPrint
            // 
            btnStudentPrint.Location = new Point(461, 87);
            btnStudentPrint.Margin = new Padding(3, 4, 3, 4);
            btnStudentPrint.Name = "btnStudentPrint";
            btnStudentPrint.Size = new Size(86, 31);
            btnStudentPrint.TabIndex = 2;
            btnStudentPrint.Text = "button1";
            btnStudentPrint.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(461, 125);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(86, 31);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "button2";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(461, 164);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 31);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "button3";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(461, 203);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "button4";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnsetDormitory
            // 
            btnsetDormitory.Location = new Point(461, 241);
            btnsetDormitory.Margin = new Padding(3, 4, 3, 4);
            btnsetDormitory.Name = "btnsetDormitory";
            btnsetDormitory.Size = new Size(86, 31);
            btnsetDormitory.TabIndex = 6;
            btnsetDormitory.Text = "button5";
            btnsetDormitory.UseVisualStyleBackColor = true;
            // 
            // btnSetBlock
            // 
            btnSetBlock.Location = new Point(461, 280);
            btnSetBlock.Margin = new Padding(3, 4, 3, 4);
            btnSetBlock.Name = "btnSetBlock";
            btnSetBlock.Size = new Size(86, 31);
            btnSetBlock.TabIndex = 7;
            btnSetBlock.Text = "button6";
            btnSetBlock.UseVisualStyleBackColor = true;
            // 
            // btnAddOwner
            // 
            btnAddOwner.Location = new Point(461, 321);
            btnAddOwner.Margin = new Padding(3, 4, 3, 4);
            btnAddOwner.Name = "btnAddOwner";
            btnAddOwner.Size = new Size(86, 31);
            btnAddOwner.TabIndex = 8;
            btnAddOwner.Text = "button7";
            btnAddOwner.UseVisualStyleBackColor = true;
            // 
            // btnDeleteOwner
            // 
            btnDeleteOwner.Location = new Point(461, 360);
            btnDeleteOwner.Margin = new Padding(3, 4, 3, 4);
            btnDeleteOwner.Name = "btnDeleteOwner";
            btnDeleteOwner.Size = new Size(86, 31);
            btnDeleteOwner.TabIndex = 9;
            btnDeleteOwner.Text = "button8";
            btnDeleteOwner.UseVisualStyleBackColor = true;
            // 
            // btnShowBlocks
            // 
            btnShowBlocks.Location = new Point(461, 412);
            btnShowBlocks.Margin = new Padding(3, 4, 3, 4);
            btnShowBlocks.Name = "btnShowBlocks";
            btnShowBlocks.Size = new Size(86, 31);
            btnShowBlocks.TabIndex = 10;
            btnShowBlocks.Text = "button9";
            btnShowBlocks.UseVisualStyleBackColor = true;
            // 
            // frmDormitory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmDormitory";
            Text = "frmDormitory";
            Load += frmDormitory_Load;
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