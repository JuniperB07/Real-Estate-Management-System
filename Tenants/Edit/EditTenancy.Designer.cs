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
            cmbRentType = new ComboBox();
            label2 = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            lblEndDate = new Label();
            cmbRoom = new ComboBox();
            lblRoom = new Label();
            cmbInternetPlan = new ComboBox();
            lblInternetPlan = new Label();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            btnSave = new Button();
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
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(157, 3);
            label1.Name = "label1";
            label1.Size = new Size(592, 161);
            label1.TabIndex = 4;
            label1.Text = "TENANT MANAGEMENT\r\nEDIT TENANCY INFORMATION";
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
            label8.Text = "Rent Type:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbRentType
            // 
            cmbRentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRentType.ForeColor = Color.FromArgb(0, 70, 67);
            cmbRentType.FormattingEnabled = true;
            cmbRentType.Location = new Point(394, 182);
            cmbRentType.Name = "cmbRentType";
            cmbRentType.Size = new Size(344, 31);
            cmbRentType.TabIndex = 20;
            cmbRentType.TextChanged += cmbRentType_TextChanged;
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
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "MMMM d, yyyy";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(394, 224);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(344, 30);
            dtpStartDate.TabIndex = 22;
            dtpStartDate.ValueChanged += dtpStartDate_ValueChanged;
            // 
            // dtpEndDate
            // 
            dtpEndDate.CustomFormat = "MMMM d, yyyy";
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(394, 265);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(344, 30);
            dtpEndDate.TabIndex = 24;
            dtpEndDate.ValueChanged += dtpEndDate_ValueChanged;
            // 
            // lblEndDate
            // 
            lblEndDate.BackColor = Color.Transparent;
            lblEndDate.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblEndDate.ForeColor = Color.FromArgb(0, 70, 67);
            lblEndDate.Location = new Point(12, 268);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(376, 27);
            lblEndDate.TabIndex = 23;
            lblEndDate.Text = "Tenancy End Date:";
            lblEndDate.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbRoom
            // 
            cmbRoom.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoom.ForeColor = Color.FromArgb(0, 70, 67);
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(394, 348);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(344, 31);
            cmbRoom.TabIndex = 26;
            cmbRoom.TextChanged += cmbRoom_TextChanged;
            // 
            // lblRoom
            // 
            lblRoom.BackColor = Color.Transparent;
            lblRoom.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblRoom.ForeColor = Color.FromArgb(0, 70, 67);
            lblRoom.Location = new Point(12, 351);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(376, 27);
            lblRoom.TabIndex = 25;
            lblRoom.Text = "Room #:";
            lblRoom.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbInternetPlan
            // 
            cmbInternetPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInternetPlan.ForeColor = Color.FromArgb(0, 70, 67);
            cmbInternetPlan.FormattingEnabled = true;
            cmbInternetPlan.Location = new Point(394, 390);
            cmbInternetPlan.Name = "cmbInternetPlan";
            cmbInternetPlan.Size = new Size(344, 31);
            cmbInternetPlan.TabIndex = 28;
            cmbInternetPlan.TextChanged += cmbInternetPlan_TextChanged;
            // 
            // lblInternetPlan
            // 
            lblInternetPlan.BackColor = Color.Transparent;
            lblInternetPlan.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblInternetPlan.ForeColor = Color.FromArgb(0, 70, 67);
            lblInternetPlan.Location = new Point(12, 393);
            lblInternetPlan.Name = "lblInternetPlan";
            lblInternetPlan.Size = new Size(376, 27);
            lblInternetPlan.TabIndex = 27;
            lblInternetPlan.Text = "Internet Subscription Plan:";
            lblInternetPlan.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.ForeColor = Color.FromArgb(0, 70, 67);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(394, 432);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(344, 31);
            cmbStatus.TabIndex = 30;
            cmbStatus.TextChanged += cmbStatus_TextChanged;
            // 
            // lblStatus
            // 
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(0, 70, 67);
            lblStatus.Location = new Point(12, 435);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(376, 27);
            lblStatus.TabIndex = 29;
            lblStatus.Text = "Tenancy Status:";
            lblStatus.TextAlign = ContentAlignment.TopRight;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 67);
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(0, 70, 67);
            btnSave.Location = new Point(274, 489);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 44);
            btnSave.TabIndex = 32;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            cmbBuilding.TextChanged += cmbBuilding_TextChanged;
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
            Controls.Add(btnSave);
            Controls.Add(cmbStatus);
            Controls.Add(lblStatus);
            Controls.Add(cmbInternetPlan);
            Controls.Add(lblInternetPlan);
            Controls.Add(cmbRoom);
            Controls.Add(lblRoom);
            Controls.Add(dtpEndDate);
            Controls.Add(lblEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(label2);
            Controls.Add(cmbRentType);
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
        private ComboBox cmbRentType;
        private Label label2;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label lblEndDate;
        private ComboBox cmbRoom;
        private Label lblRoom;
        private ComboBox cmbInternetPlan;
        private Label lblInternetPlan;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private Button btnSave;
        private ComboBox cmbBuilding;
        private Label label7;
    }
}