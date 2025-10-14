namespace Real_Estate_Management_System.Billing
{
    partial class WaterBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaterBill));
            pnlHeader = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtPrevious = new TextBox();
            txtPresent = new TextBox();
            label3 = new Label();
            btnConfirm = new Button();
            lblCurrentCharge = new Label();
            lblConsumption = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            lblDeductions = new Label();
            lblRemainingBalance = new Label();
            label12 = new Label();
            lblTotal = new Label();
            btnSubmit = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackgroundImage = Properties.Resources.REMS_BILLING_WATER;
            pnlHeader.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHeader.Controls.Add(label1);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(530, 150);
            pnlHeader.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(118, 9);
            label1.Name = "label1";
            label1.Size = new Size(409, 133);
            label1.TabIndex = 2;
            label1.Text = "WATER BILL\r\nINFORMATION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(13, 170);
            label2.Name = "label2";
            label2.Size = new Size(274, 25);
            label2.TabIndex = 1;
            label2.Text = "PREVIOUS READING:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txtPrevious
            // 
            txtPrevious.BorderStyle = BorderStyle.FixedSingle;
            txtPrevious.Location = new Point(293, 169);
            txtPrevious.Name = "txtPrevious";
            txtPrevious.Size = new Size(225, 30);
            txtPrevious.TabIndex = 2;
            txtPrevious.TextAlign = HorizontalAlignment.Center;
            // 
            // txtPresent
            // 
            txtPresent.BorderStyle = BorderStyle.FixedSingle;
            txtPresent.Location = new Point(293, 210);
            txtPresent.Name = "txtPresent";
            txtPresent.Size = new Size(225, 30);
            txtPresent.TabIndex = 4;
            txtPresent.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.Location = new Point(13, 211);
            label3.Name = "label3";
            label3.Size = new Size(274, 25);
            label3.TabIndex = 3;
            label3.Text = "PRESENT READING:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnConfirm
            // 
            btnConfirm.FlatAppearance.BorderSize = 0;
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(378, 246);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(140, 43);
            btnConfirm.TabIndex = 5;
            btnConfirm.Text = "CONFIRM";
            btnConfirm.UseVisualStyleBackColor = true;
            // 
            // lblCurrentCharge
            // 
            lblCurrentCharge.Font = new Font("Arial", 12F, FontStyle.Bold);
            lblCurrentCharge.Location = new Point(293, 340);
            lblCurrentCharge.Name = "lblCurrentCharge";
            lblCurrentCharge.Size = new Size(225, 25);
            lblCurrentCharge.TabIndex = 7;
            lblCurrentCharge.Text = "0.00";
            lblCurrentCharge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConsumption
            // 
            lblConsumption.Location = new Point(293, 299);
            lblConsumption.Name = "lblConsumption";
            lblConsumption.Size = new Size(225, 25);
            lblConsumption.TabIndex = 6;
            lblConsumption.Text = "0";
            lblConsumption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Font = new Font("Arial", 12F, FontStyle.Bold);
            label6.Location = new Point(13, 340);
            label6.Name = "label6";
            label6.Size = new Size(274, 25);
            label6.TabIndex = 9;
            label6.Text = "CURRENT CHARGE:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Location = new Point(13, 299);
            label7.Name = "label7";
            label7.Size = new Size(274, 25);
            label7.TabIndex = 8;
            label7.Text = "CONSUMPTION:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Font = new Font("Arial", 12F, FontStyle.Italic);
            label8.Location = new Point(13, 431);
            label8.Name = "label8";
            label8.Size = new Size(274, 25);
            label8.TabIndex = 13;
            label8.Text = "DEDUCTIONS:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Location = new Point(13, 390);
            label9.Name = "label9";
            label9.Size = new Size(274, 25);
            label9.TabIndex = 12;
            label9.Text = "REMAINING BALANCE:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDeductions
            // 
            lblDeductions.Font = new Font("Arial", 12F, FontStyle.Italic);
            lblDeductions.Location = new Point(293, 431);
            lblDeductions.Name = "lblDeductions";
            lblDeductions.Size = new Size(225, 25);
            lblDeductions.TabIndex = 11;
            lblDeductions.Text = "0.00";
            lblDeductions.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRemainingBalance
            // 
            lblRemainingBalance.Location = new Point(293, 390);
            lblRemainingBalance.Name = "lblRemainingBalance";
            lblRemainingBalance.Size = new Size(225, 25);
            lblRemainingBalance.TabIndex = 10;
            lblRemainingBalance.Text = "0.00";
            lblRemainingBalance.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            label12.Location = new Point(13, 491);
            label12.Name = "label12";
            label12.Size = new Size(274, 34);
            label12.TabIndex = 15;
            label12.Text = "BILL TOTAL:";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Arial", 16.2F, FontStyle.Bold);
            lblTotal.Location = new Point(293, 491);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(225, 34);
            lblTotal.TabIndex = 14;
            lblTotal.Text = "0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubmit.Location = new Point(195, 552);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(140, 43);
            btnSubmit.TabIndex = 16;
            btnSubmit.Text = "SUBMIT";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // WaterBill
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 607);
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
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "WaterBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Real Estate Management System - New Bill [MANAGE: Water Bill]";
            Load += Manage_WaterBill_Load;
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Label label2;
        private TextBox txtPrevious;
        private TextBox txtPresent;
        private Label label3;
        private Button btnConfirm;
        private Label lblCurrentCharge;
        private Label lblConsumption;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lblDeductions;
        private Label lblRemainingBalance;
        private Label label12;
        private Label lblTotal;
        private Button btnSubmit;
    }
}