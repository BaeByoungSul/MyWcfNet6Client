using BBS;
using System;
using System.ComponentModel;
using System.Diagnostics;

namespace WcfFileClient
{
    public partial class frmFile : Form
    {
        public frmFile()
        {
            InitializeComponent();
            //CheckForIllegalCrossThreadCalls = false; 
        }

        private void btn_file_select_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string initFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                //openFileDialog.InitialDirectory = initFolder; 
                openFileDialog.Filter = "All files (*.*)|*.*|(*.dll)|*.dll";

                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    txtUploadFile.Text = openFileDialog.FileName;


                }
            }
        }

        
        private void btn_t1_upload_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo1.Text == String.Empty)
                {
                    MessageBox.Show("Select Binding");
                    return;
                }
                FileData uploadFileData = new FileData();

                // file 명, Length
                FileInfo sfi = new FileInfo(txtUploadFile.Text.Trim());
                uploadFileData.FileName = sfi.Name;
                uploadFileData.FileLength = sfi.Length;

                FileClient _cli;//= new FileClient();
                if (cbo1.Text.Equals("Http"))
                {
                    _cli = new FileClient(MyBindinEnum.Http);
                }
                else  //if(cbo_t1.Text.Equals("NetTcp"))
                {
                    _cli = new FileClient(MyBindinEnum.NetTcp);
                }

                Stopwatch sw = new Stopwatch();
                sw.Start();
                //                using (var sourceStream = File.OpenRead(sfi.FullName))
                using (var sourceStream = new FileStream(sfi.FullName,
                  System.IO.FileMode.Open,
                  System.IO.FileAccess.Read,
                  System.IO.FileShare.None, 65536))

                {
                    CustomStream customStream = new CustomStream(sourceStream, sfi.Length);
                    customStream.ProgressChanged += CustomStream_ProgressChanged; ;

                    uploadFileData.MyStream = customStream;

                    _cli.UploadFile(uploadFileData);
                }
               
                sw.Stop();
                txrElapsedTime.Text = Convert.ToString(sw.ElapsedMilliseconds / 1000);
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }


        /// <summary>
        /// progressBar1.Invoke에서 멈춰서 BeginInvoke로 
        /// https://stackoverflow.com/questions/8978573/reasons-that-control-begininvoke-would-not-execute-a-delegate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception"></exception>
        private void CustomStream_ProgressChanged(object? sender, MyProgressChangedEventArgs e)
        {
            long value = 100L * e.BytesRead / e.Length;

            if (progressBar1.InvokeRequired)
            {

                progressBar1.BeginInvoke(() => 
                {
                    this.progressBar1.Value = (int)value;
                    Debug.WriteLine(e.BytesRead);
                
                });

                //progressBar1.Invoke(new MethodInvoker(delegate ()
                //{
                //    this.progressBar2.Value = (int)value;
                //}));
            }
            else
            {
                progressBar1.Value = (int)value;
            }

            


        }

        private void btn_t1_download_Click(object sender, EventArgs e)
        {
            string targetFilePath = Path.Combine(@"d:\", txt_t1_download.Text);

            try
            {

                if (cbo1.Text == String.Empty)
                {
                    MessageBox.Show("Select Binding");
                    return;
                }

                // file 명, Length

                FileClient _cli; //= new FileClient();
                if (cbo1.Text.Equals("Http"))
                {
                    _cli = new FileClient(MyBindinEnum.Http);
                }
                else  //if(cbo_t1.Text.Equals("NetTcp"))
                {
                    _cli = new FileClient(MyBindinEnum.NetTcp);
                }

                Stopwatch sw = new Stopwatch();
                sw.Start();

                using (FileData filedata = _cli.DownloadFile(new DownloadRequest { FileName = txt_t1_download.Text }))
                {
                    if (filedata.MyStream == null) throw new Exception("Download file stream is null");
                    
                    CustomStream customStream = new CustomStream(filedata.MyStream, filedata.FileLength);
                    customStream.ProgressChanged += Download_ProgressChanged1;

                    // File이 있어면 삭제
                    if (File.Exists(targetFilePath)) File.Delete(targetFilePath);

                    // Target filestream 생성
                    //FileStream targetStream = File.Create(targetFilePath);
                    FileStream targetStream = new FileStream(targetFilePath, FileMode.Create, FileAccess.Write, FileShare.None, 65536);
                    customStream.CopyTo(targetStream);
                    targetStream.Close();
                }

                sw.Stop();
                txrElapsedTime.Text = Convert.ToString(sw.ElapsedMilliseconds / 1000);

                _cli.MyClose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        private void Download_ProgressChanged1(object? sender, MyProgressChangedEventArgs e)
        {
            long value = 100L * e.BytesRead / e.Length;

            this.progressBar1.Value = (int)value;
        }

        private async void btn_t2_upload_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo1.Text == String.Empty)
                {
                    MessageBox.Show("Select Binding");
                    return;
                }
                FileData uploadFileData = new FileData();

                // file 명, Length
                FileInfo sfi = new FileInfo(txtUploadFile.Text.Trim());
                uploadFileData.FileName = sfi.Name;
                //uploadFileData.FileLength = sfi.Length;

                FileClient _cli; //= new FileClient();
                if (cbo1.Text.Equals("Http"))
                {
                    _cli = new FileClient(MyBindinEnum.Http);
                }
                else  //if(cbo_t1.Text.Equals("NetTcp"))
                {
                    _cli = new FileClient(MyBindinEnum.NetTcp);
                }

                Stopwatch sw = new Stopwatch();
                sw.Start();
                using (var sourceStream = File.OpenRead(sfi.FullName))
                {
                    CustomStream customStream = new CustomStream(sourceStream, sfi.Length);
                    customStream.ProgressChanged += CustomStream_ProgressChanged1; ;

                    uploadFileData.MyStream = customStream;
                    await _cli.UploadFileAsync(uploadFileData);
                }
                sw.Stop();
                txrElapsedTime.Text = Convert.ToString(sw.ElapsedMilliseconds / 1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
        private void CustomStream_ProgressChanged1(object? sender, MyProgressChangedEventArgs e)
        {
            long value = 100L * e.BytesRead / e.Length;
            if (this.progressBar2.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.progressBar2.Value = (int)value;
                }));
            }
            else
                this.progressBar2.Value = (int)value;
        }
        private async void btn_t2_download_Click(object sender, EventArgs e)
        {
       
            string targetFilePath = Path.Combine(@"d:\", txt_t2_download.Text);

            try
            {

                if (cbo1.Text == String.Empty)
                {
                    MessageBox.Show("Select Binding");
                    return;
                }

                // file 명, Length

                FileClient _cli; //= new FileClient();
                if (cbo1.Text.Equals("Http"))
                {
                    _cli = new FileClient(MyBindinEnum.Http);
                }
                else  //if(cbo_t1.Text.Equals("NetTcp"))
                {
                    _cli = new FileClient(MyBindinEnum.NetTcp);
                }

                Stopwatch sw = new Stopwatch();
                sw.Start();

                using (FileData filedata = await _cli.DownloadFileAsync(new DownloadRequest { FileName = txt_t2_download.Text }))
                {
                    if (filedata.MyStream == null) throw new Exception("Download file stream is null");

                    CustomStream customStream = new CustomStream(filedata.MyStream, filedata.FileLength);
                    customStream.ProgressChanged += CustomStream_ProgressChanged1;

                    // file이 있어면 삭제
                    if (File.Exists(targetFilePath)) File.Delete(targetFilePath);

                    // Target filestream 생성
                    //FileStream targetStream = File.Create(targetFilePath);
                    FileStream targetStream = new FileStream(targetFilePath, FileMode.Create, FileAccess.Write, FileShare.None, 65536);
                    await customStream.CopyToAsync(targetStream);

                    //await Task.Run(() => customStream.CopyTo(targetStream));

                    targetStream.Close();
                }
                sw.Stop();
                txrElapsedTime.Text = Convert.ToString(sw.ElapsedMilliseconds / 1000);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        /**********
        private async void btn_t2_upload2_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbo1.Text == String.Empty)
                {
                    MessageBox.Show("Select Binding");
                    return;
                }
                FileData uploadFileData = new FileData();

                // file 명, Length
                FileInfo sfi = new FileInfo(txtUploadFile.Text.Trim());
                uploadFileData.FileName = sfi.Name;
                //uploadFileData.FileLength = sfi.Length;

                FileClient _cli; //= new FileClient();
                if (cbo1.Text.Equals("Http"))
                {
                    _cli = new FileClient(MyBindinEnum.Http);
                }
                else  //if(cbo_t1.Text.Equals("NetTcp"))
                {
                    _cli = new FileClient(MyBindinEnum.NetTcp);
                }

                Stopwatch sw = new Stopwatch();
                sw.Start();
                using (var sourceStream = File.OpenRead(sfi.FullName))
                {
                    CustomStream customStream = new CustomStream(sourceStream, sfi.Length);
                    customStream.ProgressChanged += CustomStream_ProgressChanged1; ;

                    uploadFileData.MyStream = customStream;
                    await _cli.UploadFileMyAsync(uploadFileData);
                }
                sw.Stop();
                txrElapsedTime.Text = Convert.ToString(sw.ElapsedMilliseconds / 1000);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private async void btn_t2_download2_Click(object sender, EventArgs e)
        {
            string targetFilePath = Path.Combine(@"d:\", txt_t2_download.Text);

            try
            {

                if (cbo1.Text == String.Empty)
                {
                    MessageBox.Show("Select Binding");
                    return;
                }

                // file 명, Length

                FileClient _cli; //= new FileClient();
                if (cbo1.Text.Equals("Http"))
                {
                    _cli = new FileClient(MyBindinEnum.Http);
                }
                else  //if(cbo_t1.Text.Equals("NetTcp"))
                {
                    _cli = new FileClient(MyBindinEnum.NetTcp);
                }

                Stopwatch sw = new Stopwatch();
                sw.Start();

                using (FileData filedata = await _cli.DownloadFileMyAsync(new DownloadRequest { FileName = txt_t2_download.Text }))
                {
                    CustomStream customStream = new CustomStream(filedata.MyStream, filedata.FileLength);
                    customStream.ProgressChanged += CustomStream_ProgressChanged1;

                    // file이 있어면 삭제
                    if (File.Exists(targetFilePath)) File.Delete(targetFilePath);

                    // Target filestream 생성
                    FileStream targetStream = File.Create(targetFilePath);
                    await customStream.CopyToAsync(targetStream);

                    //await Task.Run(() => customStream.CopyTo(targetStream));

                    targetStream.Close();
                }
                sw.Stop();
                txrElapsedTime.Text = Convert.ToString(sw.ElapsedMilliseconds / 1000);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

*****************************/
    }
}