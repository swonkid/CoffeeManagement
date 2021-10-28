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
    public partial class frmsoluong : Form
    {
        public frmsoluong()
        {
            InitializeComponent();
        }
        int maban1;
        int maban2;
        string tenmon;
        int stt;
        int dongia;
        int soluong;
        public frmsoluong(int mb1, int mb2, string tm, int sl, int dg, int st) : this()
        {
            maban1 = mb1;
            maban2 = mb2;
            tenmon = tm;
            soluong = sl;
            dongia = dg;
            stt = st;
        }
        CSDLDataContext csdl = new CSDLDataContext();
        public int laymamon(String tm)
        {
            var conn = new SqlConnection("server = NICK-LAPTOP\\SQLEXPRESS; database=QLBanTraSua; uid=sa; pwd=system ");
            conn.Open();
            string sql = "select MaMon from Mon where TenMon = '" + tm + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader r = cmd.ExecuteReader();

            r.Read();
            int mamon;
            string[] st = new string[1];
            st[0] = r[0].ToString();
            mamon = Convert.ToInt32(st[0]);
            return mamon;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
        
        private void frmsoluong_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(num.Value);
            int x = soluong - n;
            if (soluong < n)
            {
                MessageBox.Show("Đã vượt số lượng hiện có! Vui lòng kiểm tra lại.");
            }
            else
            {
                csdl.tachban2(maban2, stt, n);
                csdl.tachban3(maban1, laymamon(tenmon), x, dongia);
                MessageBox.Show("Thành công!");         
                this.Close();

            }
        }
    }
}
