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

namespace Server_QLTraSua
{
    public partial class frmtachban : Form
    {
        public frmtachban()
        {
            InitializeComponent();
        }
       
        CSDLDataContext csdl = new CSDLDataContext();
        int maban;
        int mabann;
        private void frmtachban_Load(object sender, EventArgs e)
        {
            


            cbb1.DataSource = csdl.dsban();
            cbb1.DisplayMember = "TenBan";
            cbb1.ValueMember = "MaBan";
            cbb1.Text = "Chọn Bàn ";
         
           

            cbb2.DataSource = csdl.dsban();
            cbb2.DisplayMember = "TenBan";
            cbb2.ValueMember = "MaBan";
            cbb2.Text = "Chọn Bàn ";

            cbb2.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button5.Enabled = false;

        }

        private void cbb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb2.Enabled = true;
            try
            {
                maban = Convert.ToInt32(cbb1.SelectedValue.ToString());
                if (cbb2.Text.Equals(cbb1.Text))
                {
                    MessageBox.Show("Không Thể Gọp hoặc Tách Cùng 1 Bàn");
                }
                dtgvbangoc.DataSource = csdl.showhdban(maban);
            }
            catch (Exception)
            { }
          
           
        }

        private void cbb1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void cbb1_Leave(object sender, EventArgs e)
        {
           
        }

        private void cbb1_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void cbb1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void frmtachban_Click(object sender, EventArgs e)
        {
            
        }

        private void cbb1_Click(object sender, EventArgs e)
        {
            
        }

        private void cbb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button5.Enabled = true;

            try
            {
                mabann = Convert.ToInt32(cbb2.SelectedValue.ToString());
                if (cbb2.Text.Equals(cbb1.Text))
                {
                    MessageBox.Show("Không Thể Gọp hoặc Tách Cùng 1 Bàn");
                }
               
                dtgvbandich.DataSource = csdl.showhdban(mabann);
            }
            catch (Exception)
            {}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                csdl.chuyenban(maban, mabann);
                dtgvbangoc.DataSource = csdl.showhdban(maban);
                dtgvbandich.DataSource = csdl.showhdban(mabann);
            }
            catch (Exception)
            {}
          
        }
        int maban1;
        int maban2;
        string tenmon;
        int stt;
        int dongia;
        int soluong;
        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                maban1 = Convert.ToInt32(cbb1.SelectedValue);
                maban2 = Convert.ToInt32(cbb2.SelectedValue);
                tenmon = dtgvbangoc.CurrentRow.Cells["TenMon1"].Value.ToString();
                dongia = Convert.ToInt32(dtgvbangoc.CurrentRow.Cells["DonGia1"].Value.ToString());
                stt = Convert.ToInt32(dtgvbangoc.CurrentRow.Cells["stt1"].Value.ToString());
                soluong = Convert.ToInt32(dtgvbangoc.CurrentRow.Cells["SoLuong1"].Value.ToString());
                if (soluong == 1)
                {
                    csdl.tachban(mabann, Convert.ToInt32(dtgvbangoc.CurrentRow.Cells["stt1"].Value.ToString()));
                    dtgvbangoc.DataSource = csdl.showhdban(maban);
                    dtgvbandich.DataSource = csdl.showhdban(mabann);
                }
                else
                {
                    frmsoluong frm = new frmsoluong(maban1, maban2, tenmon, soluong, dongia, stt);
                    frm.ShowDialog();
                }
            }
            catch (Exception)
            {}


        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                csdl.chuyenban(mabann, maban);
                dtgvbangoc.DataSource = csdl.showhdban(maban);
                dtgvbandich.DataSource = csdl.showhdban(mabann);
            }
            catch (Exception)
            {}
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           /* try
            {
                maban1 = Convert.ToInt32(cbb1.SelectedValue);
                maban2 = Convert.ToInt32(cbb2.SelectedValue);
                tenmon = dtgvbangoc.CurrentRow.Cells["TenMon2"].Value.ToString();
                dongia = Convert.ToInt32(dtgvbangoc.CurrentRow.Cells["DonGia2"].Value.ToString());
                stt = Convert.ToInt32(dtgvbangoc.CurrentRow.Cells["stt2"].Value.ToString());
                soluong = Convert.ToInt32(dtgvbangoc.CurrentRow.Cells["SoLuong2"].Value.ToString());
                if (soluong == 1)
                {
                    csdl.tachban(maban, Convert.ToInt32(dtgvbandich.CurrentRow.Cells["stt2"].Value.ToString()));
                    dtgvbangoc.DataSource = csdl.showhdban(maban);
                    dtgvbandich.DataSource = csdl.showhdban(mabann);
                }
                else
                {
                    frmsoluong frm = new frmsoluong(maban1, maban2, tenmon, soluong, dongia, stt);
                    frm.ShowDialog();
                }
            }
            catch (Exception)
            { }*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dtgvbangoc.DataSource = csdl.showhdban(maban);
            dtgvbandich.DataSource = csdl.showhdban(mabann);
        }
    }
}
