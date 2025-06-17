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
            lblDormitory = new Label();
            lblBlock = new Label();
            lblBlockOwner = new Label();
            lblDormitoryOwner = new Label();
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
            // btnPrint
            // 
            btnPrint.Location = new Point(464, 56);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(86, 31);
            btnPrint.TabIndex = 1;
            btnPrint.Text = "button1";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(464, 107);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "button2";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSetRoomAssigment
            // 
            btnSetRoomAssigment.Location = new Point(464, 145);
            btnSetRoomAssigment.Margin = new Padding(3, 4, 3, 4);
            btnSetRoomAssigment.Name = "btnSetRoomAssigment";
            btnSetRoomAssigment.Size = new Size(86, 31);
            btnSetRoomAssigment.TabIndex = 3;
            btnSetRoomAssigment.Text = "button3";
            btnSetRoomAssigment.UseVisualStyleBackColor = true;
            // 
            // lblDormitory
            // 
            lblDormitory.AutoSize = true;
            lblDormitory.Location = new Point(617, 56);
            lblDormitory.Name = "lblDormitory";
            lblDormitory.Size = new Size(94, 20);
            lblDormitory.TabIndex = 4;
            lblDormitory.Text = "lblDormitory";
            // 
            // lblBlock
            // 
            lblBlock.AutoSize = true;
            lblBlock.Location = new Point(617, 96);
            lblBlock.Name = "lblBlock";
            lblBlock.Size = new Size(62, 20);
            lblBlock.TabIndex = 5;
            lblBlock.Text = "lblBlock";
            // 
            // lblBlockOwner
            // 
            lblBlockOwner.AutoSize = true;
            lblBlockOwner.Location = new Point(617, 145);
            lblBlockOwner.Name = "lblBlockOwner";
            lblBlockOwner.Size = new Size(105, 20);
            lblBlockOwner.TabIndex = 6;
            lblBlockOwner.Text = "lblBlockOwner";
            // 
            // lblDormitoryOwner
            // 
            lblDormitoryOwner.AutoSize = true;
            lblDormitoryOwner.Location = new Point(617, 178);
            lblDormitoryOwner.Name = "lblDormitoryOwner";
            lblDormitoryOwner.Size = new Size(137, 20);
            lblDormitoryOwner.TabIndex = 7;
            lblDormitoryOwner.Text = "lblDormitoryOwner";
            // 
            // frmRoomAssigment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lblDormitoryOwner);
            Controls.Add(lblBlockOwner);
            Controls.Add(lblBlock);
            Controls.Add(lblDormitory);
            Controls.Add(btnSetRoomAssigment);
            Controls.Add(btnDelete);
            Controls.Add(btnPrint);
            Controls.Add(dgvStudents);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRoomAssigment";
            Text = "frmRoomAssigment";
            Load += frmRoomAssigment_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvStudents;
        private Button btnPrint;
        private Button btnDelete;
        private Button btnSetRoomAssigment;
        private Label lblDormitory;
        private Label lblBlock;
        private Label lblBlockOwner;
        private Label lblDormitoryOwner;
    }
}