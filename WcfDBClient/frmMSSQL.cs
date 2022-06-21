using BBS;
using System.Data;
using System.Text;

namespace WcfDBClient
{
    public partial class frmMSSQL : Form
    {
        public frmMSSQL()
        {
            InitializeComponent();
          
        }

        private void btn_sel_1_Click(object sender, EventArgs e)
        {

            // 기본 binding
            MyBindinEnum bindinEnum = MyBindinEnum.Http;

            if (cbo1.Text.Equals("Http")) bindinEnum = MyBindinEnum.Http;
            else if (cbo1.Text.Equals("NetTcp")) bindinEnum = MyBindinEnum.NetTcp;

            DBClient _cli = new DBClient(bindinEnum);


            SvcReturnList<TestItemMst, TestItemDtl> rtn = _cli.GetDataList<TestItemMst, TestItemDtl>(GetCmd());

            dgv1.DataSource = null;
            dgv2.DataSource = null;

            if (rtn.ReturnCD == "OK")
            {
                dgv1.DataSource = rtn.ReturnList1;
                dgv2.DataSource = rtn.ReturnList2;

            }
        }
        private MyCommand GetCmd()
        {
            MyCommand _cmd = new MyCommand("MST", "AZURE_DB",
                           (int)CommandType.StoredProcedure, "NakDongDB..USP_TEST_MST_SEL");



            _cmd.Parameters = new MyPara[2];
            _cmd.Parameters[0] = new MyPara("@TEST_MST_NM", (int)SqlDbType.NVarChar, (int)ParameterDirection.Input);
            _cmd.Parameters[1] = new MyPara("@TEST_PARA", (int)SqlDbType.NVarChar, (int)ParameterDirection.Input);

            //가변배열 초기화
            MyParaValue[][] myParaValues = new MyParaValue[1][];
            myParaValues[0] = new MyParaValue[2];

            myParaValues[0][0] = new MyParaValue("@TEST_MST_NM", "%");
            myParaValues[0][1] = new MyParaValue("@TEST_PARA", "%");

            _cmd.ParaValues = myParaValues;
            return _cmd;
        }

        private void btn_sel_2_Click(object sender, EventArgs e)
        {
            // 기본 binding
            MyBindinEnum bindinEnum = MyBindinEnum.Http;

            if (cbo1.Text.Equals("Http")) bindinEnum = MyBindinEnum.Http;
            else if (cbo1.Text.Equals("NetTcp")) bindinEnum = MyBindinEnum.NetTcp;

            DBClient _cli = new DBClient(bindinEnum);
            SvcReturnDs rtn = _cli.GetDataSet(GetCmd());

            dgv1.DataSource = null;
            dgv2.DataSource = null;

            if (rtn.ReturnCD == "OK")
            {
                dgv1.DataSource = rtn.ReturnDs?.Tables[0];
                dgv2.DataSource = rtn.ReturnDs?.Tables[1];
            }
        }
        private void btn_ins2_Click(object sender, EventArgs e)
        {
            // Create Db Command
            List<MyCommand> mycmds = new List<MyCommand>();
            MyCommand cmdMst = ITEM_MST_Command();
            MyCommand cmdDtl = ITEM_DTL_Command();
            mycmds.AddRange(new MyCommand[] { cmdMst, cmdDtl });

            try
            {
                Cursor = Cursors.WaitCursor;    
                if (cbo1.Text == String.Empty)
                {
                    MessageBox.Show("Select Binding");
                    return;
                }

                // 기본 binding
                MyBindinEnum bindinEnum = MyBindinEnum.Http;

                if (cbo1.Text.Equals("Http")) bindinEnum = MyBindinEnum.Http;
                else if (cbo1.Text.Equals("NetTcp")) bindinEnum = MyBindinEnum.NetTcp;

                DBClient _cli = new DBClient(bindinEnum);

                SvcReturnDs rtn = _cli.ExecQuery(mycmds);

                dgv2.DataSource = rtn.ReturnDs?.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }finally
            {
                Cursor= Cursors.Default;    
            }
        }
        private void btn_ins1_Click(object sender, EventArgs e)
        {
            //
            StringBuilder strQuery1 = new StringBuilder();
            strQuery1.AppendLine("INSERT INTO  TESTDB..A_TEST1(COL1,COL2) VALUES ('dfd','222' ) ");
            strQuery1.AppendLine("INSERT INTO  TESTDB..A_TEST21(COL1,COL2) VALUES ('df','222' ) ");
            strQuery1.AppendLine("INSERT INTO  TESTDB..A_TEST1(COL1,COL2) VALUES ('fdf','222' ) ");

            // Create Db Command
            List<MyCommand> mycmds = new List<MyCommand>();
            MyCommand cmd = new MyCommand("MST_1", "BSBAE", (int)CommandType.Text, strQuery1.ToString());

            MyCommand cmdMst = ITEM_MST_Command();
            MyCommand cmdDtl = ITEM_DTL_Command();
            mycmds.AddRange(new MyCommand[] { cmdMst, cmdDtl });

            try
            {
                Cursor = Cursors.WaitCursor; 

                if (cbo1.Text == String.Empty)
                {
                    MessageBox.Show("Select Binding");
                    return;
                }

                // 기본 binding
                MyBindinEnum bindinEnum = MyBindinEnum.Http;

                if (cbo1.Text.Equals("Http")) bindinEnum = MyBindinEnum.Http;
                else if (cbo1.Text.Equals("NetTcp")) bindinEnum = MyBindinEnum.NetTcp;

                DBClient _cli = new DBClient(bindinEnum);
                //_cli.SetTransOption(System.Transactions.TransactionScopeOption.Suppress);

                SvcReturnList<DBOutPut> rtn = _cli.ExecQuery<DBOutPut>(mycmds);

                dgv1.DataSource = rtn.ReturnList;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
        private MyCommand ITEM_MST_Command()
        {

            MyCommand _cmd = new MyCommand("MST", "AZURE_DB",
                (int)CommandType.StoredProcedure, "NakDongDB..USP_TEST_MST_INS");

            _cmd.Parameters = new MyPara[2];
            _cmd.Parameters[0] = new MyPara("@TEST_MST_NM", (int)SqlDbType.NVarChar, (int)ParameterDirection.Input);
            _cmd.Parameters[1] = new MyPara("@TEST_ID", (int)SqlDbType.BigInt, (int)ParameterDirection.Output);

            // Parameter Value 가변배열 초기화
            MyParaValue[][] myParaValues = new MyParaValue[1][]; // 한세트 정의
            myParaValues[0] = new MyParaValue[2];

            myParaValues[0][0] = new MyParaValue("@TEST_MST_NM", "배병술");
            myParaValues[0][1] = new MyParaValue("@TEST_ID", "");

            _cmd.ParaValues = myParaValues;

            return _cmd;
        }
        private MyCommand ITEM_DTL_Command()
        {
            MyCommand _cmd = new MyCommand("DTL", "AZURE_DB",
                            (int)CommandType.StoredProcedure, "NakDongDB..USP_TEST_DTL_INS");


            _cmd.Parameters = new MyPara[3];

            _cmd.Parameters[0] = new MyPara("@TEST_ID", (int)SqlDbType.BigInt, (int)ParameterDirection.Input,
                "MST", "@TEST_ID");
            _cmd.Parameters[1] = new MyPara("@TEST_DTL_NM", (int)SqlDbType.NVarChar, (int)ParameterDirection.Input);
            _cmd.Parameters[2] = new MyPara("@AMOUNT", (int)SqlDbType.Decimal, (int)ParameterDirection.Input);



            // Parameter Value 가변배열 초기화
            MyParaValue[][] myParaValues = new MyParaValue[3][]; // 3세트 정의

            myParaValues[0] = new MyParaValue[3]; // 첫번째 셋트
            myParaValues[0][0] = new MyParaValue("@TEST_ID", string.Empty);
            myParaValues[0][1] = new MyParaValue("@TEST_DTL_NM", "놀부1");
            myParaValues[0][2] = new MyParaValue("@AMOUNT", "123.5");

            myParaValues[1] = new MyParaValue[3]; // 두번째 셋트
            myParaValues[1][0] = new MyParaValue("@TEST_ID", string.Empty);
            myParaValues[1][1] = new MyParaValue("@TEST_DTL_NM", "놀부2");
            myParaValues[1][2] = new MyParaValue("@AMOUNT", "222.5");

            myParaValues[2] = new MyParaValue[3]; // 세번째 셋트
            myParaValues[2][0] = new MyParaValue("@TEST_ID", string.Empty);
            myParaValues[2][1] = new MyParaValue("@TEST_DTL_NM", "흥부");
            myParaValues[2][2] = new MyParaValue("@AMOUNT", "333.5");

            _cmd.ParaValues = myParaValues;

            return _cmd;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = null;
            dgv2.DataSource = null;
        }
    }
}