namespace Final
{
    partial class frmBlock
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
            dgvBlocks = new DataGridView();
            txtSearch = new TextBox();
            btnEdit = new Button();
            btnPrint = new Button();
            btnDelete = new Button();
            btnSetBlock = new Button();
            btnSetRoom = new Button();
            btnAddOwner = new Button();
            btnDeleteOwner = new Button();
            btnShowRooms = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBlocks).BeginInit();
            SuspendLayout();
            // 
            // dgvBlocks
            // 
            dgvBlocks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBlocks.Location = new Point(12, 12);
            dgvBlocks.Name = "dgvBlocks";
            dgvBlocks.Size = new Size(240, 150);
            dgvBlocks.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(343, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(100, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(368, 91);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "button1";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(368, 120);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "button2";
            btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(368, 149);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "button3";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSetBlock
            // 
            btnSetBlock.Location = new Point(368, 178);
            btnSetBlock.Name = "btnSetBlock";
            btnSetBlock.Size = new Size(75, 23);
            btnSetBlock.TabIndex = 5;
            btnSetBlock.Text = "button4";
            btnSetBlock.UseVisualStyleBackColor = true;
            // 
            // btnSetRoom
            // 
            btnSetRoom.Location = new Point(368, 207);
            btnSetRoom.Name = "btnSetRoom";
            btnSetRoom.Size = new Size(75, 23);
            btnSetRoom.TabIndex = 6;
            btnSetRoom.Text = "button5";
            btnSetRoom.UseVisualStyleBackColor = true;
            // 
            // btnAddOwner
            // 
            btnAddOwner.Location = new Point(368, 236);
            btnAddOwner.Name = "btnAddOwner";
            btnAddOwner.Size = new Size(75, 23);
            btnAddOwner.TabIndex = 7;
            btnAddOwner.Text = "button6";
            btnAddOwner.UseVisualStyleBackColor = true;
            // 
            // btnDeleteOwner
            // 
            btnDeleteOwner.Location = new Point(368, 265);
            btnDeleteOwner.Name = "btnDeleteOwner";
            btnDeleteOwner.Size = new Size(75, 23);
            btnDeleteOwner.TabIndex = 8;
            btnDeleteOwner.Text = "button7";
            btnDeleteOwner.UseVisualStyleBackColor = true;
            // 
            // btnShowRooms
            // 
            btnShowRooms.Location = new Point(368, 294);
            btnShowRooms.Name = "btnShowRooms";
            btnShowRooms.Size = new Size(75, 23);
            btnShowRooms.TabIndex = 9;
            btnShowRooms.Text = "button8";
            btnShowRooms.UseVisualStyleBackColor = true;
            // 
            // frmBlock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShowRooms);
            Controls.Add(btnDeleteOwner);
            Controls.Add(btnAddOwner);
            Controls.Add(btnSetRoom);
            Controls.Add(btnSetBlock);
            Controls.Add(btnDelete);
            Controls.Add(btnPrint);
            Controls.Add(btnEdit);
            Controls.Add(txtSearch);
            Controls.Add(dgvBlocks);
            Name = "frmBlock";
            Text = "frmBlock";
            ((System.ComponentModel.ISupportInitialize)dgvBlocks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBlocks;
        private TextBox txtSearch;
        private Button btnEdit;
        private Button btnPrint;
        private Button btnDelete;
        private Button btnSetBlock;
        private Button btnSetRoom;
        private Button btnAddOwner;
        private Button btnDeleteOwner;
        private Button btnShowRooms;
    }
}