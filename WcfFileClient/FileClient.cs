using BBS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BBS
{
    public enum MyBindinEnum
    {
        Http,
        NetTcp
    }

    public class FileClient
    {

        private EndpointAddress address_http = new EndpointAddress("http://146.56.155.85:9210/FileService");
        private EndpointAddress address_tcp = new EndpointAddress("net.tcp://146.56.155.85:9220/FileService");

        //private EndpointAddress address_http = new EndpointAddress("http://172.20.105.36:9210/FileService");
        //private EndpointAddress address_tcp = new EndpointAddress("net.tcp://172.20.105.36:9220/FileService");
        //private EndpointAddress address_http = new EndpointAddress("http://localhost:9210/FileService");
        //private EndpointAddress address_tcp = new EndpointAddress("net.tcp://localhost:9220/FileService");


        private ChannelFactory<IFileService> MyFactory { get; set; }
        private IFileService MyChannel { get; set; }

        public FileClient(MyBindinEnum myBindin)
        {
            if (myBindin == MyBindinEnum.Http)
            {
                BasicHttpBinding binding = GetHttpBinding();
                MyFactory = new ChannelFactory<IFileService>(binding, address_http);
            }
            else if (myBindin == MyBindinEnum.NetTcp)
            {
                NetTcpBinding binding = GetNetTcpBinding();
                MyFactory = new ChannelFactory<IFileService>(binding, address_tcp);
            }
            if (MyFactory == null) throw new Exception("Can not connect to Service");

            MyChannel = MyFactory.CreateChannel();
        }
        public CheckFileResponse SeverCheckFile(string fileName)
        {
            return MyChannel.CheckFile(fileName);
        }

        public void UploadFile(FileData uploadFile)
        {
            try
            {
                MyChannel.UploadFile(uploadFile);
            }
            catch (Exception )
            {
                throw ;
            }
        }
        /// <summary>
        /// task.run(action) == Task.Factory.StartNew(action);
        /// </summary>
        /// <param name="uploadFile"></param>
        /// <returns></returns>
        public Task UploadFileAsync(FileData uploadFile)
        {
            try
            {
                return Task.Factory.StartNew(() => MyChannel.UploadFile(uploadFile));
                //return Task.Run(() =>  MyChannel.UploadFile(uploadFile));
            }
            catch (Exception )
            {

                throw ;
            }            
        }

        public FileData DownloadFile(DownloadRequest request)
        {
            try
            {
                return MyChannel.DownloadFile(request);
            }
            catch (Exception )
            {

                throw ;
            }
        }
     
        public Task<FileData> DownloadFileAsync(DownloadRequest request)
        {
            try
            {
                //Func<FileData> function = new Func<FileData>(() => MyChannel.DownloadFile(request));
                //return Task.Factory.StartNew<FileData>(function);

                return Task.Factory.StartNew<FileData>(() => MyChannel.DownloadFile(request));

            }
            catch (Exception )
            {

                throw ;
            }
        }
        private BasicHttpBinding GetHttpBinding()
        {
            BasicHttpBinding binding = new BasicHttpBinding();

            binding.TransferMode = TransferMode.Streamed;
            binding.MessageEncoding = WSMessageEncoding.Mtom;
            binding.Security.Mode = BasicHttpSecurityMode.None;
    
            binding.MaxReceivedMessageSize = 2147483647;
            binding.MaxBufferSize = 65536;

            binding.ReaderQuotas.MaxStringContentLength = 2147483647;
            binding.ReaderQuotas.MaxBytesPerRead = 2147483647;
            binding.ReaderQuotas.MaxArrayLength = 2147483647;
            binding.ReaderQuotas.MaxNameTableCharCount = 2147483647;
            binding.ReaderQuotas.MaxDepth = 2147483647;

            binding.OpenTimeout = TimeSpan.FromMinutes(5);
            binding.CloseTimeout = TimeSpan.FromMinutes(5);
            binding.ReceiveTimeout = TimeSpan.FromMinutes(15);
            binding.SendTimeout = TimeSpan.FromMinutes(15);

            return binding;
        }
        private NetTcpBinding GetNetTcpBinding()
        {
            NetTcpBinding binding = new NetTcpBinding();

            binding.TransferMode = TransferMode.Streamed;
            binding.Security.Mode =  SecurityMode.None;

            binding.MaxReceivedMessageSize = 2147483647;
            binding.MaxBufferSize = 65536;

            binding.OpenTimeout = TimeSpan.FromMinutes(5);
            binding.CloseTimeout = TimeSpan.FromMinutes(5);
            binding.ReceiveTimeout = TimeSpan.FromMinutes(15);
            binding.SendTimeout = TimeSpan.FromMinutes(15);

            return binding;
        }

        public void MyClose()
        {
            ((IClientChannel)MyChannel).Close();
            MyFactory.Close();
        }

        //public Task<FileData> DownloadFileMyAsync(DownloadRequest request)
        //{
        //    try
        //    {
        //        //return await MyChannel.DownloadFileMyAsync(request);
        //        return MyChannel.DownloadFileMyAsync(request);

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
        ///// <summary>
        ///// task.run(action) == Task.Factory.StartNew(action);
        ///// </summary>
        ///// <param name="uploadFile"></param>
        ///// <returns></returns>
        //public async Task UploadFileMyAsync(FileData uploadFile)
        //{
        //    try
        //    {
        //        await MyChannel.UploadFileMyAsync(uploadFile);

        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }
        //}
    }
}
