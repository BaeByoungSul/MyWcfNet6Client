using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace BBS
{
    public enum MyBindinEnum
    {
        Http,
        NetTcp
    }
    public class SvcReturnList<T>
    {
        public SvcReturnList()
        {
            ReturnCD = string.Empty;
            ReturnMsg = String.Empty;
            //ReturnList = new List<T>() ;
        }
        public string ReturnCD { get; set; }  // "FAIL", "OK"
        public string ReturnMsg { get; set; }
        public List<T>? ReturnList { get; set; }
    }
    public class SvcReturnList<T1,T2>
    {
        public SvcReturnList()
        {
            ReturnCD = string.Empty;
            ReturnMsg = String.Empty;
            //ReturnList1 = new List<T1>();
            //ReturnList2 = new List<T2>();
        }
        public string ReturnCD { get; set; }  // "FAIL", "OK"
        public string ReturnMsg { get; set; }
        public List<T1>? ReturnList1 { get; set; }
        public List<T2>? ReturnList2 { get; set; }
    }
    public class SvcReturnDs
    {
        public SvcReturnDs()
        {
            ReturnCD = string.Empty;
            ReturnMsg = String.Empty;
        }

        public string ReturnCD { get; set; }  // "FAIL", "OK"
        public string ReturnMsg { get; set; }
        public DataSet? ReturnDs { get; set; }
    }

    
    public class DBClient:IDisposable
    {
        //private EndpointAddress address_http = new EndpointAddress("http://146.56.155.85:9110/DBService");
        //private EndpointAddress address_tcp = new EndpointAddress("net.tcp://146.56.155.85:9120/DBService");
        //private EndpointAddress address_http = new EndpointAddress("http://172.20.105.36:9110/DBService");
        //private EndpointAddress address_tcp = new EndpointAddress("net.tcp://172.20.105.36:9120/DBService");
        private EndpointAddress address_http = new EndpointAddress("http://localhost:9110/DBService");
        private EndpointAddress address_tcp = new EndpointAddress("net.tcp://localhost:9120/DBService ");

        private System.ServiceModel.ChannelFactory<IDBService> MyFactory { get; set; }
        private IDBService MyChannel { get; set; }
        public DBClient(MyBindinEnum myBindin)
        {
            if (myBindin == MyBindinEnum.Http)
            {
                BasicHttpBinding binding = GetHttpBinding();
                if (binding == null) throw new Exception("Binding is null");
                if (address_http == null) throw new Exception("Endpoing Address is null");

                MyFactory = new System.ServiceModel.ChannelFactory<IDBService>(binding, address_http);
            }
            else if (myBindin == MyBindinEnum.NetTcp)
            {
                NetTcpBinding binding = GetNetTcpBinding();
                MyFactory = new ChannelFactory<IDBService>(binding, address_tcp);
            }
            if (MyFactory == null) throw new Exception("Can not connect to Service");

            MyChannel = MyFactory.CreateChannel();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private BasicHttpBinding GetHttpBinding()
        {
            BasicHttpBinding binding = new BasicHttpBinding();

            binding.TransferMode = TransferMode.Streamed;
            binding.MessageEncoding = WSMessageEncoding.Mtom;
            binding.Security.Mode = BasicHttpSecurityMode.None;

            binding.MaxBufferSize = 2147483647;
            binding.MaxReceivedMessageSize = 2147483647;

            binding.OpenTimeout = TimeSpan.FromMinutes(5);
            binding.CloseTimeout = TimeSpan.FromMinutes(5);
            binding.ReceiveTimeout = TimeSpan.FromMinutes(15);
            binding.SendTimeout = TimeSpan.FromMinutes(15);

            binding.ReaderQuotas.MaxStringContentLength = 2147483647;

            return binding;
        }
        private NetTcpBinding GetNetTcpBinding()
        {
            NetTcpBinding binding = new NetTcpBinding();

            binding.TransferMode = TransferMode.Streamed;
            binding.Security.Mode = SecurityMode.None;

            binding.MaxReceivedMessageSize = 2147483647;

            binding.OpenTimeout = TimeSpan.FromMinutes(5);
            binding.CloseTimeout = TimeSpan.FromMinutes(5);
            binding.ReceiveTimeout = TimeSpan.FromMinutes(15);
            binding.SendTimeout = TimeSpan.FromMinutes(15);


            binding.ReaderQuotas.MaxStringContentLength = 2147483647;
            return binding;
        }
       
        private SvcReturn ExecNonQuery(MyCommand[] cmds)
        {
            return MyChannel.ExecNonQuery(cmds);
        }
        //public void SetTransOption(TransactionScopeOption scopeOption)
        //{
        //    MyChannel.SetTransOption (scopeOption);
        //}
        public SvcReturnList<T> ExecQuery<T>(List<MyCommand> lstMyCmd)
        {
            try
            {
                SvcReturn resRtn = MyChannel.ExecNonQuery(lstMyCmd.ToArray());

                var doc = XDocument.Parse(resRtn.ReturnStr);
                List<T>? lstOutPut = DeserializeXml<T>(doc);
                

                SvcReturnList<T> execReturn = new SvcReturnList<T>()
                {
                    ReturnCD = resRtn.ReturnCD,
                    ReturnMsg = resRtn.ReturnMsg,
                    ReturnList = lstOutPut
                };
                return execReturn;

            }
            catch (Exception )
            {
                throw ;
            }
        }
        public SvcReturnDs ExecQuery(List<MyCommand> lstMyCmd)
        {
            try
            {
                SvcReturn resRtn = MyChannel.ExecNonQuery(lstMyCmd.ToArray());

                var doc = XDocument.Parse(resRtn.ReturnStr);
                List<DBOutPut>? lstOutPut = DeserializeXml<DBOutPut>(doc);

                DataSet ds = new DataSet();
                if (lstOutPut != null)
                {
                    ds.Tables.Add(ToDataTable(lstOutPut));
                }
                

                //StringReader theReader = new StringReader(resRtn.ReturnStr);
                //DataSet ds = new DataSet();
                //ds.ReadXml(theReader, XmlReadMode.ReadSchema);

                return new SvcReturnDs()
                {
                    ReturnCD = resRtn.ReturnCD,
                    ReturnMsg = resRtn.ReturnMsg,
                    ReturnDs = ds
                };

               

            }
            catch (Exception )
            {
                throw ;
            }
        }
        private SvcReturn GetDataSetXml(MyCommand cmd)
        {
            return MyChannel.GetDataSetXml(cmd);
        }

        /// <summary>
        /// DataSet으로 Return
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public SvcReturnDs GetDataSet(MyCommand cmd)
        {
            try
            {
                SvcReturn resRtn = MyChannel.GetDataSetXml(cmd);

                if (resRtn.ReturnCD != "OK")
                {
                    return new SvcReturnDs()
                    {
                        ReturnCD = resRtn.ReturnCD,
                        ReturnMsg = resRtn.ReturnMsg,
                        ReturnDs = new DataSet()
                    };

                }
                StringReader theReader = new StringReader(resRtn.ReturnStr);
                DataSet ds = new DataSet();
                ds.ReadXml(theReader, XmlReadMode.ReadSchema);
                
                return new SvcReturnDs()
                {
                    ReturnCD = resRtn.ReturnCD,
                    ReturnMsg = resRtn.ReturnMsg,
                    ReturnDs = ds
                };


            }
            catch (Exception )
            {

                throw ;
            }
        }
        /// <summary>
        /// return table이 한개인 경우
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public SvcReturnList<T> GetDataList<T>(MyCommand cmd)
        {
            SvcReturn resRtn = MyChannel.GetDataSetXml(cmd);

            var doc = XDocument.Parse(resRtn.ReturnStr);
            List<T>? lstReturn = DeserializeXml<T>(doc);
            
            return new SvcReturnList<T>()
            {
                ReturnCD = resRtn.ReturnCD,
                ReturnMsg = resRtn.ReturnMsg,
                ReturnList = lstReturn
            };
        }

        /// <summary>
        /// Return Table이 두개인 경우
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2"></typeparam>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public SvcReturnList<T1, T2> GetDataList<T1, T2>(MyCommand cmd)
        {
            SvcReturn resRtn = MyChannel.GetDataSetXml(cmd);

            var doc = XDocument.Parse(resRtn.ReturnStr);
            List<T1>? lstReturn1 = DeserializeXml<T1>(doc);
            List<T2>? lstReturn2 = DeserializeXml<T2>(doc);

            return new SvcReturnList<T1, T2>()
            {
                ReturnCD = resRtn.ReturnCD,
                ReturnMsg = resRtn.ReturnMsg,
                ReturnList1 = lstReturn1,
                ReturnList2 = lstReturn2
            };
        }
        private static List<T>? DeserializeXml<T>(XDocument doc)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer serializer =
                    new System.Xml.Serialization.XmlSerializer(typeof(List<T>), new XmlRootAttribute("Result_Ds"));

                System.Xml.XmlReader reader = doc.CreateReader();

                List<T>? result = (List<T>?)serializer.Deserialize(reader );
                reader.Close();

                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        /// <summary>
        /// https://www.codegrepper.com/code-examples/csharp/convert+list+to+datatable+c%23
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public static DataTable ToDataTable<T>(List<T>  data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;
        }
        //private DataTable ToDataTable<T>(List<T> items)
        //{
        //    DataTable dataTable = new DataTable(typeof(T).Name);
        //    //Get all the properties
        //    PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
        //    foreach (PropertyInfo prop in Props)
        //    {
        //        //Setting column names as Property names
        //        dataTable.Columns.Add(prop.Name);
        //    }
        //    foreach (T item in items)
        //    {
        //        var values = new object[Props.Length];
        //        for (int i = 0; i < Props.Length; i++)
        //        {
        //            //inserting property values to datatable rows
        //            values[i] = Props[i].GetValue(item, null);
        //        }
        //        dataTable.Rows.Add(values);
        //    }
        //    //put a breakpoint here and check datatable
        //    return dataTable;
        //}

        public void Dispose()
        {
            ((IClientChannel)MyChannel).Close();
            MyFactory.Close();
        }


    }
}
