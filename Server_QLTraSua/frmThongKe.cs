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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }
        CSDLDataContext csdl = new CSDLDataContext();
        private void frmThongKe_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = csdl.loadcthd();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tinhtien = 0;
            int n = dataGridView1.RowCount;
            for (int i = 0; i < n; i++)
            {
                tinhtien += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
            lbltongtien.Text = tinhtien.ToString();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            rabtthang.Checked = false;
            rabthtnam.Checked = false;
            dataGridView1.DataSource = csdl.loadhdtheongay(dateTimePicker1.Value);
            
        }

        private void rabtthang_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = csdl.loadhdtheothang(dateTimePicker1.Value.Month);
        }

        private void rabthtnam_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = csdl.loadtheonam(dateTimePicker1.Value.Year);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*try
            {
                Frmreport frm = new Frmreport();
                frm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng cài đặt phần mềm (CrystalReport) ");
            }*/
            
        }
    }
}
