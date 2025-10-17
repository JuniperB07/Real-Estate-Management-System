namespace Real_Estate_Management_System.Tenants.Activity
{
    partial class AdvancesCredits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancesCredits));
            panel1 = new Panel();
            rdbAllTime = new RadioButton();
            comboBox1 = new ComboBox();
            label4 = new Label();
            pnlDateRange = new Panel();
            label3 = new Label();
            label2 = new Label();
            dtpDateRange_To = new DateTimePicker();
            dtpDateRange_From = new DateTimePicker();
            rdbDateRange = new RadioButton();
            rdbThisYear = new RadioButton();
            rdbThisMonth = new RadioButton();
            label1 = new Label();
            panel1.SuspendLayout();
            pnlDateRange.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 70, 67);
            panel1.Controls.Add(rdbAllTime);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pnlDateRange);
            panel1.Controls.Add(rdbDateRange);
            panel1.Controls.Add(rdbThisYear);
            panel1.Controls.Add(rdbThisMonth);
            panel1.Controls.Add(label1);
            panel1.ForeColor = Color.FromArgb(240, 237, 229);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(275, 593);
            panel1.TabIndex = 2;
            // 
            // rdbAllTime
            // 
            rdbAllTime.Location = new Point(23, 110);
            rdbAllTime.Name = "rdbAllTime";
            rdbAllTime.Size = new Size(249, 30);
            rdbAllTime.TabIndex = 7;
            rdbAllTime.TabStop = true;
            rdbAllTime.Text = "All Time";
            rdbAllTime.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(240, 237, 229);
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.ForeColor = Color.FromArgb(0, 70, 67);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(101, 272);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(171, 31);
            comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 275);
            label4.Name = "label4";
            label4.Size = new Size(272, 25);
            label4.TabIndex = 5;
            label4.Text = "Sort By:";
            // 
            // pnlDateRange
            // 
            pnlDateRange.Controls.Add(label3);
            pnlDateRange.Controls.Add(label2);
            pnlDateRange.Controls.Add(dtpDateRange_To);
            pnlDateRange.Controls.Add(dtpDateRange_From);
            pnlDateRange.Location = new Point(1, 182);
            pnlDateRange.Name = "pnlDateRange";
            pnlDateRange.Size = new Size(274, 74);
            pnlDateRange.TabIndex = 4;
            // 
            // label3
            // 
            label3.Location = new Point(3, 44);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 3;
            label3.Text = "To:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.Location = new Point(3, 9);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 2;
            label2.Text = "From:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // dtpDateRange_To
            // 
            dtpDateRange_To.CustomFormat = "MMM d, yyyy";
            dtpDateRange_To.Format = DateTimePickerFormat.Custom;
            dtpDateRange_To.Location = new Point(100, 39);
            dtpDateRange_To.Name = "dtpDateRange_To";
            dtpDateRange_To.Size = new Size(171, 30);
            dtpDateRange_To.TabIndex = 1;
            // 
            // dtpDateRange_From
            // 
            dtpDateRange_From.CustomFormat = "MMM d, yyyy";
            dtpDateRange_From.Format = DateTimePickerFormat.Custom;
            dtpDateRange_From.Location = new Point(100, 3);
            dtpDateRange_From.Name = "dtpDateRange_From";
            dtpDateRange_From.Size = new Size(171, 30);
            dtpDateRange_From.TabIndex = 0;
            // 
            // rdbDateRange
            // 
            rdbDateRange.Location = new Point(23, 146);
            rdbDateRange.Name = "rdbDateRange";
            rdbDateRange.Size = new Size(249, 30);
            rdbDateRange.TabIndex = 3;
            rdbDateRange.TabStop = true;
            rdbDateRange.Text = "Date Range";
            rdbDateRange.UseVisualStyleBackColor = true;
            rdbDateRange.CheckedChanged += rdbDateRange_CheckedChanged;
            // 
            // rdbThisYear
            // 
            rdbThisYear.Location = new Point(23, 74);
            rdbThisYear.Name = "rdbThisYear";
            rdbThisYear.Size = new Size(249, 30);
            rdbThisYear.TabIndex = 2;
            rdbThisYear.TabStop = true;
            rdbThisYear.Text = "This Year";
            rdbThisYear.UseVisualStyleBackColor = true;
            // 
            // rdbThisMonth
            // 
            rdbThisMonth.Location = new Point(23, 38);
            rdbThisMonth.Name = "rdbThisMonth";
            rdbThisMonth.Size = new Size(249, 30);
            rdbThisMonth.TabIndex = 1;
            rdbThisMonth.TabStop = true;
            rdbThisMonth.Text = "This Month";
            rdbThisMonth.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 10);
            label1.Name = "label1";
            label1.Size = new Size(272, 25);
            label1.TabIndex = 0;
            label1.Text = "Filter By:";
            // 
            // AdvancesCredits
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(1166, 590);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "AdvancesCredits";
            StartPosition = FormStartPosition.Manual;
            Text = "Advances & Credits";
            FormClosing += AdvancesCredits_FormClosing;
            FormClosed += AdvancesCredits_FormClosed;
            Load += AdvancesCredits_Load;
            Shown += AdvancesCredits_Shown;
            panel1.ResumeLayout(false);
            pnlDateRange.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RadioButton rdbAllTime;
        private ComboBox comboBox1;
        private Label label4;
        private Panel pnlDateRange;
        private Label label3;
        private Label label2;
        private DateTimePicker dtpDateRange_To;
        private DateTimePicker dtpDateRange_From;
        private RadioButton rdbDateRange;
        private RadioButton rdbThisYear;
        private RadioButton rdbThisMonth;
        private Label label1;
    }
}