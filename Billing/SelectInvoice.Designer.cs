namespace Real_Estate_Management_System.Billing
{
    partial class SelectInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectInvoice));
            dgvInvoices = new DataGridView();
            txtSearchTenant = new TextBox();
            lstTenantsList = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            SuspendLayout();
            // 
            // dgvInvoices
            // 
            dgvInvoices.AllowUserToAddRows = false;
            dgvInvoices.AllowUserToDeleteRows = false;
            dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoices.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgvInvoices.BackgroundColor = Color.FromArgb(240, 237, 229);
            dgvInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInvoices.GridColor = Color.FromArgb(240, 237, 229);
            dgvInvoices.Location = new Point(367, 12);
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.ReadOnly = true;
            dgvInvoices.RowHeadersVisible = false;
            dgvInvoices.RowHeadersWidth = 51;
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoices.Size = new Size(757, 571);
            dgvInvoices.TabIndex = 3;
            dgvInvoices.CellContentDoubleClick += dgvInvoices_CellContentDoubleClick;
            // 
            // txtSearchTenant
            // 
            txtSearchTenant.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearchTenant.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchTenant.BorderStyle = BorderStyle.FixedSingle;
            txtSearchTenant.Font = new Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearchTenant.ForeColor = Color.FromArgb(0, 70, 67);
            txtSearchTenant.Location = new Point(12, 12);
            txtSearchTenant.Name = "txtSearchTenant";
            txtSearchTenant.PlaceholderText = "Search Tenant...";
            txtSearchTenant.Size = new Size(349, 34);
            txtSearchTenant.TabIndex = 4;
            txtSearchTenant.TextChanged += txtSearchTenant_TextChanged;
            // 
            // lstTenantsList
            // 
            lstTenantsList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstTenantsList.BackColor = Color.FromArgb(240, 237, 229);
            lstTenantsList.BorderStyle = BorderStyle.FixedSingle;
            lstTenantsList.ForeColor = Color.FromArgb(0, 70, 67);
            lstTenantsList.FormattingEnabled = true;
            lstTenantsList.ItemHeight = 23;
            lstTenantsList.Location = new Point(12, 52);
            lstTenantsList.Name = "lstTenantsList";
            lstTenantsList.Size = new Size(349, 531);
            lstTenantsList.TabIndex = 5;
            lstTenantsList.MouseDoubleClick += lstTenantsList_MouseDoubleClick;
            // 
            // SelectInvoice
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(1136, 593);
            Controls.Add(lstTenantsList);
            Controls.Add(txtSearchTenant);
            Controls.Add(dgvInvoices);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "SelectInvoice";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Real Estate Management System - Billing [SELECT INVOICE]";
            Load += SelectInvoice_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvInvoices;
        private TextBox txtSearchTenant;
        private ListBox lstTenantsList;
    }
}