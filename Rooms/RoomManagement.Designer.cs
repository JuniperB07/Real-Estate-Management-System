namespace Real_Estate_Management_System.Rooms
{
    partial class RoomManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoomManagement));
            pnlHeader = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnlBuildingInfo = new Panel();
            panel11 = new Panel();
            btnBuilding_New = new Button();
            pictureBox3 = new PictureBox();
            lstBuilding = new ListBox();
            txtBuildingAddress = new TextBox();
            txtBuildingName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            pnlRoomInfo = new Panel();
            panel2 = new Panel();
            btnEdit = new Button();
            pictureBox4 = new PictureBox();
            lstRooms = new ListBox();
            panel1 = new Panel();
            btnRoom_New = new Button();
            pictureBox2 = new PictureBox();
            txtOccupancyStatus = new TextBox();
            txtOccupyingTenant = new TextBox();
            txtRoomName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label3 = new Label();
            panel3 = new Panel();
            btnEditBuilding = new Button();
            pictureBox5 = new PictureBox();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlBuildingInfo.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlRoomInfo.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackColor = Color.FromArgb(0, 70, 67);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.ForeColor = Color.FromArgb(240, 237, 229);
            pnlHeader.Location = new Point(-1, -1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1078, 167);
            pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(157, 0);
            label1.Name = "label1";
            label1.Size = new Size(918, 161);
            label1.TabIndex = 4;
            label1.Text = "REAL ESTATE MANAGEMENT SYSTEM\r\nROOM MANAGEMENT";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.REMS_ROOMS_LIGHT;
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pnlBuildingInfo
            // 
            pnlBuildingInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlBuildingInfo.BackColor = Color.FromArgb(0, 69, 127);
            pnlBuildingInfo.BackgroundImage = Properties.Resources.REMS_ROOMS_BUILDING;
            pnlBuildingInfo.BackgroundImageLayout = ImageLayout.Stretch;
            pnlBuildingInfo.Controls.Add(panel3);
            pnlBuildingInfo.Controls.Add(panel11);
            pnlBuildingInfo.Controls.Add(lstBuilding);
            pnlBuildingInfo.Controls.Add(txtBuildingAddress);
            pnlBuildingInfo.Controls.Add(txtBuildingName);
            pnlBuildingInfo.Controls.Add(label5);
            pnlBuildingInfo.Controls.Add(label4);
            pnlBuildingInfo.Controls.Add(label2);
            pnlBuildingInfo.ForeColor = Color.FromArgb(240, 237, 229);
            pnlBuildingInfo.Location = new Point(0, 165);
            pnlBuildingInfo.Name = "pnlBuildingInfo";
            pnlBuildingInfo.Size = new Size(537, 530);
            pnlBuildingInfo.TabIndex = 1;
            // 
            // panel11
            // 
            panel11.BackColor = Color.Transparent;
            panel11.Controls.Add(btnBuilding_New);
            panel11.Controls.Add(pictureBox3);
            panel11.Location = new Point(12, 153);
            panel11.Name = "panel11";
            panel11.Size = new Size(186, 50);
            panel11.TabIndex = 11;
            // 
            // btnBuilding_New
            // 
            btnBuilding_New.BackColor = Color.FromArgb(0, 69, 127);
            btnBuilding_New.FlatAppearance.BorderSize = 0;
            btnBuilding_New.FlatStyle = FlatStyle.Flat;
            btnBuilding_New.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuilding_New.ForeColor = SystemColors.Control;
            btnBuilding_New.Location = new Point(75, 3);
            btnBuilding_New.Name = "btnBuilding_New";
            btnBuilding_New.Size = new Size(108, 44);
            btnBuilding_New.TabIndex = 1;
            btnBuilding_New.Text = "NEW";
            btnBuilding_New.TextAlign = ContentAlignment.MiddleLeft;
            btnBuilding_New.UseVisualStyleBackColor = false;
            btnBuilding_New.Click += btnBuilding_New_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.REMS_ADD_ICON;
            pictureBox3.Location = new Point(13, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // lstBuilding
            // 
            lstBuilding.BackColor = Color.FromArgb(0, 69, 127);
            lstBuilding.BorderStyle = BorderStyle.None;
            lstBuilding.ForeColor = Color.FromArgb(240, 237, 229);
            lstBuilding.FormattingEnabled = true;
            lstBuilding.ItemHeight = 23;
            lstBuilding.Location = new Point(12, 270);
            lstBuilding.Name = "lstBuilding";
            lstBuilding.Size = new Size(518, 230);
            lstBuilding.TabIndex = 10;
            lstBuilding.MouseDoubleClick += lstBuilding_MouseDoubleClick;
            // 
            // txtBuildingAddress
            // 
            txtBuildingAddress.BackColor = Color.FromArgb(0, 69, 127);
            txtBuildingAddress.BorderStyle = BorderStyle.None;
            txtBuildingAddress.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuildingAddress.ForeColor = Color.FromArgb(240, 237, 229);
            txtBuildingAddress.Location = new Point(233, 114);
            txtBuildingAddress.Multiline = true;
            txtBuildingAddress.Name = "txtBuildingAddress";
            txtBuildingAddress.ReadOnly = true;
            txtBuildingAddress.Size = new Size(297, 142);
            txtBuildingAddress.TabIndex = 9;
            // 
            // txtBuildingName
            // 
            txtBuildingName.BackColor = Color.FromArgb(0, 69, 127);
            txtBuildingName.BorderStyle = BorderStyle.None;
            txtBuildingName.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuildingName.ForeColor = Color.FromArgb(240, 237, 229);
            txtBuildingName.Location = new Point(233, 74);
            txtBuildingName.Name = "txtBuildingName";
            txtBuildingName.ReadOnly = true;
            txtBuildingName.Size = new Size(297, 27);
            txtBuildingName.TabIndex = 8;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 113);
            label5.Name = "label5";
            label5.Size = new Size(215, 37);
            label5.TabIndex = 7;
            label5.Text = "Building Address:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 74);
            label4.Name = "label4";
            label4.Size = new Size(215, 34);
            label4.TabIndex = 6;
            label4.Text = "Building Name:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 28.2F, FontStyle.Bold | FontStyle.Underline);
            label2.ForeColor = Color.FromArgb(240, 237, 229);
            label2.Location = new Point(12, 4);
            label2.Name = "label2";
            label2.Size = new Size(518, 70);
            label2.TabIndex = 5;
            label2.Text = "BUILDINGS";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRoomInfo
            // 
            pnlRoomInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            pnlRoomInfo.BackColor = Color.FromArgb(236, 98, 6);
            pnlRoomInfo.BackgroundImage = Properties.Resources.REMS_ROOMS_ROOM;
            pnlRoomInfo.BackgroundImageLayout = ImageLayout.Stretch;
            pnlRoomInfo.Controls.Add(panel2);
            pnlRoomInfo.Controls.Add(lstRooms);
            pnlRoomInfo.Controls.Add(panel1);
            pnlRoomInfo.Controls.Add(txtOccupancyStatus);
            pnlRoomInfo.Controls.Add(txtOccupyingTenant);
            pnlRoomInfo.Controls.Add(txtRoomName);
            pnlRoomInfo.Controls.Add(label8);
            pnlRoomInfo.Controls.Add(label7);
            pnlRoomInfo.Controls.Add(label6);
            pnlRoomInfo.Controls.Add(label3);
            pnlRoomInfo.ForeColor = Color.FromArgb(240, 237, 229);
            pnlRoomInfo.Location = new Point(536, 165);
            pnlRoomInfo.Name = "pnlRoomInfo";
            pnlRoomInfo.Size = new Size(541, 530);
            pnlRoomInfo.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(btnEdit);
            panel2.Controls.Add(pictureBox4);
            panel2.Location = new Point(311, 168);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 50);
            panel2.TabIndex = 14;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(236, 98, 6);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(75, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(137, 44);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT";
            btnEdit.TextAlign = ContentAlignment.MiddleLeft;
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.REMS_EDIT_ICON;
            pictureBox4.Location = new Point(13, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // lstRooms
            // 
            lstRooms.BackColor = Color.FromArgb(236, 98, 6);
            lstRooms.BorderStyle = BorderStyle.None;
            lstRooms.ForeColor = Color.FromArgb(240, 237, 229);
            lstRooms.FormattingEnabled = true;
            lstRooms.ItemHeight = 23;
            lstRooms.Location = new Point(8, 224);
            lstRooms.Name = "lstRooms";
            lstRooms.Size = new Size(518, 276);
            lstRooms.TabIndex = 14;
            lstRooms.MouseDoubleClick += lstRooms_MouseDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btnRoom_New);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(8, 168);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 50);
            panel1.TabIndex = 13;
            // 
            // btnRoom_New
            // 
            btnRoom_New.BackColor = Color.FromArgb(236, 98, 6);
            btnRoom_New.FlatAppearance.BorderSize = 0;
            btnRoom_New.FlatStyle = FlatStyle.Flat;
            btnRoom_New.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRoom_New.ForeColor = SystemColors.Control;
            btnRoom_New.Location = new Point(75, 3);
            btnRoom_New.Name = "btnRoom_New";
            btnRoom_New.Size = new Size(137, 44);
            btnRoom_New.TabIndex = 1;
            btnRoom_New.Text = "NEW";
            btnRoom_New.TextAlign = ContentAlignment.MiddleLeft;
            btnRoom_New.UseVisualStyleBackColor = false;
            btnRoom_New.Click += btnRoom_New_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.REMS_ADD_ICON;
            pictureBox2.Location = new Point(13, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(56, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // txtOccupancyStatus
            // 
            txtOccupancyStatus.BackColor = Color.FromArgb(236, 98, 6);
            txtOccupancyStatus.BorderStyle = BorderStyle.None;
            txtOccupancyStatus.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOccupancyStatus.ForeColor = Color.FromArgb(240, 237, 229);
            txtOccupancyStatus.Location = new Point(229, 138);
            txtOccupancyStatus.Name = "txtOccupancyStatus";
            txtOccupancyStatus.ReadOnly = true;
            txtOccupancyStatus.Size = new Size(297, 23);
            txtOccupancyStatus.TabIndex = 12;
            // 
            // txtOccupyingTenant
            // 
            txtOccupyingTenant.BackColor = Color.FromArgb(236, 98, 6);
            txtOccupyingTenant.BorderStyle = BorderStyle.None;
            txtOccupyingTenant.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtOccupyingTenant.ForeColor = Color.FromArgb(240, 237, 229);
            txtOccupyingTenant.Location = new Point(229, 106);
            txtOccupyingTenant.Name = "txtOccupyingTenant";
            txtOccupyingTenant.ReadOnly = true;
            txtOccupyingTenant.Size = new Size(297, 23);
            txtOccupyingTenant.TabIndex = 11;
            // 
            // txtRoomName
            // 
            txtRoomName.BackColor = Color.FromArgb(236, 98, 6);
            txtRoomName.BorderStyle = BorderStyle.None;
            txtRoomName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomName.ForeColor = Color.FromArgb(240, 237, 229);
            txtRoomName.Location = new Point(229, 74);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.ReadOnly = true;
            txtRoomName.Size = new Size(297, 23);
            txtRoomName.TabIndex = 10;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(7, 138);
            label8.Name = "label8";
            label8.Size = new Size(215, 27);
            label8.TabIndex = 9;
            label8.Text = "Occupancy Status:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(7, 106);
            label7.Name = "label7";
            label7.Size = new Size(215, 27);
            label7.TabIndex = 8;
            label7.Text = "Occupying Tenant:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(7, 74);
            label6.Name = "label6";
            label6.Size = new Size(215, 27);
            label6.TabIndex = 7;
            label6.Text = "Room Name:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 28.2F, FontStyle.Bold | FontStyle.Underline);
            label3.ForeColor = Color.FromArgb(240, 237, 229);
            label3.Location = new Point(0, 4);
            label3.Name = "label3";
            label3.Size = new Size(526, 70);
            label3.TabIndex = 6;
            label3.Text = "ROOMS";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(btnEditBuilding);
            panel3.Controls.Add(pictureBox5);
            panel3.Location = new Point(12, 209);
            panel3.Name = "panel3";
            panel3.Size = new Size(186, 50);
            panel3.TabIndex = 12;
            // 
            // btnEditBuilding
            // 
            btnEditBuilding.BackColor = Color.FromArgb(0, 69, 127);
            btnEditBuilding.FlatAppearance.BorderSize = 0;
            btnEditBuilding.FlatStyle = FlatStyle.Flat;
            btnEditBuilding.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditBuilding.ForeColor = SystemColors.Control;
            btnEditBuilding.Location = new Point(75, 3);
            btnEditBuilding.Name = "btnEditBuilding";
            btnEditBuilding.Size = new Size(108, 44);
            btnEditBuilding.TabIndex = 1;
            btnEditBuilding.Text = "EDIT";
            btnEditBuilding.TextAlign = ContentAlignment.MiddleLeft;
            btnEditBuilding.UseVisualStyleBackColor = false;
            btnEditBuilding.Click += btnEditBuilding_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.REMS_EDIT_ICON;
            pictureBox5.Location = new Point(13, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(56, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // RoomManagement
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(1074, 691);
            Controls.Add(pnlRoomInfo);
            Controls.Add(pnlBuildingInfo);
            Controls.Add(pnlHeader);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "RoomManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Real Estate Management System - Room Management";
            FormClosing += RoomManagement_FormClosing;
            Load += RoomManagement_Load;
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlBuildingInfo.ResumeLayout(false);
            pnlBuildingInfo.PerformLayout();
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlRoomInfo.ResumeLayout(false);
            pnlRoomInfo.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel pnlBuildingInfo;
        private Panel pnlRoomInfo;
        private Label label2;
        private Label label3;
        private TextBox txtBuildingName;
        private Label label5;
        private Label label4;
        private ListBox lstBuilding;
        private TextBox txtBuildingAddress;
        private Panel panel11;
        private Button btnBuilding_New;
        private PictureBox pictureBox3;
        private ListBox lstRooms;
        private Panel panel1;
        private Button btnRoom_New;
        private PictureBox pictureBox2;
        private TextBox txtOccupancyStatus;
        private TextBox txtOccupyingTenant;
        private TextBox txtRoomName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Panel panel2;
        private Button btnEdit;
        private PictureBox pictureBox4;
        private Panel panel3;
        private Button btnEditBuilding;
        private PictureBox pictureBox5;
    }
}