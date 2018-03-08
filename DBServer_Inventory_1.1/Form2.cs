using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBServer_Inventory_1._1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void servers_listBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.servers_listBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBA_DBServer_InventoryDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBA_DBServer_InventoryDataSet.informsys_list' table. You can move, or remove it, as needed.
            this.informsys_listTableAdapter.Fill(this.dBA_DBServer_InventoryDataSet.informsys_list);
            // TODO: This line of code loads data into the 'dBA_DBServer_InventoryDataSet.informsys_list' table. You can move, or remove it, as needed.
            this.informsys_listTableAdapter.Fill(this.dBA_DBServer_InventoryDataSet.informsys_list);
            // TODO: This line of code loads data into the 'dBA_DBServer_InventoryDataSet.informsys_list' table. You can move, or remove it, as needed.
            this.informsys_listTableAdapter.Fill(this.dBA_DBServer_InventoryDataSet.informsys_list);
            // TODO: This line of code loads data into the 'dBA_DBServer_InventoryDataSet.servers_list' table. You can move, or remove it, as needed.
            this.servers_listTableAdapter.Fill(this.dBA_DBServer_InventoryDataSet.servers_list);

        }
    }
}
