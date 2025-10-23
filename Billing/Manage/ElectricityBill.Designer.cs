namespace Real_Estate_Management_System.Billing.Manage
{
    partial class ElectricityBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ElectricityBill));
            pnlHeader = new Panel();
            label1 = new Label();
            btnSubmit = new Button();
            label12 = new Label();
            lblTotal = new Label();
            label8 = new Label();
            label9 = new Label();
            lblDeductions = new Label();
            lblRemainingBalance = new Label();
            label6 = new Label();
            label7 = new Label();
            lblCurrentCharge = new Label();
            lblConsumption = new Label();
            btnConfirm = new Button();
            txtPresent = new TextBox();
            label3 = new Label();
            txtPrevious = new TextBox();
            label2 = new Label();
            label4 = new Label();
            lblDueDate = new Label();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackgroundImage = Properties.Resources.REMS_BILLING_ELECTRICITY;
            pnlHeader.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Location = new Point(1, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(605, 150);
            pnlHeader.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(118, 9);
            label1.Name = "label1";
            label1.Size = new Size(484, 141);
            label1.TabIndex = 2;
            label1.Text = "ELECTRICITY BILL\r\nINFORMATION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline);
            btnSubmit.Location = new Point(233, 587);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(140, 43);
            btnSubmit.TabIndex = 32;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // label12
            // 
            label12.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            label12.Location = new Point(88, 528);
            label12.Name = "label12";
            label12.Size = new Size(274, 34);
            label12.TabIndex = 31;
            label12.Text = "BILL TOTAL:";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            lblTotal.Location = new Point(368, 528);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(225, 34);
            lblTotal.TabIndex = 30;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Arial", 12F, FontStyle.Italic);
            label8.Location = new Point(88, 468);
            label8.Name = "label8";
            label8.Size = new Size(274, 25);
            label8.TabIndex = 29;
            label8.Text = "DEDUCTIONS:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Location = new Point(88, 427);
            label9.Name = "label9";
            label9.Size = new Size(274, 25);
            label9.TabIndex = 28;
            label9.Text = "REMAINING BALANCE:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDeductions
            // 
            lblDeductions.Font = new Font("Arial", 12F, FontStyle.Italic);
            lblDeductions.Location = new Point(368, 468);
            lblDeductions.Name = "lblDeductions";
            lblDeductions.Size = new Size(225, 25);
            lblDeductions.TabIndex = 27;
            lblDeductions.Text = "0.00";
            lblDeductions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRemainingBalance
            // 
            lblRemainingBalance.Location = new Point(368, 427);
            lblRemainingBalance.Name = "lblRemainingBalance";
            lblRemainingBalance.Size = new Size(225, 25);
            lblRemainingBalance.TabIndex = 26;
            lblRemainingBalance.Text = "0.00";
            lblRemainingBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(88, 377);
            label6.Name = "label6";
            label6.Size = new Size(274, 25);
            label6.TabIndex = 25;
            label6.Text = "CURRENT CHARGE:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(88, 336);
            label7.Name = "label7";
            label7.Size = new Size(274, 25);
            label7.TabIndex = 24;
            label7.Text = "CONSUMPTION:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCurrentCharge
            // 
            lblCurrentCharge.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblCurrentCharge.Location = new Point(368, 377);
            lblCurrentCharge.Name = "lblCurrentCharge";
            lblCurrentCharge.Size = new Size(225, 25);
            lblCurrentCharge.TabIndex = 23;
            lblCurrentCharge.Text = "0.00";
            lblCurrentCharge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConsumption
            // 
            lblConsumption.Location = new Point(368, 336);
            lblConsumption.Name = "lblConsumption";
            lblConsumption.Size = new Size(225, 25);
            lblConsumption.TabIndex = 22;
            lblConsumption.Text = "0";
            lblConsumption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Underline);
            btnConfirm.Location = new Point(453, 283);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(140, 43);
            btnConfirm.TabIndex = 21;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtPresent
            // 
            txtPresent.BorderStyle = BorderStyle.FixedSingle;
            txtPresent.ForeColor = Color.FromArgb(0, 70, 67);
            txtPresent.Location = new Point(368, 247);
            txtPresent.Name = "txtPresent";
            txtPresent.Size = new Size(225, 30);
            txtPresent.TabIndex = 20;
            txtPresent.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Location = new Point(88, 248);
            label3.Name = "label3";
            label3.Size = new Size(274, 25);
            label3.TabIndex = 19;
            label3.Text = "PRESENT READING:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPrevious
            // 
            txtPrevious.BorderStyle = BorderStyle.FixedSingle;
            txtPrevious.ForeColor = Color.FromArgb(0, 70, 67);
            txtPrevious.Location = new Point(368, 206);
            txtPrevious.Name = "txtPrevious";
            txtPrevious.Size = new Size(225, 30);
            txtPrevious.TabIndex = 18;
            txtPrevious.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.Location = new Point(88, 207);
            label2.Name = "label2";
            label2.Size = new Size(274, 25);
            label2.TabIndex = 17;
            label2.Text = "PREVIOUS READING:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Location = new Point(88, 168);
            label4.Name = "label4";
            label4.Size = new Size(274, 25);
            label4.TabIndex = 34;
            label4.Text = "DUE DATE:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDueDate
            // 
            lblDueDate.Location = new Point(368, 168);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(225, 25);
            lblDueDate.TabIndex = 33;
            lblDueDate.Text = "September 10, 2000";
            lblDueDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ElectricityBill
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(605, 643);
            Controls.Add(label4);
            Controls.Add(lblDueDate);
            Controls.Add(btnSubmit);
            Controls.Add(label12);
            Controls.Add(lblTotal);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(lblDeductions);
            Controls.Add(lblRemainingBalance);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(lblCurrentCharge);
            Controls.Add(lblConsumption);
            Controls.Add(btnConfirm);
            Controls.Add(txtPresent);
            Controls.Add(label3);
            Controls.Add(txtPrevious);
            Controls.Add(label2);
            Controls.Add(pnlHeader);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ElectricityBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Real Estate Management System - New Bill [MANAGE: Electricity Bill]";
            FormClosing += ElectricityBill_FormClosing;
            Load += ElectricityBill_Load;
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Button btnSubmit;
        private Label label12;
        private Label lblTotal;
        private Label label8;
        private Label label9;
        private Label lblDeductions;
        private Label lblRemainingBalance;
        private Label label6;
        private Label label7;
        private Label lblCurrentCharge;
        private Label lblConsumption;
        private Button btnConfirm;
        private TextBox txtPresent;
        private Label label3;
        private TextBox txtPrevious;
        private Label label2;
        private Label label4;
        private Label lblDueDate;
    }
}