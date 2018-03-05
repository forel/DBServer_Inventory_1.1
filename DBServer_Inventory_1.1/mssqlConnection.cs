using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DBServer_Inventory_1._1
{
    public class mssqlConnection
    {
        string serverName;
        string databaseName;
        string loginName;
        string loginPassword;
        bool trustedConnection;
        //comment git 1
        //comment git 2
        //comment git 3
        //comment git 4
        //comment git 5
        //comment git 6


        SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder();
        public SqlConnection sqlConnection = null;

        //constructor: create connection
        public mssqlConnection(string pserverName, string pdatabaseName, string ploginName, string ploginPassword, bool ptrustedConnection)
        {
            this.serverName = pserverName;
            this.databaseName = pdatabaseName;
            this.loginName = ploginName;
            this.loginPassword = ploginPassword;
            this.trustedConnection = ptrustedConnection;

            connectionString.DataSource = serverName;
            connectionString.InitialCatalog = databaseName;

            //trusted connection            
            if (this.trustedConnection)
            {
                connectionString.IntegratedSecurity = true;
            }
            else
            {
                connectionString.IntegratedSecurity = false;
                connectionString.UserID = loginName;
                connectionString.Password = loginPassword;
            }

            sqlConnection = new SqlConnection(connectionString.ConnectionString);
        }

        //test connection
        public void testConnection()
        {
            MessageBox.Show(sqlConnection.State.ToString());
        }

        //open connection
        public void openConnection()
        {
            try
            {
                sqlConnection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
            
        }

        //close connection
        public void closeConnection()
        {
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

    }
}
