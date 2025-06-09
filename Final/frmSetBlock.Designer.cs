namespace Final
{
    partial class frmSetBlock
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
            txtName = new TextBox();
            numFloorNumber = new NumericUpDown();
            numRoomNumber = new NumericUpDown();
            numCapacity = new NumericUpDown();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numFloorNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoomNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(382, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // numFloorNumber
            // 
            numFloorNumber.Location = new Point(362, 77);
            numFloorNumber.Name = "numFloorNumber";
            numFloorNumber.Size = new Size(120, 23);
            numFloorNumber.TabIndex = 1;
            // 
            // numRoomNumber
            // 
            numRoomNumber.Location = new Point(362, 119);
            numRoomNumber.Name = "numRoomNumber";
            numRoomNumber.Size = new Size(120, 23);
            numRoomNumber.TabIndex = 2;
            // 
            // numCapacity
            // 
            numCapacity.Location = new Point(362, 161);
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(120, 23);
            numCapacity.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(407, 406);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmSetBlock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(numCapacity);
            Controls.Add(numRoomNumber);
            Controls.Add(numFloorNumber);
            Controls.Add(txtName);
            Name = "frmSetBlock";
            Text = "frmSetBlock";
            ((System.ComponentModel.ISupportInitialize)numFloorNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoomNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private NumericUpDown numFloorNumber;
        private NumericUpDown numRoomNumber;
        private NumericUpDown numCapacity;
        private Button btnSave;
    }
}