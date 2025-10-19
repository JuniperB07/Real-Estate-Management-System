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
            cmbRentType = new ComboBox();
            label8 = new Label();
            label2 = new Label();
            lblEndDate = new Label();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            cmbRoomName = new ComboBox();
            lblRoomName = new Label();
            cmbInternetPlan = new ComboBox();
            lblInternetPlan = new Label();
            cmbStatus = new ComboBox();
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
            // cmbRentType
            // 
            cmbRentType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRentType.ForeColor = Color.FromArgb(0, 70, 67);
            cmbRentType.FormattingEnabled = true;
            cmbRentType.Location = new Point(304, 182);
            cmbRentType.Name = "cmbRentType";
            cmbRentType.Size = new Size(344, 31);
            cmbRentType.TabIndex = 22;
            cmbRentType.SelectedIndexChanged += cmbRentType_SelectedIndexChanged;
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
            label8.Text = "Rent Type:";
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
            // lblEndDate
            // 
            lblEndDate.BackColor = Color.Transparent;
            lblEndDate.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblEndDate.ForeColor = Color.FromArgb(0, 70, 67);
            lblEndDate.Location = new Point(13, 279);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(285, 27);
            lblEndDate.TabIndex = 25;
            lblEndDate.Text = "Tenancy End Date:";
            lblEndDate.TextAlign = ContentAlignment.TopRight;
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "MMMM d, yyyy";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(304, 226);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(344, 30);
            dtpStartDate.TabIndex = 27;
            // 
            // dtpEndDate
            // 
            dtpEndDate.CustomFormat = "MMMM d, yyyy";
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(304, 273);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(344, 30);
            dtpEndDate.TabIndex = 28;
            // 
            // cmbRoomName
            // 
            cmbRoomName.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRoomName.ForeColor = Color.FromArgb(0, 70, 67);
            cmbRoomName.FormattingEnabled = true;
            cmbRoomName.Location = new Point(304, 366);
            cmbRoomName.Name = "cmbRoomName";
            cmbRoomName.Size = new Size(344, 31);
            cmbRoomName.TabIndex = 30;
            // 
            // lblRoomName
            // 
            lblRoomName.BackColor = Color.Transparent;
            lblRoomName.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblRoomName.ForeColor = Color.FromArgb(0, 70, 67);
            lblRoomName.Location = new Point(13, 369);
            lblRoomName.Name = "lblRoomName";
            lblRoomName.Size = new Size(285, 27);
            lblRoomName.TabIndex = 29;
            lblRoomName.Text = "Occupied Room:";
            lblRoomName.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbInternetPlan
            // 
            cmbInternetPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbInternetPlan.ForeColor = Color.FromArgb(0, 70, 67);
            cmbInternetPlan.FormattingEnabled = true;
            cmbInternetPlan.Location = new Point(304, 413);
            cmbInternetPlan.Name = "cmbInternetPlan";
            cmbInternetPlan.Size = new Size(344, 31);
            cmbInternetPlan.TabIndex = 32;
            // 
            // lblInternetPlan
            // 
            lblInternetPlan.BackColor = Color.Transparent;
            lblInternetPlan.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblInternetPlan.ForeColor = Color.FromArgb(0, 70, 67);
            lblInternetPlan.Location = new Point(13, 416);
            lblInternetPlan.Name = "lblInternetPlan";
            lblInternetPlan.Size = new Size(285, 27);
            lblInternetPlan.TabIndex = 31;
            lblInternetPlan.Text = "Internet Subscription Plan:";
            lblInternetPlan.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.ForeColor = Color.FromArgb(0, 70, 67);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(304, 460);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(344, 31);
            cmbStatus.TabIndex = 34;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 70, 67);
            label6.Location = new Point(13, 463);
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
            button3.Location = new Point(220, 521);
            button3.Name = "button3";
            button3.Size = new Size(203, 44);
            button3.TabIndex = 35;
            button3.Text = "SAVE CHANGES";
            button3.UseVisualStyleBackColor = true;
            // 
            // cmbBuilding
            // 
            cmbBuilding.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuilding.ForeColor = Color.FromArgb(0, 70, 67);
            cmbBuilding.FormattingEnabled = true;
            cmbBuilding.Location = new Point(304, 319);
            cmbBuilding.Name = "cmbBuilding";
            cmbBuilding.Size = new Size(344, 31);
            cmbBuilding.TabIndex = 37;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.ForeColor = Color.FromArgb(0, 70, 67);
            label7.Location = new Point(13, 322);
            label7.Name = "label7";
            label7.Size = new Size(285, 27);
            label7.TabIndex = 36;
            label7.Text = "Building Name:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // NewTenancy
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(660, 577);
            Controls.Add(cmbBuilding);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(cmbStatus);
            Controls.Add(label6);
            Controls.Add(cmbInternetPlan);
            Controls.Add(lblInternetPlan);
            Controls.Add(cmbRoomName);
            Controls.Add(lblRoomName);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(lblEndDate);
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
        private ComboBox cmbRentType;
        private Label label8;
        private Label label2;
        private Label lblEndDate;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private ComboBox cmbRoomName;
        private Label lblRoomName;
        private ComboBox cmbInternetPlan;
        private Label lblInternetPlan;
        private ComboBox cmbStatus;
        private Label label6;
        private Button button3;
        private ComboBox cmbBuilding;
        private Label label7;
    }
}