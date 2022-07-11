using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBS.WCF
{
    public enum MyBindinEnum
    {
        Http,
        NetTcp
    }
    //public static class MyAppSetting
    //{
    //    public static string Db_Addr_http { get; set; }
    //    public static string Db_Addr_tcp { get; set; }

    //    public  MyAppSetting()
    //    {
    //        var builder = new ConfigurationBuilder()
    //            .SetBasePath(Directory.GetCurrentDirectory())
    //            .AddJsonFile("appsettiongs.json", optional: false);
    //        IConfiguration config = builder.Build();
    //        Db_Address_http = config.GetValue<string>("DBWcfSetting:Address_http");
    //        Db_Address_tcp = config.GetValue<string>("DBWcfSetting:Address_tcp");
    //    }
    //}
}