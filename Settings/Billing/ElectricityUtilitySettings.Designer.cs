namespace Real_Estate_Management_System.Settings.Billing
{
    partial class ElectricityUtilitySettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElectricityUtilitySettings));
            panel1 = new Panel();
            label1 = new Label();
            btnSave = new Button();
            txtUnitPrice = new TextBox();
            label2 = new Label();
            txtUnit = new TextBox();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 70, 67);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.FromArgb(240, 237, 229);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 99);
            panel1.TabIndex = 31;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 17);
            label1.Name = "label1";
            label1.Size = new Size(498, 64);
            label1.TabIndex = 0;
            label1.Text = "ELECTRICITY UTILITY SETTINGS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 67);
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(0, 70, 67);
            btnSave.Location = new Point(155, 195);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 44);
            btnSave.TabIndex = 36;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Arial", 12F);
            txtUnitPrice.ForeColor = Color.FromArgb(0, 70, 67);
            txtUnitPrice.Location = new Point(190, 148);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(319, 30);
            txtUnitPrice.TabIndex = 35;
            txtUnitPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(11, 151);
            label2.Name = "label2";
            label2.Size = new Size(173, 28);
            label2.TabIndex = 34;
            label2.Text = "Unit Price:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // txtUnit
            // 
            txtUnit.Font = new Font("Arial", 12F);
            txtUnit.ForeColor = Color.FromArgb(0, 70, 67);
            txtUnit.Location = new Point(190, 112);
            txtUnit.Name = "txtUnit";
            txtUnit.Size = new Size(319, 30);
            txtUnit.TabIndex = 33;
            txtUnit.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(11, 115);
            label3.Name = "label3";
            label3.Size = new Size(173, 28);
            label3.TabIndex = 32;
            label3.Text = "Unit:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // ElectricityUtilitySettings
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(522, 252);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Controls.Add(txtUnitPrice);
            Controls.Add(label2);
            Controls.Add(txtUnit);
            Controls.Add(label3);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "ElectricityUtilitySettings";
            Text = "Settings - ELECTRICITY UTILITY";
            FormClosing += ElectricityUtilitySettings_FormClosing;
            Load += ElectricityUtilitySettings_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnSave;
        private TextBox txtUnitPrice;
        private Label label2;
        private TextBox txtUnit;
        private Label label3;
    }
}