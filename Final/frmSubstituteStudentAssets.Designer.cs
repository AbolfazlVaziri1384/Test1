namespace Final
{
    partial class frmSubstituteStudentAssets
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
            dgvSubstitute = new DataGridView();
            btnPrint = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSubstitute).BeginInit();
            SuspendLayout();
            // 
            // dgvSubstitute
            // 
            dgvSubstitute.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubstitute.Location = new Point(39, 12);
            dgvSubstitute.Name = "dgvSubstitute";
            dgvSubstitute.RowHeadersWidth = 51;
            dgvSubstitute.Size = new Size(300, 188);
            dgvSubstitute.TabIndex = 0;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(509, 90);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(94, 29);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "btnPrint";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // frmSubstituteStudentAssets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPrint);
            Controls.Add(dgvSubstitute);
            Name = "frmSubstituteStudentAssets";
            Text = "frmSubstituteStudentAssets";
            Load += frmSubstituteStudentAssets_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSubstitute).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvSubstitute;
        private Button btnPrint;
    }
}