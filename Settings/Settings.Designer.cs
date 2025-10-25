namespace Real_Estate_Management_System.Settings
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            mnuMenu = new MenuStrip();
            tsmiBilling = new ToolStripMenuItem();
            tsmiBilling_Utilities = new ToolStripMenuItem();
            tsmiBilling_Utilities_Water = new ToolStripMenuItem();
            tsmiBilling_Utilities_Electricity = new ToolStripMenuItem();
            tsmiBilling_DueDates = new ToolStripMenuItem();
            tsmiBilling_DueDates_Utilities = new ToolStripMenuItem();
            tsmiBilling_DueDates_Rental = new ToolStripMenuItem();
            tsmiBilling_DueDates_Internet = new ToolStripMenuItem();
            tsmiBilling_Invoice = new ToolStripMenuItem();
            tsmiBilling_Invoice_InvoiceNumberPrefix = new ToolStripMenuItem();
            tsmiBilling_Invoice_PDFExportPath = new ToolStripMenuItem();
            tsmiBilling_Invoice_BusinessInformation = new ToolStripMenuItem();
            tsmiBilling_Invoice_ContactInformation = new ToolStripMenuItem();
            tsmiBilling_Invoice_BIRInformation = new ToolStripMenuItem();
            tsmiAccounts = new ToolStripMenuItem();
            tsmiAccounts_NewUserAccount = new ToolStripMenuItem();
            tsmiAccounts_EditUserAccount = new ToolStripMenuItem();
            mnuMenu.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMenu
            // 
            mnuMenu.Font = new Font("Arial", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mnuMenu.ImageScalingSize = new Size(20, 20);
            mnuMenu.Items.AddRange(new ToolStripItem[] { tsmiBilling, tsmiAccounts });
            mnuMenu.Location = new Point(0, 0);
            mnuMenu.Name = "mnuMenu";
            mnuMenu.Size = new Size(1163, 28);
            mnuMenu.TabIndex = 1;
            mnuMenu.Text = "menuStrip1";
            // 
            // tsmiBilling
            // 
            tsmiBilling.DropDownItems.AddRange(new ToolStripItem[] { tsmiBilling_Utilities, tsmiBilling_DueDates, tsmiBilling_Invoice });
            tsmiBilling.Name = "tsmiBilling";
            tsmiBilling.Size = new Size(66, 24);
            tsmiBilling.Text = "Billing";
            // 
            // tsmiBilling_Utilities
            // 
            tsmiBilling_Utilities.DropDownItems.AddRange(new ToolStripItem[] { tsmiBilling_Utilities_Water, tsmiBilling_Utilities_Electricity });
            tsmiBilling_Utilities.Name = "tsmiBilling_Utilities";
            tsmiBilling_Utilities.Size = new Size(224, 26);
            tsmiBilling_Utilities.Text = "Utilities";
            // 
            // tsmiBilling_Utilities_Water
            // 
            tsmiBilling_Utilities_Water.Name = "tsmiBilling_Utilities_Water";
            tsmiBilling_Utilities_Water.Size = new Size(224, 26);
            tsmiBilling_Utilities_Water.Text = "Water";
            tsmiBilling_Utilities_Water.Click += tsmiBilling_Utilities_Water_Click;
            // 
            // tsmiBilling_Utilities_Electricity
            // 
            tsmiBilling_Utilities_Electricity.Name = "tsmiBilling_Utilities_Electricity";
            tsmiBilling_Utilities_Electricity.Size = new Size(224, 26);
            tsmiBilling_Utilities_Electricity.Text = "Electricity";
            tsmiBilling_Utilities_Electricity.Click += tsmiBilling_Utilities_Electricity_Click;
            // 
            // tsmiBilling_DueDates
            // 
            tsmiBilling_DueDates.DropDownItems.AddRange(new ToolStripItem[] { tsmiBilling_DueDates_Utilities, tsmiBilling_DueDates_Rental, tsmiBilling_DueDates_Internet });
            tsmiBilling_DueDates.Name = "tsmiBilling_DueDates";
            tsmiBilling_DueDates.Size = new Size(224, 26);
            tsmiBilling_DueDates.Text = "Due Dates";
            // 
            // tsmiBilling_DueDates_Utilities
            // 
            tsmiBilling_DueDates_Utilities.Name = "tsmiBilling_DueDates_Utilities";
            tsmiBilling_DueDates_Utilities.Size = new Size(224, 26);
            tsmiBilling_DueDates_Utilities.Text = "Utilities";
            tsmiBilling_DueDates_Utilities.Click += tsmiBilling_DueDates_Utilities_Click;
            // 
            // tsmiBilling_DueDates_Rental
            // 
            tsmiBilling_DueDates_Rental.Name = "tsmiBilling_DueDates_Rental";
            tsmiBilling_DueDates_Rental.Size = new Size(224, 26);
            tsmiBilling_DueDates_Rental.Text = "Rental";
            // 
            // tsmiBilling_DueDates_Internet
            // 
            tsmiBilling_DueDates_Internet.Name = "tsmiBilling_DueDates_Internet";
            tsmiBilling_DueDates_Internet.Size = new Size(224, 26);
            tsmiBilling_DueDates_Internet.Text = "Internet";
            // 
            // tsmiBilling_Invoice
            // 
            tsmiBilling_Invoice.DropDownItems.AddRange(new ToolStripItem[] { tsmiBilling_Invoice_InvoiceNumberPrefix, tsmiBilling_Invoice_PDFExportPath, tsmiBilling_Invoice_BusinessInformation, tsmiBilling_Invoice_ContactInformation, tsmiBilling_Invoice_BIRInformation });
            tsmiBilling_Invoice.Name = "tsmiBilling_Invoice";
            tsmiBilling_Invoice.Size = new Size(224, 26);
            tsmiBilling_Invoice.Text = "Invoice";
            // 
            // tsmiBilling_Invoice_InvoiceNumberPrefix
            // 
            tsmiBilling_Invoice_InvoiceNumberPrefix.Name = "tsmiBilling_Invoice_InvoiceNumberPrefix";
            tsmiBilling_Invoice_InvoiceNumberPrefix.Size = new Size(253, 26);
            tsmiBilling_Invoice_InvoiceNumberPrefix.Text = "Invoice Number Prefix";
            // 
            // tsmiBilling_Invoice_PDFExportPath
            // 
            tsmiBilling_Invoice_PDFExportPath.Name = "tsmiBilling_Invoice_PDFExportPath";
            tsmiBilling_Invoice_PDFExportPath.Size = new Size(253, 26);
            tsmiBilling_Invoice_PDFExportPath.Text = "PDF Export Path";
            // 
            // tsmiBilling_Invoice_BusinessInformation
            // 
            tsmiBilling_Invoice_BusinessInformation.Name = "tsmiBilling_Invoice_BusinessInformation";
            tsmiBilling_Invoice_BusinessInformation.Size = new Size(253, 26);
            tsmiBilling_Invoice_BusinessInformation.Text = "Business Information";
            // 
            // tsmiBilling_Invoice_ContactInformation
            // 
            tsmiBilling_Invoice_ContactInformation.Name = "tsmiBilling_Invoice_ContactInformation";
            tsmiBilling_Invoice_ContactInformation.Size = new Size(253, 26);
            tsmiBilling_Invoice_ContactInformation.Text = "Contact Information";
            // 
            // tsmiBilling_Invoice_BIRInformation
            // 
            tsmiBilling_Invoice_BIRInformation.Name = "tsmiBilling_Invoice_BIRInformation";
            tsmiBilling_Invoice_BIRInformation.Size = new Size(253, 26);
            tsmiBilling_Invoice_BIRInformation.Text = "BIR Information";
            // 
            // tsmiAccounts
            // 
            tsmiAccounts.DropDownItems.AddRange(new ToolStripItem[] { tsmiAccounts_NewUserAccount, tsmiAccounts_EditUserAccount });
            tsmiAccounts.Name = "tsmiAccounts";
            tsmiAccounts.Size = new Size(91, 24);
            tsmiAccounts.Text = "Accounts";
            // 
            // tsmiAccounts_NewUserAccount
            // 
            tsmiAccounts_NewUserAccount.Name = "tsmiAccounts_NewUserAccount";
            tsmiAccounts_NewUserAccount.Size = new Size(226, 26);
            tsmiAccounts_NewUserAccount.Text = "New User Account";
            // 
            // tsmiAccounts_EditUserAccount
            // 
            tsmiAccounts_EditUserAccount.Name = "tsmiAccounts_EditUserAccount";
            tsmiAccounts_EditUserAccount.Size = new Size(226, 26);
            tsmiAccounts_EditUserAccount.Text = "Edit User Account";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 237, 229);
            ClientSize = new Size(1163, 728);
            Controls.Add(mnuMenu);
            Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(0, 70, 67);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = mnuMenu;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            FormClosing += Settings_FormClosing;
            Load += Settings_Load;
            mnuMenu.ResumeLayout(false);
            mnuMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMenu;
        private ToolStripMenuItem tsmiBilling;
        private ToolStripMenuItem tsmiBilling_Utilities;
        private ToolStripMenuItem tsmiBilling_Utilities_Water;
        private ToolStripMenuItem tsmiBilling_Utilities_Electricity;
        private ToolStripMenuItem tsmiBilling_DueDates;
        private ToolStripMenuItem tsmiBilling_DueDates_Utilities;
        private ToolStripMenuItem tsmiBilling_DueDates_Rental;
        private ToolStripMenuItem tsmiBilling_DueDates_Internet;
        private ToolStripMenuItem tsmiBilling_Invoice;
        private ToolStripMenuItem tsmiBilling_Invoice_InvoiceNumberPrefix;
        private ToolStripMenuItem tsmiBilling_Invoice_PDFExportPath;
        private ToolStripMenuItem tsmiBilling_Invoice_BusinessInformation;
        private ToolStripMenuItem tsmiBilling_Invoice_ContactInformation;
        private ToolStripMenuItem tsmiBilling_Invoice_BIRInformation;
        private ToolStripMenuItem tsmiAccounts;
        private ToolStripMenuItem tsmiAccounts_NewUserAccount;
        private ToolStripMenuItem tsmiAccounts_EditUserAccount;
    }
}