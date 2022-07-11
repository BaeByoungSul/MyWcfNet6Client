﻿using BBS.WCF;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WcfDBClient
{
    public partial class frmOracle : Form
    {
        public frmOracle()
        {
            InitializeComponent();
        }

        private void btn_sel_1_Click(object sender, EventArgs e)
        {
            // Connection명
            if (cbo2.SelectedIndex < 0) cbo2.SelectedIndex = 0;
            
            string conName = cbo2.Text;

            // 기본 binding
            MyBindinEnum bindinEnum = MyBindinEnum.Http;

            if (cbo1.Text.Equals("Http")) bindinEnum = MyBindinEnum.Http;
            else if (cbo1.Text.Equals("NetTcp")) bindinEnum = MyBindinEnum.NetTcp;

            DBClient _cli = new DBClient(bindinEnum);

            SvcReturnDs rtn = _cli.GetDataSet(GetCmd_Sel_1(conName));

            dgv1.DataSource = null;
            dgv2.DataSource = null;

            if (rtn.ReturnCD == "OK")
            {
                dgv1.DataSource = rtn.ReturnDs?.Tables[0];
                
            }
        }
        private MyCommand GetCmd_Sel_1(string conName)
        {

            MyCommand _cmd = new MyCommand("MST", conName,
                           (int)CommandType.Text, "select * from employees");

            return _cmd;
        }

        private void btn_sel_2_Click(object sender, EventArgs e)
        {
            // Connection명
            if (cbo2.SelectedIndex < 0) cbo2.SelectedIndex = 0;

            string conName = cbo2.Text;

            // 기본 binding
            MyBindinEnum bindinEnum = MyBindinEnum.Http;

            if (cbo1.Text.Equals("Http")) bindinEnum = MyBindinEnum.Http;
            else if (cbo1.Text.Equals("NetTcp")) bindinEnum = MyBindinEnum.NetTcp;

            DBClient _cli = new DBClient(bindinEnum);


            SvcReturnDs rtn = _cli.GetDataSet(GetCmd_Sel_2(conName));

            dgv1.DataSource = null;
            dgv2.DataSource = null;

            if (rtn.ReturnCD == "OK")
            {
                dgv1.DataSource = rtn.ReturnDs?.Tables[0];
                dgv2.DataSource = rtn.ReturnDs?.Tables[1];

            }
        }
        private MyCommand GetCmd_Sel_2(string conName)
        {
            MyCommand _cmd = new MyCommand(
                "MST",
                conName,
                (int)CommandType.StoredProcedure,
                "USP_TEST_PKG.Test_Query1"
            );
            // 파라미터 정의
            _cmd.Parameters = new MyPara[3];
            _cmd.Parameters[0] = new MyPara("VIEW_CUSOR1", (int)OracleDbType.RefCursor, (int)ParameterDirection.Output);
            _cmd.Parameters[1] = new MyPara("VIEW_CUSOR1", (int)OracleDbType.RefCursor, (int)ParameterDirection.Output);
            _cmd.Parameters[2] = new MyPara("P_BAD_TYPE", (int)OracleDbType.Varchar2, (int)ParameterDirection.Input);

            //파라미터 값: 가변배열 초기화
            MyParaValue[][] myParaValues = new MyParaValue[1][];
            myParaValues[0] = new MyParaValue[3];

            myParaValues[0][0] = new MyParaValue("VIEW_CUSOR1", null) ;
            myParaValues[0][1] = new MyParaValue("VIEW_CUSOR1", null);
            myParaValues[0][2] = new MyParaValue("P_BAD_TYPE", "6");

            _cmd.ParaValues = myParaValues;

            return _cmd;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgv1.DataSource = null;
            dgv2.DataSource = null;
        }

        private void btn_ins1_Click(object sender, EventArgs e)
        {

            // Connection명
            if (cbo2.SelectedIndex < 0) cbo2.SelectedIndex = 0;

            string conName = cbo2.Text;

            //
            List<MyCommand> myCmds = new List<MyCommand>();
            MyCommand cmd1 = GetCmd_INS_1(conName);
            myCmds.AddRange(new MyCommand[] { cmd1 });
            try
            {
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

                SvcReturnDs rtn = _cli.ExecQuery(myCmds);
                if (rtn.ReturnCD.Equals("OK"))
                {
                    dgv1.DataSource = rtn.ReturnDs?.Tables[0];
                }
                else
                    MessageBox.Show(rtn.ReturnMsg);
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private MyCommand GetCmd_INS_1(string conName)
        {
            StringBuilder _strQuery1 = new StringBuilder();
            _strQuery1.AppendLine(" BEGIN ");
            _strQuery1.AppendLine("   INSERT INTO  BBB_TEMP(SERIAL_NO, CREATION_DATE) VALUES ('12111',SYSDATE ); ");
            _strQuery1.AppendLine("   INSERT INTO  BBB_TEMP(SERIAL_NO, CREATION_DATE) VALUES ('12112',SYSDATE ); ");
            _strQuery1.AppendLine("   INSERT INTO  BBB_TEMP(SERIAL_NO, CREATION_DATE) VALUES ('12113',SYSDATE ); ");
            _strQuery1.AppendLine(" END;");

            MyCommand _cmd = new MyCommand("MST", conName,
                           (int)CommandType.Text, _strQuery1.ToString());

            return _cmd;
        }

        private void btn_ins2_Click(object sender, EventArgs e)
        {

            // Connection명
            if (cbo2.SelectedIndex < 0) cbo2.SelectedIndex = 0;
            string conName = cbo2.Text;


            List<MyCommand> myCmds = new List<MyCommand>();
            MyCommand cmd1 = GetCmd_INS_2(conName);
            myCmds.AddRange(new MyCommand[] { cmd1 });
            try
            {
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

                SvcReturnDs rtn = _cli.ExecQuery(myCmds);
                if (rtn.ReturnCD.Equals("OK"))
                {
                    dgv2.DataSource = rtn.ReturnDs?.Tables[0];
                }
                else
                    MessageBox.Show(rtn.ReturnMsg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }


        private MyCommand GetCmd_INS_2(string conName)
        {
            StringBuilder _strQuery1 = new StringBuilder();
            _strQuery1.AppendLine("Declare ");
            _strQuery1.AppendLine(" P_TEST_ID_OUT NUMBER; ");

            _strQuery1.AppendLine("BEGIN");
            _strQuery1.AppendLine("    USP_TEST_PKG.Test_MST (   ");
            _strQuery1.AppendLine("       P_TEST_MST_NM => '" + "흥부전" + "'");
            _strQuery1.AppendLine("    ,  P_TEST_ID => P_TEST_ID_OUT ");
            _strQuery1.AppendLine("    );  ");

            _strQuery1.AppendLine("    USP_TEST_PKG.Test_DTL (   ");
            _strQuery1.AppendLine("       P_TEST_ID     => P_TEST_ID_OUT ");
            _strQuery1.AppendLine("    ,  P_TEST_DTL_NM => '" + "흥부" + "'");
            _strQuery1.AppendLine("    );  ");

            _strQuery1.AppendLine("    USP_TEST_PKG.Test_DTL (   ");
            _strQuery1.AppendLine("       P_TEST_ID     => P_TEST_ID_OUT ");
            _strQuery1.AppendLine("    ,  P_TEST_DTL_NM => '" + "놀부" + "'");
            _strQuery1.AppendLine("    );  ");

            _strQuery1.AppendLine("    USP_TEST_PKG.Test_DTL (   ");
            _strQuery1.AppendLine("       P_TEST_ID     => P_TEST_ID_OUT ");
            _strQuery1.AppendLine("    ,  P_TEST_DTL_NM => '" + "안녕하세요" + "'");
            _strQuery1.AppendLine("    );  ");

            _strQuery1.AppendLine("END;");


            MyCommand _cmd = new MyCommand("MST", conName,
                           (int)CommandType.Text, _strQuery1.ToString());

            return _cmd;
        }

        private void btn_ins3_Click(object sender, EventArgs e)
        {

            // Connection명
            if (cbo2.SelectedIndex < 0) cbo2.SelectedIndex = 0;
            string conName = cbo2.Text;

            // Create Db Command
            List<MyCommand> mycmds = new List<MyCommand>();
            MyCommand cmdMst = ITEM_MST_Command(conName);
            MyCommand cmdDtl = ITEM_DTL_Command(conName);
            mycmds.AddRange(new MyCommand[] { cmdMst, cmdDtl });

            try
            {
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
                if (rtn.ReturnCD.Equals("OK"))
                {
                    dgv2.DataSource = rtn.ReturnDs?.Tables[0];
                }
                else
                    MessageBox.Show(rtn.ReturnMsg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        private MyCommand ITEM_MST_Command(string conName)
        {

            MyCommand _cmd = new MyCommand("MST", conName,
                (int)CommandType.StoredProcedure, "USP_TEST_PKG.Test_MST");

            _cmd.Parameters = new MyPara[2];
            _cmd.Parameters[0] = new MyPara("P_TEST_MST_NM", (int)OracleDbType.Varchar2, (int)ParameterDirection.Input);
            _cmd.Parameters[1] = new MyPara("P_TEST_ID", (int)OracleDbType.Decimal, (int)ParameterDirection.Output);

            // Parameter Value 가변배열 초기화
            MyParaValue[][] myParaValues = new MyParaValue[1][]; // 한세트 정의

            myParaValues[0] = new MyParaValue[2];
            myParaValues[0][0] = new MyParaValue("P_TEST_MST_NM", "배병술");
            myParaValues[0][1] = new MyParaValue("P_TEST_ID", null);

            _cmd.ParaValues = myParaValues;

            return _cmd;
        }
        private MyCommand ITEM_DTL_Command(string conName)
        {
            MyCommand _cmd = new MyCommand("DTL", conName,
                            (int)CommandType.StoredProcedure, "USP_TEST_PKG.Test_DTL");


            _cmd.Parameters = new MyPara[3];

            _cmd.Parameters[0] = new MyPara("P_TEST_ID", (int)OracleDbType.Decimal, (int)ParameterDirection.Input,
                "MST", "P_TEST_ID");
            _cmd.Parameters[1] = new MyPara("P_TEST_DTL_NM", (int)OracleDbType.Varchar2, (int)ParameterDirection.Input);
            _cmd.Parameters[2] = new MyPara("P_AMOUNT", (int)OracleDbType.Decimal, (int)ParameterDirection.Input);



            // Parameter Value 가변배열 초기화
            MyParaValue[][] myParaValues = new MyParaValue[3][]; // 3세트 정의

            myParaValues[0] = new MyParaValue[3]; // 첫번째 셋트
            myParaValues[0][0] = new MyParaValue("P_TEST_ID", null);
            myParaValues[0][1] = new MyParaValue("P_TEST_DTL_NM", "놀부1");
            myParaValues[0][2] = new MyParaValue("P_AMOUNT", "123.5");

            myParaValues[1] = new MyParaValue[3]; // 두번째 셋트
            myParaValues[1][0] = new MyParaValue("P_TEST_ID", null);
            myParaValues[1][1] = new MyParaValue("P_TEST_DTL_NM", "놀부2");
            myParaValues[1][2] = new MyParaValue("P_AMOUNT", "222.5");

            myParaValues[2] = new MyParaValue[3]; // 세번째 셋트
            myParaValues[2][0] = new MyParaValue("P_TEST_ID", null);
            myParaValues[2][1] = new MyParaValue("P_TEST_DTL_NM", "흥부");
            myParaValues[2][2] = new MyParaValue("P_AMOUNT", "333.5");

            _cmd.ParaValues = myParaValues;

            return _cmd;
        }


    }
}
