namespace Real_Estate_Management_System
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            pnlBG = new Panel();
            pcbLogo = new PictureBox();
            lblLoading = new Label();
            label1 = new Label();
            tmrUIUpdater = new System.Windows.Forms.Timer(components);
            pnlBG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlBG
            // 
            pnlBG.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlBG.BackColor = Color.FromArgb(0, 70, 67);
            pnlBG.Controls.Add(pcbLogo);
            pnlBG.Location = new Point(0, 0);
            pnlBG.Name = "pnlBG";
            pnlBG.Size = new Size(763, 414);
            pnlBG.TabIndex = 0;
            pnlBG.MouseDown += pnlBG_MouseDown;
            pnlBG.MouseMove += pnlBG_MouseMove;
            pnlBG.MouseUp += pnlBG_MouseUp;
            // 
            // pcbLogo
            // 
            pcbLogo.Image = Properties.Resources.REMS_LOGO___LIGHT;
            pcbLogo.Location = new Point(12, 7);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(737, 399);
            pcbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            pcbLogo.MouseDown += pcbLogo_MouseDown;
            pcbLogo.MouseMove += pcbLogo_MouseMove;
            pcbLogo.MouseUp += pcbLogo_MouseUp;
            // 
            // lblLoading
            // 
            lblLoading.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLoading.Location = new Point(12, 418);
            lblLoading.Name = "lblLoading";
            lblLoading.Size = new Size(506, 27);
            lblLoading.TabIndex = 1;
            lblLoading.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(524, 418);
            label1.Name = "label1";
            label1.Size = new Size(225, 27);
            label1.TabIndex = 2;
            label1.Text = "Created by: Juniper Bolabon";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tmrUIUpdater
            // 
            tmrUIUpdater.Enabled = true;
            tmrUIUpdater.Interval = 500;
            tmrUIUpdater.Tick += tmrUIUpdater_Tick;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(761, 450);
            Controls.Add(label1);
            Controls.Add(lblLoading);
            Controls.Add(pnlBG);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            FormClosing += Splash_FormClosing;
            Load += Splash_Load;
            pnlBG.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBG;
        private PictureBox pcbLogo;
        private Label lblLoading;
        private Label label1;
        private System.Windows.Forms.Timer tmrUIUpdater;
    }
}