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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            label6 = new Label();
            txtPhone = new TextBox();
            label7 = new Label();
            cmbValidID = new ComboBox();
            txtIDNumber = new TextBox();
            label8 = new Label();
            panel2 = new Panel();
            btnUpload = new Button();
            btnTenant_Edit = new Button();
            pictureBox5 = new PictureBox();
            btnSave = new Button();
            ofdUpload = new OpenFileDialog();
            panel3 = new Panel();
            btnRemoveID = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbIDPhoto).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.White;
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Arial", 13.8F);
            txtFirstName.ForeColor = Color.FromArgb(0, 70, 67);
            txtFirstName.Location = new Point(306, 204);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(260, 34);
            txtFirstName.TabIndex = 3;
            txtFirstName.TextChanged += txtFirstName_TextChanged;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.White;
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Arial", 13.8F);
            txtLastName.ForeColor = Color.FromArgb(0, 70, 67);
            txtLastName.Location = new Point(573, 204);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(260, 34);
            txtLastName.TabIndex = 4;
            txtLastName.TextChanged += txtLastName_TextChanged;
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
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CustomFormat = "MMMM d, yyyy";
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.Location = new Point(505, 281);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(328, 30);
            dtpDateOfBirth.TabIndex = 10;
            dtpDateOfBirth.ValueChanged += dtpDateOfBirth_ValueChanged;
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
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.ForeColor = Color.FromArgb(0, 70, 67);
            txtPhone.Location = new Point(505, 329);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(328, 30);
            txtPhone.TabIndex = 12;
            txtPhone.TextChanged += txtPhone_TextChanged;
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
            // cmbValidID
            // 
            cmbValidID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbValidID.FormattingEnabled = true;
            cmbValidID.Location = new Point(211, 378);
            cmbValidID.Name = "cmbValidID";
            cmbValidID.Size = new Size(328, 31);
            cmbValidID.TabIndex = 14;
            cmbValidID.SelectedIndexChanged += cmbValidID_SelectedIndexChanged;
            // 
            // txtIDNumber
            // 
            txtIDNumber.BackColor = Color.White;
            txtIDNumber.BorderStyle = BorderStyle.FixedSingle;
            txtIDNumber.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtIDNumber.ForeColor = Color.FromArgb(0, 70, 67);
            txtIDNumber.Location = new Point(211, 415);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(328, 30);
            txtIDNumber.TabIndex = 16;
            txtIDNumber.TextChanged += txtIDNumber_TextChanged;
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
            panel2.Controls.Add(btnUpload);
            panel2.Controls.Add(btnTenant_Edit);
            panel2.Controls.Add(pictureBox5);
            panel2.Location = new Point(545, 367);
            panel2.Name = "panel2";
            panel2.Size = new Size(288, 50);
            panel2.TabIndex = 18;
            // 
            // btnUpload
            // 
            btnUpload.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUpload.FlatAppearance.BorderSize = 0;
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.ForeColor = Color.FromArgb(0, 70, 67);
            btnUpload.Location = new Point(72, 3);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(213, 44);
            btnUpload.TabIndex = 2;
            btnUpload.Text = "UPLOAD ID";
            btnUpload.TextAlign = ContentAlignment.MiddleLeft;
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
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
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 67);
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(0, 70, 67);
            btnSave.Location = new Point(321, 462);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 44);
            btnSave.TabIndex = 3;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ofdUpload
            // 
            ofdUpload.FileName = "openFileDialog1";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnRemoveID);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(545, 423);
            panel3.Name = "panel3";
            panel3.Size = new Size(288, 50);
            panel3.TabIndex = 19;
            // 
            // btnRemoveID
            // 
            btnRemoveID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRemoveID.FlatAppearance.BorderSize = 0;
            btnRemoveID.FlatStyle = FlatStyle.Flat;
            btnRemoveID.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveID.ForeColor = Color.FromArgb(0, 70, 67);
            btnRemoveID.Location = new Point(72, 5);
            btnRemoveID.Name = "btnRemoveID";
            btnRemoveID.Size = new Size(213, 41);
            btnRemoveID.TabIndex = 2;
            btnRemoveID.Text = "REMOVE ID";
            btnRemoveID.TextAlign = ContentAlignment.MiddleLeft;
            btnRemoveID.UseVisualStyleBackColor = true;
            btnRemoveID.Click += btnRemoveID_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(72, 6);
            button2.Name = "button2";
            button2.Size = new Size(312, 0);
            button2.TabIndex = 1;
            button2.Text = "VIEW/EDIT";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.REMS_TENANTS_TERMINATE;
            pictureBox2.Location = new Point(10, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // EditTenant
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(845, 518);
            Controls.Add(panel3);
            Controls.Add(btnSave);
            Controls.Add(panel2);
            Controls.Add(txtIDNumber);
            Controls.Add(label8);
            Controls.Add(cmbValidID);
            Controls.Add(label7);
            Controls.Add(txtPhone);
            Controls.Add(label6);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
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
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pcbIDPhoto;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpDateOfBirth;
        private Label label6;
        private TextBox txtPhone;
        private Label label7;
        private ComboBox cmbValidID;
        private TextBox txtIDNumber;
        private Label label8;
        private Panel panel2;
        private Button btnTenant_Edit;
        private PictureBox pictureBox5;
        private Button btnUpload;
        private Button btnSave;
        private OpenFileDialog ofdUpload;
        private Panel panel3;
        private Button btnRemoveID;
        private Button button2;
        private PictureBox pictureBox2;
    }
}