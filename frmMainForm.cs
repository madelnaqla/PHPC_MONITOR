using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;
using Infragistics.Win.Misc;
using System.Resources;
using System.Globalization;
using System.Threading;
using System.IO;


namespace Time_Attendance
{
    public partial class frmMainForm : Form
    {
        public static SqlConnection _MasterCon;
        public static string ServerName;
        public static string _ConfigPlace;
        public static string[] _Machin;
        public static string main_door;

        public frmMainForm()
        {
            InitializeComponent();
            try
            {
                StreamReader sr = new StreamReader("Server.txt");
                ServerName = sr.ReadLine();
                string UserName = sr.ReadLine();
                string Password = sr.ReadLine();
                sr.Close();
                _MasterCon = new SqlConnection("Data Source=" + ServerName + ";Initial Catalog=TimeAttendance_MONITOR;User ID=" + UserName + ";Password=" + Password);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                this.Close();
            }
            try
            {
                StreamReader sr = new StreamReader("configuration.txt");
                _ConfigPlace = sr.ReadLine();
                _Machin = new string[8];
                string m = sr.ReadLine();
                int x = 0;
                while (m != null)
                {
                    _Machin[x] = m;
                    m = sr.ReadLine();
                    x++;
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                this.Close();
            }
            try
            {
                StreamReader sr = new StreamReader("main_door.txt");
                main_door = sr.ReadLine();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                this.Close();
            }
        }

        private bool CheckFormOpen(Form f)
        {
            foreach (Form childForm in MdiChildren)
            {
                if (f.Text == childForm.Text)
                {
                    childForm.Activate();
                    return true;
                }
            }
            return false;
        }


        private void frmMainForm_Load(object sender, EventArgs e)
        {
            frmEmpMange rr = new frmEmpMange();
            if (!CheckFormOpen(rr))
            {
                rr.MdiParent = this;
                rr.Text = "Monitor";
                rr.Show();
            }
            /*frmLogin frm = new frmLogin();
            frm.frm = this;
            frm.ShowDialog();
            try
            {
                StreamReader sr = new StreamReader("LastUpdate.txt");
                lblLastUpdate.Text = sr.ReadLine();
                sr.Close();
            }
            catch
            {
                lblLastUpdate.Text = "";
            }

            SqlCommand com = new SqlCommand("SELECT convert(char(10),MAX(TRN_TIME),103) AS Date , convert(char(19),MAX(TRN_TIME),8) AS Time FROM EMPLOYEE_TRANSACTIONS", _MasterCon);
            com.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {

                lblMaxUpdate.Text = dt.Rows[0][0].ToString() + " " + dt.Rows[0][1].ToString();
            }
            else
            {
                lblMaxUpdate.Text = "";
            }
            */
        }
        /*public static int GetIDIndex(string id, string colName, DataTable NavDt)
        {
            for (int i = 0; i < NavDt.Rows.Count; i++)
            {
                if (id == NavDt.Rows[i][colName].ToString().Trim())
                    return i;
            }
            return -1;
        }*/



        private void ultraToolbarsManager1_ToolClick_1(object sender, Infragistics.Win.UltraWinToolbars.ToolClickEventArgs e)
        {
            if (main_door == "All")
            {
                switch (e.Tool.Key)
                {
                    case "Exit Application":
                        Application.Exit();
                        break;
                    case "Monitor":
                        frmEmpMange rr = new frmEmpMange();
                        if (!CheckFormOpen(rr))
                        {
                            rr.MdiParent = this;
                            rr.Text = "Monitor";
                            rr.Show();
                        }
                        break;

                    case "ALL_TRANS":
                        FrmAllEmpTrans rr2 = new FrmAllEmpTrans();
                        if (!CheckFormOpen(rr2))
                        {
                            rr2.MdiParent = this;
                            rr2.Text = "All Transactions";
                            rr2.Show();
                        }
                        break;
                    case "TRANS":
                        FrmEmpTrans rr3 = new FrmEmpTrans();
                        if (!CheckFormOpen(rr3))
                        {
                            rr3.MdiParent = this;
                            rr3.Text = "Transactions";
                            rr3.Show();
                        }
                        break;
                    case "IN_COMPANY":
                        FrmNowIN rr4 = new FrmNowIN();
                        if (!CheckFormOpen(rr4))
                        {
                            rr4.MdiParent = this;
                            rr4.Text = "In Company";
                            rr4.Show();
                        }
                        break;
                    case "DELAYY":
                        Frm_Delay rr5 = new Frm_Delay();
                        if (!CheckFormOpen(rr5))
                        {
                            rr5.MdiParent = this;
                            rr5.Text = "Delay";
                            rr5.Show();
                        }
                        break;
                }
            }
            else
            {

                switch (e.Tool.Key)
                {
                    case "Exit Application":
                        Application.Exit();
                        break;
                    case "Monitor":
                        frmEmpMange rr = new frmEmpMange();
                        if (!CheckFormOpen(rr))
                        {
                            rr.MdiParent = this;
                            rr.Text = "Monitor";
                            rr.Show();
                        }
                        break;
                }
            }

        }
    }
}
