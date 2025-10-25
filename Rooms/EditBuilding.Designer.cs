namespace Real_Estate_Management_System.Rooms
{
    partial class EditBuilding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBuilding));
            pnlHeader = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtRentalRate = new TextBox();
            label3 = new Label();
            btnSave = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackColor = Color.FromArgb(0, 70, 67);
            pnlHeader.Controls.Add(label1);
            pnlHeader.ForeColor = Color.FromArgb(240, 237, 229);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(633, 167);
            pnlHeader.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(607, 161);
            label1.TabIndex = 5;
            label1.Text = "ROOM MANAGEMENT\r\nEDIT BUILDING RENTAL RATE";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 70, 67);
            label2.Location = new Point(12, 180);
            label2.Name = "label2";
            label2.Size = new Size(607, 34);
            label2.TabIndex = 6;
            label2.Text = "BUILDING NAME";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtRentalRate
            // 
            txtRentalRate.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRentalRate.ForeColor = Color.FromArgb(0, 70, 67);
            txtRentalRate.Location = new Point(303, 240);
            txtRentalRate.Name = "txtRentalRate";
            txtRentalRate.Size = new Size(316, 34);
            txtRentalRate.TabIndex = 16;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 240);
            label3.Name = "label3";
            label3.Size = new Size(285, 34);
            label3.TabIndex = 15;
            label3.Text = "Rental Rate:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 67);
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(0, 70, 67);
            btnSave.Location = new Point(209, 309);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 44);
            btnSave.TabIndex = 31;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EditBuilding
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(631, 365);
            Controls.Add(btnSave);
            Controls.Add(txtRentalRate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pnlHeader);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "EditBuilding";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Real Estate Management System - Edit Building Rental Rate";
            Load += EditBuilding_Load;
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Label label2;
        private TextBox txtRentalRate;
        private Label label3;
        private Button btnSave;
    }
}