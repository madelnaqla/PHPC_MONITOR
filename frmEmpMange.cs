using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.OleDb;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;


namespace Time_Attendance
{
    public partial class frmEmpMange : Form
    {
        SqlCommand _cmd;
        SqlDataAdapter _da;
        public DataTable _NavDt = new DataTable();
        public SqlConnection _MasterCon;
        public int _index;
        string _ID = "";
        static string ID = "";
        public DataSet _ds;
        string _CardNo = "";
        static byte[] imageData;
        public static string Path = "";
        public static string AccessPassword = "";
//        static int FLAG = 0;
        static int  CHANGE= 0;

        DataRow[] dr;
        public frmEmpMange()
        {
            InitializeComponent();

            DBConnection();
        }

        private void DBConnection()
        {

            // _MasterCon = new SqlConnection("Data Source=.; Initial Catalog= EsofWIN_Finger; user=sa; password=123456");
            try
            {
                _MasterCon = frmMainForm._MasterCon;
                //_MasterCon.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Server Connection isn't Available, check configeration!!", "connecting to server......");
            }
            comboBox1.SelectedIndex = 0;
        }

        private void frmEmpMange_Load(object sender, EventArgs e)
        {
            butt_stop.Enabled = true;
            butt_start.Enabled = false;
            radioButtonIn.Enabled = false;
            radioButtonOut.Enabled = false;
            textBox1.Enabled = false;
            comboBox1.SelectedItem = frmMainForm.main_door;
            if (frmMainForm.main_door == "All")
            {
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
            }
            //
            timer1.Enabled = false;
            timer1_Tick(null, null);
            timer1.Enabled = true;
            //comboBox1.SelectedIndex = 0;
            //FLAG = 1;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Open file in to a filestream and read data in a byte array.
        static public byte[] ReadFile(string sPath)
        {
            //Initialize byte array with a null value initially.
            byte[] data = null;

            //Use FileInfo object to get file size.
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;

            //Open FileStream to read file
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);

            //Use BinaryReader to read file stream into byte array.
            BinaryReader br = new BinaryReader(fStream);

            //When you use BinaryReader, you need to supply number of bytes to read from file.
            //In this case we want to read entire file. So supplying total number of bytes.
            data = br.ReadBytes((int)numBytes);
            return data;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable DT = new DataTable();
            SqlCommand _cmd = new SqlCommand(/*"", frmMainForm._MasterCon*/);
            _cmd.Connection = frmMainForm._MasterCon;
            if (comboBox1.SelectedIndex == 0)
            { _cmd.CommandText = "SELECT TOP (1) AA.TRN_TIME,AA.TRN_CARD_NO,CRD_NAME, CRD_DEPARTMENT, CRD_JOB,TRN_PLACE,PhotoBytes FROM(SELECT MAX(TRN_TIME)TRN_TIME,TRN_CARD_NO,TRN_PLACE FROM dbo.EMPLOYEE_TRANSACTIONS_MONITOR GROUP BY TRN_CARD_NO,TRN_PLACE)AS AA INNER JOIN dbo.EMPLOYEE_CARDS ON dbo.EMPLOYEE_CARDS.CRD_NO=AA.TRN_CARD_NO order by 1 DESC"; }
            else if (comboBox1.SelectedIndex == 1)
            { _cmd.CommandText = "SELECT TOP (1) AA.TRN_TIME,AA.TRN_CARD_NO,CRD_NAME, CRD_DEPARTMENT, CRD_JOB,TRN_PLACE,PhotoBytes FROM(SELECT MAX(TRN_TIME)TRN_TIME,TRN_CARD_NO,TRN_PLACE,TRN_MACHINE FROM dbo.EMPLOYEE_TRANSACTIONS_MONITOR WHERE TRN_MACHINE IN('in','out')GROUP BY TRN_CARD_NO,TRN_PLACE,TRN_MACHINE)AS AA INNER JOIN dbo.EMPLOYEE_CARDS ON dbo.EMPLOYEE_CARDS.CRD_NO=AA.TRN_CARD_NO order by 1 DESC"; }
            else if (comboBox1.SelectedIndex == 2)
            { _cmd.CommandText = "SELECT TOP (1) AA.TRN_TIME,AA.TRN_CARD_NO,CRD_NAME, CRD_DEPARTMENT, CRD_JOB,TRN_PLACE,PhotoBytes FROM(SELECT MAX(TRN_TIME)TRN_TIME,TRN_CARD_NO,TRN_PLACE,TRN_MACHINE FROM dbo.EMPLOYEE_TRANSACTIONS_MONITOR WHERE TRN_MACHINE IN('new in','new out')GROUP BY TRN_CARD_NO,TRN_PLACE,TRN_MACHINE)AS AA INNER JOIN dbo.EMPLOYEE_CARDS ON dbo.EMPLOYEE_CARDS.CRD_NO=AA.TRN_CARD_NO order by 1 DESC"; }


            SqlDataAdapter _da = new SqlDataAdapter(_cmd);
            _da.Fill(DT);
            if (DT.Rows.Count >= 1 || CHANGE==1)
            {
                if (LBL_IN_OUT.Text != DT.Rows[0]["TRN_TIME"].ToString()|| CHANGE==1)// || FLAG < 1)
                {
                    txtCardNo.Text = DT.Rows[0]["TRN_CARD_NO"].ToString();
                    txtemployeename.Text = DT.Rows[0]["CRD_NAME"].ToString();
                    txt_department.Text = DT.Rows[0]["CRD_DEPARTMENT"].ToString();
                    txtJob.Text = DT.Rows[0]["CRD_JOB"].ToString();
                    LBL_IN_OUT.Text = DT.Rows[0]["TRN_TIME"].ToString();
                    LBL_IN.Text = DT.Rows[0]["TRN_PLACE"].ToString();
                    if (LBL_IN.Text == "In")
                    {
                        LBL_IN.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        LBL_IN.ForeColor = System.Drawing.Color.Red;
                    }
                    try
                    {
                        //Get image data from gridview column.
                        imageData = (byte[])DT.Rows[0]["PhotoBytes"];

                        //Initialize image variable
                        Image newImage;
                        //Read image data into a memory stream
                        using (MemoryStream ms = new MemoryStream(imageData, 0, imageData.Length))
                        {
                            ms.Write(imageData, 0, imageData.Length);

                            //Set image variable value using memory stream.
                            newImage = Image.FromStream(ms, true);
                        }

                        //set picture
                        pictureBox1.Image = newImage;
                    }
                    catch (Exception ex)
                    {
                        pictureBox1.Image = null;
                        //MessageBox.Show(ex.ToString());
                    }
                    //-----------------------


                    DT = new DataTable();
                    _cmd = new SqlCommand();
                    _cmd.Connection = frmMainForm._MasterCon;
                    if (radioButtonIn.Checked)
                    {
                        if (comboBox1.SelectedIndex == 0)
                        { _cmd.CommandText = "SELECT top(" + textBox1.Text + ") EMPLOYEE_CARDS.PhotoBytes , EMPLOYEE_CARDS.CRD_NO, EMPLOYEE_CARDS.CRD_NAME, rtrim(convert(char(20),AA.TRN_TIME,103))+' '+rtrim(convert(char(20),AA.TRN_TIME,24))as TRN_TIME, EMPLOYEE_CARDS.CRD_JOB, EMPLOYEE_CARDS.CRD_DEPARTMENT, AA.TRN_PLACE   FROM     (SELECT     MAX(TRN_TIME) AS TRN_TIME, TRN_CARD_NO, TRN_PLACE FROM         EMPLOYEE_TRANSACTIONS_MONITOR WHERE     (TRN_PLACE = 'In') AND TRN_TIME>(dbo.GET_MAX_OUT(TRN_CARD_NO)) AND (TRN_TIME BETWEEN DATEADD(dd,-1,GETDATE()) AND GETDATE()) GROUP BY TRN_CARD_NO, TRN_PLACE) AS AA INNER JOIN EMPLOYEE_CARDS ON EMPLOYEE_CARDS.CRD_NO = AA.TRN_CARD_NO ORDER BY TRN_TIME desc"; }
                        else if (comboBox1.SelectedIndex == 1)
                        { _cmd.CommandText = "SELECT top(" + textBox1.Text + ") EMPLOYEE_CARDS.PhotoBytes , EMPLOYEE_CARDS.CRD_NO, EMPLOYEE_CARDS.CRD_NAME, rtrim(convert(char(20),AA.TRN_TIME,103))+' '+rtrim(convert(char(20),AA.TRN_TIME,24))as TRN_TIME, EMPLOYEE_CARDS.CRD_JOB, EMPLOYEE_CARDS.CRD_DEPARTMENT, AA.TRN_PLACE   FROM     (SELECT     MAX(TRN_TIME) AS TRN_TIME, TRN_CARD_NO, TRN_PLACE ,TRN_MACHINE FROM         EMPLOYEE_TRANSACTIONS_MONITOR WHERE     (TRN_PLACE = 'In')AND TRN_MACHINE IN ('in','out') AND TRN_TIME>=(dbo.GET_MAX_OUT(TRN_CARD_NO)) AND (TRN_TIME BETWEEN DATEADD(dd,-1,GETDATE()) AND GETDATE()) GROUP BY TRN_CARD_NO, TRN_PLACE,TRN_MACHINE) AS AA INNER JOIN EMPLOYEE_CARDS ON EMPLOYEE_CARDS.CRD_NO = AA.TRN_CARD_NO ORDER BY TRN_TIME desc"; }
                        else if (comboBox1.SelectedIndex == 2)
                        { _cmd.CommandText = "SELECT top(" + textBox1.Text + ") EMPLOYEE_CARDS.PhotoBytes , EMPLOYEE_CARDS.CRD_NO, EMPLOYEE_CARDS.CRD_NAME, rtrim(convert(char(20),AA.TRN_TIME,103))+' '+rtrim(convert(char(20),AA.TRN_TIME,24))as TRN_TIME, EMPLOYEE_CARDS.CRD_JOB, EMPLOYEE_CARDS.CRD_DEPARTMENT, AA.TRN_PLACE   FROM     (SELECT     MAX(TRN_TIME) AS TRN_TIME, TRN_CARD_NO, TRN_PLACE ,TRN_MACHINE FROM         EMPLOYEE_TRANSACTIONS_MONITOR WHERE     (TRN_PLACE = 'In')AND TRN_MACHINE IN ('new in','new out') AND TRN_TIME>=(dbo.GET_MAX_OUT(TRN_CARD_NO)) AND (TRN_TIME BETWEEN DATEADD(dd,-1,GETDATE()) AND GETDATE()) GROUP BY TRN_CARD_NO, TRN_PLACE,TRN_MACHINE) AS AA INNER JOIN EMPLOYEE_CARDS ON EMPLOYEE_CARDS.CRD_NO = AA.TRN_CARD_NO ORDER BY TRN_TIME desc"; }
                    }
                    else
                    {
                        if (comboBox1.SelectedIndex == 0)
                        { _cmd.CommandText = "SELECT top(" + textBox1.Text + ") EMPLOYEE_CARDS.PhotoBytes , EMPLOYEE_CARDS.CRD_NO, EMPLOYEE_CARDS.CRD_NAME, rtrim(convert(char(20),AA.TRN_TIME,103))+' '+rtrim(convert(char(20),AA.TRN_TIME,24))as TRN_TIME, EMPLOYEE_CARDS.CRD_JOB, EMPLOYEE_CARDS.CRD_DEPARTMENT, AA.TRN_PLACE   FROM     (SELECT     MAX(TRN_TIME) AS TRN_TIME, TRN_CARD_NO, TRN_PLACE  FROM         EMPLOYEE_TRANSACTIONS_MONITOR WHERE     (TRN_PLACE = 'Out') AND (TRN_TIME BETWEEN DATEADD(dd,-1,GETDATE()) AND GETDATE()) GROUP BY TRN_CARD_NO, TRN_PLACE) AS AA INNER JOIN EMPLOYEE_CARDS ON EMPLOYEE_CARDS.CRD_NO = AA.TRN_CARD_NO ORDER BY TRN_TIME desc"; }
                        else if (comboBox1.SelectedIndex == 1)
                        { _cmd.CommandText = "SELECT top(" + textBox1.Text + ") EMPLOYEE_CARDS.PhotoBytes , EMPLOYEE_CARDS.CRD_NO, EMPLOYEE_CARDS.CRD_NAME, rtrim(convert(char(20),AA.TRN_TIME,103))+' '+rtrim(convert(char(20),AA.TRN_TIME,24))as TRN_TIME, EMPLOYEE_CARDS.CRD_JOB, EMPLOYEE_CARDS.CRD_DEPARTMENT, AA.TRN_PLACE   FROM     (SELECT     MAX(TRN_TIME) AS TRN_TIME, TRN_CARD_NO, TRN_PLACE  FROM         EMPLOYEE_TRANSACTIONS_MONITOR WHERE     (TRN_PLACE = 'Out')AND TRN_MACHINE IN ('in','out') AND TRN_TIME>=(dbo.GET_MAX_OUT(TRN_CARD_NO)) AND (TRN_TIME BETWEEN DATEADD(dd,-1,GETDATE()) AND GETDATE()) GROUP BY TRN_CARD_NO, TRN_PLACE) AS AA INNER JOIN EMPLOYEE_CARDS ON EMPLOYEE_CARDS.CRD_NO = AA.TRN_CARD_NO ORDER BY TRN_TIME desc";
                       /* timer1.Enabled = false;
                           textBox2.Text= _cmd.CommandText;*/
                        }
                        else if (comboBox1.SelectedIndex == 2)
                        { _cmd.CommandText = "SELECT top(" + textBox1.Text + ") EMPLOYEE_CARDS.PhotoBytes , EMPLOYEE_CARDS.CRD_NO, EMPLOYEE_CARDS.CRD_NAME, rtrim(convert(char(20),AA.TRN_TIME,103))+' '+rtrim(convert(char(20),AA.TRN_TIME,24))as TRN_TIME, EMPLOYEE_CARDS.CRD_JOB, EMPLOYEE_CARDS.CRD_DEPARTMENT, AA.TRN_PLACE   FROM     (SELECT     MAX(TRN_TIME) AS TRN_TIME, TRN_CARD_NO, TRN_PLACE,TRN_MACHINE  FROM         EMPLOYEE_TRANSACTIONS_MONITOR WHERE     (TRN_PLACE = 'Out')AND TRN_MACHINE IN ('new in','new out') AND TRN_TIME>=(dbo.GET_MAX_OUT(TRN_CARD_NO)) AND (TRN_TIME BETWEEN DATEADD(dd,-1,GETDATE()) AND GETDATE()) GROUP BY TRN_CARD_NO, TRN_PLACE,TRN_MACHINE) AS AA INNER JOIN EMPLOYEE_CARDS ON EMPLOYEE_CARDS.CRD_NO = AA.TRN_CARD_NO ORDER BY TRN_TIME desc"; }
                    }
                    _da = new SqlDataAdapter(_cmd);
                    _da.Fill(DT);
                    GrdEmployees.DataSource = DT;                    
                }
                //FLAG += 1;
            }
        }

        private void GrdEmployees_InitializeLayout(object sender, Infragistics.Win.UltraWinGrid.InitializeLayoutEventArgs e)
        {
            GrdEmployees.DisplayLayout.Override.MinRowHeight = 100;
            GrdEmployees.DisplayLayout.Override.CellAppearance.TextHAlign = HAlign.Center;
            GrdEmployees.DisplayLayout.Override.CellAppearance.TextVAlign = VAlign.Middle;
            GrdEmployees.DisplayLayout.Override.CellAppearance.BorderAlpha = Alpha.Transparent;
            GrdEmployees.DisplayLayout.Override.RowAppearance.BorderAlpha = Alpha.Transparent;
            GrdEmployees.DisplayLayout.Override.RowAppearance.BorderColor = Color.White;
            GrdEmployees.DisplayLayout.Override.RowSelectors = DefaultableBoolean.False;
            GrdEmployees.DisplayLayout.Override.FilterUIType = FilterUIType.HeaderIcons;
            GrdEmployees.DisplayLayout.Bands[0].Columns["CRD_DEPARTMENT"].Hidden = true;
            GrdEmployees.DisplayLayout.Bands[0].Columns["TRN_PLACE"].Hidden = true;
            GrdEmployees.DisplayLayout.Bands[0].Columns["CRD_job"].Hidden = true;
            GrdEmployees.DisplayLayout.Bands[0].Columns["PhotoBytes"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.Image;
            e.Layout.Bands[0].Columns["CRD_NO"].Header.Caption = "Employee No.";
            e.Layout.Bands[0].Columns["PhotoBytes"].Header.Caption = "";
            e.Layout.Bands[0].Columns["CRD_NAME"].Header.Caption = "Name";
            e.Layout.Bands[0].Columns["TRN_TIME"].Header.Caption = "Enter Time";
            e.Layout.Bands[0].Columns["CRD_job"].Header.Caption = "JOB";
            e.Layout.Bands[0].Columns["CRD_DEPARTMENT"].Header.Caption = "DEPARTMENT";
            e.Layout.Bands[0].Columns["TRN_PLACE"].Header.Caption = "Place";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CHANGE = 1;
            timer1_Tick(null, null);
            CHANGE = 0;
        }

        private void Btncancel_Click(object sender, EventArgs e)
        {
            _cmd = new SqlCommand();
            _cmd.Connection = _MasterCon;
            if (comboBox1.SelectedIndex == 0)
            { _cmd.CommandText = "SELECT EMPLOYEE_CARDS.PhotoBytes , EMPLOYEE_CARDS.CRD_NO, EMPLOYEE_CARDS.CRD_NAME, rtrim(convert(char(20),AA.TRN_TIME,103))+' '+rtrim(convert(char(20),AA.TRN_TIME,24))as TRN_TIME, EMPLOYEE_CARDS.CRD_JOB, EMPLOYEE_CARDS.CRD_DEPARTMENT, AA.TRN_PLACE   FROM     (SELECT     MAX(TRN_TIME) AS TRN_TIME, TRN_CARD_NO, TRN_PLACE FROM         EMPLOYEE_TRANSACTIONS_MONITOR WHERE     (TRN_PLACE = 'In') AND TRN_TIME>(dbo.GET_MAX_OUT(TRN_CARD_NO)) AND (TRN_TIME BETWEEN DATEADD(dd,-1,GETDATE()) AND GETDATE()) GROUP BY TRN_CARD_NO, TRN_PLACE) AS AA INNER JOIN EMPLOYEE_CARDS ON EMPLOYEE_CARDS.CRD_NO = AA.TRN_CARD_NO ORDER BY TRN_TIME"; }
            else if (comboBox1.SelectedIndex == 1)
            { _cmd.CommandText = "SELECT EMPLOYEE_CARDS.PhotoBytes , EMPLOYEE_CARDS.CRD_NO, EMPLOYEE_CARDS.CRD_NAME, rtrim(convert(char(20),AA.TRN_TIME,103))+' '+rtrim(convert(char(20),AA.TRN_TIME,24))as TRN_TIME, EMPLOYEE_CARDS.CRD_JOB, EMPLOYEE_CARDS.CRD_DEPARTMENT, AA.TRN_PLACE   FROM     (SELECT     MAX(TRN_TIME) AS TRN_TIME, TRN_CARD_NO, TRN_PLACE ,TRN_MACHINE FROM         EMPLOYEE_TRANSACTIONS_MONITOR WHERE     (TRN_PLACE = 'In')AND TRN_MACHINE IN ('in','out') AND TRN_TIME>(dbo.GET_MAX_OUT(TRN_CARD_NO)) AND (TRN_TIME BETWEEN DATEADD(dd,-1,GETDATE()) AND GETDATE()) GROUP BY TRN_CARD_NO, TRN_PLACE,TRN_MACHINE) AS AA INNER JOIN EMPLOYEE_CARDS ON EMPLOYEE_CARDS.CRD_NO = AA.TRN_CARD_NO ORDER BY TRN_TIME"; }
            else if (comboBox1.SelectedIndex == 2)
            { _cmd.CommandText = "SELECT EMPLOYEE_CARDS.PhotoBytes , EMPLOYEE_CARDS.CRD_NO, EMPLOYEE_CARDS.CRD_NAME, rtrim(convert(char(20),AA.TRN_TIME,103))+' '+rtrim(convert(char(20),AA.TRN_TIME,24))as TRN_TIME, EMPLOYEE_CARDS.CRD_JOB, EMPLOYEE_CARDS.CRD_DEPARTMENT, AA.TRN_PLACE   FROM     (SELECT     MAX(TRN_TIME) AS TRN_TIME, TRN_CARD_NO, TRN_PLACE ,TRN_MACHINE FROM         EMPLOYEE_TRANSACTIONS_MONITOR WHERE     (TRN_PLACE = 'In')AND TRN_MACHINE IN ('new in','new out') AND TRN_TIME>(dbo.GET_MAX_OUT(TRN_CARD_NO)) AND (TRN_TIME BETWEEN DATEADD(dd,-1,GETDATE()) AND GETDATE()) GROUP BY TRN_CARD_NO, TRN_PLACE,TRN_MACHINE) AS AA INNER JOIN EMPLOYEE_CARDS ON EMPLOYEE_CARDS.CRD_NO = AA.TRN_CARD_NO ORDER BY TRN_TIME"; }
            _cmd.CommandTimeout = 2000;
            _da = new SqlDataAdapter(_cmd);
            DataTable _Dt = new DataTable();
            _Dt.Reset();
            _da.Fill(_Dt);

            frmReportViewer2 Viewer = new frmReportViewer2();

            if (_Dt.Rows.Count == 0)
            {
                MessageBox.Show("Message_No_Records", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
            In_COM_Rpt EmpTransRpt = new In_COM_Rpt();
            EmpTransRpt.Database.Tables[0].SetDataSource(_Dt);
            EmpTransRpt.SetParameterValue(EmpTransRpt.Parameter_From.ParameterFieldName, DateTime.Now.ToString("dd/MM/yyyy"));
            EmpTransRpt.SetParameterValue(EmpTransRpt.Parameter_IN_OUT.ParameterFieldName, "IN");
            Viewer.crystalReportViewer1.ReportSource = EmpTransRpt;
            Viewer.ShowDialog();
        }

        private void radioButtonOut_CheckedChanged(object sender, EventArgs e)
        {
            timer1_Tick(null, null);
        }

        private void radioButtonIn_CheckedChanged(object sender, EventArgs e)
        {
            timer1_Tick(null, null);
        }

        private void butt_stop_Click(object sender, EventArgs e)
        {
            butt_start.Enabled = true;
            butt_stop.Enabled = false;
            radioButtonIn.Enabled = true;
            radioButtonOut.Enabled = true;
            textBox1.Enabled = true;
            timer1.Enabled = false;
        }

        private void butt_start_Click(object sender, EventArgs e)
        {
            CHANGE = 1;
            int x;
            int.TryParse(textBox1.Text,out x);
            if (x == 0)
            {
                MessageBox.Show("must be number");
            }
            else
            {
                butt_stop.Enabled = true;
                butt_start.Enabled = false;
                radioButtonIn.Enabled = false;
                radioButtonOut.Enabled = false;
                textBox1.Enabled = false;
                timer1_Tick(null, null);
                timer1.Enabled = true;
            }
            CHANGE = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int x;
            int.TryParse(textBox1.Text,out x);
            if (x == 0)
            {
                MessageBox.Show("must be number");
            }
        }
    }
}