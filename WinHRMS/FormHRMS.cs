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

namespace WinHRMS
{
    public partial class FormHRMS : Form
    {
        private User CurrentUser;

        public FormHRMS()
        {
            InitializeComponent();
            CurrentUser = new User();
        }

        private void Login() {
            if (!CurrentUser.IsLogedIn)
            {
                FormLogin login = new FormLogin();
                login.ShowInTaskbar = false;
                DialogResult result = login.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    CurrentUser = login.User;
                    if (CurrentUser.IsLogedIn)
                    {
                        this.menuStrip.Enabled = true;
                        this.toolStrip.Enabled = true;
                        loadHome();
                    }
                }
                else
                {
                    Close();
                }
            }
        }

        private void loadHome()
        {
            FormHome childForm = new FormHome();
            childForm.MdiParent = this;
            childForm.Text = "Home";
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void FormHRMS_Load(object sender, EventArgs e)
        {
        }

        private void FormHRMS_Shown(object sender, EventArgs e)
        {
            this.menuStrip.Enabled = false;
            this.toolStrip.Enabled = false;
            Login();
        }

        private void fileBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var child in this.MdiChildren)
            {
                if (child.GetType() == typeof(FormHome)) {
                    child.Show();
                    return;
                }
            }
            loadHome();
        }

        private void testViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTest childForm = new FormTest();
            childForm.MdiParent = this;
            childForm.Text = "Test";
            childForm.WindowState = FormWindowState.Maximized;
            childForm.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
