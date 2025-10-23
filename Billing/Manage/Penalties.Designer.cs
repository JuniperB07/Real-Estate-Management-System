namespace Real_Estate_Management_System.Billing.Manage
{
    partial class Penalties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Penalties));
            dgvPenalties = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvPenalties).BeginInit();
            SuspendLayout();
            // 
            // dgvPenalties
            // 
            dgvPenalties.AllowUserToAddRows = false;
            dgvPenalties.AllowUserToDeleteRows = false;
            dgvPenalties.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPenalties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPenalties.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvPenalties.BackgroundColor = Color.FromArgb(240, 237, 229);
            dgvPenalties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPenalties.GridColor = Color.FromArgb(240, 237, 229);
            dgvPenalties.Location = new Point(12, 106);
            dgvPenalties.Name = "dgvPenalties";
            dgvPenalties.ReadOnly = true;
            dgvPenalties.RowHeadersVisible = false;
            dgvPenalties.RowHeadersWidth = 51;
            dgvPenalties.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPenalties.Size = new Size(1111, 519);
            dgvPenalties.TabIndex = 3;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1111, 55);
            label1.TabIndex = 4;
            label1.Text = "LIST OF UNPAID/PARTIALLY PAID PENALTIES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 70, 67);
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(1111, 39);
            label2.TabIndex = 5;
            label2.Text = "Tenant Name";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Penalties
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(1135, 637);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvPenalties);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Penalties";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Real Estate Management System - Manage: [LIST OF PENALTIES]";
            FormClosing += Penalties_FormClosing;
            Load += Penalties_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPenalties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPenalties;
        private Label label1;
        private Label label2;
    }
}