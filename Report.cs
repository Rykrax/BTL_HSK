using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HSK_ver_1
{
    public partial class frmReport : Form
    {
        public frmReport()
        {
            InitializeComponent();
        }

        public void ShowReport(string name_report, string name_proc)
        {
            using (SqlConnection sql = ConnectData.GetSqlConnection())
            {
                sql.Open();
                using (SqlCommand cmd = new SqlCommand(name_proc,sql))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter adapter = new SqlDataAdapter())
                    {
                        adapter.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            adapter.Fill(dt);

                            ReportDocument report = new ReportDocument();
                            string path = $"F:\\Software\\C#\\BTL_HSK_ver_1\\BaoCao\\{name_report}";
                            report.Load(path);
                            report.SetDataSource(dt);

                            crystalReportViewer1.ReportSource = report;
                            crystalReportViewer1.Refresh();
                        }
                    }
                }
                sql.Close();
            }
        }
    }
}
