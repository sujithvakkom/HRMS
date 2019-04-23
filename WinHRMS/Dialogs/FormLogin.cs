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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.User = new User();
            setMessage("Please Login.", false);
        }

        public User User { get; private set; }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            performLogin();
        }

        private void performLogin()
        {
            errorProviderLogin.Clear();
            var isValid = true;
            if (tBUserName.Text.Trim().Length == 0)
            {
                isValid = isValid & false;
                errorProviderLogin.SetError(labelUserName, "Cannot be blank.");
            }
            if (tBPassword.Text.Trim().Length == 0)
            {
                isValid = isValid & false;
                errorProviderLogin.SetError(labelPassword, "Cannot be blank.");
            }
            if (isValid)
            {
                this.User = new User()
                {
                    UserName = tBUserName.Text.Trim(),
                    Password = tBPassword.Text.Trim(),
                    IsLogedIn = false//S true
                };
                try
                {
                    using (var context = new DataStore(Settings.Default.ConnectionString))
                        this.User.Login(context);

                    if (this.User.IsLogedIn == true)
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        setMessage("Invalid User Name or password.",
                            true);
                    }
                }
                catch (Exception ex) {
                        setMessage("Error in connection.",
                            true,ex);
                }
            }
        }

        private void setMessage(string Message, bool Error, Exception ex =null)
        {
            panelMessage.BackColor = (Error==true? Color.DarkRed: Color.Green);
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
        }

        private void tBPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                performLogin();
            }
        }
    }
}
