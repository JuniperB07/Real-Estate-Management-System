namespace Real_Estate_Management_System.Payments
{
    partial class MakePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakePayment));
            pnlHeader = new Panel();
            lblHeader = new Label();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackgroundImage = Properties.Resources.REMS_MAKE_PAYMENT_RENTAL;
            pnlHeader.BackgroundImageLayout = ImageLayout.Stretch;
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Location = new Point(-1, -1);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(644, 131);
            pnlHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.BackColor = Color.Transparent;
            lblHeader.Font = new Font("Arial Black", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = SystemColors.ControlLightLight;
            lblHeader.Location = new Point(181, 10);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(450, 108);
            lblHeader.TabIndex = 22;
            lblHeader.Text = "MAKE PAYMENT:\r\nELECTRICITY BILL";
            lblHeader.TextAlign = ContentAlignment.TopCenter;
            // 
            // MakePayment
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(642, 674);
            Controls.Add(pnlHeader);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "MakePayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Real Estate Management System - Make Payment [ELECTRICITY]";
            Load += MakePayment_Load;
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
    }
}