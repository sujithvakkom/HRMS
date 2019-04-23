namespace WinHRMS
{
    partial class FormAddAsset
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
            this.linkLabelSelectFile = new System.Windows.Forms.LinkLabel();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolTipSelectFile = new System.Windows.Forms.ToolTip(this.components);
            this.labelDept = new System.Windows.Forms.Label();
            this.comboBoxDept = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabelDetails = new System.Windows.Forms.LinkLabel();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.labelMessage = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.panelOptions.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.ErrorImage = global::WinHRMS.Properties.Resources.iconfinder_shield_error;
            this.pictureBoxPreview.Image = global::WinHRMS.Properties.Resources.iconfinder_icon_document_image;
            this.pictureBoxPreview.InitialImage = global::WinHRMS.Properties.Resources.iconfinder_icon_document_image;
            this.pictureBoxPreview.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(128, 128);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxPreview.TabIndex = 12;
            this.pictureBoxPreview.TabStop = false;
            // 
            // textBoxDisplayName
            // 
            this.textBoxDisplayName.Location = new System.Drawing.Point(511, 143);
            this.textBoxDisplayName.Name = "textBoxDisplayName";
            this.textBoxDisplayName.Size = new System.Drawing.Size(262, 22);
            this.textBoxDisplayName.TabIndex = 0;
            this.textBoxDisplayName.Tag = "0";
            // 
            // validThruDate
            // 
            this.validThruDate.Location = new System.Drawing.Point(510, 335);
            this.validThruDate.Name = "validThruDate";
            this.validThruDate.Size = new System.Drawing.Size(262, 22);
            this.validThruDate.TabIndex = 4;
            this.validThruDate.ValueChanged += new System.EventHandler(this.validThruDate_ValueChanged);
            // 
            // validFromDate
            // 
            this.validFromDate.Location = new System.Drawing.Point(510, 288);
            this.validFromDate.Name = "validFromDate";
            this.validFromDate.Size = new System.Drawing.Size(262, 22);
            this.validFromDate.TabIndex = 3;
            this.validFromDate.ValueChanged += new System.EventHandler(this.validFromDate_ValueChanged);
            // 
            // labelValidThru
            // 
            this.labelValidThru.AutoSize = true;
            this.labelValidThru.Location = new System.Drawing.Point(428, 338);
            this.labelValidThru.Name = "labelValidThru";
            this.labelValidThru.Size = new System.Drawing.Size(73, 17);
            this.labelValidThru.TabIndex = 7;
            this.labelValidThru.Text = "Valid Thru";
            // 
            // buttonAddDocType
            // 
            this.buttonAddDocType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAddDocType.Location = new System.Drawing.Point(749, 190);
            this.buttonAddDocType.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAddDocType.Name = "buttonAddDocType";
            this.buttonAddDocType.Size = new System.Drawing.Size(24, 24);
            this.buttonAddDocType.TabIndex = 13;
            this.buttonAddDocType.TabStop = false;
            this.buttonAddDocType.Text = "+";
            this.buttonAddDocType.UseVisualStyleBackColor = true;
            this.buttonAddDocType.Click += new System.EventHandler(this.buttonAddDocType_Click);
            // 
            // labelValidFrom
            // 
            this.labelValidFrom.AutoSize = true;
            this.labelValidFrom.Location = new System.Drawing.Point(426, 291);
            this.labelValidFrom.Name = "labelValidFrom";
            this.labelValidFrom.Size = new System.Drawing.Size(75, 17);
            this.labelValidFrom.TabIndex = 8;
            this.labelValidFrom.Text = "Valid From";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Emirates ID",
            "Passport"});
            this.comboBoxType.Location = new System.Drawing.Point(511, 190);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(229, 24);
            this.comboBoxType.TabIndex = 1;
            // 
            // labelDisplayName
            // 
            this.labelDisplayName.AutoSize = true;
            this.labelDisplayName.Location = new System.Drawing.Point(456, 146);
            this.labelDisplayName.Name = "labelDisplayName";
            this.labelDisplayName.Size = new System.Drawing.Size(45, 17);
            this.labelDisplayName.TabIndex = 9;
            this.labelDisplayName.Text = "Name";
            // 
            // labelDocType
            // 
            this.labelDocType.AutoSize = true;
            this.labelDocType.Location = new System.Drawing.Point(428, 194);
            this.labelDocType.Name = "labelDocType";
            this.labelDocType.Size = new System.Drawing.Size(73, 17);
            this.labelDocType.TabIndex = 10;
            this.labelDocType.Text = "Doc. Type";
            // 
            // linkLabelSelectFile
            // 
            this.linkLabelSelectFile.AutoEllipsis = true;
            this.linkLabelSelectFile.Location = new System.Drawing.Point(508, 102);
            this.linkLabelSelectFile.Name = "linkLabelSelectFile";
            this.linkLabelSelectFile.Size = new System.Drawing.Size(265, 16);
            this.linkLabelSelectFile.TabIndex = 0;
            this.linkLabelSelectFile.Text = "Please select file";
            this.linkLabelSelectFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelOptions.Controls.Add(this.buttonCancel);
            this.panelOptions.Controls.Add(this.buttonOK);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOptions.Location = new System.Drawing.Point(0, 540);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(794, 51);
            this.panelOptions.TabIndex = 18;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(632, 6);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 36);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonOK.Location = new System.Drawing.Point(713, 6);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 36);
            this.buttonOK.TabIndex = 6;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.pictureBoxPreview);
            this.panel1.Location = new System.Drawing.Point(12, 66);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 436);
            this.panel1.TabIndex = 19;
            // 
            // labelDept
            // 
            this.labelDept.AutoSize = true;
            this.labelDept.Location = new System.Drawing.Point(459, 243);
            this.labelDept.Name = "labelDept";
            this.labelDept.Size = new System.Drawing.Size(42, 17);
            this.labelDept.TabIndex = 10;
            this.labelDept.Text = "Dept.";
            // 
            // comboBoxDept
            // 
            this.comboBoxDept.FormattingEnabled = true;
            this.comboBoxDept.Location = new System.Drawing.Point(511, 239);
            this.comboBoxDept.Name = "comboBoxDept";
            this.comboBoxDept.Size = new System.Drawing.Size(229, 24);
            this.comboBoxDept.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(749, 239);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 13;
            this.button1.TabStop = false;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonAddDept_Click);
            // 
            // linkLabelDetails
            // 
            this.linkLabelDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelDetails.AutoSize = true;
            this.linkLabelDetails.LinkColor = System.Drawing.Color.White;
            this.linkLabelDetails.Location = new System.Drawing.Point(731, 12);
            this.linkLabelDetails.Name = "linkLabelDetails";
            this.linkLabelDetails.Size = new System.Drawing.Size(51, 17);
            this.linkLabelDetails.TabIndex = 1;
            this.linkLabelDetails.TabStop = true;
            this.linkLabelDetails.Text = "Details";
            this.linkLabelDetails.Visible = false;
            // 
            // panelMessage
            // 
            this.panelMessage.BackColor = System.Drawing.Color.DarkGreen;
            this.panelMessage.Controls.Add(this.linkLabelDetails);
            this.panelMessage.Controls.Add(this.labelMessage);
            this.panelMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMessage.ForeColor = System.Drawing.Color.White;
            this.panelMessage.Location = new System.Drawing.Point(0, 0);
            this.panelMessage.Name = "panelMessage";
            this.panelMessage.Size = new System.Drawing.Size(794, 40);
            this.panelMessage.TabIndex = 20;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(12, 12);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(94, 17);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "Fill the details";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FormAddAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 591);
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.linkLabelSelectFile);
            this.Controls.Add(this.textBoxDisplayName);
            this.Controls.Add(this.validThruDate);
            this.Controls.Add(this.validFromDate);
            this.Controls.Add(this.labelValidThru);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAddDocType);
            this.Controls.Add(this.labelValidFrom);
            this.Controls.Add(this.comboBoxDept);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelDept);
            this.Controls.Add(this.labelDisplayName);
            this.Controls.Add(this.labelDocType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddAsset";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Asset";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.panelOptions.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.TextBox textBoxDisplayName;
        private System.Windows.Forms.DateTimePicker validThruDate;
        private System.Windows.Forms.DateTimePicker validFromDate;
        private System.Windows.Forms.Label labelValidThru;
        private System.Windows.Forms.Button buttonAddDocType;
        private System.Windows.Forms.Label labelValidFrom;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelDisplayName;
        private System.Windows.Forms.Label labelDocType;
        private System.Windows.Forms.LinkLabel linkLabelSelectFile;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTipSelectFile;
        private System.Windows.Forms.Label labelDept;
        private System.Windows.Forms.ComboBox comboBoxDept;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabelDetails;
        private System.Windows.Forms.Panel panelMessage;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}