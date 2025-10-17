namespace Real_Estate_Management_System.Tenants.Activity
{
    partial class ViewActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewActivity));
            panel1 = new Panel();
            lblTenantName = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            btnInvoiceHistory = new Button();
            btnPaymentHistory = new Button();
            btnAdvancesCredits = new Button();
            btnComplaints = new Button();
            btnPenalties = new Button();
            btnOthers = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(0, 70, 67);
            panel1.Controls.Add(lblTenantName);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = Color.FromArgb(240, 237, 229);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1169, 167);
            panel1.TabIndex = 0;
            // 
            // lblTenantName
            // 
            lblTenantName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTenantName.BackColor = Color.Transparent;
            lblTenantName.Cursor = Cursors.Hand;
            lblTenantName.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenantName.ForeColor = Color.FromArgb(240, 237, 229);
            lblTenantName.Location = new Point(160, 88);
            lblTenantName.Name = "lblTenantName";
            lblTenantName.Size = new Size(1009, 63);
            lblTenantName.TabIndex = 5;
            lblTenantName.Text = "DELA CRUZ, JUAN";
            lblTenantName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(157, 13);
            label1.Name = "label1";
            label1.Size = new Size(1009, 75);
            label1.TabIndex = 4;
            label1.Text = "VIEW TENANT ACTIVITY";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.REMS_TENANTS_ACTIVITY;
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnInvoiceHistory
            // 
            btnInvoiceHistory.BackColor = Color.FromArgb(0, 70, 67);
            btnInvoiceHistory.FlatAppearance.BorderSize = 0;
            btnInvoiceHistory.FlatStyle = FlatStyle.Flat;
            btnInvoiceHistory.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInvoiceHistory.ForeColor = Color.FromArgb(240, 237, 229);
            btnInvoiceHistory.Location = new Point(12, 172);
            btnInvoiceHistory.Name = "btnInvoiceHistory";
            btnInvoiceHistory.Size = new Size(185, 68);
            btnInvoiceHistory.TabIndex = 1;
            btnInvoiceHistory.Text = "INVOICE HISTORY";
            btnInvoiceHistory.UseVisualStyleBackColor = false;
            btnInvoiceHistory.Click += btnInvoiceHistory_Click;
            // 
            // btnPaymentHistory
            // 
            btnPaymentHistory.BackColor = Color.FromArgb(0, 70, 67);
            btnPaymentHistory.FlatAppearance.BorderSize = 0;
            btnPaymentHistory.FlatStyle = FlatStyle.Flat;
            btnPaymentHistory.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPaymentHistory.ForeColor = Color.FromArgb(240, 237, 229);
            btnPaymentHistory.Location = new Point(203, 172);
            btnPaymentHistory.Name = "btnPaymentHistory";
            btnPaymentHistory.Size = new Size(185, 68);
            btnPaymentHistory.TabIndex = 2;
            btnPaymentHistory.Text = "PAYMENT HISTORY";
            btnPaymentHistory.UseVisualStyleBackColor = false;
            btnPaymentHistory.Click += btnPaymentHistory_Click;
            // 
            // btnAdvancesCredits
            // 
            btnAdvancesCredits.BackColor = Color.FromArgb(0, 70, 67);
            btnAdvancesCredits.FlatAppearance.BorderSize = 0;
            btnAdvancesCredits.FlatStyle = FlatStyle.Flat;
            btnAdvancesCredits.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdvancesCredits.ForeColor = Color.FromArgb(240, 237, 229);
            btnAdvancesCredits.Location = new Point(394, 172);
            btnAdvancesCredits.Name = "btnAdvancesCredits";
            btnAdvancesCredits.Size = new Size(185, 68);
            btnAdvancesCredits.TabIndex = 3;
            btnAdvancesCredits.Text = "ADVANCES && CREDITS";
            btnAdvancesCredits.UseVisualStyleBackColor = false;
            btnAdvancesCredits.Click += btnAdvancesCredits_Click;
            // 
            // btnComplaints
            // 
            btnComplaints.BackColor = Color.FromArgb(0, 70, 67);
            btnComplaints.FlatAppearance.BorderSize = 0;
            btnComplaints.FlatStyle = FlatStyle.Flat;
            btnComplaints.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnComplaints.ForeColor = Color.FromArgb(240, 237, 229);
            btnComplaints.Location = new Point(585, 172);
            btnComplaints.Name = "btnComplaints";
            btnComplaints.Size = new Size(185, 68);
            btnComplaints.TabIndex = 4;
            btnComplaints.Text = "COMPLAINTS";
            btnComplaints.UseVisualStyleBackColor = false;
            btnComplaints.Click += btnComplaints_Click;
            // 
            // btnPenalties
            // 
            btnPenalties.BackColor = Color.FromArgb(0, 70, 67);
            btnPenalties.FlatAppearance.BorderSize = 0;
            btnPenalties.FlatStyle = FlatStyle.Flat;
            btnPenalties.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPenalties.ForeColor = Color.FromArgb(240, 237, 229);
            btnPenalties.Location = new Point(776, 172);
            btnPenalties.Name = "btnPenalties";
            btnPenalties.Size = new Size(185, 68);
            btnPenalties.TabIndex = 5;
            btnPenalties.Text = "PENALTIES";
            btnPenalties.UseVisualStyleBackColor = false;
            btnPenalties.Click += btnPenalties_Click;
            // 
            // btnOthers
            // 
            btnOthers.BackColor = Color.FromArgb(0, 70, 67);
            btnOthers.FlatAppearance.BorderSize = 0;
            btnOthers.FlatStyle = FlatStyle.Flat;
            btnOthers.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOthers.ForeColor = Color.FromArgb(240, 237, 229);
            btnOthers.Location = new Point(967, 172);
            btnOthers.Name = "btnOthers";
            btnOthers.Size = new Size(185, 68);
            btnOthers.TabIndex = 6;
            btnOthers.Text = "OTHERS";
            btnOthers.UseVisualStyleBackColor = false;
            btnOthers.Click += btnOthers_Click;
            // 
            // ViewActivity
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(1166, 252);
            Controls.Add(btnOthers);
            Controls.Add(btnPenalties);
            Controls.Add(btnComplaints);
            Controls.Add(btnAdvancesCredits);
            Controls.Add(btnPaymentHistory);
            Controls.Add(btnInvoiceHistory);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "ViewActivity";
            StartPosition = FormStartPosition.Manual;
            Text = "Real Estate Management System - View Tenant Activity";
            Load += ViewActivity_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lblTenantName;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private CheckedListBox clstFilter;
        internal Button btnInvoiceHistory;
        internal Button btnPaymentHistory;
        internal Button btnAdvancesCredits;
        internal Button btnComplaints;
        internal Button btnPenalties;
        internal Button btnOthers;
    }
}