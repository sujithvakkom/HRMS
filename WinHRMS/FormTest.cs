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
using WinHRMS.Models;
using WinHRMS.Properties;

namespace WinHRMS
{
    public partial class FormTest : Form
    {
        private List<AssetView> assets;

        public FormTest()
        {
            InitializeComponent();
            this.dataGridView1.AutoGenerateColumns = false;
            using (var context = new DataStore(Settings.Default.ConnectionString))
            {
                this.assets = AssetView.getList(context);
                this.dataGridView1.DataSource = assets;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex] == DCEdit)
            {
                MessageBox.Show(this.assets[e.RowIndex].AssetName, "Edit");
            }
            
        }
    }
}
