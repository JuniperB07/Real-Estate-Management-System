namespace Real_Estate_Management_System.Internet
{
    partial class NewPlan
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
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            cmbBuilding = new ComboBox();
            label2 = new Label();
            txtPlanName = new TextBox();
            txtPlanPrice = new TextBox();
            label4 = new Label();
            cmbAvailabilityStatus = new ComboBox();
            label5 = new Label();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(1, 53, 60);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.ForeColor = Color.FromArgb(240, 237, 229);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(706, 162);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(156, 9);
            label1.Name = "label1";
            label1.Size = new Size(547, 149);
            label1.TabIndex = 6;
            label1.Text = "INTERNET SERVICE MANAGER\r\nCREATE NEW PLAN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.REMS_INTERNET_NEW_PLAN;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(138, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 190);
            label3.Name = "label3";
            label3.Size = new Size(280, 31);
            label3.TabIndex = 9;
            label3.Text = "Select Building:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbBuilding
            // 
            cmbBuilding.BackColor = Color.FromArgb(240, 237, 229);
            cmbBuilding.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuilding.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBuilding.ForeColor = Color.FromArgb(1, 53, 60);
            cmbBuilding.FormattingEnabled = true;
            cmbBuilding.Location = new Point(298, 188);
            cmbBuilding.Name = "cmbBuilding";
            cmbBuilding.Size = new Size(396, 35);
            cmbBuilding.TabIndex = 12;
            cmbBuilding.SelectedIndexChanged += cmbBuilding_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 238);
            label2.Name = "label2";
            label2.Size = new Size(280, 31);
            label2.TabIndex = 13;
            label2.Text = "Plan Name:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPlanName
            // 
            txtPlanName.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlanName.ForeColor = Color.FromArgb(1, 53, 60);
            txtPlanName.Location = new Point(298, 236);
            txtPlanName.Name = "txtPlanName";
            txtPlanName.Size = new Size(396, 34);
            txtPlanName.TabIndex = 14;
            txtPlanName.TextChanged += txtPlanName_TextChanged;
            // 
            // txtPlanPrice
            // 
            txtPlanPrice.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPlanPrice.ForeColor = Color.FromArgb(1, 53, 60);
            txtPlanPrice.Location = new Point(298, 283);
            txtPlanPrice.Name = "txtPlanPrice";
            txtPlanPrice.Size = new Size(396, 34);
            txtPlanPrice.TabIndex = 16;
            txtPlanPrice.TextChanged += txtPlanPrice_TextChanged;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 285);
            label4.Name = "label4";
            label4.Size = new Size(280, 31);
            label4.TabIndex = 15;
            label4.Text = "Plan Price:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbAvailabilityStatus
            // 
            cmbAvailabilityStatus.BackColor = Color.FromArgb(240, 237, 229);
            cmbAvailabilityStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAvailabilityStatus.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbAvailabilityStatus.ForeColor = Color.FromArgb(1, 53, 60);
            cmbAvailabilityStatus.FormattingEnabled = true;
            cmbAvailabilityStatus.Location = new Point(298, 330);
            cmbAvailabilityStatus.Name = "cmbAvailabilityStatus";
            cmbAvailabilityStatus.Size = new Size(396, 35);
            cmbAvailabilityStatus.TabIndex = 18;
            cmbAvailabilityStatus.SelectedIndexChanged += cmbAvailabilityStatus_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 332);
            label5.Name = "label5";
            label5.Size = new Size(280, 31);
            label5.TabIndex = 17;
            label5.Text = "Availability Status:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 67);
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(0, 70, 67);
            btnSave.Location = new Point(247, 394);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 44);
            btnSave.TabIndex = 29;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // NewPlan
            // 
            AutoScaleDimensions = new SizeF(10F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(706, 450);
            Controls.Add(btnSave);
            Controls.Add(cmbAvailabilityStatus);
            Controls.Add(label5);
            Controls.Add(txtPlanPrice);
            Controls.Add(label4);
            Controls.Add(txtPlanName);
            Controls.Add(label2);
            Controls.Add(cmbBuilding);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(1, 53, 60);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4);
            Name = "NewPlan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Internet Service Manager - Create New Plan";
            Load += NewPlan_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private ComboBox cmbBuilding;
        private Label label2;
        private TextBox txtPlanName;
        private TextBox txtPlanPrice;
        private Label label4;
        private ComboBox cmbAvailabilityStatus;
        private Label label5;
        private Button btnSave;
    }
}