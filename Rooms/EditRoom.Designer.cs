namespace Real_Estate_Management_System.Rooms
{
    partial class EditRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRoom));
            pnlHeader = new Panel();
            label1 = new Label();
            label4 = new Label();
            cmbBuilding = new ComboBox();
            txtRoomName = new TextBox();
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
            pnlHeader.Size = new Size(621, 167);
            pnlHeader.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(596, 161);
            label1.TabIndex = 5;
            label1.Text = "ROOM MANAGEMENT\r\nEDIT ROOM INFORMATION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 187);
            label4.Name = "label4";
            label4.Size = new Size(215, 34);
            label4.TabIndex = 11;
            label4.Text = "Building:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // cmbBuilding
            // 
            cmbBuilding.BackColor = Color.FromArgb(240, 237, 229);
            cmbBuilding.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBuilding.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbBuilding.ForeColor = Color.FromArgb(0, 70, 67);
            cmbBuilding.FormattingEnabled = true;
            cmbBuilding.Location = new Point(244, 185);
            cmbBuilding.Name = "cmbBuilding";
            cmbBuilding.Size = new Size(364, 34);
            cmbBuilding.TabIndex = 12;
            cmbBuilding.SelectedIndexChanged += cmbBuilding_SelectedIndexChanged;
            // 
            // txtRoomName
            // 
            txtRoomName.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomName.ForeColor = Color.FromArgb(0, 70, 67);
            txtRoomName.Location = new Point(244, 233);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(364, 34);
            txtRoomName.TabIndex = 14;
            txtRoomName.TextChanged += txtRoomName_TextChanged;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 233);
            label2.Name = "label2";
            label2.Size = new Size(215, 34);
            label2.TabIndex = 13;
            label2.Text = "Room Name:";
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
            btnSave.Location = new Point(206, 291);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 44);
            btnSave.TabIndex = 30;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // EditRoom
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(620, 347);
            Controls.Add(btnSave);
            Controls.Add(txtRoomName);
            Controls.Add(label2);
            Controls.Add(cmbBuilding);
            Controls.Add(label4);
            Controls.Add(pnlHeader);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "EditRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Room Management - Edit Room Information";
            Load += EditRoom_Load;
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Label label4;
        private ComboBox cmbBuilding;
        private TextBox txtRoomName;
        private Label label2;
        private Button btnSave;
    }
}