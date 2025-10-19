namespace Real_Estate_Management_System.Internet
{
    partial class InternetManagement
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InternetManagement));
            pnlHeader = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            cmbBuilding = new ComboBox();
            label6 = new Label();
            label2 = new Label();
            lstInternetPlans = new ListBox();
            label4 = new Label();
            pnlPlanInformation = new Panel();
            lblSubscribers = new Label();
            label11 = new Label();
            lblBuilding = new Label();
            label10 = new Label();
            lblPlanPrice = new Label();
            label8 = new Label();
            lblPlanName = new Label();
            label5 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            btnReset = new Button();
            pictureBox4 = new PictureBox();
            panel4 = new Panel();
            btnEdit = new Button();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            btnNew = new Button();
            pictureBox2 = new PictureBox();
            dgvSubscribers = new DataGridView();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            pnlPlanInformation.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubscribers).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackColor = Color.FromArgb(0, 70, 67);
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.ForeColor = Color.FromArgb(240, 237, 229);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1110, 167);
            pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(156, 0);
            label1.Name = "label1";
            label1.Size = new Size(954, 161);
            label1.TabIndex = 5;
            label1.Text = "REAL ESTATE MANAGEMENT SYSTEM\r\nINTERNET SERVICE MANAGER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.REMS_INTERNET_LIGHT;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.BackColor = Color.FromArgb(1, 53, 60);
            panel1.Controls.Add(cmbBuilding);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lstInternetPlans);
            panel1.Controls.Add(label4);
            panel1.ForeColor = Color.FromArgb(240, 237, 229);
            panel1.Location = new Point(0, 166);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 531);
            panel1.TabIndex = 1;
            // 
            // cmbBuilding
            // 
            cmbBuilding.BackColor = Color.FromArgb(240, 237, 229);
            cmbBuilding.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuilding.ForeColor = Color.FromArgb(1, 53, 60);
            cmbBuilding.FormattingEnabled = true;
            cmbBuilding.Location = new Point(12, 45);
            cmbBuilding.Name = "cmbBuilding";
            cmbBuilding.Size = new Size(232, 31);
            cmbBuilding.TabIndex = 11;
            cmbBuilding.SelectedIndexChanged += cmbBuilding_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 5);
            label6.Name = "label6";
            label6.Size = new Size(215, 37);
            label6.TabIndex = 10;
            label6.Text = "Building:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 502);
            label2.Name = "label2";
            label2.Size = new Size(244, 26);
            label2.TabIndex = 9;
            label2.Text = "*Double click to select plan.";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // lstInternetPlans
            // 
            lstInternetPlans.BackColor = Color.FromArgb(1, 53, 60);
            lstInternetPlans.BorderStyle = BorderStyle.None;
            lstInternetPlans.ForeColor = Color.FromArgb(240, 237, 229);
            lstInternetPlans.FormattingEnabled = true;
            lstInternetPlans.ItemHeight = 23;
            lstInternetPlans.Location = new Point(12, 159);
            lstInternetPlans.Name = "lstInternetPlans";
            lstInternetPlans.Size = new Size(235, 322);
            lstInternetPlans.TabIndex = 8;
            lstInternetPlans.MouseDoubleClick += lstInternetPlans_MouseDoubleClick;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 111);
            label4.Name = "label4";
            label4.Size = new Size(215, 37);
            label4.TabIndex = 7;
            label4.Text = "Internet Plans:";
            // 
            // pnlPlanInformation
            // 
            pnlPlanInformation.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPlanInformation.BackColor = Color.Transparent;
            pnlPlanInformation.BackgroundImage = Properties.Resources.REMS_INTERNET_PLAN_INFORMATION;
            pnlPlanInformation.BackgroundImageLayout = ImageLayout.Stretch;
            pnlPlanInformation.Controls.Add(lblSubscribers);
            pnlPlanInformation.Controls.Add(label11);
            pnlPlanInformation.Controls.Add(lblBuilding);
            pnlPlanInformation.Controls.Add(label10);
            pnlPlanInformation.Controls.Add(lblPlanPrice);
            pnlPlanInformation.Controls.Add(label8);
            pnlPlanInformation.Controls.Add(lblPlanName);
            pnlPlanInformation.Controls.Add(label5);
            pnlPlanInformation.Controls.Add(label3);
            pnlPlanInformation.ForeColor = Color.FromArgb(1, 53, 60);
            pnlPlanInformation.Location = new Point(250, 167);
            pnlPlanInformation.Name = "pnlPlanInformation";
            pnlPlanInformation.Size = new Size(868, 166);
            pnlPlanInformation.TabIndex = 2;
            // 
            // lblSubscribers
            // 
            lblSubscribers.BackColor = Color.Transparent;
            lblSubscribers.Font = new Font("Arial", 64.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubscribers.Location = new Point(498, 37);
            lblSubscribers.Name = "lblSubscribers";
            lblSubscribers.Size = new Size(329, 115);
            lblSubscribers.TabIndex = 16;
            lblSubscribers.Text = "10";
            lblSubscribers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(415, 4);
            label11.Name = "label11";
            label11.Size = new Size(211, 37);
            label11.TabIndex = 15;
            label11.Text = "# of Subscribers:";
            // 
            // lblBuilding
            // 
            lblBuilding.BackColor = Color.Transparent;
            lblBuilding.Location = new Point(142, 101);
            lblBuilding.Name = "lblBuilding";
            lblBuilding.Size = new Size(245, 57);
            lblBuilding.TabIndex = 14;
            lblBuilding.Text = "Building A";
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(21, 101);
            label10.Name = "label10";
            label10.Size = new Size(115, 25);
            label10.TabIndex = 13;
            label10.Text = "Building:";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // lblPlanPrice
            // 
            lblPlanPrice.BackColor = Color.Transparent;
            lblPlanPrice.Location = new Point(142, 71);
            lblPlanPrice.Name = "lblPlanPrice";
            lblPlanPrice.Size = new Size(245, 25);
            lblPlanPrice.TabIndex = 12;
            lblPlanPrice.Text = "1,000.00";
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(21, 71);
            label8.Name = "label8";
            label8.Size = new Size(115, 25);
            label8.TabIndex = 11;
            label8.Text = "Price:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // lblPlanName
            // 
            lblPlanName.BackColor = Color.Transparent;
            lblPlanName.Location = new Point(142, 41);
            lblPlanName.Name = "lblPlanName";
            lblPlanName.Size = new Size(245, 25);
            lblPlanName.TabIndex = 10;
            lblPlanName.Text = "None";
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Location = new Point(21, 41);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 9;
            label5.Text = "Plan Name:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(7, 4);
            label3.Name = "label3";
            label3.Size = new Size(211, 37);
            label3.TabIndex = 8;
            label3.Text = "Plan Information:";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.BackColor = Color.FromArgb(182, 67, 38);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.ForeColor = Color.FromArgb(240, 237, 229);
            panel2.Location = new Point(250, 332);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 362);
            panel2.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Controls.Add(btnReset);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(7, 300);
            panel5.Name = "panel5";
            panel5.Size = new Size(199, 50);
            panel5.TabIndex = 16;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(182, 67, 38);
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = SystemColors.Control;
            btnReset.Location = new Point(75, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(120, 44);
            btnReset.TabIndex = 1;
            btnReset.Text = "RESET";
            btnReset.TextAlign = ContentAlignment.MiddleLeft;
            btnReset.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.REMS_RESET_ICON;
            pictureBox4.Location = new Point(13, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(btnEdit);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(7, 63);
            panel4.Name = "panel4";
            panel4.Size = new Size(199, 50);
            panel4.TabIndex = 15;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(182, 67, 38);
            btnEdit.FlatAppearance.BorderSize = 0;
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEdit.ForeColor = SystemColors.Control;
            btnEdit.Location = new Point(75, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(120, 44);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "EDIT";
            btnEdit.TextAlign = ContentAlignment.MiddleLeft;
            btnEdit.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.REMS_EDIT_ICON;
            pictureBox3.Location = new Point(13, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(btnNew);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(7, 7);
            panel3.Name = "panel3";
            panel3.Size = new Size(199, 50);
            panel3.TabIndex = 14;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.FromArgb(182, 67, 38);
            btnNew.FlatAppearance.BorderSize = 0;
            btnNew.FlatStyle = FlatStyle.Flat;
            btnNew.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNew.ForeColor = SystemColors.Control;
            btnNew.Location = new Point(75, 3);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(120, 44);
            btnNew.TabIndex = 1;
            btnNew.Text = "NEW";
            btnNew.TextAlign = ContentAlignment.MiddleLeft;
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
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
            // dgvSubscribers
            // 
            dgvSubscribers.AllowUserToAddRows = false;
            dgvSubscribers.AllowUserToDeleteRows = false;
            dgvSubscribers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dgvSubscribers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvSubscribers.BackgroundColor = Color.FromArgb(240, 237, 229);
            dgvSubscribers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(1, 53, 60);
            dataGridViewCellStyle1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(240, 237, 229);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(0, 185, 177);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvSubscribers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSubscribers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 70, 67);
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 70, 67);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSubscribers.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSubscribers.EnableHeadersVisualStyles = false;
            dgvSubscribers.GridColor = Color.FromArgb(240, 237, 229);
            dgvSubscribers.Location = new Point(474, 339);
            dgvSubscribers.MultiSelect = false;
            dgvSubscribers.Name = "dgvSubscribers";
            dgvSubscribers.ReadOnly = true;
            dgvSubscribers.RowHeadersVisible = false;
            dgvSubscribers.RowHeadersWidth = 51;
            dgvSubscribers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSubscribers.Size = new Size(623, 343);
            dgvSubscribers.TabIndex = 4;
            // 
            // InternetManagement
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(1109, 694);
            Controls.Add(dgvSubscribers);
            Controls.Add(panel2);
            Controls.Add(pnlPlanInformation);
            Controls.Add(panel1);
            Controls.Add(pnlHeader);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "InternetManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Real Estate Management System - Internet Service Management";
            FormClosing += InternetManagement_FormClosing;
            Load += InternetManagement_Load;
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            pnlPlanInformation.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubscribers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private ListBox lstInternetPlans;
        private Label label4;
        private Panel pnlPlanInformation;
        private Label label3;
        private Label lblPlanPrice;
        private Label label8;
        private Label lblPlanName;
        private Label label5;
        private Label lblSubscribers;
        private Label label11;
        private Label lblBuilding;
        private Label label10;
        private Panel panel2;
        private Panel panel5;
        private Button btnReset;
        private PictureBox pictureBox4;
        private Panel panel4;
        private Button btnEdit;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Button btnNew;
        private PictureBox pictureBox2;
        private DataGridView dgvSubscribers;
        private ComboBox cmbBuilding;
        private Label label6;
    }
}