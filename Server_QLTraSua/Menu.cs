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
    public partial class Menu : Form
    {
        CSDLDataContext csdl = new CSDLDataContext();
        public Menu()
        {
            InitializeComponent();
        }
        string maloai;
        private void Menu_Load(object sender, EventArgs e)
        {
            cbblm.DataSource = csdl.dsloai();
            cbblm.DisplayMember = "TenLoai";
            cbblm.ValueMember = "MaLoai";
            maloai =Convert.ToString(cbblm.SelectedValue);

            dataGridView1.DataSource = csdl.showdsmon();
           
            
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            maloai = cbblm.SelectedValue.ToString();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            csdl.nhapmon(txttm.Text, Convert.ToDouble(txtgia.Text),Convert.ToInt32(maloai),Convert.ToInt32(txtkm.Text));
            dataGridView1.DataSource = csdl.showdsmon();         
            txttm.Text = "";
            txtgia.Text = "";
            txtkm.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            csdl.xoamon(dataGridView1.CurrentRow.Cells["TenMon"].Value.ToString());
            dataGridView1.DataSource = csdl.showdsmon();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            csdl.suamon(txttm.Text, Convert.ToDouble(txtgia.Text), Convert.ToInt32(maloai),Convert.ToInt32(txtkm.Text), Convert.ToInt32(dataGridView1.CurrentRow.Cells["MaMon"].Value.ToString()));
            dataGridView1.DataSource = csdl.showdsmon();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txttm.Text = dataGridView1.CurrentRow.Cells["TenMon"].Value.ToString();
                txtgia.Text = dataGridView1.CurrentRow.Cells["Gia"].Value.ToString();
                cbblm.Text = dataGridView1.CurrentRow.Cells["LoaiMon"].Value.ToString();
                txtkm.Text = "0";
            }
            catch (Exception)
            {
                
                
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtgia_Leave(object sender, EventArgs e)
        {
            int n = 0;
            if (int.TryParse(this.txtgia.Text, out n))
            {

            }
            else
            {
                MessageBox.Show("Không Được Nhập Chử");
                txtgia.Focus();
            }
        }
    }
}
