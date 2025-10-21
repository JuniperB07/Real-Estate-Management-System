namespace Real_Estate_Management_System.Utilities
{
    partial class EditCharges
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCharges));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            txtWaterCharge = new TextBox();
            label3 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            txtElectricityCharge = new TextBox();
            label4 = new Label();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            btnSave = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Size = new Size(606, 167);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(14, 19);
            label1.Name = "label1";
            label1.Size = new Size(579, 129);
            label1.TabIndex = 6;
            label1.Text = "UTILITIES MANAGER:\r\nEDIT CHARGES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtWaterCharge);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 173);
            panel2.Name = "panel2";
            panel2.Size = new Size(606, 95);
            panel2.TabIndex = 1;
            // 
            // txtWaterCharge
            // 
            txtWaterCharge.ForeColor = Color.FromArgb(0, 70, 67);
            txtWaterCharge.Location = new Point(299, 45);
            txtWaterCharge.Name = "txtWaterCharge";
            txtWaterCharge.Size = new Size(292, 30);
            txtWaterCharge.TabIndex = 23;
            txtWaterCharge.TextChanged += txtWaterCharge_TextChanged;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 70, 67);
            label3.Location = new Point(105, 46);
            label3.Name = "label3";
            label3.Size = new Size(188, 29);
            label3.TabIndex = 22;
            label3.Text = "Charge/Unit:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 70, 67);
            label8.Location = new Point(105, 3);
            label8.Name = "label8";
            label8.Size = new Size(391, 33);
            label8.TabIndex = 20;
            label8.Text = "Water Consumption Charge/Unit:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.REMS_UTILITIES_WATER;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtElectricityCharge);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(0, 281);
            panel3.Name = "panel3";
            panel3.Size = new Size(606, 96);
            panel3.TabIndex = 2;
            // 
            // txtElectricityCharge
            // 
            txtElectricityCharge.ForeColor = Color.FromArgb(0, 70, 67);
            txtElectricityCharge.Location = new Point(299, 46);
            txtElectricityCharge.Name = "txtElectricityCharge";
            txtElectricityCharge.Size = new Size(292, 30);
            txtElectricityCharge.TabIndex = 24;
            txtElectricityCharge.TextChanged += txtElectricityCharge_TextChanged;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 70, 67);
            label4.Location = new Point(105, 46);
            label4.Name = "label4";
            label4.Size = new Size(188, 29);
            label4.TabIndex = 23;
            label4.Text = "Charge/Unit:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 70, 67);
            label2.Location = new Point(105, 3);
            label2.Name = "label2";
            label2.Size = new Size(472, 33);
            label2.TabIndex = 21;
            label2.Text = "Electricity Consumption Charge per Unit:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.REMS_UTILITIES_ELECTRICITY;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(96, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 67);
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(0, 70, 67);
            btnSave.Location = new Point(197, 399);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 44);
            btnSave.TabIndex = 28;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EditCharges
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(603, 455);
            Controls.Add(btnSave);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "EditCharges";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Utilities Manager - Edit Charges";
            Load += EditCharges_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Button btnSave;
        private Label label8;
        private Label label2;
        private TextBox txtWaterCharge;
        private Label label3;
        private TextBox txtElectricityCharge;
        private Label label4;
    }
}