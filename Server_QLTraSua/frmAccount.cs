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
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }
        CSDLDataContext csdl = new CSDLDataContext();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            try
            {
                var testtk = csdl.loadtk(txttk.Text).SingleOrDefault();
                if (testtk!=null)
                {
                    lbtb.Text = "Tên Tài Khoản Đã Tồn Tại";
                }
                else
                {
                    if (txttk.Text == "" || txtmk.Text == "" || txtnlmk.Text == "")
                    {
                        lbtb.Text = "Chưa Nhập Đầy Đủ Thông Tin";
                    }
                    else
                    {
                        if (txtmk.Text.Equals(txtnlmk.Text))
                        {
                            csdl.dangky(txttk.Text, txtmk.Text);
                            lbtb.Text = "Đăng Ký Thành Công";
                        }
                        else
                        {
                            lbtb.Text = "Mật Khẩu Không Trùng Khớp";
                        }
                    }
                   
                }
            }
            catch (Exception)
            { }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
