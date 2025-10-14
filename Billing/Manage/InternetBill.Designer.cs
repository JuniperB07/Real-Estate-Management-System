namespace Real_Estate_Management_System.Billing.Manage
{
    partial class InternetBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InternetBill));
            pnlHeader = new Panel();
            label1 = new Label();
            label4 = new Label();
            lblDueDate = new Label();
            label2 = new Label();
            lblAvailedPlan = new Label();
            label12 = new Label();
            lblTotal = new Label();
            label8 = new Label();
            label9 = new Label();
            lblDeductions = new Label();
            lblRemainingBalance = new Label();
            label6 = new Label();
            label7 = new Label();
            lblCurrentCharge = new Label();
            lblSubscriptionFee = new Label();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackgroundImage = Properties.Resources.REMS_BILLING_INTERNET;
            pnlHeader.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(542, 161);
            pnlHeader.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(153, 9);
            label1.Name = "label1";
            label1.Size = new Size(389, 152);
            label1.TabIndex = 2;
            label1.Text = "INTERNET BILL\r\nINFORMATION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(24, 178);
            label4.Name = "label4";
            label4.Size = new Size(275, 25);
            label4.TabIndex = 50;
            label4.Text = "DUE DATE:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDueDate
            // 
            lblDueDate.Location = new Point(305, 178);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(225, 25);
            lblDueDate.TabIndex = 49;
            lblDueDate.Text = "September 10, 2000";
            lblDueDate.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(25, 220);
            label2.Name = "label2";
            label2.Size = new Size(274, 25);
            label2.TabIndex = 48;
            label2.Text = "AVAILED PLAN:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblAvailedPlan
            // 
            lblAvailedPlan.Location = new Point(305, 220);
            lblAvailedPlan.Name = "lblAvailedPlan";
            lblAvailedPlan.Size = new Size(225, 25);
            lblAvailedPlan.TabIndex = 47;
            lblAvailedPlan.Text = "None";
            lblAvailedPlan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            label12.Location = new Point(25, 454);
            label12.Name = "label12";
            label12.Size = new Size(274, 34);
            label12.TabIndex = 46;
            label12.Text = "BILL TOTAL:";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            lblTotal.Location = new Point(305, 454);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(225, 34);
            lblTotal.TabIndex = 45;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Arial", 12F, FontStyle.Italic);
            label8.Location = new Point(25, 394);
            label8.Name = "label8";
            label8.Size = new Size(274, 25);
            label8.TabIndex = 44;
            label8.Text = "DEDUCTIONS:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Location = new Point(25, 353);
            label9.Name = "label9";
            label9.Size = new Size(274, 25);
            label9.TabIndex = 43;
            label9.Text = "REMAINING BALANCE:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDeductions
            // 
            lblDeductions.Font = new Font("Arial", 12F, FontStyle.Italic);
            lblDeductions.Location = new Point(305, 394);
            lblDeductions.Name = "lblDeductions";
            lblDeductions.Size = new Size(225, 25);
            lblDeductions.TabIndex = 42;
            lblDeductions.Text = "0.00";
            lblDeductions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRemainingBalance
            // 
            lblRemainingBalance.Location = new Point(305, 353);
            lblRemainingBalance.Name = "lblRemainingBalance";
            lblRemainingBalance.Size = new Size(225, 25);
            lblRemainingBalance.TabIndex = 41;
            lblRemainingBalance.Text = "0.00";
            lblRemainingBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(25, 303);
            label6.Name = "label6";
            label6.Size = new Size(274, 25);
            label6.TabIndex = 40;
            label6.Text = "CURRENT CHARGE:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(25, 262);
            label7.Name = "label7";
            label7.Size = new Size(274, 25);
            label7.TabIndex = 39;
            label7.Text = "SUBSCRIPTION FEE:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCurrentCharge
            // 
            lblCurrentCharge.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblCurrentCharge.Location = new Point(305, 303);
            lblCurrentCharge.Name = "lblCurrentCharge";
            lblCurrentCharge.Size = new Size(225, 25);
            lblCurrentCharge.TabIndex = 38;
            lblCurrentCharge.Text = "0.00";
            lblCurrentCharge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSubscriptionFee
            // 
            lblSubscriptionFee.Location = new Point(305, 262);
            lblSubscriptionFee.Name = "lblSubscriptionFee";
            lblSubscriptionFee.Size = new Size(225, 25);
            lblSubscriptionFee.TabIndex = 37;
            lblSubscriptionFee.Text = "0.00";
            lblSubscriptionFee.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InternetBill
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 505);
            Controls.Add(label4);
            Controls.Add(lblDueDate);
            Controls.Add(label2);
            Controls.Add(lblAvailedPlan);
            Controls.Add(label12);
            Controls.Add(lblTotal);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(lblDeductions);
            Controls.Add(lblRemainingBalance);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(lblCurrentCharge);
            Controls.Add(lblSubscriptionFee);
            Controls.Add(pnlHeader);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InternetBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Real Estate Management System - New Bill [MANAGE: Internet Bill]";
            Load += InternetBill_Load;
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Label label4;
        private Label lblDueDate;
        private Label label2;
        private Label lblAvailedPlan;
        private Label label12;
        private Label lblTotal;
        private Label label8;
        private Label label9;
        private Label lblDeductions;
        private Label lblRemainingBalance;
        private Label label6;
        private Label label7;
        private Label lblCurrentCharge;
        private Label lblSubscriptionFee;
    }
}