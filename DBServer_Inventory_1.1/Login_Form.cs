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
    public partial class Login_Form : Form
    {
        mssqlConnection obj_sqlConnection = null;

        public Login_Form()
        {
            InitializeComponent();

            textBox1.Text = "MW-DBA-CMS";
            textBox4.Text = "DBA_DBServer_Inventory";
            textBox2.Text = Environment.UserDomainName.ToString() + @"\" + Environment.UserName.ToString();
            textBox3.Text = "";
            textBox3.UseSystemPasswordChar = true;
            checkBox1.Checked = false;
        }
        //комментарий для проверки гита
        //при загрузке формы устанавливаю свойства в исходное значение
        private void Login_Form_Load(object sender, EventArgs e)
        {
            textBox1.Text = "MW-DBA-CMS";
            textBox4.Text = "DBA_DBServer_Inventory";
            textBox2.Text = Environment.UserDomainName.ToString() + @"\" + Environment.UserName.ToString();
            textBox3.Text = "";
            textBox3.UseSystemPasswordChar = true;
            checkBox1.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;

                button1.Select();
            }
            else
            {
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }
        }

        // button: Connect
        private void button1_Click(object sender, EventArgs e)
        {
            //проверка заполненых полей с именем входа
            if (label4.Visible)
            {
                label4.Visible = false;
            }

            if (!checkBox1.Checked &&
                (String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrWhiteSpace(textBox2.Text) ||
                String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrWhiteSpace(textBox3.Text)))
            {
                label4.Visible = true;
                label4.Text = "Fill the fields 'Login' and 'Password' or use 'Trusted connection'";
            }
            else
            {
                obj_sqlConnection = new mssqlConnection(textBox1.Text, textBox4.Text, textBox2.Text, textBox3.Text, checkBox1.Checked);

                obj_sqlConnection.openConnection();
                if (obj_sqlConnection.sqlConnection.State == ConnectionState.Open)
                {
                    Form1.serverName = textBox1.Text;
                    Form1.databaseName = textBox4.Text;
                    Form1.loginName = textBox2.Text;
                    Form1.loginPassword = textBox3.Text;
                    Form1.loginTrusted = checkBox1.Checked;

                    Close();
                }
            }
        }

        // button: Decline
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
