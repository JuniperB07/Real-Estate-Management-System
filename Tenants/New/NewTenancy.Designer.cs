namespace Real_Estate_Management_System.Tenants.New
{
    partial class NewTenancy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTenancy));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label2 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox3 = new ComboBox();
            label5 = new Label();
            comboBox4 = new ComboBox();
            label6 = new Label();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(100, 59, 159);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(661, 167);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(158, 6);
            label1.Name = "label1";
            label1.Size = new Size(500, 161);
            label1.TabIndex = 5;
            label1.Text = "NEW TENANT:\r\nTENANCY INFORMATION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.REMS_TENANTS_NEW_TENANCY_INFO;
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.ForeColor = Color.FromArgb(0, 70, 67);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(304, 182);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(344, 31);
            comboBox1.TabIndex = 22;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(0, 70, 67);
            label8.Location = new Point(13, 185);
            label8.Name = "label8";
            label8.Size = new Size(285, 27);
            label8.TabIndex = 21;
            label8.Text = "Room Type:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 70, 67);
            label2.Location = new Point(13, 232);
            label2.Name = "label2";
            label2.Size = new Size(285, 27);
            label2.TabIndex = 23;
            label2.Text = "Tenancy Start Date:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 70, 67);
            label3.Location = new Point(13, 279);
            label3.Name = "label3";
            label3.Size = new Size(285, 27);
            label3.TabIndex = 25;
            label3.Text = "Tenancy End Date:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MMMM d, yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(304, 226);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(344, 30);
            dateTimePicker1.TabIndex = 27;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "MMMM d, yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(304, 273);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(344, 30);
            dateTimePicker2.TabIndex = 28;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.ForeColor = Color.FromArgb(0, 70, 67);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(304, 319);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(344, 31);
            comboBox2.TabIndex = 30;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 70, 67);
            label4.Location = new Point(13, 322);
            label4.Name = "label4";
            label4.Size = new Size(285, 27);
            label4.TabIndex = 29;
            label4.Text = "Room #:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.ForeColor = Color.FromArgb(0, 70, 67);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(304, 366);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(344, 31);
            comboBox3.TabIndex = 32;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 70, 67);
            label5.Location = new Point(13, 369);
            label5.Name = "label5";
            label5.Size = new Size(285, 27);
            label5.TabIndex = 31;
            label5.Text = "Internet Subscription Plan:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.ForeColor = Color.FromArgb(0, 70, 67);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(304, 413);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(344, 31);
            comboBox4.TabIndex = 34;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 70, 67);
            label6.Location = new Point(13, 416);
            label6.Name = "label6";
            label6.Size = new Size(285, 27);
            label6.TabIndex = 33;
            label6.Text = "Status:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Bottom;
            button3.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 67);
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.FromArgb(0, 70, 67);
            button3.Location = new Point(225, 466);
            button3.Name = "button3";
            button3.Size = new Size(203, 44);
            button3.TabIndex = 35;
            button3.Text = "SAVE CHANGES";
            button3.UseVisualStyleBackColor = true;
            // 
            // NewTenancy
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(660, 522);
            Controls.Add(button3);
            Controls.Add(comboBox4);
            Controls.Add(label6);
            Controls.Add(comboBox3);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "NewTenancy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Real Estate Management System - New Tenant: Tenancy Information";
            Load += NewTenancy_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label8;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox3;
        private Label label5;
        private ComboBox comboBox4;
        private Label label6;
        private Button button3;
    }
}