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
    public partial class frmLoaiMon : Form
    {
        public frmLoaiMon()
        {
            InitializeComponent();
        }
        CSDLDataContext csdl = new CSDLDataContext();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLoaiMon_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = csdl.dsloai();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtml.Text = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
                txttl.Text = dataGridView1.CurrentRow.Cells["Column2"].Value.ToString();
            
            }
            catch (Exception)
            {


            }
        }

        private void txttl_TextChanged(object sender, EventArgs e)
        {
            
       
        }

        private void txttl_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                txtml.Text = "Mã Loại";
            }
            catch (Exception)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            csdl.themloai(txttl.Text);
            dataGridView1.DataSource = csdl.dsloai();
            txttl.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            csdl.xoaloai(dataGridView1.CurrentRow.Cells["Column2"].Value.ToString());
            dataGridView1.DataSource = csdl.dsloai();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            csdl.sualoai(txttl.Text, Convert.ToInt32(dataGridView1.CurrentRow.Cells["Column1"].Value));
            dataGridView1.DataSource = csdl.dsloai();
        }
    }
}
