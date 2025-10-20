namespace Real_Estate_Management_System.Tenants.Edit
{
    partial class EditTenancy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTenancy));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            comboBox3 = new ComboBox();
            label5 = new Label();
            comboBox4 = new ComboBox();
            label6 = new Label();
            button3 = new Button();
            cmbBuilding = new ComboBox();
            label7 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(100, 59, 159);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 167);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(157, 3);
            label1.Name = "label1";
            label1.Size = new Size(592, 161);
            label1.TabIndex = 4;
            label1.Text = "TENANT MANAGEMENT\r\nEDIT\r\nTENANCY INFORMATION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.REMS_TENANTS_EDIT_TENANCY_INFO1;
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(0, 70, 67);
            label8.Location = new Point(12, 185);
            label8.Name = "label8";
            label8.Size = new Size(376, 27);
            label8.TabIndex = 19;
            label8.Text = "Room Type:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.ForeColor = Color.FromArgb(0, 70, 67);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(394, 182);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(344, 31);
            comboBox1.TabIndex = 20;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 70, 67);
            label2.Location = new Point(12, 227);
            label2.Name = "label2";
            label2.Size = new Size(376, 27);
            label2.TabIndex = 21;
            label2.Text = "Tenancy Start Date:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MMMM d, yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(394, 224);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(344, 30);
            dateTimePicker1.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "MMMM d, yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(394, 265);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(344, 30);
            dateTimePicker2.TabIndex = 24;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 70, 67);
            label3.Location = new Point(12, 268);
            label3.Name = "label3";
            label3.Size = new Size(376, 27);
            label3.TabIndex = 23;
            label3.Text = "Tenancy End Date:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.ForeColor = Color.FromArgb(0, 70, 67);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(394, 348);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(344, 31);
            comboBox2.TabIndex = 26;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 70, 67);
            label4.Location = new Point(12, 351);
            label4.Name = "label4";
            label4.Size = new Size(376, 27);
            label4.TabIndex = 25;
            label4.Text = "Room #:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.ForeColor = Color.FromArgb(0, 70, 67);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(394, 390);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(344, 31);
            comboBox3.TabIndex = 28;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 70, 67);
            label5.Location = new Point(12, 393);
            label5.Name = "label5";
            label5.Size = new Size(376, 27);
            label5.TabIndex = 27;
            label5.Text = "Internet Subscription Plan:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.ForeColor = Color.FromArgb(0, 70, 67);
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(394, 432);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(344, 31);
            comboBox4.TabIndex = 30;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 70, 67);
            label6.Location = new Point(12, 435);
            label6.Name = "label6";
            label6.Size = new Size(376, 27);
            label6.TabIndex = 29;
            label6.Text = "Tenancy Status:";
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
            button3.Location = new Point(274, 489);
            button3.Name = "button3";
            button3.Size = new Size(203, 44);
            button3.TabIndex = 32;
            button3.Text = "SAVE CHANGES";
            button3.UseVisualStyleBackColor = true;
            // 
            // cmbBuilding
            // 
            cmbBuilding.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuilding.ForeColor = Color.FromArgb(0, 70, 67);
            cmbBuilding.FormattingEnabled = true;
            cmbBuilding.Location = new Point(394, 306);
            cmbBuilding.Name = "cmbBuilding";
            cmbBuilding.Size = new Size(344, 31);
            cmbBuilding.TabIndex = 39;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 70, 67);
            label7.Location = new Point(103, 309);
            label7.Name = "label7";
            label7.Size = new Size(285, 27);
            label7.TabIndex = 38;
            label7.Text = "Building Name:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // EditTenancy
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(750, 545);
            Controls.Add(cmbBuilding);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(comboBox4);
            Controls.Add(label6);
            Controls.Add(comboBox3);
            Controls.Add(label5);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
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
            Name = "EditTenancy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditTenancy";
            Load += EditTenancy_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label8;
        private ComboBox comboBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private ComboBox comboBox3;
        private Label label5;
        private ComboBox comboBox4;
        private Label label6;
        private Button button3;
        private ComboBox cmbBuilding;
        private Label label7;
    }
}