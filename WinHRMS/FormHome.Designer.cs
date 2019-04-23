namespace WinHRMS
{
    partial class FormHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.groupBoxProperties = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelImage = new System.Windows.Forms.Panel();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.textBoxDisplayName = new System.Windows.Forms.TextBox();
            this.validThruDate = new System.Windows.Forms.DateTimePicker();
            this.validFromDate = new System.Windows.Forms.DateTimePicker();
            this.labelValidThru = new System.Windows.Forms.Label();
            this.buttonAddDocType = new System.Windows.Forms.Button();
            this.labelValidFrom = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelDisplayName = new System.Windows.Forms.Label();
            this.labelDocType = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DCEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DCDisplay = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCValidFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCValidThru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DCDaysToExpairy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStripAsset = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxProperties.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStripAsset.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFilters.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(676, 100);
            this.groupBoxFilters.TabIndex = 0;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "&Filters";
            // 
            // groupBoxProperties
            // 
            this.groupBoxProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProperties.Controls.Add(this.buttonSave);
            this.groupBoxProperties.Controls.Add(this.panel1);
            this.groupBoxProperties.Location = new System.Drawing.Point(703, 12);
            this.groupBoxProperties.Name = "groupBoxProperties";
            this.groupBoxProperties.Size = new System.Drawing.Size(422, 633);
            this.groupBoxProperties.TabIndex = 2;
            this.groupBoxProperties.TabStop = false;
            this.groupBoxProperties.Text = "&Properties";
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(318, 584);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(81, 34);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.panelImage);
            this.panel1.Controls.Add(this.textBoxDisplayName);
            this.panel1.Controls.Add(this.validThruDate);
            this.panel1.Controls.Add(this.validFromDate);
            this.panel1.Controls.Add(this.labelValidThru);
            this.panel1.Controls.Add(this.buttonAddDocType);
            this.panel1.Controls.Add(this.labelValidFrom);
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Controls.Add(this.labelDisplayName);
            this.panel1.Controls.Add(this.labelDocType);
            this.panel1.Location = new System.Drawing.Point(15, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 546);
            this.panel1.TabIndex = 5;
            // 
            // panelImage
            // 
            this.panelImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelImage.AutoScroll = true;
            this.panelImage.Controls.Add(this.pictureBoxPreview);
            this.panelImage.Location = new System.Drawing.Point(4, 3);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(394, 417);
            this.panelImage.TabIndex = 7;
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.ErrorImage = global::WinHRMS.Properties.Resources.iconfinder_shield_error;
            this.pictureBoxPreview.InitialImage = global::WinHRMS.Properties.Resources.iconfinder_icon_document_image;
            this.pictureBoxPreview.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(394, 417);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPreview.TabIndex = 3;
            this.pictureBoxPreview.TabStop = false;
            // 
            // textBoxDisplayName
            // 
            this.textBoxDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxDisplayName.Location = new System.Drawing.Point(91, 426);
            this.textBoxDisplayName.Name = "textBoxDisplayName";
            this.textBoxDisplayName.Size = new System.Drawing.Size(262, 22);
            this.textBoxDisplayName.TabIndex = 6;
            // 
            // validThruDate
            // 
            this.validThruDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.validThruDate.Location = new System.Drawing.Point(91, 513);
            this.validThruDate.Name = "validThruDate";
            this.validThruDate.Size = new System.Drawing.Size(262, 22);
            this.validThruDate.TabIndex = 5;
            // 
            // validFromDate
            // 
            this.validFromDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.validFromDate.Location = new System.Drawing.Point(91, 485);
            this.validFromDate.Name = "validFromDate";
            this.validFromDate.Size = new System.Drawing.Size(262, 22);
            this.validFromDate.TabIndex = 5;
            // 
            // labelValidThru
            // 
            this.labelValidThru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValidThru.AutoSize = true;
            this.labelValidThru.Location = new System.Drawing.Point(3, 518);
            this.labelValidThru.Name = "labelValidThru";
            this.labelValidThru.Size = new System.Drawing.Size(73, 17);
            this.labelValidThru.TabIndex = 0;
            this.labelValidThru.Text = "Valid Thru";
            // 
            // buttonAddDocType
            // 
            this.buttonAddDocType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddDocType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddDocType.Location = new System.Drawing.Point(329, 454);
            this.buttonAddDocType.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddDocType.Name = "buttonAddDocType";
            this.buttonAddDocType.Size = new System.Drawing.Size(24, 24);
            this.buttonAddDocType.TabIndex = 4;
            this.buttonAddDocType.Text = "+";
            this.buttonAddDocType.UseVisualStyleBackColor = true;
            // 
            // labelValidFrom
            // 
            this.labelValidFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelValidFrom.AutoSize = true;
            this.labelValidFrom.Location = new System.Drawing.Point(1, 490);
            this.labelValidFrom.Name = "labelValidFrom";
            this.labelValidFrom.Size = new System.Drawing.Size(75, 17);
            this.labelValidFrom.TabIndex = 0;
            this.labelValidFrom.Text = "Valid From";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Emirates ID",
            "Passport"});
            this.comboBoxType.Location = new System.Drawing.Point(91, 454);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(229, 24);
            this.comboBoxType.TabIndex = 1;
            // 
            // labelDisplayName
            // 
            this.labelDisplayName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDisplayName.AutoSize = true;
            this.labelDisplayName.Location = new System.Drawing.Point(31, 429);
            this.labelDisplayName.Name = "labelDisplayName";
            this.labelDisplayName.Size = new System.Drawing.Size(45, 17);
            this.labelDisplayName.TabIndex = 0;
            this.labelDisplayName.Text = "Name";
            // 
            // labelDocType
            // 
            this.labelDocType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDocType.AutoSize = true;
            this.labelDocType.Location = new System.Drawing.Point(3, 457);
            this.labelDocType.Name = "labelDocType";
            this.labelDocType.Size = new System.Drawing.Size(73, 17);
            this.labelDocType.TabIndex = 0;
            this.labelDocType.Text = "Doc. Type";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DCEdit,
            this.DCDisplay,
            this.DCName,
            this.DCType,
            this.DCValidFrom,
            this.DCValidThru,
            this.DCDaysToExpairy});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStripAsset;
            this.dataGridView1.Location = new System.Drawing.Point(12, 118);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(676, 527);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DCEdit
            // 
            this.DCEdit.FillWeight = 10F;
            this.DCEdit.HeaderText = "Edit";
            this.DCEdit.Name = "DCEdit";
            this.DCEdit.ReadOnly = true;
            this.DCEdit.Text = "Edit";
            this.DCEdit.UseColumnTextForLinkValue = true;
            // 
            // DCDisplay
            // 
            this.DCDisplay.FillWeight = 10F;
            this.DCDisplay.HeaderText = "Display";
            this.DCDisplay.Name = "DCDisplay";
            this.DCDisplay.ReadOnly = true;
            this.DCDisplay.Text = "Display";
            this.DCDisplay.UseColumnTextForLinkValue = true;
            // 
            // DCName
            // 
            this.DCName.DataPropertyName = "AssetName";
            this.DCName.FillWeight = 25F;
            this.DCName.HeaderText = "Name";
            this.DCName.Name = "DCName";
            this.DCName.ReadOnly = true;
            // 
            // DCType
            // 
            this.DCType.DataPropertyName = "AssetType";
            this.DCType.FillWeight = 10F;
            this.DCType.HeaderText = "Type";
            this.DCType.Name = "DCType";
            this.DCType.ReadOnly = true;
            // 
            // DCValidFrom
            // 
            this.DCValidFrom.DataPropertyName = "AssetValidFrom";
            this.DCValidFrom.FillWeight = 20F;
            this.DCValidFrom.HeaderText = "Valid From";
            this.DCValidFrom.Name = "DCValidFrom";
            this.DCValidFrom.ReadOnly = true;
            // 
            // DCValidThru
            // 
            this.DCValidThru.DataPropertyName = "AssetValidThru";
            this.DCValidThru.FillWeight = 20F;
            this.DCValidThru.HeaderText = "Valid Thru";
            this.DCValidThru.Name = "DCValidThru";
            this.DCValidThru.ReadOnly = true;
            // 
            // DCDaysToExpairy
            // 
            this.DCDaysToExpairy.DataPropertyName = "DaysToExpairy";
            this.DCDaysToExpairy.FillWeight = 5F;
            this.DCDaysToExpairy.HeaderText = "Days To Expiry";
            this.DCDaysToExpairy.Name = "DCDaysToExpairy";
            this.DCDaysToExpairy.ReadOnly = true;
            // 
            // contextMenuStripAsset
            // 
            this.contextMenuStripAsset.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripAsset.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem});
            this.contextMenuStripAsset.Name = "contextMenuStripAsset";
            this.contextMenuStripAsset.Size = new System.Drawing.Size(107, 28);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 657);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxProperties);
            this.Controls.Add(this.groupBoxFilters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormHome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.groupBoxProperties.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStripAsset.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.GroupBox groupBoxProperties;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelDocType;
        private System.Windows.Forms.Label labelValidThru;
        private System.Windows.Forms.Label labelValidFrom;
        private System.Windows.Forms.Button buttonAddDocType;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.DateTimePicker validFromDate;
        private System.Windows.Forms.DateTimePicker validThruDate;
        private System.Windows.Forms.TextBox textBoxDisplayName;
        private System.Windows.Forms.Label labelDisplayName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAsset;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.DataGridViewLinkColumn DCEdit;
        private System.Windows.Forms.DataGridViewLinkColumn DCDisplay;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCType;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCValidFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCValidThru;
        private System.Windows.Forms.DataGridViewTextBoxColumn DCDaysToExpairy;
        private System.Windows.Forms.Panel panelImage;
    }
}