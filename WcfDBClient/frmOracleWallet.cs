using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfDBClient
{
    public partial class frmOracleWallet : Form
    {
        public frmOracleWallet()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConfiguration.WalletLocation = @"(SOURCE=(METHOD=FILE)(METHOD_DATA=(DIRECTORY=D:\Prog_Git\03.WCF\WcfNet6Client\WcfDBClient\bin\Debug\Wallet_NakdongDB)))";
            OracleConfiguration.SqlNetWalletOverride = true;
            OracleConfiguration.TnsAdmin = @"D:\Prog_Git\03.WCF\WcfNet6Client\WcfDBClient\bin\Debug\Wallet_NakdongDB";
            OracleConfiguration.TraceLevel = 7;
            OracleConfiguration.TraceFileLocation = @"d:\temp";
            OracleConfiguration.TraceOption = 7;

            var user = "admin";
            var password = "Asdfqwer1234!@#$";
            var datasrc = "nakdongdb_tpurgent";

            var connectionString = $"User Id={user};Password={password};Data Source={datasrc};";

            using (OracleConnection conn = new OracleConnection())
            {


                conn.ConnectionString = connectionString;

                //conn.Open();

                Console.WriteLine("State: {0}", conn.State);
                Console.WriteLine("ConnectionString: {0}",
                    conn.ConnectionString);
                OracleCommand command = conn.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "select * from employees";

                OracleDataAdapter? dbAdapter = new OracleDataAdapter(command);
                // DB Command exec 
                DataSet? ds = new("Result_Ds");
                dbAdapter.Fill(ds);

                dgv1.DataSource = null;

                dgv1.DataSource = ds.Tables[0];

                dbAdapter.Dispose();
                command.Dispose();
                conn.Close();
            }

            /***
                        var connection = new OracleConnection(connectionString);
                        connection.KeepAlive = true;

                        connection.Open();
                        OracleCommand command = connection.CreateCommand();
                        command.CommandType = CommandType.Text;
                        command.CommandText = "select * from employees";

                        IDataAdapter? dbAdapter = new OracleDataAdapter(command);
                        // DB Command exec 
                        DataSet? ds = new("Result_Ds");
                        dbAdapter.Fill(ds);


                        dgv1.DataSource = null;

                        dgv1.DataSource = ds.Tables[0];

                        command.Dispose();
                        connection.Close();
            ***/



            //OracleConnection connection = TakeMeToTheClouds();
            //connection.Open();

            //string constr = "User Id=/; Data Source=mytns;";

            //string ProviderName = "Oracle.ManagedDataAccess.Client";

            //DbProviderFactory factory = DbProviderFactories.GetFactory(ProviderName);
            //if (factory == null) return;

            //using (DbConnection? conn = factory.CreateConnection())
            //{
            //    try
            //    {
            //        conn.ConnectionString = constr;
            //        conn.Open();

            //        DataTable dtSchema = conn.GetSchema();
            //        dtSchema.WriteXml(ProviderName + "_Schema.xml");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //        Console.WriteLine(ex.StackTrace);
            //    }
            //    Console.ReadLine();
            //}
        }

        private OracleConnection TakeMeToTheClouds()
        {
            var user = "admin";
            var password = "Asdfqwer1234!@#$";
            var cnstr = "CN=adb.ap-seoul-1.oraclecloud.com, OU=Oracle ADB SEOUL, O=Oracle Corporation, L=Redwood City, ST=California, C=US";
            var ds = "description= (retry_count=20)(retry_delay=3)(address=(protocol=tcps)(port=1522)(host=adb.ap-seoul-1.oraclecloud.com))(connect_data=(service_name=g1eec2c133908f8_nakdongdb_medium.adb.oraclecloud.com))" +
                     "(security=(ssl_server_cert_dn=" +'"' + cnstr +'"' +"))";

            var connectionString = $"User Id={user};Password={password};Data Source={ds};";
            return new OracleConnection(connectionString);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var ds2 = "(description= (retry_count=20)(retry_delay=3)(address=(protocol=tcps)(port=1521)(host=adb.ap-seoul-1.oraclecloud.com))(connect_data=(service_name=g1eec2c133908f8_nakdongdb_medium.adb.oraclecloud.com))(security=(ssl_server_dn_match=yes)))";

            var user = "admin";
            var password = "Asdfqwer1234!@#$";

            //Enter user id and password, such as ADMIN user	
            string conString = $"User Id={user};Password={password};Data Source={ds2};";

            
            using (OracleConnection con = new OracleConnection(conString))
            {
                using (OracleCommand cmd = con.CreateCommand())
                {
                    try
                    {
                        
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "select * from employees";

                        OracleDataAdapter? dbAdapter = new OracleDataAdapter(cmd);
                        // DB Command exec 
                        DataSet? ds22 = new("Result_Ds");
                        dbAdapter.Fill(ds22);

                        dgv1.DataSource = null;

                        dgv1.DataSource = ds22.Tables[0];

                        /***
                        con.Open();

                        Console.WriteLine("Successfully connected to Oracle Autonomous Database");

                        //Retrieve database version info
                        cmd.CommandText = "SELECT BANNER FROM V$VERSION";
                        OracleDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        Console.WriteLine("Connected to " + reader.GetString(0));
                        ***/
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    Console.ReadLine();
                }
            }
        }
    }
}
