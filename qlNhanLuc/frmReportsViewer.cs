using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlNhanLuc
{
    public partial class frmReportsViewer : Form
    {
        public frmReportsViewer()
        {
            InitializeComponent();
        }

        private void frmReportsViewer_Load(object sender, EventArgs e)
        {

        }

        internal void ShowReport(string reportFileName, string recordFillter = "", string reportTitle = "")
        {
            ///1.nap report
            ReportDocument rpt = new ReportDocument();
            string path = string.Format("{0}\\Reports\\{1}"
                , Application.StartupPath
                , reportFileName);

            rpt.Load(path);
            ///2.cap nhat nguon du lieu
            TableLogOnInfo logonInfo = new TableLogOnInfo();
            logonInfo.ConnectionInfo.ServerName = ".\\SQLEXPRESS";
            logonInfo.ConnectionInfo.DatabaseName = "qlNhanLuc";
            logonInfo.ConnectionInfo.UserID = "sa";
            logonInfo.ConnectionInfo.Password = "123456";

            foreach (Table t in rpt.Database.Tables)
                t.ApplyLogOnInfo(logonInfo);


            ///3.loc

            if (!String.IsNullOrEmpty(recordFillter))
                rpt.RecordSelectionFormula = recordFillter;
            if (!String.IsNullOrEmpty(reportTitle))
                rpt.SummaryInfo.ReportTitle = reportTitle;

            //rpt.SummaryInfo.ReportTitle = "Danh sách Nhân viên";
            ///4.hien thi
            crystalReportViewer1.ReportSource = rpt;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
