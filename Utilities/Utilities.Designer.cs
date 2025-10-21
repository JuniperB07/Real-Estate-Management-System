namespace Real_Estate_Management_System.Utilities
{
    partial class Utilities
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Utilities));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lstBuildingsList = new ListBox();
            label2 = new Label();
            pnlUtilitiesInformation = new Panel();
            btnReset = new Button();
            btnEditCharges = new Button();
            btnAddConsumption = new Button();
            label10 = new Label();
            lblElectricityUnit = new Label();
            lblElectricityCharge = new Label();
            label13 = new Label();
            label9 = new Label();
            lblWaterUnit = new Label();
            lblWaterCharge = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            chrtUtilitiesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lblYear = new Label();
            cmbYear = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            pnlUtilitiesInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chrtUtilitiesChart).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 70, 67);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = Color.FromArgb(240, 237, 229);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1218, 167);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(156, 0);
            label1.Name = "label1";
            label1.Size = new Size(1059, 161);
            label1.TabIndex = 5;
            label1.Text = "REAL ESTATE MANAGEMENT SYSTEM\r\nUTILITIES MANAGER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.REMS_UTILITIES_LIGHT;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(10, 36, 114);
            panel2.Controls.Add(lstBuildingsList);
            panel2.Controls.Add(label2);
            panel2.ForeColor = Color.FromArgb(255, 186, 8);
            panel2.Location = new Point(0, 167);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 635);
            panel2.TabIndex = 1;
            // 
            // lstBuildingsList
            // 
            lstBuildingsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstBuildingsList.BackColor = Color.FromArgb(10, 36, 114);
            lstBuildingsList.BorderStyle = BorderStyle.None;
            lstBuildingsList.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstBuildingsList.ForeColor = Color.FromArgb(255, 186, 8);
            lstBuildingsList.FormattingEnabled = true;
            lstBuildingsList.ItemHeight = 26;
            lstBuildingsList.Location = new Point(28, 46);
            lstBuildingsList.Name = "lstBuildingsList";
            lstBuildingsList.Size = new Size(262, 546);
            lstBuildingsList.TabIndex = 1;
            lstBuildingsList.MouseDoubleClick += lstBuildingsList_MouseDoubleClick;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(214, 33);
            label2.TabIndex = 0;
            label2.Text = "Select Building:";
            // 
            // pnlUtilitiesInformation
            // 
            pnlUtilitiesInformation.BackColor = Color.FromArgb(255, 186, 8);
            pnlUtilitiesInformation.Controls.Add(btnReset);
            pnlUtilitiesInformation.Controls.Add(btnEditCharges);
            pnlUtilitiesInformation.Controls.Add(btnAddConsumption);
            pnlUtilitiesInformation.Controls.Add(label10);
            pnlUtilitiesInformation.Controls.Add(lblElectricityUnit);
            pnlUtilitiesInformation.Controls.Add(lblElectricityCharge);
            pnlUtilitiesInformation.Controls.Add(label13);
            pnlUtilitiesInformation.Controls.Add(label9);
            pnlUtilitiesInformation.Controls.Add(lblWaterUnit);
            pnlUtilitiesInformation.Controls.Add(lblWaterCharge);
            pnlUtilitiesInformation.Controls.Add(label6);
            pnlUtilitiesInformation.Controls.Add(label5);
            pnlUtilitiesInformation.Controls.Add(label4);
            pnlUtilitiesInformation.Controls.Add(label3);
            pnlUtilitiesInformation.ForeColor = Color.FromArgb(10, 36, 114);
            pnlUtilitiesInformation.Location = new Point(296, 166);
            pnlUtilitiesInformation.Name = "pnlUtilitiesInformation";
            pnlUtilitiesInformation.Size = new Size(922, 181);
            pnlUtilitiesInformation.TabIndex = 2;
            // 
            // btnReset
            // 
            btnReset.FlatAppearance.BorderSize = 2;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnReset.Location = new Point(706, 133);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(204, 45);
            btnReset.TabIndex = 14;
            btnReset.Text = "Reset Form";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btnEditCharges
            // 
            btnEditCharges.FlatAppearance.BorderSize = 2;
            btnEditCharges.FlatStyle = FlatStyle.Flat;
            btnEditCharges.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnEditCharges.Location = new Point(706, 7);
            btnEditCharges.Name = "btnEditCharges";
            btnEditCharges.Size = new Size(204, 45);
            btnEditCharges.TabIndex = 13;
            btnEditCharges.Text = "Edit Charges";
            btnEditCharges.UseVisualStyleBackColor = true;
            btnEditCharges.Click += btnEditCharges_Click;
            // 
            // btnAddConsumption
            // 
            btnAddConsumption.FlatAppearance.BorderSize = 2;
            btnAddConsumption.FlatStyle = FlatStyle.Flat;
            btnAddConsumption.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAddConsumption.Location = new Point(706, 63);
            btnAddConsumption.Name = "btnAddConsumption";
            btnAddConsumption.Size = new Size(204, 45);
            btnAddConsumption.TabIndex = 12;
            btnAddConsumption.Text = "Add Consumption";
            btnAddConsumption.UseVisualStyleBackColor = true;
            btnAddConsumption.Click += btnAddConsumption_Click;
            // 
            // label10
            // 
            label10.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(367, 133);
            label10.Name = "label10";
            label10.Size = new Size(78, 29);
            label10.TabIndex = 11;
            label10.Text = "per";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblElectricityUnit
            // 
            lblElectricityUnit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblElectricityUnit.Location = new Point(451, 133);
            lblElectricityUnit.Name = "lblElectricityUnit";
            lblElectricityUnit.Size = new Size(156, 29);
            lblElectricityUnit.TabIndex = 10;
            lblElectricityUnit.Text = "kWh";
            lblElectricityUnit.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblElectricityCharge
            // 
            lblElectricityCharge.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblElectricityCharge.Location = new Point(215, 133);
            lblElectricityCharge.Name = "lblElectricityCharge";
            lblElectricityCharge.Size = new Size(146, 29);
            lblElectricityCharge.TabIndex = 9;
            lblElectricityCharge.Text = "0.00";
            lblElectricityCharge.TextAlign = ContentAlignment.TopCenter;
            // 
            // label13
            // 
            label13.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(30, 133);
            label13.Name = "label13";
            label13.Size = new Size(179, 29);
            label13.TabIndex = 8;
            label13.Text = "Electric Utility:";
            label13.TextAlign = ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(367, 99);
            label9.Name = "label9";
            label9.Size = new Size(78, 29);
            label9.TabIndex = 7;
            label9.Text = "per";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblWaterUnit
            // 
            lblWaterUnit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWaterUnit.Location = new Point(451, 99);
            lblWaterUnit.Name = "lblWaterUnit";
            lblWaterUnit.Size = new Size(156, 29);
            lblWaterUnit.TabIndex = 6;
            lblWaterUnit.Text = "m^3";
            lblWaterUnit.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblWaterCharge
            // 
            lblWaterCharge.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWaterCharge.Location = new Point(215, 99);
            lblWaterCharge.Name = "lblWaterCharge";
            lblWaterCharge.Size = new Size(146, 29);
            lblWaterCharge.TabIndex = 5;
            lblWaterCharge.Text = "0.00";
            lblWaterCharge.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(30, 99);
            label6.Name = "label6";
            label6.Size = new Size(179, 29);
            label6.TabIndex = 4;
            label6.Text = "Water Utility:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(451, 61);
            label5.Name = "label5";
            label5.Size = new Size(156, 33);
            label5.TabIndex = 3;
            label5.Text = "Utility Unit";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(215, 61);
            label4.Name = "label4";
            label4.Size = new Size(146, 33);
            label4.TabIndex = 2;
            label4.Text = "Charge";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 26F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 4);
            label3.Name = "label3";
            label3.Size = new Size(574, 57);
            label3.TabIndex = 1;
            label3.Text = "UTILITIES INFORMATION:";
            // 
            // chrtUtilitiesChart
            // 
            chrtUtilitiesChart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            chrtUtilitiesChart.BackColor = Color.FromArgb(240, 237, 229);
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = -45;
            chartArea1.Name = "ChartArea1";
            chrtUtilitiesChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chrtUtilitiesChart.Legends.Add(legend1);
            chrtUtilitiesChart.Location = new Point(302, 397);
            chrtUtilitiesChart.Name = "chrtUtilitiesChart";
            chrtUtilitiesChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chrtUtilitiesChart.PaletteCustomColors = new Color[]
    {
    Color.FromArgb(10, 36, 114),
    Color.FromArgb(255, 186, 8)
    };
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Water";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Electricity";
            chrtUtilitiesChart.Series.Add(series1);
            chrtUtilitiesChart.Series.Add(series2);
            chrtUtilitiesChart.Size = new Size(904, 390);
            chrtUtilitiesChart.TabIndex = 3;
            chrtUtilitiesChart.Text = "chart1";
            title1.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title1.ForeColor = Color.FromArgb(0, 70, 67);
            title1.Name = "Title1";
            title1.Text = "Utility Consumption Graph for the Current Year";
            chrtUtilitiesChart.Titles.Add(title1);
            // 
            // lblYear
            // 
            lblYear.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYear.Location = new Point(302, 359);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(203, 33);
            lblYear.TabIndex = 4;
            lblYear.Text = "Select Year:";
            lblYear.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbYear
            // 
            cmbYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbYear.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbYear.ForeColor = Color.FromArgb(0, 70, 67);
            cmbYear.FormattingEnabled = true;
            cmbYear.Location = new Point(511, 357);
            cmbYear.Name = "cmbYear";
            cmbYear.Size = new Size(146, 34);
            cmbYear.TabIndex = 5;
            cmbYear.TextChanged += cmbYear_TextChanged;
            // 
            // Utilities
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(1218, 799);
            Controls.Add(cmbYear);
            Controls.Add(lblYear);
            Controls.Add(chrtUtilitiesChart);
            Controls.Add(pnlUtilitiesInformation);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Utilities";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Real Estate Management System - Utilities";
            FormClosing += Utilities_FormClosing;
            Load += Utilities_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            pnlUtilitiesInformation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chrtUtilitiesChart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private ListBox lstBuildingsList;
        private Label label2;
        private Panel pnlUtilitiesInformation;
        private Label label3;
        private Label label10;
        private Label lblElectricityUnit;
        private Label lblElectricityCharge;
        private Label label13;
        private Label label9;
        private Label lblWaterUnit;
        private Label lblWaterCharge;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnAddElectricityConsumption;
        private Button btnAddConsumption;
        private Button btnEditCharges;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtUtilitiesChart;
        private Button btnReset;
        private Label lblYear;
        private ComboBox cmbYear;
    }
}