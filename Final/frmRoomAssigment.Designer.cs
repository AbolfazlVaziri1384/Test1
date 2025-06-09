namespace Final
{
    partial class frmRoomAssigment
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
            btnPrint = new Button();
            btnDelete = new Button();
            btnSetRoomAssigment = new Button();
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
            // btnPrint
            // 
            btnPrint.Location = new Point(406, 42);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "button1";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(406, 80);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "button2";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSetRoomAssigment
            // 
            btnSetRoomAssigment.Location = new Point(406, 109);
            btnSetRoomAssigment.Name = "btnSetRoomAssigment";
            btnSetRoomAssigment.Size = new Size(75, 23);
            btnSetRoomAssigment.TabIndex = 3;
            btnSetRoomAssigment.Text = "button3";
            btnSetRoomAssigment.UseVisualStyleBackColor = true;
            // 
            // frmRoomAssigment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSetRoomAssigment);
            Controls.Add(btnDelete);
            Controls.Add(btnPrint);
            Controls.Add(dgvStudents);
            Name = "frmRoomAssigment";
            Text = "frmRoomAssigment";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvStudents;
        private Button btnPrint;
        private Button btnDelete;
        private Button btnSetRoomAssigment;
    }
}