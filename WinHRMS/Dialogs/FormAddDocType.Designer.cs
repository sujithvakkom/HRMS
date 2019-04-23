namespace WinHRMS
{
    partial class FormAddDocType
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.panelMessage = new System.Windows.Forms.Panel();
            this.linkLabelDetails = new System.Windows.Forms.LinkLabel();
            this.labelMessage = new System.Windows.Forms.Label();
            this.tBDeptName = new System.Windows.Forms.TextBox();
            this.labelDeptName = new System.Windows.Forms.Label();
            this.errorProviderDeptName = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelOptions.SuspendLayout();
            this.panelMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDeptName)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(315, 8);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 36);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "&Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Location = new System.Drawing.Point(396, 8);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 36);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "&Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelOptions.Controls.Add(this.buttonCancel);
            this.panelOptions.Controls.Add(this.buttonSave);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOptions.Location = new System.Drawing.Point(0, 202);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(483, 51);
            this.panelOptions.TabIndex = 6;
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
            this.panelMessage.Size = new System.Drawing.Size(483, 40);
            this.panelMessage.TabIndex = 7;
            // 
            // linkLabelDetails
            // 
            this.linkLabelDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabelDetails.AutoSize = true;
            this.linkLabelDetails.LinkColor = System.Drawing.Color.White;
            this.linkLabelDetails.Location = new System.Drawing.Point(420, 12);
            this.linkLabelDetails.Name = "linkLabelDetails";
            this.linkLabelDetails.Size = new System.Drawing.Size(51, 17);
            this.linkLabelDetails.TabIndex = 1;
            this.linkLabelDetails.TabStop = true;
            this.linkLabelDetails.Text = "Details";
            this.linkLabelDetails.Visible = false;
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
            // tBDeptName
            // 
            this.tBDeptName.Location = new System.Drawing.Point(215, 115);
            this.tBDeptName.Name = "tBDeptName";
            this.tBDeptName.Size = new System.Drawing.Size(154, 22);
            this.tBDeptName.TabIndex = 8;
            // 
            // labelDeptName
            // 
            this.labelDeptName.AutoSize = true;
            this.labelDeptName.Location = new System.Drawing.Point(113, 118);
            this.labelDeptName.Name = "labelDeptName";
            this.labelDeptName.Size = new System.Drawing.Size(73, 17);
            this.labelDeptName.TabIndex = 9;
            this.labelDeptName.Text = "Doc. Type";
            // 
            // errorProviderDeptName
            // 
            this.errorProviderDeptName.ContainerControl = this;
            // 
            // FormAddDocType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 253);
            this.Controls.Add(this.tBDeptName);
            this.Controls.Add(this.labelDeptName);
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.panelOptions);
            this.Name = "FormAddDocType";
            this.ShowIcon = false;
            this.Text = "Add Dept";
            this.panelOptions.ResumeLayout(false);
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDeptName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.Panel panelMessage;
        private System.Windows.Forms.LinkLabel linkLabelDetails;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox tBDeptName;
        private System.Windows.Forms.Label labelDeptName;
        private System.Windows.Forms.ErrorProvider errorProviderDeptName;
    }
}