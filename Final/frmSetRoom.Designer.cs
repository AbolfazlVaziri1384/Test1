namespace Final
{
    partial class frmSetRoom
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
            numNumber = new NumericUpDown();
            numCapacity = new NumericUpDown();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numFloorNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(364, 48);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 0;
            // 
            // numFloorNumber
            // 
            numFloorNumber.Location = new Point(344, 102);
            numFloorNumber.Name = "numFloorNumber";
            numFloorNumber.Size = new Size(120, 23);
            numFloorNumber.TabIndex = 1;
            // 
            // numNumber
            // 
            numNumber.Location = new Point(344, 142);
            numNumber.Name = "numNumber";
            numNumber.Size = new Size(120, 23);
            numNumber.TabIndex = 2;
            // 
            // numCapacity
            // 
            numCapacity.Location = new Point(344, 171);
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(120, 23);
            numCapacity.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(377, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmSetRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(numCapacity);
            Controls.Add(numNumber);
            Controls.Add(numFloorNumber);
            Controls.Add(txtName);
            Name = "frmSetRoom";
            Text = "frmSetRoom";
            ((System.ComponentModel.ISupportInitialize)numFloorNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private NumericUpDown numFloorNumber;
        private NumericUpDown numNumber;
        private NumericUpDown numCapacity;
        private Button btnSave;
    }
}