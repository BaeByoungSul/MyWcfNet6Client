using BBS;
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
    public partial class frmMySQL : Form
    {
        public frmMySQL()
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
            MyCommand _cmd = new MyCommand("MST", "MYSQL_DB",
                           (int)CommandType.StoredProcedure, "USP_TEST_MST_SEL");



            _cmd.Parameters = new MyPara[2];
            _cmd.Parameters[0] = new MyPara("P_TEST_MST_NM", (int)SqlDbType.NVarChar, (int)ParameterDirection.Input);
            _cmd.Parameters[1] = new MyPara("P_TEST_PARA", (int)SqlDbType.NVarChar, (int)ParameterDirection.Input);

            //가변배열 초기화
            MyParaValue[][] myParaValues = new MyParaValue[1][];
            myParaValues[0] = new MyParaValue[2];

            myParaValues[0][0] = new MyParaValue("P_TEST_MST_NM", "%");
            myParaValues[0][1] = new MyParaValue("P_TEST_PARA", "%");

            _cmd.ParaValues = myParaValues;
            return _cmd;
        }

    }
}
