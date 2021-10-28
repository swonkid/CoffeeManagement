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
    public partial class frmtramon : Form
    {
        public frmtramon()
        {
            InitializeComponent();
        }
        CSDLDataContext csdl = new CSDLDataContext();
        int maban;
        private void frmtramon_Load(object sender, EventArgs e)
        {
            cbb1.DataSource = csdl.dsban();
            cbb1.DisplayMember = "TenBan";
            cbb1.ValueMember = "MaBan";
            cbb1.Text = "Bàn 1";
        }

        private void cbb1_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                maban = Convert.ToInt32(cbb1.SelectedValue.ToString());             
                dtgvbangoc.DataSource = csdl.showhdban(maban);
            }
            catch (Exception)
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                csdl.tramon(Convert.ToInt32(dtgvbangoc.CurrentRow.Cells["stt1"].Value.ToString()));
                dtgvbangoc.DataSource = csdl.showhdban(maban);
            }
            catch (Exception)
            {}
           
        }
    }
}
