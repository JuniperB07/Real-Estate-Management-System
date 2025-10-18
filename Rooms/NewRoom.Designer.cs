namespace Real_Estate_Management_System.Rooms
{
    partial class NewRoom
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
            pnlHeader = new Panel();
            lblBuildingName = new Label();
            label1 = new Label();
            txtRoomName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            btnSave = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlHeader.BackColor = Color.FromArgb(0, 70, 67);
            pnlHeader.Controls.Add(lblBuildingName);
            pnlHeader.Controls.Add(label1);
            pnlHeader.ForeColor = Color.FromArgb(240, 237, 229);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(621, 167);
            pnlHeader.TabIndex = 2;
            // 
            // lblBuildingName
            // 
            lblBuildingName.BackColor = Color.Transparent;
            lblBuildingName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBuildingName.Location = new Point(12, 99);
            lblBuildingName.Name = "lblBuildingName";
            lblBuildingName.Size = new Size(596, 68);
            lblBuildingName.TabIndex = 8;
            lblBuildingName.Text = "This new room will be added under Building Name:";
            lblBuildingName.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(240, 237, 229);
            label1.Location = new Point(12, 6);
            label1.Name = "label1";
            label1.Size = new Size(596, 89);
            label1.TabIndex = 5;
            label1.Text = "ROOM MANAGEMENT\r\nADD NEW ROOM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRoomName
            // 
            txtRoomName.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoomName.ForeColor = Color.FromArgb(0, 70, 67);
            txtRoomName.Location = new Point(244, 183);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.Size = new Size(364, 34);
            txtRoomName.TabIndex = 10;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 183);
            label4.Name = "label4";
            label4.Size = new Size(215, 34);
            label4.TabIndex = 9;
            label4.Text = "Room Name:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 220);
            label2.Name = "label2";
            label2.Size = new Size(596, 32);
            label2.TabIndex = 11;
            label2.Text = "*New rooms will default to status 'Vacant' with no occupying tenant.";
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
            btnSave.Location = new Point(206, 261);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(203, 44);
            btnSave.TabIndex = 29;
            btnSave.Text = "SAVE CHANGES";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // NewRoom
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(620, 317);
            Controls.Add(btnSave);
            Controls.Add(label2);
            Controls.Add(txtRoomName);
            Controls.Add(label4);
            Controls.Add(pnlHeader);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "NewRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Room Management - Add New Room";
            Load += NewRoom_Load;
            pnlHeader.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label label1;
        private Label lblBuildingName;
        private TextBox txtRoomName;
        private Label label4;
        private Label label2;
        private Button btnSave;
    }
}