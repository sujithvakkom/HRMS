namespace WinHRMS
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labelUserName = new System.Windows.Forms.Label();
            this.tBUserName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.tBPassword = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.errorProviderLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.panelMessage = new System.Windows.Forms.Panel();
            this.labelMessage = new System.Windows.Forms.Label();
            this.panelOptions = new System.Windows.Forms.Panel();
            this.linkLabelDetails = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).BeginInit();
            this.panelMessage.SuspendLayout();
            this.panelOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(14, 52);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(79, 17);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User &Name";
            // 
            // tBUserName
            // 
            this.tBUserName.Location = new System.Drawing.Point(116, 49);
            this.tBUserName.Name = "tBUserName";
            this.tBUserName.Size = new System.Drawing.Size(154, 22);
            this.tBUserName.TabIndex = 0;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(24, 85);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "&Password";
            // 
            // tBPassword
            // 
            this.tBPassword.Location = new System.Drawing.Point(116, 82);
            this.tBPassword.Name = "tBPassword";
            this.tBPassword.Size = new System.Drawing.Size(154, 22);
            this.tBPassword.TabIndex = 1;
            this.tBPassword.UseSystemPasswordChar = true;
            this.tBPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPassword_KeyPress);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(135, 7);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 36);
            this.buttonCancel.TabIndex = 3;
            this.buttonCancel.Text = "&Close";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(216, 7);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 36);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "&OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // errorProviderLogin
            // 
            this.errorProviderLogin.ContainerControl = this;
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
            this.panelMessage.Size = new System.Drawing.Size(313, 40);
            this.panelMessage.TabIndex = 4;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(12, 12);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(90, 17);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Text = "Please Login";
            // 
            // panelOptions
            // 
            this.panelOptions.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelOptions.Controls.Add(this.buttonCancel);
            this.panelOptions.Controls.Add(this.buttonOK);
            this.panelOptions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelOptions.Location = new System.Drawing.Point(0, 113);
            this.panelOptions.Name = "panelOptions";
            this.panelOptions.Size = new System.Drawing.Size(313, 51);
            this.panelOptions.TabIndex = 5;
            // 
            // linkLabelDetails
            // 
            this.linkLabelDetails.AutoSize = true;
            this.linkLabelDetails.LinkColor = System.Drawing.Color.White;
            this.linkLabelDetails.Location = new System.Drawing.Point(250, 12);
            this.linkLabelDetails.Name = "linkLabelDetails";
            this.linkLabelDetails.Size = new System.Drawing.Size(51, 17);
            this.linkLabelDetails.TabIndex = 1;
            this.linkLabelDetails.TabStop = true;
            this.linkLabelDetails.Text = "Details";
            this.linkLabelDetails.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 164);
            this.ControlBox = false;
            this.Controls.Add(this.panelOptions);
            this.Controls.Add(this.panelMessage);
            this.Controls.Add(this.tBPassword);
            this.Controls.Add(this.tBUserName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLogin)).EndInit();
            this.panelMessage.ResumeLayout(false);
            this.panelMessage.PerformLayout();
            this.panelOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox tBUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox tBPassword;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.ErrorProvider errorProviderLogin;
        private System.Windows.Forms.Panel panelMessage;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Panel panelOptions;
        private System.Windows.Forms.LinkLabel linkLabelDetails;
    }
}