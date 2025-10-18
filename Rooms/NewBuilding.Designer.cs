namespace Real_Estate_Management_System.Rooms
{
    partial class NewBuilding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBuilding));
            pnlHeader = new Panel();
            label1 = new Label();
            label4 = new Label();
            txtBuildingName = new TextBox();
            txtBuildingAddress = new TextBox();
            label2 = new Label();
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
            pnlHeader.Size = new Size(609, 167);
            pnlHeader.TabIndex = 1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(585, 161);
            label1.TabIndex = 5;
            label1.Text = "ROOM MANAGEMENT\r\nADD NEW BUILDING";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(215, 34);
            label4.TabIndex = 7;
            label4.Text = "Building Name:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // txtBuildingName
            // 
            txtBuildingName.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuildingName.ForeColor = Color.FromArgb(0, 70, 67);
            txtBuildingName.Location = new Point(233, 185);
            txtBuildingName.Name = "txtBuildingName";
            txtBuildingName.Size = new Size(364, 34);
            txtBuildingName.TabIndex = 8;
            txtBuildingName.TextChanged += txtBuildingName_TextChanged;
            // 
            // txtBuildingAddress
            // 
            txtBuildingAddress.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuildingAddress.ForeColor = Color.FromArgb(0, 70, 67);
            txtBuildingAddress.Location = new Point(233, 230);
            txtBuildingAddress.Multiline = true;
            txtBuildingAddress.Name = "txtBuildingAddress";
            txtBuildingAddress.Size = new Size(364, 81);
            txtBuildingAddress.TabIndex = 10;
            txtBuildingAddress.TextChanged += txtBuildingAddress_TextChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 230);
            label2.Name = "label2";
            label2.Size = new Size(215, 34);
            label2.TabIndex = 9;
            label2.Text = "Building Address:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(0, 70, 67);
            btnSave.FlatAppearance.BorderSize = 2;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnSave.ForeColor = Color.FromArgb(0, 70, 67);
            btnSave.Location = new Point(197, 334);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 44);
            btnSave.TabIndex = 28;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // NewBuilding
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(609, 390);
            Controls.Add(btnSave);
            Controls.Add(txtBuildingAddress);
            Controls.Add(label2);
            Controls.Add(txtBuildingName);
            Controls.Add(label4);
            Controls.Add(pnlHeader);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "NewBuilding";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Room Management - Add New Building";
            FormClosing += NewBuilding_FormClosing;
            Load += NewBuilding_Load;
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Label label4;
        private TextBox txtBuildingName;
        private TextBox txtBuildingAddress;
        private Label label2;
        private Button btnSave;
    }
}