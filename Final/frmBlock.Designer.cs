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
            dgvBlocks.Location = new Point(14, 16);
            dgvBlocks.Margin = new Padding(3, 4, 3, 4);
            dgvBlocks.Name = "dgvBlocks";
            dgvBlocks.RowHeadersWidth = 51;
            dgvBlocks.Size = new Size(274, 200);
            dgvBlocks.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(392, 33);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(114, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(421, 121);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(86, 31);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "button1";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(421, 160);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(86, 31);
            btnPrint.TabIndex = 3;
            btnPrint.Text = "button2";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(421, 199);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "button3";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSetBlock
            // 
            btnSetBlock.Location = new Point(421, 237);
            btnSetBlock.Margin = new Padding(3, 4, 3, 4);
            btnSetBlock.Name = "btnSetBlock";
            btnSetBlock.Size = new Size(86, 31);
            btnSetBlock.TabIndex = 5;
            btnSetBlock.Text = "button4";
            btnSetBlock.UseVisualStyleBackColor = true;
            // 
            // btnSetRoom
            // 
            btnSetRoom.Location = new Point(421, 276);
            btnSetRoom.Margin = new Padding(3, 4, 3, 4);
            btnSetRoom.Name = "btnSetRoom";
            btnSetRoom.Size = new Size(86, 31);
            btnSetRoom.TabIndex = 6;
            btnSetRoom.Text = "button5";
            btnSetRoom.UseVisualStyleBackColor = true;
            // 
            // btnAddOwner
            // 
            btnAddOwner.Location = new Point(421, 315);
            btnAddOwner.Margin = new Padding(3, 4, 3, 4);
            btnAddOwner.Name = "btnAddOwner";
            btnAddOwner.Size = new Size(86, 31);
            btnAddOwner.TabIndex = 7;
            btnAddOwner.Text = "button6";
            btnAddOwner.UseVisualStyleBackColor = true;
            // 
            // btnDeleteOwner
            // 
            btnDeleteOwner.Location = new Point(421, 353);
            btnDeleteOwner.Margin = new Padding(3, 4, 3, 4);
            btnDeleteOwner.Name = "btnDeleteOwner";
            btnDeleteOwner.Size = new Size(86, 31);
            btnDeleteOwner.TabIndex = 8;
            btnDeleteOwner.Text = "button7";
            btnDeleteOwner.UseVisualStyleBackColor = true;
            // 
            // btnShowRooms
            // 
            btnShowRooms.Location = new Point(421, 392);
            btnShowRooms.Margin = new Padding(3, 4, 3, 4);
            btnShowRooms.Name = "btnShowRooms";
            btnShowRooms.Size = new Size(86, 31);
            btnShowRooms.TabIndex = 9;
            btnShowRooms.Text = "button8";
            btnShowRooms.UseVisualStyleBackColor = true;
            // 
            // frmBlock
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmBlock";
            Text = "frmBlock";
            Load += frmBlock_Load;
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