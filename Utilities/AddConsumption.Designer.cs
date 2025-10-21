namespace Real_Estate_Management_System.Utilities
{
    partial class AddConsumption
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
            lblYear = new Label();
            cmbMonth = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtWater = new TextBox();
            txtElectricity = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnSave = new Button();
            nudYear = new NumericUpDown();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudYear).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(10, 36, 114);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.FromArgb(255, 186, 8);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(586, 167);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(14, 19);
            label1.Name = "label1";
            label1.Size = new Size(561, 129);
            label1.TabIndex = 6;
            label1.Text = "UTILITIES MANAGER:\r\nADD CONSUMPTION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblYear
            // 
            lblYear.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblYear.Location = new Point(12, 238);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(252, 33);
            lblYear.TabIndex = 6;
            lblYear.Text = "Select Year:";
            lblYear.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbMonth
            // 
            cmbMonth.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMonth.Font = new Font("Arial", 12F);
            cmbMonth.ForeColor = Color.FromArgb(0, 70, 67);
            cmbMonth.FormattingEnabled = true;
            cmbMonth.Location = new Point(270, 281);
            cmbMonth.Name = "cmbMonth";
            cmbMonth.Size = new Size(305, 31);
            cmbMonth.TabIndex = 9;
            cmbMonth.TextChanged += cmbMonth_TextChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.Location = new Point(12, 283);
            label2.Name = "label2";
            label2.Size = new Size(252, 33);
            label2.TabIndex = 8;
            label2.Text = "Select Month:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 328);
            label3.Name = "label3";
            label3.Size = new Size(252, 33);
            label3.TabIndex = 10;
            label3.Text = "Water Consumption:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // txtWater
            // 
            txtWater.Font = new Font("Arial", 12F);
            txtWater.ForeColor = Color.FromArgb(0, 70, 67);
            txtWater.Location = new Point(270, 326);
            txtWater.Name = "txtWater";
            txtWater.Size = new Size(305, 30);
            txtWater.TabIndex = 11;
            txtWater.TextAlign = HorizontalAlignment.Center;
            txtWater.TextChanged += txtWater_TextChanged;
            // 
            // txtElectricity
            // 
            txtElectricity.Font = new Font("Arial", 12F);
            txtElectricity.ForeColor = Color.FromArgb(0, 70, 67);
            txtElectricity.Location = new Point(270, 371);
            txtElectricity.Name = "txtElectricity";
            txtElectricity.Size = new Size(305, 30);
            txtElectricity.TabIndex = 13;
            txtElectricity.TextAlign = HorizontalAlignment.Center;
            txtElectricity.TextChanged += txtElectricity_TextChanged;
            // 
            // label4
            // 
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 373);
            label4.Name = "label4";
            label4.Size = new Size(252, 33);
            label4.TabIndex = 12;
            label4.Text = "Electricity Consumption:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 12F);
            label5.Location = new Point(12, 170);
            label5.Name = "label5";
            label5.Size = new Size(563, 27);
            label5.TabIndex = 14;
            label5.Text = "Add new utility consumption for the building:";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Arial", 12F);
            label6.Location = new Point(12, 200);
            label6.Name = "label6";
            label6.Size = new Size(563, 27);
            label6.TabIndex = 15;
            label6.Text = "BUILDING NAME";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 67);
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(0, 70, 67);
            btnSave.Location = new Point(187, 452);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 44);
            btnSave.TabIndex = 29;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // nudYear
            // 
            nudYear.BorderStyle = BorderStyle.FixedSingle;
            nudYear.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nudYear.ForeColor = Color.FromArgb(0, 70, 67);
            nudYear.Location = new Point(271, 236);
            nudYear.Margin = new Padding(4);
            nudYear.Maximum = new decimal(new int[] { 2025, 0, 0, 0 });
            nudYear.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudYear.Name = "nudYear";
            nudYear.Size = new Size(304, 30);
            nudYear.TabIndex = 30;
            nudYear.TextAlign = HorizontalAlignment.Center;
            nudYear.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            nudYear.ValueChanged += nudYear_ValueChanged;
            // 
            // label7
            // 
            label7.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(12, 406);
            label7.Name = "label7";
            label7.Size = new Size(563, 27);
            label7.TabIndex = 31;
            label7.Text = "*Added consumption records cannot be edited once saved.";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // AddConsumption
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(587, 508);
            Controls.Add(label7);
            Controls.Add(nudYear);
            Controls.Add(btnSave);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtElectricity);
            Controls.Add(label4);
            Controls.Add(txtWater);
            Controls.Add(label3);
            Controls.Add(cmbMonth);
            Controls.Add(label2);
            Controls.Add(lblYear);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "AddConsumption";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Utilities Manager - Add Consumption";
            Load += AddConsumption_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label lblYear;
        private ComboBox cmbMonth;
        private Label label2;
        private Label label3;
        private TextBox txtWater;
        private TextBox txtElectricity;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnSave;
        private NumericUpDown nudYear;
        private Label label7;
    }
}