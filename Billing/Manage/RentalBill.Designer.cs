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
            label2 = new Label();
            lblMonthlyRent = new Label();
            label4 = new Label();
            lblDueDate = new Label();
            label3 = new Label();
            lblPenalties = new Label();
            btnSeePenalties = new Button();
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
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(195, 9);
            label1.Name = "label1";
            label1.Size = new Size(335, 141);
            label1.TabIndex = 2;
            label1.Text = "RENTAL BILL\r\nINFORMATION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom;
            label12.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            label12.Location = new Point(13, 440);
            label12.Name = "label12";
            label12.Size = new Size(274, 34);
            label12.TabIndex = 31;
            label12.Text = "BILL TOTAL:";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom;
            lblTotal.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            lblTotal.Location = new Point(293, 440);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(225, 34);
            lblTotal.TabIndex = 30;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.Font = new Font("Arial", 12F, FontStyle.Italic);
            label8.Location = new Point(13, 298);
            label8.Name = "label8";
            label8.Size = new Size(274, 25);
            label8.TabIndex = 29;
            label8.Text = "DEDUCTIONS:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Location = new Point(13, 257);
            label9.Name = "label9";
            label9.Size = new Size(274, 25);
            label9.TabIndex = 28;
            label9.Text = "REMAINING BALANCE:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDeductions
            // 
            lblDeductions.Font = new Font("Arial", 12F, FontStyle.Italic);
            lblDeductions.Location = new Point(293, 298);
            lblDeductions.Name = "lblDeductions";
            lblDeductions.Size = new Size(225, 25);
            lblDeductions.TabIndex = 27;
            lblDeductions.Text = "0.00";
            lblDeductions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRemainingBalance
            // 
            lblRemainingBalance.Location = new Point(293, 257);
            lblRemainingBalance.Name = "lblRemainingBalance";
            lblRemainingBalance.Size = new Size(225, 25);
            lblRemainingBalance.TabIndex = 26;
            lblRemainingBalance.Text = "0.00";
            lblRemainingBalance.TextAlign = ContentAlignment.MiddleCenter;
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
            // label3
            // 
            label3.Location = new Point(13, 342);
            label3.Name = "label3";
            label3.Size = new Size(274, 25);
            label3.TabIndex = 38;
            label3.Text = "PENALTIES:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblPenalties
            // 
            lblPenalties.Location = new Point(293, 342);
            lblPenalties.Name = "lblPenalties";
            lblPenalties.Size = new Size(225, 25);
            lblPenalties.TabIndex = 37;
            lblPenalties.Text = "0.00";
            lblPenalties.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSeePenalties
            // 
            btnSeePenalties.FlatAppearance.BorderSize = 0;
            btnSeePenalties.FlatStyle = FlatStyle.Flat;
            btnSeePenalties.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSeePenalties.Location = new Point(354, 370);
            btnSeePenalties.Name = "btnSeePenalties";
            btnSeePenalties.Size = new Size(164, 38);
            btnSeePenalties.TabIndex = 39;
            btnSeePenalties.Text = "See Penalties";
            btnSeePenalties.UseVisualStyleBackColor = true;
            // 
            // RentalBill
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(530, 483);
            Controls.Add(btnSeePenalties);
            Controls.Add(label3);
            Controls.Add(lblPenalties);
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
            Controls.Add(pnlHeader);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "RentalBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Real Estate Management System - New Bill [MANAGE: Rental Bill]";
            FormClosing += RentalBill_FormClosing;
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
        private Label label2;
        private Label lblMonthlyRent;
        private Label label4;
        private Label lblDueDate;
        private Label label3;
        private Label lblPenalties;
        private Button btnSeePenalties;
    }
}