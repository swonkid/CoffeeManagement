using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server_QLTraSua
{
    public partial class Frmreport : Form
    {
        public Frmreport()
        {
            InitializeComponent();
        }
        CSDLDataContext csdl = new CSDLDataContext();
        private void Frmreport_Load(object sender, EventArgs e)
        {
            /*CrystalReport rp = new CrystalReport();
            rp.SetDatabaseLogon("sa", "system");
            //rp.SetDataSource(csdl.loadhdtheothang(2));
            crystalReportViewer1.ReportSource = rp;*/
            CrystalReport1 rpt = new CrystalReport1();
            crystalReportViewer1.ReportSource = rpt;
           
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void crystalReportViewer1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
