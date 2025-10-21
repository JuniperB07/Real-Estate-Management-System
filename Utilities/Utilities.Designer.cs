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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Utilities));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            lstBuildingsList = new ListBox();
            label2 = new Label();
            panel3 = new Panel();
            btnAddConsumption = new Button();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            chrtUtilitiesGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chrtUtilitiesGraph).BeginInit();
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
            panel2.BackColor = Color.FromArgb(10, 36, 114);
            panel2.Controls.Add(lstBuildingsList);
            panel2.Controls.Add(label2);
            panel2.ForeColor = Color.FromArgb(255, 186, 8);
            panel2.Location = new Point(0, 167);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 562);
            panel2.TabIndex = 1;
            // 
            // lstBuildingsList
            // 
            lstBuildingsList.BackColor = Color.FromArgb(10, 36, 114);
            lstBuildingsList.BorderStyle = BorderStyle.None;
            lstBuildingsList.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstBuildingsList.ForeColor = Color.FromArgb(255, 186, 8);
            lstBuildingsList.FormattingEnabled = true;
            lstBuildingsList.ItemHeight = 26;
            lstBuildingsList.Location = new Point(28, 39);
            lstBuildingsList.Name = "lstBuildingsList";
            lstBuildingsList.Size = new Size(265, 494);
            lstBuildingsList.TabIndex = 1;
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
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 186, 8);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btnAddConsumption);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.ForeColor = Color.FromArgb(10, 36, 114);
            panel3.Location = new Point(296, 166);
            panel3.Name = "panel3";
            panel3.Size = new Size(922, 181);
            panel3.TabIndex = 2;
            // 
            // btnAddConsumption
            // 
            btnAddConsumption.FlatAppearance.BorderSize = 2;
            btnAddConsumption.FlatStyle = FlatStyle.Flat;
            btnAddConsumption.Font = new Font("Arial", 12F, FontStyle.Bold);
            btnAddConsumption.Location = new Point(715, 133);
            btnAddConsumption.Name = "btnAddConsumption";
            btnAddConsumption.Size = new Size(204, 45);
            btnAddConsumption.TabIndex = 12;
            btnAddConsumption.Text = "Add Consumption";
            btnAddConsumption.UseVisualStyleBackColor = true;
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
            // label11
            // 
            label11.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(451, 133);
            label11.Name = "label11";
            label11.Size = new Size(156, 29);
            label11.TabIndex = 10;
            label11.Text = "kWh";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(215, 133);
            label12.Name = "label12";
            label12.Size = new Size(146, 29);
            label12.TabIndex = 9;
            label12.Text = "0.00";
            label12.TextAlign = ContentAlignment.TopCenter;
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
            // label8
            // 
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(451, 99);
            label8.Name = "label8";
            label8.Size = new Size(156, 29);
            label8.TabIndex = 6;
            label8.Text = "m^3";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(215, 99);
            label7.Name = "label7";
            label7.Size = new Size(146, 29);
            label7.TabIndex = 5;
            label7.Text = "0.00";
            label7.TextAlign = ContentAlignment.TopCenter;
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
            // chrtUtilitiesGraph
            // 
            chrtUtilitiesGraph.BackColor = Color.FromArgb(240, 237, 229);
            chartArea1.Name = "chrt_arConsumptionGraph";
            chrtUtilitiesGraph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chrtUtilitiesGraph.Legends.Add(legend1);
            chrtUtilitiesGraph.Location = new Point(302, 353);
            chrtUtilitiesGraph.Name = "chrtUtilitiesGraph";
            chrtUtilitiesGraph.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            chrtUtilitiesGraph.PaletteCustomColors = new Color[]
    {
    Color.FromArgb(10, 36, 114),
    Color.FromArgb(255, 186, 8)
    };
            series1.ChartArea = "chrt_arConsumptionGraph";
            series1.Legend = "Legend1";
            series1.Name = "Water";
            series2.ChartArea = "chrt_arConsumptionGraph";
            series2.Legend = "Legend1";
            series2.Name = "Electricity";
            chrtUtilitiesGraph.Series.Add(series1);
            chrtUtilitiesGraph.Series.Add(series2);
            chrtUtilitiesGraph.Size = new Size(913, 361);
            chrtUtilitiesGraph.TabIndex = 3;
            chrtUtilitiesGraph.Text = "Utilities Graph";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 12F, FontStyle.Bold);
            button1.Location = new Point(715, 77);
            button1.Name = "button1";
            button1.Size = new Size(204, 45);
            button1.TabIndex = 13;
            button1.Text = "Edit Charges";
            button1.UseVisualStyleBackColor = true;
            // 
            // Utilities
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(1218, 726);
            Controls.Add(chrtUtilitiesGraph);
            Controls.Add(panel3);
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
            Load += Utilities_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chrtUtilitiesGraph).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private ListBox lstBuildingsList;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrtUtilitiesGraph;
        private Button btnAddElectricityConsumption;
        private Button btnAddConsumption;
        private Button button1;
    }
}