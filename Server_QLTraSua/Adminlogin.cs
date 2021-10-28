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
    public partial class Adminlogin : Form
    {
        public Adminlogin()
        {
            InitializeComponent();
        }
        CSDLDataContext csdl = new CSDLDataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var tk = csdl.dangnhap(txttk.Text, txtmk.Text).SingleOrDefault();
                if (tk == null)
                {
                    MessageBox.Show("Mật Khẩu Không Đúng. ");
                }
                else
                {
                    frmtramon frm = new frmtramon();
                    frm.ShowDialog();
                    this.Visible = false;
                    this.Close();
                }

            }
            catch (Exception)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
