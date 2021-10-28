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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        CSDLDataContext csdl = new CSDLDataContext();
        private void DangNhap_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txttk.Text.Equals("admin") && txtmk.Text.Equals("voduyanh"))
                {
                    Form1 frm = new Form1();
                    frm.ShowDialog();
                    this.Visible = false;
                    this.Close();
                }

                var tk = csdl.dangnhap(txttk.Text, txtmk.Text).SingleOrDefault();
                if (tk == null)
                {
                    MessageBox.Show("Tên Tài Khoản Hoặc Mật Khẩu Không Đúng. ");
                }
                else
                {
                    Form1 frm = new Form1();
                    frm.ShowDialog();
                    this.Visible = false;
                    this.Close();
                }
            }
            catch (Exception)
            {}
            

        }

        private void DangNhap_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
