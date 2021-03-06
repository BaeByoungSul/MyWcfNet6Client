using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace BBS.WCF
{
    /// <summary>
    /// DownloadFile: Server To Client로 File Stream 전송
    /// UploadFile : Client To Server로 File Stream 전송
    /// CheckFile : 서버에 파일이 있는지 ? 있어면 파일버전은 ?
    /// </summary>
    [ServiceContract]
    public interface IFileService
    {
        [OperationContract]

        FileData DownloadFile(DownloadRequest request);

        [OperationContract]

        Task<FileData> DownloadFileAsync(DownloadRequest request);

        [OperationContract]
        void UploadFile(FileData uploadFile);

        [OperationContract]
        Task UploadFileAsync(FileData uploadFile);

        [OperationContract]
        CheckFileResponse CheckFile(string fileName);
        [OperationContract]
        Task<CheckFileResponse> CheckFileAsync(string fileName);

        //[OperationContract]
        //Task UploadFileMyAsync(FileData uploadFile);
        //[OperationContract]
        //Task<FileData> DownloadFileMyAsync(DownloadRequest request);

    }
    [MessageContract]
    public class DownloadRequest
    {
        [MessageBodyMember]
        public string FileName { get; set; } = string.Empty;

    }

    [MessageContract]
    public class FileData : IDisposable
    {
        [MessageHeader]
        public string FileName { get; set; } = string.Empty;

        [MessageHeader]
        public long FileLength { get; set; }

        [MessageBodyMember(Order = 1)]
        public Stream? MyStream { get; set; }

        public void Dispose()
        {
            if (MyStream == null) return;
            MyStream.Close();
            MyStream = null;
            GC.SuppressFinalize(this);
        }

    }

    [DataContract]
    public class CheckFileResponse
    {
        [DataMember(Order = 0)]
        public bool FileExists { get; set; }

        [DataMember(Order = 1)]
        public string FileVersion { get; set; } = string.Empty;
    }

}
