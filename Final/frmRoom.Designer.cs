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
            dvgRooms = new DataGridView();
            txtSearch = new TextBox();
            btnSetRoomAssigment = new Button();
            btnSetRoom = new Button();
            btnShowRoomAssigment = new Button();
            btnDelete = new Button();
            btnPrint = new Button();
            btnEdit = new Button();
            ((System.ComponentModel.ISupportInitialize)dvgRooms).BeginInit();
            SuspendLayout();
            // 
            // dvgRooms
            // 
            dvgRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvgRooms.Location = new Point(12, 12);
            dvgRooms.Name = "dvgRooms";
            dvgRooms.Size = new Size(240, 150);
            dvgRooms.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(368, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSetRoomAssigment
            // 
            btnSetRoomAssigment.Location = new Point(393, 255);
            btnSetRoomAssigment.Name = "btnSetRoomAssigment";
            btnSetRoomAssigment.Size = new Size(75, 23);
            btnSetRoomAssigment.TabIndex = 13;
            btnSetRoomAssigment.Text = "button6";
            btnSetRoomAssigment.UseVisualStyleBackColor = true;
            // 
            // btnSetRoom
            // 
            btnSetRoom.Location = new Point(393, 226);
            btnSetRoom.Name = "btnSetRoom";
            btnSetRoom.Size = new Size(75, 23);
            btnSetRoom.TabIndex = 12;
            btnSetRoom.Text = "button5";
            btnSetRoom.UseVisualStyleBackColor = true;
            // 
            // btnShowRoomAssigment
            // 
            btnShowRoomAssigment.Location = new Point(393, 197);
            btnShowRoomAssigment.Name = "btnShowRoomAssigment";
            btnShowRoomAssigment.Size = new Size(75, 23);
            btnShowRoomAssigment.TabIndex = 11;
            btnShowRoomAssigment.Text = "button4";
            btnShowRoomAssigment.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(393, 168);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "button3";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(393, 139);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 9;
            btnPrint.Text = "button2";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(393, 110);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 8;
            btnEdit.Text = "button1";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // frmRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSetRoomAssigment);
            Controls.Add(btnSetRoom);
            Controls.Add(btnShowRoomAssigment);
            Controls.Add(btnDelete);
            Controls.Add(btnPrint);
            Controls.Add(btnEdit);
            Controls.Add(txtSearch);
            Controls.Add(dvgRooms);
            Name = "frmRoom";
            Text = "frmRoom";
            ((System.ComponentModel.ISupportInitialize)dvgRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dvgRooms;
        private TextBox txtSearch;
        private Button btnSetRoomAssigment;
        private Button btnSetRoom;
        private Button btnShowRoomAssigment;
        private Button btnDelete;
        private Button btnPrint;
        private Button btnEdit;
    }
}