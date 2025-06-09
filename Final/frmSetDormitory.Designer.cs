namespace Final
{
    partial class frmSetDormitory
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
            txtAddress = new TextBox();
            numCapacity = new NumericUpDown();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(379, 72);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(379, 45);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(100, 23);
            txtAddress.TabIndex = 2;
            // 
            // numCapacity
            // 
            numCapacity.Location = new Point(359, 101);
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(120, 23);
            numCapacity.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(404, 415);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmSetDormitory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(numCapacity);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Name = "frmSetDormitory";
            Text = "frmSetDormitory";
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtAddress;
        private NumericUpDown numCapacity;
        private Button btnSave;
    }
}