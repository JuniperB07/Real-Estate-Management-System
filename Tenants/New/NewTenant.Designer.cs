namespace Real_Estate_Management_System.Tenants.New
{
    partial class NewTenant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTenant));
            pnlHeader = new Panel();
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
            label8 = new Label();
            txtIDNumber = new TextBox();
            panel2 = new Panel();
            btnUploadID = new Button();
            button1 = new Button();
            btnTenant_Edit = new Button();
            pictureBox5 = new PictureBox();
            btnSave = new Button();
            ofdUploadID = new OpenFileDialog();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pcbIDPhoto).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackColor = Color.FromArgb(0, 38, 77);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Location = new Point(-1, -1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(722, 167);
            pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(157, 4);
            label1.Name = "label1";
            label1.Size = new Size(562, 161);
            label1.TabIndex = 4;
            label1.Text = "NEW TENANT:\r\nTENANT INFORMATION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.REMS_TENANTS_NEW;
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pcbIDPhoto
            // 
            pcbIDPhoto.Location = new Point(12, 172);
            pcbIDPhoto.Name = "pcbIDPhoto";
            pcbIDPhoto.Size = new Size(288, 199);
            pcbIDPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pcbIDPhoto.TabIndex = 1;
            pcbIDPhoto.TabStop = false;
            // 
            // label2
            // 
            label2.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(306, 182);
            label2.Name = "label2";
            label2.Size = new Size(402, 25);
            label2.TabIndex = 2;
            label2.Text = "Tenant Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Font = new Font("Arial", 13.8F);
            txtFirstName.ForeColor = Color.FromArgb(0, 70, 67);
            txtFirstName.Location = new Point(306, 210);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(200, 34);
            txtFirstName.TabIndex = 3;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Font = new Font("Arial", 13.8F);
            txtLastName.ForeColor = Color.FromArgb(0, 70, 67);
            txtLastName.Location = new Point(512, 210);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(200, 34);
            txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            label3.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(306, 247);
            label3.Name = "label3";
            label3.Size = new Size(200, 19);
            label3.TabIndex = 5;
            label3.Text = "(First Name)";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(512, 247);
            label4.Name = "label4";
            label4.Size = new Size(200, 19);
            label4.TabIndex = 6;
            label4.Text = "(Last Name)";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(306, 293);
            label5.Name = "label5";
            label5.Size = new Size(158, 25);
            label5.TabIndex = 7;
            label5.Text = "Date Of Birth:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CustomFormat = "MMMM d, yyyy";
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.Location = new Point(470, 287);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(242, 30);
            dtpDateOfBirth.TabIndex = 8;
            // 
            // label6
            // 
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(306, 344);
            label6.Name = "label6";
            label6.Size = new Size(158, 25);
            label6.TabIndex = 9;
            label6.Text = "Phone/Email:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPhone
            // 
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.ForeColor = Color.FromArgb(0, 70, 67);
            txtPhone.Location = new Point(470, 341);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(242, 30);
            txtPhone.TabIndex = 10;
            // 
            // label7
            // 
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 399);
            label7.Name = "label7";
            label7.Size = new Size(158, 25);
            label7.TabIndex = 11;
            label7.Text = "Valid ID:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbValidID
            // 
            cmbValidID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbValidID.ForeColor = Color.FromArgb(0, 70, 67);
            cmbValidID.FormattingEnabled = true;
            cmbValidID.Location = new Point(176, 396);
            cmbValidID.Name = "cmbValidID";
            cmbValidID.Size = new Size(288, 31);
            cmbValidID.TabIndex = 12;
            cmbValidID.SelectedIndexChanged += cmbValidID_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 446);
            label8.Name = "label8";
            label8.Size = new Size(158, 25);
            label8.TabIndex = 13;
            label8.Text = "ID Number:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // txtIDNumber
            // 
            txtIDNumber.BorderStyle = BorderStyle.FixedSingle;
            txtIDNumber.ForeColor = Color.FromArgb(0, 70, 67);
            txtIDNumber.Location = new Point(176, 444);
            txtIDNumber.Name = "txtIDNumber";
            txtIDNumber.Size = new Size(288, 30);
            txtIDNumber.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnUploadID);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnTenant_Edit);
            panel2.Controls.Add(pictureBox5);
            panel2.Location = new Point(470, 396);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 50);
            panel2.TabIndex = 19;
            // 
            // btnUploadID
            // 
            btnUploadID.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnUploadID.FlatAppearance.BorderSize = 0;
            btnUploadID.FlatStyle = FlatStyle.Flat;
            btnUploadID.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadID.ForeColor = Color.FromArgb(0, 70, 67);
            btnUploadID.Location = new Point(72, 3);
            btnUploadID.Name = "btnUploadID";
            btnUploadID.Size = new Size(166, 44);
            btnUploadID.TabIndex = 20;
            btnUploadID.Text = "UPLOAD ID";
            btnUploadID.TextAlign = ContentAlignment.MiddleLeft;
            btnUploadID.UseVisualStyleBackColor = true;
            btnUploadID.Click += btnUploadID_Click;
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
            button1.Size = new Size(255, 0);
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
            btnTenant_Edit.Size = new Size(266, 0);
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
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 67);
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(0, 70, 67);
            btnSave.Location = new Point(259, 490);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 44);
            btnSave.TabIndex = 20;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // NewTenant
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(720, 546);
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
            Controls.Add(pnlHeader);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "NewTenant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Real Estate Management System - New Tenant: Tenant Information";
            Load += NewTenant_Load;
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pcbIDPhoto).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
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
        private Label label8;
        private TextBox txtIDNumber;
        private Panel panel2;
        private Button button1;
        private Button btnTenant_Edit;
        private PictureBox pictureBox5;
        private Button btnUploadID;
        private Button btnSave;
        private OpenFileDialog ofdUploadID;
    }
}