using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBServer_Inventory_1._1
{
    public partial class Form1 : Form
    {
        public static string serverName;
        public static string databaseName;
        public static string loginName;
        public static string loginPassword;
        public static bool loginTrusted;

        Login_Form loginForm = new Login_Form();
        mssqlConnection form1_mssqlConnection = null;
        mssqlCommand form1_mssqlCommand = new mssqlCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Load data into DataGridView
        private void loadData()
        {
                               
            SqlCommand sqlCommand = new SqlCommand(form1_mssqlCommand.selectCommand_1, form1_mssqlConnection.sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            
            //очищаю ранее загруженные данные
            if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows.Clear();
            }

            //заполняю форму
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = sqlDataReader;

            dataGridView1.DataSource = bindingSource;

            // Resize the DataGridView columns
            //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.ColumnHeader);
        }

        // menu: Подключение
        private void подключениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loginForm.ShowDialog();

            form1_mssqlConnection = new mssqlConnection(serverName, databaseName, loginName, loginPassword, loginTrusted);
            form1_mssqlConnection.openConnection();

            loadData();
        }

        // menu: Обновить
        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form1_mssqlConnection == null)
            {
                loginForm.ShowDialog();

                form1_mssqlConnection = new mssqlConnection(serverName, databaseName, loginName, loginPassword, loginTrusted);
            }

            if (form1_mssqlConnection.sqlConnection.State != ConnectionState.Open)
            {
                form1_mssqlConnection.openConnection();
            }
            
            loadData();
        }

        // icon: Обновить
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (form1_mssqlConnection == null)
            {
                loginForm.ShowDialog();

                form1_mssqlConnection = new mssqlConnection(serverName, databaseName, loginName, loginPassword, loginTrusted);
            }

            if (form1_mssqlConnection.sqlConnection.State != ConnectionState.Open)
            {
                form1_mssqlConnection.openConnection();
            }

            loadData();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
