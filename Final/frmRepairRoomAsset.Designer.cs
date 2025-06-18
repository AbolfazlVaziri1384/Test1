namespace Final
{
    partial class frmRepairRoomAsset
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
            cmbStatus = new ComboBox();
            txtDiscription = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "سالم", "معیوب" });
            cmbStatus.Location = new Point(406, 33);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(138, 28);
            cmbStatus.TabIndex = 0;
            // 
            // txtDiscription
            // 
            txtDiscription.Location = new Point(430, 117);
            txtDiscription.Margin = new Padding(3, 4, 3, 4);
            txtDiscription.Name = "txtDiscription";
            txtDiscription.Size = new Size(114, 27);
            txtDiscription.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(430, 227);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 2;
            btnSave.Text = "button1";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmRepairRoomAsset
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnSave);
            Controls.Add(txtDiscription);
            Controls.Add(cmbStatus);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmRepairRoomAsset";
            Text = "frmRepairRoomAsset";
            Load += frmRepairRoomAsset_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbStatus;
        private TextBox txtDiscription;
        private Button btnSave;
    }
}