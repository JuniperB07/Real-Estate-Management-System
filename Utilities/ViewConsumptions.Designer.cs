namespace Real_Estate_Management_System.Utilities
{
    partial class ViewConsumptions
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            panel1 = new Panel();
            label1 = new Label();
            dgvWater = new DataGridView();
            lblTitle = new Label();
            chrtWater = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chrtElectricity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dgvElectricity = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvWater).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chrtWater).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chrtElectricity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvElectricity).BeginInit();
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
            panel1.Size = new Size(1105, 167);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(14, 21);
            label1.Name = "label1";
            label1.Size = new Size(1078, 125);
            label1.TabIndex = 5;
            label1.Text = "UTILITIES MANAGER:\r\nVIEW CONSUMPTION RECORDS";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvWater
            // 
            dgvWater.AllowUserToAddRows = false;
            dgvWater.AllowUserToDeleteRows = false;
            dgvWater.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWater.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvWater.BackgroundColor = Color.FromArgb(240, 237, 229);
            dgvWater.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWater.GridColor = Color.FromArgb(240, 237, 229);
            dgvWater.Location = new Point(12, 214);
            dgvWater.Name = "dgvWater";
            dgvWater.ReadOnly = true;
            dgvWater.RowHeadersVisible = false;
            dgvWater.RowHeadersWidth = 51;
            dgvWater.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWater.Size = new Size(515, 269);
            dgvWater.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(0, 70, 67);
            lblTitle.Location = new Point(12, 170);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1078, 41);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "Consumption Record for the Year";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // chrtWater
            // 
            chrtWater.BackColor = Color.FromArgb(240, 237, 229);
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = -45;
            chartArea1.BackColor = Color.FromArgb(240, 237, 229);
            chartArea1.Name = "ChartArea1";
            chrtWater.ChartAreas.Add(chartArea1);
            chrtWater.Location = new Point(533, 214);
            chrtWater.Name = "chrtWater";
            chrtWater.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chrtWater.PaletteCustomColors = new Color[]
    {
    Color.FromArgb(10, 36, 114)
    };
            series1.ChartArea = "ChartArea1";
            series1.Name = "Water";
            series1.YValuesPerPoint = 2;
            chrtWater.Series.Add(series1);
            chrtWater.Size = new Size(557, 269);
            chrtWater.TabIndex = 3;
            chrtWater.Text = "chart1";
            title1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.ForeColor = Color.FromArgb(0, 70, 67);
            title1.Name = "Title1";
            chrtWater.Titles.Add(title1);
            // 
            // chrtElectricity
            // 
            chrtElectricity.BackColor = Color.FromArgb(240, 237, 229);
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Angle = -45;
            chartArea2.BackColor = Color.FromArgb(240, 237, 229);
            chartArea2.Name = "ChartArea1";
            chrtElectricity.ChartAreas.Add(chartArea2);
            chrtElectricity.Location = new Point(533, 489);
            chrtElectricity.Name = "chrtElectricity";
            chrtElectricity.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chrtElectricity.PaletteCustomColors = new Color[]
    {
    Color.FromArgb(255, 186, 8)
    };
            series2.ChartArea = "ChartArea1";
            series2.Name = "Electricity";
            series2.YValuesPerPoint = 2;
            chrtElectricity.Series.Add(series2);
            chrtElectricity.Size = new Size(557, 269);
            chrtElectricity.TabIndex = 8;
            chrtElectricity.Text = "chart1";
            title2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title2.ForeColor = Color.FromArgb(0, 70, 67);
            title2.Name = "Title1";
            chrtElectricity.Titles.Add(title2);
            // 
            // dgvElectricity
            // 
            dgvElectricity.AllowUserToAddRows = false;
            dgvElectricity.AllowUserToDeleteRows = false;
            dgvElectricity.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvElectricity.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvElectricity.BackgroundColor = Color.FromArgb(240, 237, 229);
            dgvElectricity.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvElectricity.GridColor = Color.FromArgb(240, 237, 229);
            dgvElectricity.Location = new Point(12, 489);
            dgvElectricity.Name = "dgvElectricity";
            dgvElectricity.ReadOnly = true;
            dgvElectricity.RowHeadersVisible = false;
            dgvElectricity.RowHeadersWidth = 51;
            dgvElectricity.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvElectricity.Size = new Size(515, 269);
            dgvElectricity.TabIndex = 7;
            // 
            // ViewConsumptions
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(1102, 773);
            Controls.Add(chrtElectricity);
            Controls.Add(dgvElectricity);
            Controls.Add(lblTitle);
            Controls.Add(chrtWater);
            Controls.Add(dgvWater);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "ViewConsumptions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Utilities Manager - View Consumption Records";
            Load += ViewConsumptions_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvWater).EndInit();
            ((System.ComponentModel.ISupportInitialize)chrtWater).EndInit();
            ((System.ComponentModel.ISupportInitialize)chrtElectricity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvElectricity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dgvWater;
        private Label lblTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtWater;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtElectricity;
        private DataGridView dgvElectricity;
    }
}