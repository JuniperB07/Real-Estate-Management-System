namespace Real_Estate_Management_System.Billing.Manage
{
    partial class RentalBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentalBill));
            pnlHeader = new Panel();
            label1 = new Label();
            label12 = new Label();
            lblTotal = new Label();
            label8 = new Label();
            label9 = new Label();
            lblDeductions = new Label();
            lblRemainingBalance = new Label();
            label6 = new Label();
            label7 = new Label();
            lblCurrentCharge = new Label();
            lblAdditionalCharges = new Label();
            label2 = new Label();
            lblMonthlyRent = new Label();
            label4 = new Label();
            lblDueDate = new Label();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackgroundImage = Properties.Resources.REMS_BILLING_RENTAL;
            pnlHeader.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(530, 150);
            pnlHeader.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(195, 9);
            label1.Name = "label1";
            label1.Size = new Size(335, 141);
            label1.TabIndex = 2;
            label1.Text = "RENTAL BILL\r\nINFORMATION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            label12.Location = new Point(13, 446);
            label12.Name = "label12";
            label12.Size = new Size(274, 34);
            label12.TabIndex = 31;
            label12.Text = "BILL TOTAL:";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            lblTotal.Location = new Point(293, 446);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(225, 34);
            lblTotal.TabIndex = 30;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Arial", 12F, FontStyle.Italic);
            label8.Location = new Point(13, 386);
            label8.Name = "label8";
            label8.Size = new Size(274, 25);
            label8.TabIndex = 29;
            label8.Text = "DEDUCTIONS:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Location = new Point(13, 345);
            label9.Name = "label9";
            label9.Size = new Size(274, 25);
            label9.TabIndex = 28;
            label9.Text = "REMAINING BALANCE:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDeductions
            // 
            lblDeductions.Font = new Font("Arial", 12F, FontStyle.Italic);
            lblDeductions.Location = new Point(293, 386);
            lblDeductions.Name = "lblDeductions";
            lblDeductions.Size = new Size(225, 25);
            lblDeductions.TabIndex = 27;
            lblDeductions.Text = "0.00";
            lblDeductions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRemainingBalance
            // 
            lblRemainingBalance.Location = new Point(293, 345);
            lblRemainingBalance.Name = "lblRemainingBalance";
            lblRemainingBalance.Size = new Size(225, 25);
            lblRemainingBalance.TabIndex = 26;
            lblRemainingBalance.Text = "0.00";
            lblRemainingBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(13, 295);
            label6.Name = "label6";
            label6.Size = new Size(274, 25);
            label6.TabIndex = 25;
            label6.Text = "CURRENT CHARGE:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(13, 254);
            label7.Name = "label7";
            label7.Size = new Size(274, 25);
            label7.TabIndex = 24;
            label7.Text = "ADDITIONAL CHARGES:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCurrentCharge
            // 
            lblCurrentCharge.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblCurrentCharge.Location = new Point(293, 295);
            lblCurrentCharge.Name = "lblCurrentCharge";
            lblCurrentCharge.Size = new Size(225, 25);
            lblCurrentCharge.TabIndex = 23;
            lblCurrentCharge.Text = "0.00";
            lblCurrentCharge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAdditionalCharges
            // 
            lblAdditionalCharges.Location = new Point(293, 254);
            lblAdditionalCharges.Name = "lblAdditionalCharges";
            lblAdditionalCharges.Size = new Size(225, 25);
            lblAdditionalCharges.TabIndex = 22;
            lblAdditionalCharges.Text = "0";
            lblAdditionalCharges.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(13, 212);
            label2.Name = "label2";
            label2.Size = new Size(274, 25);
            label2.TabIndex = 34;
            label2.Text = "MONTHLY RENT:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMonthlyRent
            // 
            lblMonthlyRent.Location = new Point(293, 212);
            lblMonthlyRent.Name = "lblMonthlyRent";
            lblMonthlyRent.Size = new Size(225, 25);
            lblMonthlyRent.TabIndex = 33;
            lblMonthlyRent.Text = "0.00";
            lblMonthlyRent.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(12, 170);
            label4.Name = "label4";
            label4.Size = new Size(275, 25);
            label4.TabIndex = 36;
            label4.Text = "DUE DATE:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDueDate
            // 
            lblDueDate.Location = new Point(293, 170);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(225, 25);
            lblDueDate.TabIndex = 35;
            lblDueDate.Text = "September 10, 2000";
            lblDueDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RentalBill
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 503);
            Controls.Add(label4);
            Controls.Add(lblDueDate);
            Controls.Add(label2);
            Controls.Add(lblMonthlyRent);
            Controls.Add(label12);
            Controls.Add(lblTotal);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(lblDeductions);
            Controls.Add(lblRemainingBalance);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(lblCurrentCharge);
            Controls.Add(lblAdditionalCharges);
            Controls.Add(pnlHeader);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RentalBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Real Estate Management System - New Bill [MANAGE: Rental Bill]";
            Load += RentalBill_Load;
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Label label12;
        private Label lblTotal;
        private Label label8;
        private Label label9;
        private Label lblDeductions;
        private Label lblRemainingBalance;
        private Label label6;
        private Label label7;
        private Label lblCurrentCharge;
        private Label lblAdditionalCharges;
        private Label label2;
        private Label lblMonthlyRent;
        private Label label4;
        private Label lblDueDate;
    }
}