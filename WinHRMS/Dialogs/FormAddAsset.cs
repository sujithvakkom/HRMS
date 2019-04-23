using DataProvider;
using DataProvider.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinHRMS.Properties;

namespace WinHRMS
{
    public partial class FormAddAsset : Form
    {
        public FormAddAsset()
        {
            InitializeComponent();
            validThruDate.MinDate = validFromDate.Value;
            RefreshData();
        }

        private void RefreshData()
        {
            using (DataStore context = new DataStore(Settings.Default.ConnectionString))
            {
                this.comboBoxDept.Items.Clear();
                this.comboBoxDept.Items.AddRange(HRDepartment.GetList(context).ToArray());
                this.comboBoxDept.DisplayMember = "Name";

                this.comboBoxType.Items.Clear();
                this.comboBoxType.Items.AddRange(HRDocType.GetList(context).ToArray());
                this.comboBoxType.DisplayMember = "Name";
            }
        }

        public string SelectedFileName { get; private set; }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Title = "Select Document",
                CheckFileExists = true,
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png",
                Multiselect = false
            };
            if (
            dialog.ShowDialog(this) == DialogResult.OK) { }
            {
                try
                {
                    using (FileStream stream = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        this.SelectedFileName = dialog.FileName;
                        pictureBoxPreview.Image = Image.FromStream(stream);
                        this.linkLabelSelectFile.Text = Path.GetFileName(SelectedFileName);
                        this.toolTipSelectFile.SetToolTip(this.linkLabelSelectFile, this.SelectedFileName);
                    }
                }
                catch (FileNotFoundException)
                {
                    this.SelectedFileName = null;
                    this.linkLabelSelectFile.Text = "Please select File";
                    this.toolTipSelectFile.SetToolTip(this.linkLabelSelectFile, "Please select File");
                    MessageBox.Show(this, "Cannot find file." +
                        Environment.NewLine +
                        Path.GetFileName(dialog.FileName),
                    "File not found");
                }
            }
        }

        private void buttonAddDept_Click(object sender, EventArgs e)
        {
            FormAddDept dialog = new FormAddDept();
            if (dialog.ShowDialog(this) == DialogResult.OK)
                RefreshData();
        }

        private void buttonAddDocType_Click(object sender, EventArgs e)
        {
            FormAddDocType dialog = new FormAddDocType();
            if (dialog.ShowDialog(this) == DialogResult.OK)
                RefreshData();
        }

        private void validThruDate_ValueChanged(object sender, EventArgs e)
        {
        }

        private void validFromDate_ValueChanged(object sender, EventArgs e)
        {
            if (validFromDate.Value > validThruDate.Value) {
                validThruDate.Value = validFromDate.Value;
            }
            validThruDate.MinDate = validFromDate.Value;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (validateForm()) {
                try
                {
                    using (DataStore context = new DataStore(Settings.Default.ConnectionString))
                    {
                        Asset asset = new Asset()
                        {
                            AssetLocation = this.SelectedFileName,
                            AssetName = this.textBoxDisplayName.Text.Trim(),
                            AssetType = ((HRDocType)this.comboBoxType.SelectedItem).Name,
                            AssetValidFrom = this.validFromDate.Value,
                            AssetValidThru = this.validThruDate.Value
                        };
                        asset.Save(context);
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex) {
                    setMessage("Some error occurred.", true, ex);
                }
            }
        }

        private bool validateForm()
        {
            bool valid = true;
            String errorMessages = "";
            errorProvider1.Clear();
            if (this.SelectedFileName == null) {
                var message = "Please select file";
                errorProvider1.SetError(linkLabelSelectFile, message);
                errorMessages = String.IsNullOrEmpty(errorMessages) ? message : errorMessages + Environment.NewLine + message;
                valid = false;
            }
            if (!File.Exists(this.SelectedFileName))
            {
                var message = "File dose not exists.";
                errorProvider1.SetError(linkLabelSelectFile, message);
                errorMessages = String.IsNullOrEmpty(errorMessages) ? message : errorMessages + Environment.NewLine + message;
                valid = false;
            }
            if (String.IsNullOrEmpty(textBoxDisplayName.Text.Trim()))
            {
                var message = "Name cannot be blank.";
                errorProvider1.SetError(textBoxDisplayName, message);
                errorMessages = String.IsNullOrEmpty(errorMessages) ? message : errorMessages + Environment.NewLine + message;
                valid = false;
            }
            if (comboBoxType.SelectedItem == null)
            {
                var message = "Select document type.";
                errorProvider1.SetError(comboBoxType, message);
                errorMessages = String.IsNullOrEmpty(errorMessages) ? message : errorMessages + Environment.NewLine + message;
                valid = false;
            }
            if (comboBoxDept.SelectedItem == null)
            {
                var message = "Select department.";
                errorProvider1.SetError(comboBoxDept, message);
                errorMessages = String.IsNullOrEmpty(errorMessages) ? message : errorMessages + Environment.NewLine + message;
                valid = false;
            }
            if (!valid)
                setMessage("Error in fields.", true, new Exception(errorMessages));
            else
                setMessage("Please enter fields", false);
            return valid;
        }

        private void setMessage(string Message, bool Error, Exception ex = null)
        {
            panelMessage.BackColor = (Error == true ? Color.DarkRed : Color.Green);
            labelMessage.ForeColor = Color.White;
            labelMessage.Text = Message;
            if (ex != null)
            {
                RemoveClickEvent(linkLabelDetails);
                linkLabelDetails.Click += (sender, EventArgs) =>
                {
                    MessageBox.Show(this, ex.Message, "Error Details");
                };
                linkLabelDetails.Visible = true;
            }
            else { linkLabelDetails.Visible = false; }
        }

        private void RemoveClickEvent(Control control)
        {
            FieldInfo f1 = typeof(Control).GetField("EventClick",
                BindingFlags.Static | BindingFlags.NonPublic);
            object obj = f1.GetValue(control);
            PropertyInfo pi = control.GetType().GetProperty("Events",
                BindingFlags.NonPublic | BindingFlags.Instance);
            EventHandlerList list = (EventHandlerList)pi.GetValue(control, null);
            list.RemoveHandler(obj, list[obj]);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}