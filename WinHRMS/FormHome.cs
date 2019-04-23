using DataProvider;
using DataProvider.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinHRMS.Models;
using WinHRMS.Properties;

namespace WinHRMS
{
    public partial class FormHome : Form
    { 
        private List<AssetView> Assets;

        public FormHome()
        {
            InitializeComponent();
        }

        public Asset SelectAsset { get; private set; }

        private void FormHome_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            this.dataGridView1.AutoGenerateColumns = false;
            using (var context = new DataStore(Settings.Default.ConnectionString))
            {
                this.Assets = AssetView.getList(context);
                this.dataGridView1.DataSource = Assets;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.SelectAsset.AssetType = comboBoxType.SelectedItem.ToString();
            this.SelectAsset.AssetValidFrom = validFromDate.Value;
            this.SelectAsset.AssetValidThru = validThruDate.Value;

            using (var context = new DataStore(Settings.Default.ConnectionString))
                this.SelectAsset.Save(context);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex] == DCEdit)
            {
                MessageBox.Show(this.Assets[e.RowIndex].AssetName, "Edit");
            }
            else
            if (dataGridView1.Columns[e.ColumnIndex] == DCDisplay)
            {
                //pictureBoxPreview.Image = Image.FromFile(this.Assets[e.RowIndex].AssetLocation);
                try
                {
                    this.Cursor = Cursors.WaitCursor;
                    using (FileStream stream = new FileStream(this.Assets[e.RowIndex].AssetLocation, FileMode.Open, FileAccess.Read))
                    {
                        pictureBoxPreview.Image = Image.FromStream(stream);
                    }
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show(this, "Cannot find file." +
                        Environment.NewLine +
                        Path.GetFileName(this.Assets[e.RowIndex].AssetLocation),
                    "File not found");
                }
                catch (ArgumentOutOfRangeException)
                {

                    MessageBox.Show(this, "Cannot open file.",
                    "Error while opening.");
                }
                finally {
                    this.Cursor = Cursors.Default;
                }
                pictureBoxPreview.ImageLocation = this.Assets[e.RowIndex].AssetLocation;
                using (var context = new DataStore(Settings.Default.ConnectionString))
                    this.SelectAsset = Asset.get(context,
                        Path.GetFileName(this.Assets[e.RowIndex].AssetLocation));
                this.SelectAsset = this.Assets[e.RowIndex];
                try
                {
                    this.textBoxDisplayName.Text = this.SelectAsset.AssetName;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                try
                {
                    for (int i = 0; i < this.comboBoxType.Items.Count; i++)
                        if (this.comboBoxType.Items[i].ToString() == this.SelectAsset.AssetType) break;
                    this.comboBoxType.SelectedIndex = 1;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                try
                {
                    this.validFromDate.Value = this.SelectAsset.AssetValidFrom;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
                try
                {
                    this.validThruDate.Value = this.SelectAsset.AssetValidThru;
                }
                catch (Exception ex)
                {
                    Debug.WriteLine(ex.Message);
                }
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddAsset dialog = new FormAddAsset();
            dialog.ShowInTaskbar = false;
            if (dialog.ShowDialog(this) == DialogResult.OK) {
                RefreshData();
            }
        }
    }
}
