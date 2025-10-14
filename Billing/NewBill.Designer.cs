namespace Real_Estate_Management_System.Billing
{
    partial class NewBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBill));
            pnlHeader = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pnlSelectTenant = new Panel();
            txtSearchTenant = new TextBox();
            lstTenantsList = new ListBox();
            pictureBox2 = new PictureBox();
            pnlBillSummary = new Panel();
            panel4 = new Panel();
            btnSetDueDates = new Button();
            pictureBox7 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            btnReset = new Button();
            pictureBox6 = new PictureBox();
            panel2 = new Panel();
            btnSaveBill = new Button();
            pictureBox5 = new PictureBox();
            panel1 = new Panel();
            btnExportToPDF = new Button();
            pictureBox4 = new PictureBox();
            panel11 = new Panel();
            btnBillPreview = new Button();
            pictureBox3 = new PictureBox();
            pnlWaterBill = new Panel();
            label16 = new Label();
            btnManage_WaterBill = new Button();
            label10 = new Label();
            label15 = new Label();
            pnlRentalBill = new Panel();
            label18 = new Label();
            label11 = new Label();
            btnManage_RentalBill = new Button();
            label12 = new Label();
            pnlInternetBill = new Panel();
            label19 = new Label();
            btnManage_InternetBill = new Button();
            label13 = new Label();
            label14 = new Label();
            pnlElectricityBill = new Panel();
            label17 = new Label();
            btnManage_ElectricityBill = new Button();
            label8 = new Label();
            label9 = new Label();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlSelectTenant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlBillSummary.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            pnlWaterBill.SuspendLayout();
            pnlRentalBill.SuspendLayout();
            pnlInternetBill.SuspendLayout();
            pnlElectricityBill.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackColor = SystemColors.ActiveCaptionText;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1578, 167);
            pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(191, 3);
            label1.Name = "label1";
            label1.Size = new Size(1374, 161);
            label1.TabIndex = 1;
            label1.Text = "REAL ESTATE MANAGEMENT SYSTEM\r\nNEW BILL";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.REMS_INVOICE_LIGHT1;
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnlSelectTenant
            // 
            pnlSelectTenant.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlSelectTenant.BackgroundImageLayout = ImageLayout.Stretch;
            pnlSelectTenant.Controls.Add(txtSearchTenant);
            pnlSelectTenant.Controls.Add(lstTenantsList);
            pnlSelectTenant.Controls.Add(pictureBox2);
            pnlSelectTenant.Location = new Point(0, 167);
            pnlSelectTenant.Name = "pnlSelectTenant";
            pnlSelectTenant.Size = new Size(355, 695);
            pnlSelectTenant.TabIndex = 1;
            // 
            // txtSearchTenant
            // 
            txtSearchTenant.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchTenant.BorderStyle = BorderStyle.FixedSingle;
            txtSearchTenant.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchTenant.Location = new Point(3, 214);
            txtSearchTenant.Name = "txtSearchTenant";
            txtSearchTenant.Size = new Size(349, 34);
            txtSearchTenant.TabIndex = 2;
            // 
            // lstTenantsList
            // 
            lstTenantsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstTenantsList.BorderStyle = BorderStyle.FixedSingle;
            lstTenantsList.FormattingEnabled = true;
            lstTenantsList.ItemHeight = 23;
            lstTenantsList.Location = new Point(3, 260);
            lstTenantsList.Name = "lstTenantsList";
            lstTenantsList.Size = new Size(349, 416);
            lstTenantsList.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = Properties.Resources.REMS_TENANTS_LIST_BG1;
            pictureBox2.Location = new Point(3, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(349, 205);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pnlBillSummary
            // 
            pnlBillSummary.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlBillSummary.BackColor = SystemColors.ControlDarkDark;
            pnlBillSummary.Controls.Add(panel4);
            pnlBillSummary.Controls.Add(label7);
            pnlBillSummary.Controls.Add(label6);
            pnlBillSummary.Controls.Add(label4);
            pnlBillSummary.Controls.Add(label3);
            pnlBillSummary.Controls.Add(label2);
            pnlBillSummary.Controls.Add(panel3);
            pnlBillSummary.Controls.Add(panel2);
            pnlBillSummary.Controls.Add(panel1);
            pnlBillSummary.Controls.Add(panel11);
            pnlBillSummary.ForeColor = SystemColors.ControlLightLight;
            pnlBillSummary.Location = new Point(354, 167);
            pnlBillSummary.Name = "pnlBillSummary";
            pnlBillSummary.Size = new Size(1224, 299);
            pnlBillSummary.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSetDueDates);
            panel4.Controls.Add(pictureBox7);
            panel4.Location = new Point(7, 62);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 50);
            panel4.TabIndex = 3;
            // 
            // btnSetDueDates
            // 
            btnSetDueDates.FlatAppearance.BorderSize = 0;
            btnSetDueDates.FlatStyle = FlatStyle.Flat;
            btnSetDueDates.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetDueDates.ForeColor = SystemColors.Control;
            btnSetDueDates.Location = new Point(75, 3);
            btnSetDueDates.Name = "btnSetDueDates";
            btnSetDueDates.Size = new Size(222, 44);
            btnSetDueDates.TabIndex = 1;
            btnSetDueDates.Text = "SET DUE DATES";
            btnSetDueDates.TextAlign = ContentAlignment.MiddleLeft;
            btnSetDueDates.UseVisualStyleBackColor = true;
            btnSetDueDates.Click += btnSetDueDates_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.REMS_BILLING_SET_DUE_DATES;
            pictureBox7.Location = new Point(13, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(56, 44);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(607, 249);
            label7.Name = "label7";
            label7.Size = new Size(241, 38);
            label7.TabIndex = 11;
            label7.Text = "Bill Total:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(854, 193);
            label6.Name = "label6";
            label6.Size = new Size(357, 94);
            label6.TabIndex = 10;
            label6.Text = "₱1,000.00";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(313, 132);
            label4.Name = "label4";
            label4.Size = new Size(898, 27);
            label4.TabIndex = 8;
            label4.Text = "Invoice Date";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(313, 84);
            label3.Name = "label3";
            label3.Size = new Size(898, 38);
            label3.TabIndex = 7;
            label3.Text = "Bill Number";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(313, 3);
            label2.Name = "label2";
            label2.Size = new Size(898, 78);
            label2.TabIndex = 6;
            label2.Text = "Dela Cruz, Juan";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnReset);
            panel3.Controls.Add(pictureBox6);
            panel3.Location = new Point(7, 6);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 50);
            panel3.TabIndex = 5;
            // 
            // btnReset
            // 
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = SystemColors.Control;
            btnReset.Location = new Point(75, 3);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(222, 44);
            btnReset.TabIndex = 1;
            btnReset.Text = "RESET FORM";
            btnReset.TextAlign = ContentAlignment.MiddleLeft;
            btnReset.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.REMS_RESET_ICON;
            pictureBox6.Location = new Point(13, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(56, 44);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnSaveBill);
            panel2.Controls.Add(pictureBox5);
            panel2.Location = new Point(7, 246);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 50);
            panel2.TabIndex = 4;
            // 
            // btnSaveBill
            // 
            btnSaveBill.FlatAppearance.BorderSize = 0;
            btnSaveBill.FlatStyle = FlatStyle.Flat;
            btnSaveBill.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveBill.ForeColor = SystemColors.Control;
            btnSaveBill.Location = new Point(75, 3);
            btnSaveBill.Name = "btnSaveBill";
            btnSaveBill.Size = new Size(222, 44);
            btnSaveBill.TabIndex = 1;
            btnSaveBill.Text = "SAVE BILL";
            btnSaveBill.TextAlign = ContentAlignment.MiddleLeft;
            btnSaveBill.UseVisualStyleBackColor = true;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.REMS_BILLING_SAVE_BILL;
            pictureBox5.Location = new Point(13, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(56, 44);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnExportToPDF);
            panel1.Controls.Add(pictureBox4);
            panel1.Location = new Point(7, 190);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 50);
            panel1.TabIndex = 3;
            // 
            // btnExportToPDF
            // 
            btnExportToPDF.FlatAppearance.BorderSize = 0;
            btnExportToPDF.FlatStyle = FlatStyle.Flat;
            btnExportToPDF.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportToPDF.ForeColor = SystemColors.Control;
            btnExportToPDF.Location = new Point(75, 3);
            btnExportToPDF.Name = "btnExportToPDF";
            btnExportToPDF.Size = new Size(222, 44);
            btnExportToPDF.TabIndex = 1;
            btnExportToPDF.Text = "EXPORT TO PDF";
            btnExportToPDF.TextAlign = ContentAlignment.MiddleLeft;
            btnExportToPDF.UseVisualStyleBackColor = true;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.REMS_BILLING_EXPORT_TO_PDF;
            pictureBox4.Location = new Point(13, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(56, 44);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel11
            // 
            panel11.Controls.Add(btnBillPreview);
            panel11.Controls.Add(pictureBox3);
            panel11.Location = new Point(7, 134);
            panel11.Name = "panel11";
            panel11.Size = new Size(300, 50);
            panel11.TabIndex = 2;
            // 
            // btnBillPreview
            // 
            btnBillPreview.FlatAppearance.BorderSize = 0;
            btnBillPreview.FlatStyle = FlatStyle.Flat;
            btnBillPreview.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBillPreview.ForeColor = SystemColors.Control;
            btnBillPreview.Location = new Point(75, 3);
            btnBillPreview.Name = "btnBillPreview";
            btnBillPreview.Size = new Size(222, 44);
            btnBillPreview.TabIndex = 1;
            btnBillPreview.Text = "BILL PREVIEW";
            btnBillPreview.TextAlign = ContentAlignment.MiddleLeft;
            btnBillPreview.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.REMS_BILLING_BILL_PREVIEW;
            pictureBox3.Location = new Point(13, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(56, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // pnlWaterBill
            // 
            pnlWaterBill.BackgroundImage = Properties.Resources.REMS_BILLING_WATER;
            pnlWaterBill.BackgroundImageLayout = ImageLayout.Zoom;
            pnlWaterBill.Controls.Add(label16);
            pnlWaterBill.Controls.Add(btnManage_WaterBill);
            pnlWaterBill.Controls.Add(label10);
            pnlWaterBill.Controls.Add(label15);
            pnlWaterBill.Location = new Point(372, 483);
            pnlWaterBill.Name = "pnlWaterBill";
            pnlWaterBill.Size = new Size(592, 178);
            pnlWaterBill.TabIndex = 3;
            // 
            // label16
            // 
            label16.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label16.BackColor = Color.FromArgb(17, 35, 64);
            label16.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.Cornsilk;
            label16.Location = new Point(225, 123);
            label16.Name = "label16";
            label16.Size = new Size(284, 55);
            label16.TabIndex = 18;
            label16.Text = "Manage";
            label16.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnManage_WaterBill
            // 
            btnManage_WaterBill.BackColor = Color.FromArgb(17, 35, 64);
            btnManage_WaterBill.BackgroundImage = Properties.Resources.REMS_THEMED_GOTO;
            btnManage_WaterBill.BackgroundImageLayout = ImageLayout.Zoom;
            btnManage_WaterBill.FlatAppearance.BorderSize = 0;
            btnManage_WaterBill.FlatStyle = FlatStyle.Flat;
            btnManage_WaterBill.Location = new Point(509, 123);
            btnManage_WaterBill.Name = "btnManage_WaterBill";
            btnManage_WaterBill.Size = new Size(83, 55);
            btnManage_WaterBill.TabIndex = 17;
            btnManage_WaterBill.UseVisualStyleBackColor = false;
            btnManage_WaterBill.Click += btnManage_WaterBill_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Cornsilk;
            label10.Location = new Point(314, 86);
            label10.Name = "label10";
            label10.Size = new Size(275, 38);
            label10.TabIndex = 12;
            label10.Text = "WATER BILL TOTAL";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Arial", 43.8F, FontStyle.Bold);
            label15.ForeColor = Color.Cornsilk;
            label15.Location = new Point(64, 0);
            label15.Name = "label15";
            label15.Size = new Size(525, 86);
            label15.TabIndex = 14;
            label15.Text = "₱1,000.00";
            label15.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlRentalBill
            // 
            pnlRentalBill.BackgroundImage = Properties.Resources.REMS_BILLING_RENTAL;
            pnlRentalBill.BackgroundImageLayout = ImageLayout.Stretch;
            pnlRentalBill.Controls.Add(label18);
            pnlRentalBill.Controls.Add(label11);
            pnlRentalBill.Controls.Add(btnManage_RentalBill);
            pnlRentalBill.Controls.Add(label12);
            pnlRentalBill.Location = new Point(970, 483);
            pnlRentalBill.Name = "pnlRentalBill";
            pnlRentalBill.Size = new Size(592, 178);
            pnlRentalBill.TabIndex = 4;
            // 
            // label18
            // 
            label18.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label18.BackColor = Color.FromArgb(65, 38, 102);
            label18.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.Cornsilk;
            label18.Location = new Point(225, 124);
            label18.Name = "label18";
            label18.Size = new Size(284, 54);
            label18.TabIndex = 22;
            label18.Text = "Manage";
            label18.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Cornsilk;
            label11.Location = new Point(272, 86);
            label11.Name = "label11";
            label11.Size = new Size(317, 38);
            label11.TabIndex = 15;
            label11.Text = "RENTAL BILL TOTAL";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnManage_RentalBill
            // 
            btnManage_RentalBill.BackColor = Color.FromArgb(65, 38, 102);
            btnManage_RentalBill.BackgroundImage = Properties.Resources.REMS_THEMED_GOTO;
            btnManage_RentalBill.BackgroundImageLayout = ImageLayout.Zoom;
            btnManage_RentalBill.FlatAppearance.BorderSize = 0;
            btnManage_RentalBill.FlatStyle = FlatStyle.Flat;
            btnManage_RentalBill.Location = new Point(509, 124);
            btnManage_RentalBill.Name = "btnManage_RentalBill";
            btnManage_RentalBill.Size = new Size(83, 54);
            btnManage_RentalBill.TabIndex = 21;
            btnManage_RentalBill.UseVisualStyleBackColor = false;
            btnManage_RentalBill.Click += btnManage_RentalBill_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Arial", 43.8F, FontStyle.Bold);
            label12.ForeColor = Color.Cornsilk;
            label12.Location = new Point(64, 0);
            label12.Name = "label12";
            label12.Size = new Size(525, 86);
            label12.TabIndex = 16;
            label12.Text = "₱1,000.00";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlInternetBill
            // 
            pnlInternetBill.BackgroundImage = Properties.Resources.REMS_BILLING_INTERNET;
            pnlInternetBill.BackgroundImageLayout = ImageLayout.Stretch;
            pnlInternetBill.Controls.Add(label19);
            pnlInternetBill.Controls.Add(btnManage_InternetBill);
            pnlInternetBill.Controls.Add(label13);
            pnlInternetBill.Controls.Add(label14);
            pnlInternetBill.Location = new Point(970, 667);
            pnlInternetBill.Name = "pnlInternetBill";
            pnlInternetBill.Size = new Size(592, 178);
            pnlInternetBill.TabIndex = 6;
            // 
            // label19
            // 
            label19.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label19.BackColor = Color.FromArgb(0, 90, 90);
            label19.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.Cornsilk;
            label19.Location = new Point(225, 123);
            label19.Name = "label19";
            label19.Size = new Size(284, 54);
            label19.TabIndex = 22;
            label19.Text = "Manage";
            label19.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnManage_InternetBill
            // 
            btnManage_InternetBill.BackColor = Color.FromArgb(0, 90, 90);
            btnManage_InternetBill.BackgroundImage = Properties.Resources.REMS_THEMED_GOTO;
            btnManage_InternetBill.BackgroundImageLayout = ImageLayout.Zoom;
            btnManage_InternetBill.FlatAppearance.BorderSize = 0;
            btnManage_InternetBill.FlatStyle = FlatStyle.Flat;
            btnManage_InternetBill.Location = new Point(509, 123);
            btnManage_InternetBill.Name = "btnManage_InternetBill";
            btnManage_InternetBill.Size = new Size(83, 54);
            btnManage_InternetBill.TabIndex = 21;
            btnManage_InternetBill.UseVisualStyleBackColor = false;
            btnManage_InternetBill.Click += btnManage_InternetBill_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Cornsilk;
            label13.Location = new Point(231, 86);
            label13.Name = "label13";
            label13.Size = new Size(358, 38);
            label13.TabIndex = 15;
            label13.Text = "INTERNET BILL TOTAL";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Arial", 43.8F, FontStyle.Bold);
            label14.ForeColor = Color.Cornsilk;
            label14.Location = new Point(64, 0);
            label14.Name = "label14";
            label14.Size = new Size(525, 86);
            label14.TabIndex = 16;
            label14.Text = "₱1,000.00";
            label14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlElectricityBill
            // 
            pnlElectricityBill.BackgroundImage = Properties.Resources.REMS_BILLING_ELECTRICITY;
            pnlElectricityBill.BackgroundImageLayout = ImageLayout.Stretch;
            pnlElectricityBill.Controls.Add(label17);
            pnlElectricityBill.Controls.Add(btnManage_ElectricityBill);
            pnlElectricityBill.Controls.Add(label8);
            pnlElectricityBill.Controls.Add(label9);
            pnlElectricityBill.Location = new Point(372, 667);
            pnlElectricityBill.Name = "pnlElectricityBill";
            pnlElectricityBill.Size = new Size(592, 178);
            pnlElectricityBill.TabIndex = 5;
            // 
            // label17
            // 
            label17.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label17.BackColor = Color.FromArgb(102, 79, 1);
            label17.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.Cornsilk;
            label17.Location = new Point(225, 124);
            label17.Name = "label17";
            label17.Size = new Size(284, 54);
            label17.TabIndex = 20;
            label17.Text = "Manage";
            label17.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnManage_ElectricityBill
            // 
            btnManage_ElectricityBill.BackColor = Color.FromArgb(102, 79, 1);
            btnManage_ElectricityBill.BackgroundImage = Properties.Resources.REMS_THEMED_GOTO;
            btnManage_ElectricityBill.BackgroundImageLayout = ImageLayout.Zoom;
            btnManage_ElectricityBill.FlatAppearance.BorderSize = 0;
            btnManage_ElectricityBill.FlatStyle = FlatStyle.Flat;
            btnManage_ElectricityBill.Location = new Point(509, 124);
            btnManage_ElectricityBill.Name = "btnManage_ElectricityBill";
            btnManage_ElectricityBill.Size = new Size(83, 54);
            btnManage_ElectricityBill.TabIndex = 19;
            btnManage_ElectricityBill.UseVisualStyleBackColor = false;
            btnManage_ElectricityBill.Click += btnManage_ElectricityBill_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Cornsilk;
            label8.Location = new Point(180, 86);
            label8.Name = "label8";
            label8.Size = new Size(409, 38);
            label8.TabIndex = 15;
            label8.Text = "ELECTRICITY BILL TOTAL";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Arial", 43.8F, FontStyle.Bold);
            label9.ForeColor = Color.Cornsilk;
            label9.Location = new Point(64, 0);
            label9.Name = "label9";
            label9.Size = new Size(525, 86);
            label9.TabIndex = 16;
            label9.Text = "₱1,000.00";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NewBill
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1577, 859);
            Controls.Add(pnlInternetBill);
            Controls.Add(pnlRentalBill);
            Controls.Add(pnlElectricityBill);
            Controls.Add(pnlWaterBill);
            Controls.Add(pnlBillSummary);
            Controls.Add(pnlSelectTenant);
            Controls.Add(pnlHeader);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "NewBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewBill";
            FormClosing += NewBill_FormClosing;
            Load += NewBill_Load;
            pnlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlSelectTenant.ResumeLayout(false);
            pnlSelectTenant.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlBillSummary.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            pnlWaterBill.ResumeLayout(false);
            pnlRentalBill.ResumeLayout(false);
            pnlInternetBill.ResumeLayout(false);
            pnlElectricityBill.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel pnlSelectTenant;
        private ListBox lstTenantsList;
        private PictureBox pictureBox2;
        private TextBox txtSearchTenant;
        private Panel pnlBillSummary;
        private Panel panel3;
        private Button btnReset;
        private PictureBox pictureBox6;
        private Panel panel2;
        private Button btnSaveBill;
        private PictureBox pictureBox5;
        private Panel panel1;
        private Button btnExportToPDF;
        private PictureBox pictureBox4;
        private Panel panel11;
        private Button btnBillPreview;
        private PictureBox pictureBox3;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label4;
        private Panel pnlWaterBill;
        private Panel pnlRentalBill;
        private Panel pnlInternetBill;
        private Panel pnlElectricityBill;
        private Label label15;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label8;
        private Label label9;
        private Label label16;
        private Button btnManage_WaterBill;
        private Label label17;
        private Button btnManage_ElectricityBill;
        private Label label18;
        private Button btnManage_RentalBill;
        private Label label19;
        private Button btnManage_InternetBill;
        private Panel panel4;
        private Button btnSetDueDates;
        private PictureBox pictureBox7;
    }
}