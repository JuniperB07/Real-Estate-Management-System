namespace Real_Estate_Management_System.Settings.Due_Dates
{
    partial class UtilityDueDateSettings
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
            panel1 = new Panel();
            label1 = new Label();
            label3 = new Label();
            cmbDueDateMode = new ComboBox();
            lblDueDateDay = new Label();
            txtDueDateDay = new TextBox();
            btnSave = new Button();
            btnRestore = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 70, 67);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.FromArgb(240, 237, 229);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(576, 99);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Arial", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 17);
            label1.Name = "label1";
            label1.Size = new Size(551, 64);
            label1.TabIndex = 0;
            label1.Text = "UTILITY DUE DATE SETTINGS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 117);
            label3.Name = "label3";
            label3.Size = new Size(227, 28);
            label3.TabIndex = 34;
            label3.Text = "Due Date Mode:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbDueDateMode
            // 
            cmbDueDateMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDueDateMode.ForeColor = Color.FromArgb(0, 70, 67);
            cmbDueDateMode.FormattingEnabled = true;
            cmbDueDateMode.Location = new Point(245, 114);
            cmbDueDateMode.Name = "cmbDueDateMode";
            cmbDueDateMode.Size = new Size(319, 31);
            cmbDueDateMode.TabIndex = 35;
            cmbDueDateMode.TextChanged += cmbDueDateMode_TextChanged;
            // 
            // lblDueDateDay
            // 
            lblDueDateDay.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblDueDateDay.Location = new Point(12, 164);
            lblDueDateDay.Name = "lblDueDateDay";
            lblDueDateDay.Size = new Size(227, 28);
            lblDueDateDay.TabIndex = 36;
            lblDueDateDay.Text = "Due Date Day:";
            lblDueDateDay.TextAlign = ContentAlignment.TopRight;
            // 
            // txtDueDateDay
            // 
            txtDueDateDay.ForeColor = Color.FromArgb(0, 70, 67);
            txtDueDateDay.Location = new Point(245, 161);
            txtDueDateDay.Name = "txtDueDateDay";
            txtDueDateDay.Size = new Size(92, 30);
            txtDueDateDay.TabIndex = 37;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 67);
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(0, 70, 67);
            btnSave.Location = new Point(337, 212);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(227, 44);
            btnSave.TabIndex = 38;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRestore
            // 
            btnRestore.Anchor = AnchorStyles.Bottom;
            btnRestore.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 67);
            btnRestore.FlatAppearance.BorderSize = 2;
            btnRestore.FlatStyle = FlatStyle.Flat;
            btnRestore.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnRestore.ForeColor = Color.FromArgb(0, 70, 67);
            btnRestore.Location = new Point(12, 212);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(227, 44);
            btnRestore.TabIndex = 39;
            btnRestore.Text = "RESTORE DEFAULTS";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // UtilityDueDateSettings
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(576, 268);
            Controls.Add(btnRestore);
            Controls.Add(btnSave);
            Controls.Add(txtDueDateDay);
            Controls.Add(lblDueDateDay);
            Controls.Add(cmbDueDateMode);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 3, 4, 3);
            Name = "UtilityDueDateSettings";
            Text = "Settings - UTILITY DUE DATE";
            Load += UtilityDueDateSettings_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private ComboBox cmbDueDateMode;
        private Label lblDueDateDay;
        private TextBox txtDueDateDay;
        private Button btnSave;
        private Button btnRestore;
    }
}