using DataProvider;
using DataProvider.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinHRMS.Properties;

namespace WinHRMS
{
    public partial class FormAddDept : Form
    {
        public FormAddDept()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (DataStore context = new DataStore(Settings.Default.ConnectionString))
                {
                    if (this.tBDeptName.Text.Trim().Length > 0)
                        HRDepartment.AddDept(this.tBDeptName.Text.Trim(), context);
                    else
                    {
                        errorProviderDeptName.SetError(this.tBDeptName, "Cannot be blank.");
                        setMessage("Invalid values", true, null);
                    }
                }
                this.DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex) {
                setMessage("Some error occurred", true, ex);
            }
        }

        private void setMessage(string Message, bool Error, Exception ex = null)
        {
            panelMessage.BackColor = (Error == true ? Color.DarkRed : Color.Green);
            labelMessage.ForeColor = Color.White;
            labelMessage.Text = Message;
            if (ex != null)
            {
                linkLabelDetails.Click += (sender, EventArgs) =>
                {
                    MessageBox.Show(this, ex.Message, "Error Details");
                };
                linkLabelDetails.Visible = true;
            }
            else { linkLabelDetails.Visible = false; }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
