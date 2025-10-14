namespace Real_Estate_Management_System.Dialogs
{
    partial class MSGBox_OK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MSGBox_OK));
            pictureBox1 = new PictureBox();
            rtxtMessage = new RichTextBox();
            btnOK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.REMS_LOGO___DARK;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 218);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // rtxtMessage
            // 
            rtxtMessage.BorderStyle = BorderStyle.None;
            rtxtMessage.Location = new Point(222, 12);
            rtxtMessage.Name = "rtxtMessage";
            rtxtMessage.ReadOnly = true;
            rtxtMessage.Size = new Size(465, 161);
            rtxtMessage.TabIndex = 1;
            rtxtMessage.Text = "";
            // 
            // btnOK
            // 
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOK.Location = new Point(385, 189);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(138, 41);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // MSGBox_OK
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 242);
            Controls.Add(btnOK);
            Controls.Add(rtxtMessage);
            Controls.Add(pictureBox1);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MSGBox_OK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MSGBox_OK";
            FormClosing += MSGBox_OK_FormClosing;
            Load += MSGBox_OK_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private RichTextBox rtxtMessage;
        private Button btnOK;
    }
}