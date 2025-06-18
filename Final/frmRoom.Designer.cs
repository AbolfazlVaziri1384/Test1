namespace Final
{
    partial class frmRoom
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
            dgvRooms = new DataGridView();
            txtSearch = new TextBox();
            btnSetRoomAssigment = new Button();
            btnSetRoom = new Button();
            btnShowRoomAssigment = new Button();
            btnDelete = new Button();
            btnPrint = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            // 
            // dgvRooms
            // 
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Location = new Point(14, 16);
            dgvRooms.Margin = new Padding(3, 4, 3, 4);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.RowHeadersWidth = 51;
            dgvRooms.Size = new Size(274, 200);
            dgvRooms.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(421, 59);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(114, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnSetRoomAssigment
            // 
            btnSetRoomAssigment.Location = new Point(449, 340);
            btnSetRoomAssigment.Margin = new Padding(3, 4, 3, 4);
            btnSetRoomAssigment.Name = "btnSetRoomAssigment";
            btnSetRoomAssigment.Size = new Size(86, 31);
            btnSetRoomAssigment.TabIndex = 13;
            btnSetRoomAssigment.Text = "button6";
            btnSetRoomAssigment.UseVisualStyleBackColor = true;
            // 
            // btnSetRoom
            // 
            btnSetRoom.Location = new Point(449, 301);
            btnSetRoom.Margin = new Padding(3, 4, 3, 4);
            btnSetRoom.Name = "btnSetRoom";
            btnSetRoom.Size = new Size(86, 31);
            btnSetRoom.TabIndex = 12;
            btnSetRoom.Text = "button5";
            btnSetRoom.UseVisualStyleBackColor = true;
            // 
            // btnShowRoomAssigment
            // 
            btnShowRoomAssigment.Location = new Point(449, 263);
            btnShowRoomAssigment.Margin = new Padding(3, 4, 3, 4);
            btnShowRoomAssigment.Name = "btnShowRoomAssigment";
            btnShowRoomAssigment.Size = new Size(86, 31);
            btnShowRoomAssigment.TabIndex = 11;
            btnShowRoomAssigment.Text = "button4";
            btnShowRoomAssigment.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(449, 224);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "button3";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(449, 185);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(86, 31);
            btnPrint.TabIndex = 9;
            btnPrint.Text = "button2";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(449, 147);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 31);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "button1";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // frmRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnSetRoomAssigment);
            Controls.Add(btnSetRoom);
            Controls.Add(btnShowRoomAssigment);
            Controls.Add(btnDelete);
            Controls.Add(btnPrint);
            Controls.Add(btnEdit);
            Controls.Add(txtSearch);
            Controls.Add(dgvRooms);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRoom";
            Text = "frmRoom";
            Load += frmRoom_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRooms;
        private TextBox txtSearch;
        private Button btnSetRoomAssigment;
        private Button btnSetRoom;
        private Button btnShowRoomAssigment;
        private Button btnDelete;
        private Button btnPrint;
        private Button btnEdit;
    }
}