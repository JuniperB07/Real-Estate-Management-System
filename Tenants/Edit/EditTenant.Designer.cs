namespace Real_Estate_Management_System.Tenants
{
    partial class EditTenant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditTenant));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pcbIDPhoto = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            label8 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            btnTenant_Edit = new Button();
            pictureBox5 = new PictureBox();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbIDPhoto).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 38, 77);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 167);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(158, 6);
            label1.Name = "label1";
            label1.Size = new Size(686, 161);
            label1.TabIndex = 4;
            label1.Text = "TENANT MANAGEMENT\r\nEDIT/VIEW TENANT INFORMATION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.REMS_TENANTS_EDIT_TENANT_INFO1;
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pcbIDPhoto
            // 
            pcbIDPhoto.Image = Properties.Resources.REMS_TENANTS_DEFAULT_ID;
            pcbIDPhoto.Location = new Point(12, 169);
            pcbIDPhoto.Name = "pcbIDPhoto";
            pcbIDPhoto.Size = new Size(288, 199);
            pcbIDPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pcbIDPhoto.TabIndex = 1;
            pcbIDPhoto.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(306, 169);
            label2.Name = "label2";
            label2.Size = new Size(193, 32);
            label2.TabIndex = 2;
            label2.Text = "Tenant Name:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Arial", 13.8F);
            textBox1.ForeColor = Color.FromArgb(0, 70, 67);
            textBox1.Location = new Point(306, 204);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 34);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Arial", 13.8F);
            textBox2.ForeColor = Color.FromArgb(0, 70, 67);
            textBox2.Location = new Point(573, 204);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 34);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(306, 241);
            label3.Name = "label3";
            label3.Size = new Size(260, 23);
            label3.TabIndex = 5;
            label3.Text = "(First Name)";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(573, 241);
            label4.Name = "label4";
            label4.Size = new Size(260, 23);
            label4.TabIndex = 6;
            label4.Text = "(Last Name)";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 70, 67);
            label5.Location = new Point(306, 287);
            label5.Name = "label5";
            label5.Size = new Size(193, 27);
            label5.TabIndex = 9;
            label5.Text = "Date of Birth:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "MMMM d, yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(505, 281);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(328, 30);
            dateTimePicker1.TabIndex = 10;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 70, 67);
            label6.Location = new Point(306, 331);
            label6.Name = "label6";
            label6.Size = new Size(193, 27);
            label6.TabIndex = 11;
            label6.Text = "Phone/Email:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.FromArgb(0, 70, 67);
            textBox3.Location = new Point(505, 329);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(328, 30);
            textBox3.TabIndex = 12;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 70, 67);
            label7.Location = new Point(12, 381);
            label7.Name = "label7";
            label7.Size = new Size(193, 27);
            label7.TabIndex = 13;
            label7.Text = "Valid ID:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(211, 378);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(328, 31);
            comboBox1.TabIndex = 14;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.White;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.FromArgb(0, 70, 67);
            textBox4.Location = new Point(211, 415);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(328, 30);
            textBox4.TabIndex = 16;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(0, 70, 67);
            label8.Location = new Point(12, 417);
            label8.Name = "label8";
            label8.Size = new Size(193, 27);
            label8.TabIndex = 15;
            label8.Text = "ID Number:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnTenant_Edit);
            panel2.Controls.Add(pictureBox5);
            panel2.Location = new Point(545, 378);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 50);
            panel2.TabIndex = 18;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 70, 67);
            button1.Location = new Point(72, 3);
            button1.Name = "button1";
            button1.Size = new Size(213, 44);
            button1.TabIndex = 2;
            button1.Text = "UPLOAD ID";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            // 
            // btnTenant_Edit
            // 
            btnTenant_Edit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnTenant_Edit.FlatAppearance.BorderSize = 0;
            btnTenant_Edit.FlatStyle = FlatStyle.Flat;
            btnTenant_Edit.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTenant_Edit.ForeColor = SystemColors.Control;
            btnTenant_Edit.Location = new Point(72, 6);
            btnTenant_Edit.Name = "btnTenant_Edit";
            btnTenant_Edit.Size = new Size(224, 0);
            btnTenant_Edit.TabIndex = 1;
            btnTenant_Edit.Text = "VIEW/EDIT";
            btnTenant_Edit.TextAlign = ContentAlignment.MiddleLeft;
            btnTenant_Edit.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.REMS_TENANTS_BROWSE;
            pictureBox5.Location = new Point(10, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(56, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 67);
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.FromArgb(0, 70, 67);
            button2.Location = new Point(321, 462);
            button2.Name = "button2";
            button2.Size = new Size(203, 44);
            button2.TabIndex = 3;
            button2.Text = "SAVE CHANGES";
            button2.UseVisualStyleBackColor = true;
            // 
            // EditTenant
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(845, 518);
            Controls.Add(button2);
            Controls.Add(panel2);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label6);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pcbIDPhoto);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "EditTenant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditTenant";
            FormClosing += EditTenant_FormClosing;
            Load += EditTenant_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbIDPhoto).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pcbIDPhoto;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private TextBox textBox3;
        private Label label7;
        private ComboBox comboBox1;
        private TextBox textBox4;
        private Label label8;
        private Panel panel2;
        private Button btnTenant_Edit;
        private PictureBox pictureBox5;
        private Button button1;
        private Button button2;
    }
}