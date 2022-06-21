using BBS;
using System.Diagnostics;

namespace WcfFileClient
{
    public partial class frmFile : Form
    {
        public frmFile()
        {
            InitializeComponent();
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

                // file Έν, Length
                FileInfo sfi = new FileInfo(txtUploadFile.Text.Trim());
                uploadFileData.FileName = sfi.Name;
                //uploadFileData.FileLength = sfi.Length;

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
                using (var sourceStream = File.OpenRead(sfi.FullName))
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

        private void CustomStream_ProgressChanged(object? sender, ProgressChangedEventArgs e)
        {
            long value = 100L * e.BytesRead / e.Length;


            if (this.progressBar1.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.progressBar1.Value = (int)value;
                }));

            }
            else
                this.progressBar1.Value = (int)value;

        }
    }
}