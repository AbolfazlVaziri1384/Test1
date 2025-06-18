namespace Final
{
    partial class frmSetStudentAssets
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
            txtDiscription = new TextBox();
            lblGuid = new Label();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(400, 72);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(114, 27);
            txtName.TabIndex = 0;
            // 
            // txtDiscription
            // 
            txtDiscription.Location = new Point(400, 133);
            txtDiscription.Margin = new Padding(3, 4, 3, 4);
            txtDiscription.Name = "txtDiscription";
            txtDiscription.Size = new Size(114, 27);
            txtDiscription.TabIndex = 1;
            // 
            // lblGuid
            // 
            lblGuid.AutoSize = true;
            lblGuid.Location = new Point(454, 216);
            lblGuid.Name = "lblGuid";
            lblGuid.Size = new Size(50, 20);
            lblGuid.TabIndex = 2;
            lblGuid.Text = "label1";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(429, 280);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 3;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmSetStudentAssets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnSave);
            Controls.Add(lblGuid);
            Controls.Add(txtDiscription);
            Controls.Add(txtName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmSetStudentAssets";
            Text = "frmSetStudentAssets";
            Load += frmSetStudentAssets_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtDiscription;
        private Label lblGuid;
        private Button btnSave;
    }
}