namespace Real_Estate_Management_System.Tenants.Edit
{
    partial class EditEmergency
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditEmergency));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            txtEmergencyContact = new TextBox();
            label8 = new Label();
            txtPhone = new TextBox();
            label2 = new Label();
            txtRelationship = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            btnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(110, 14, 10);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(-1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(780, 167);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(158, 6);
            label1.Name = "label1";
            label1.Size = new Size(622, 161);
            label1.TabIndex = 5;
            label1.Text = "TENANT MANAGEMENT\r\nEDIT\r\nEMERGENCY INFORMATION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.REMS_TENANTS_EDIT_EMERGENCY_INFO;
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 139);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtEmergencyContact
            // 
            txtEmergencyContact.BackColor = Color.White;
            txtEmergencyContact.BorderStyle = BorderStyle.FixedSingle;
            txtEmergencyContact.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmergencyContact.ForeColor = Color.FromArgb(0, 70, 67);
            txtEmergencyContact.Location = new Point(322, 181);
            txtEmergencyContact.Name = "txtEmergencyContact";
            txtEmergencyContact.Size = new Size(447, 30);
            txtEmergencyContact.TabIndex = 18;
            txtEmergencyContact.TextChanged += txtEmergencyContact_TextChanged;
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Arial", 12F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(0, 70, 67);
            label8.Location = new Point(12, 184);
            label8.Name = "label8";
            label8.Size = new Size(304, 27);
            label8.TabIndex = 17;
            label8.Text = "Emergency Contact:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPhone
            // 
            txtPhone.BackColor = Color.White;
            txtPhone.BorderStyle = BorderStyle.FixedSingle;
            txtPhone.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhone.ForeColor = Color.FromArgb(0, 70, 67);
            txtPhone.Location = new Point(322, 222);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(447, 30);
            txtPhone.TabIndex = 20;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 70, 67);
            label2.Location = new Point(12, 225);
            label2.Name = "label2";
            label2.Size = new Size(304, 27);
            label2.TabIndex = 19;
            label2.Text = "Phone/Email:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // txtRelationship
            // 
            txtRelationship.BackColor = Color.White;
            txtRelationship.BorderStyle = BorderStyle.FixedSingle;
            txtRelationship.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRelationship.ForeColor = Color.FromArgb(0, 70, 67);
            txtRelationship.Location = new Point(322, 263);
            txtRelationship.Name = "txtRelationship";
            txtRelationship.Size = new Size(447, 30);
            txtRelationship.TabIndex = 22;
            txtRelationship.TextChanged += txtRelationship_TextChanged;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial", 12F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 70, 67);
            label3.Location = new Point(12, 266);
            label3.Name = "label3";
            label3.Size = new Size(304, 27);
            label3.TabIndex = 21;
            label3.Text = "Relationship:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.White;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAddress.ForeColor = Color.FromArgb(0, 70, 67);
            txtAddress.Location = new Point(322, 304);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(447, 135);
            txtAddress.TabIndex = 24;
            txtAddress.TextChanged += txtAddress_TextChanged;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 70, 67);
            label4.Location = new Point(12, 307);
            label4.Name = "label4";
            label4.Size = new Size(304, 27);
            label4.TabIndex = 23;
            label4.Text = "Address:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 67);
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(0, 70, 67);
            btnSave.Location = new Point(288, 457);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 44);
            btnSave.TabIndex = 25;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EditEmergency
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(777, 513);
            Controls.Add(btnSave);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtRelationship);
            Controls.Add(label3);
            Controls.Add(txtPhone);
            Controls.Add(label2);
            Controls.Add(txtEmergencyContact);
            Controls.Add(label8);
            Controls.Add(panel1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "EditEmergency";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditEmergency";
            Load += EditEmergency_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtEmergencyContact;
        private Label label8;
        private TextBox txtPhone;
        private Label label2;
        private TextBox txtRelationship;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private Button btnSave;
    }
}