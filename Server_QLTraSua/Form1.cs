using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Threading;
using System.Data.Common;

namespace Server_QLTraSua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread luong;
        CSDLDataContext csdl = new CSDLDataContext();
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtgvban.DataSource = csdl.dsban();
            dataGridView1.DataSource = csdl.showdsmon();
            int rows = dataGridView1.Rows.Count -1 ;//bỏ dòng rổng cuối gridview    
            for (int i = 0; i < rows; i++)
            {
                double km = Convert.ToSingle(dataGridView1.Rows[i].Cells["khuyenmai"].Value)/100;
                double giakm = Convert.ToSingle(dataGridView1.Rows[i].Cells["Column2"].Value) - (Convert.ToSingle(dataGridView1.Rows[i].Cells["Column2"].Value) * km);
                dataGridView1.Rows[i].Cells["giakm"].Value = Convert.ToUInt32(giakm);
            }
            
            luong = new Thread(new ThreadStart(startserver));
            //luong.Start();
            
        }

        private void cmbloaimon_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbloaimon_Click(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void dtgvmon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
            }
            catch (Exception)
            {                       
            }
        
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        int maban;
        int mamon;
        private void dtgvban_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtban.Text = dtgvban.CurrentRow.Cells[1].Value.ToString();
                maban = Convert.ToInt32(dtgvban.CurrentRow.Cells["MaBann"].Value);
                lbtenban.Text = dtgvban.CurrentRow.Cells[1].Value.ToString();
                dtgvhoadon.DataSource = csdl.showhd1(maban);
                lbtt.Text = "0";
            }
            catch (Exception)
            {
                
           
            }
           
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
       
        private void btnnhap_Click(object sender, EventArgs e)
        {
            try
            {
                csdl.datmon(maban, mamon, Convert.ToInt32(txtsoluong.Text), Convert.ToInt32(txtgia.Text));
                MessageBox.Show("đã nhập");
                dtgvhoadon.DataSource = csdl.showhd1(maban);
            }
            catch (Exception)
            {

                MessageBox.Show("Chưa Nhập Đủ Thông Tin! Nhận Order Không Thành Công","Thông Báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           

        }

        private void dtgvban_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            float thanhtien = 0;
            int dong = dtgvhoadon.Rows.Count;
            
            for (int i = 0; i < dong - 1; i++)
            {
                thanhtien+= float.Parse((Convert.ToInt32((dtgvhoadon.Rows[i].Cells[1].Value)) * Convert.ToInt32((dtgvhoadon.Rows[i].Cells[2].Value))).ToString());
            }
            lbtt.Text = thanhtien.ToString();
           
        }

        private void bltt_Click(object sender, EventArgs e)
        {

        }

        private void btnthanhtien_Click(object sender, EventArgs e)
        {
            try
            {
                double khuyenmai = Convert.ToDouble(txtkm.Text) / 100;
                double thanhtien = 0;
                thanhtien = Convert.ToDouble(lbtt.Text) - (Convert.ToDouble(lbtt.Text) * khuyenmai);
                lbthanhtien.Text = thanhtien.ToString();
                csdl.cthd(maban, dtpk.Value, Convert.ToDouble(lbtt.Text), Convert.ToDouble(txtkm.Text), Convert.ToDouble(lbthanhtien.Text));
                csdl.xoaban(maban);
                txtkm.Text = 0.ToString();
               
                
            }
            catch (Exception)
            {
                MessageBox.Show("Chưa tính tiền");
                
            }
               
            
        }
        Socket server;
        Socket clientSock;
        string s;
        public void startserver()
        {
            IPAddress[] addresses = Dns.GetHostAddresses(Dns.GetHostName());
            StringBuilder sbAddressList = new StringBuilder();
            int dong = addresses.Length - 1;
            IPAddress ip =  addresses[dong];

            //IPAddress ipa = IPAddress.Parse("192.168.1.5"); //ip local
            IPAddress ipa = ip; //ip lan
            IPEndPoint ipEnd = new IPEndPoint(ipa, 5656);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(ipEnd);
            MessageBox.Show("SERVER ĐÃ ĐƯỢC KHỞI ĐỘNG");
            //MessageBox.Show(ip.ToString());
            server.Listen(100);
            while (true)
            {
              
                clientSock = server.Accept();
                new Thread(new ThreadStart(xuly)).Start();
                new Thread(new ThreadStart(nhanorder)).Start();

               
            }
            
        }
       
        public void xuly()
        {
            byte[] data = new byte[1000];
            int dong = dtgvban.Rows.Count -1;
            data = Encoding.ASCII.GetBytes(dong.ToString());
            clientSock.Send(data);
            DataTable table = getdata();           
            clientSock.Send(SerializeData(table));
            
        }
        public int laymaban(String tenban)
        {
            var conn = new SqlConnection("server = NICK-LAPTOP\\SQLEXPRESS; database=QLBanTraSua; uid=sa; pwd=system ");
            conn.Open();
            string sql = "select MaBan from Ban where TenBan = '" +tenban+ "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader r = cmd.ExecuteReader();

            r.Read();

            string[] st = new string[1];
            st[0] = r[0].ToString();
            maban = Convert.ToInt32(st[0]);
            return maban;
        }

        string[] arr;
        string tenmon,gia,soluong;
        public void nhanorder()
        {
            try
            {
                while (true)
                {
                    byte[] data = new byte[5000];
                    int recv = clientSock.Receive(data);
                    s = Encoding.Unicode.GetString(data, 0, recv);
                    arr = s.Split('\t');
                    string tb = s.Substring(5);

                    DialogResult dlr = MessageBox.Show(tb,arr[0].ToUpper(), MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dlr == DialogResult.Yes)
                    {

                        int i = 1;
                        while (i < arr.Length - 1)
                        {
                            maban = laymaban(arr[0]);
                            tenmon = arr[i];
                            gia = arr[i + 1];
                            soluong = arr[i + 2];
                            var conn = new SqlConnection("server = NICK-LAPTOP\\SQLEXPRESS; database=QLBanTraSua; uid=sa; pwd=system ");
                            conn.Open();
                            string sql = "select MaMon from Mon where TenMon = N'" + tenmon.Trim() + "'";
                            SqlCommand cmd = new SqlCommand(sql, conn);
                            SqlDataReader r = cmd.ExecuteReader();

                            r.Read();

                            string[] st = new string[1];
                            st[0] = r[0].ToString();
                            mamon = Convert.ToInt32(st[0]);





                            //MessageBox.Show(maban.ToString() + ' ' + mamon.ToString() + ' ' + gia + ' ' + soluong);

                            csdl.datmon(maban, mamon, Convert.ToInt32(soluong), Convert.ToInt32(gia));
                            i = i + 3;

                        }

                    }
                    else
                    {
                        
                    }


                }
            }
            catch (Exception)
            {
               
            }
                
          
        }
        
        
        private byte[] SerializeData(Object o) // chuyen bản sang mảng byte
        {
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
            
        }
        private DataTable getdata()
        {        
            var table = new DataTable("Mon");
            table.Columns.Add("TenMon");
            table.Columns.Add("Gia");
            table.Columns.Add("Giakm");

            int rows = dataGridView1.Rows.Count - 1;//bỏ dòng rổng cuối gridview    
            for (int i = 0; i < rows; i++)
            {
                table.Rows.Add((dataGridView1.Rows[i].Cells["Column1"].Value), (dataGridView1.Rows[i].Cells["Column2"].Value), (dataGridView1.Rows[i].Cells["giakm"].Value));   
            }

            return table;
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtmon.Text = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
                txtgia.Text = dataGridView1.CurrentRow.Cells["giakm"].Value.ToString();
                mamon = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Column4"].Value.ToString());
                txtsoluong.Text = "1";
            }
            catch (Exception)
            {}
            
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("BẠN CÓ MUỐN THOÁT ?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                
            }
            else
            {
                e.Cancel = true;
            }
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            frmtachban frm = new frmtachban();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtgia_TextChanged(object sender, EventArgs e)
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

        private void loạiMónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiMon frm = new frmLoaiMon();
            frm.ShowDialog();
        }

        private void tàiKhoảngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount frm = new frmAccount();
            frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {     
                int dong = dtgvban.Rows.Count - 1;
                if (dong == 0)
                {
                    string tbtemp = "Mang về ";
                    csdl.themban(tbtemp);
                    dtgvban.DataSource = csdl.dsban();
                }
                else
                {
                    string tbtemp = "Bàn " + dong;
                    csdl.themban(tbtemp);
                    dtgvban.DataSource = csdl.dsban();
                }

                
            }
            catch (Exception)
            {}
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int dong = dtgvban.Rows.Count - 2;
                if (dong == 0)
                {
                    string tbtemp = "Mang về ";
                    csdl.huyban(tbtemp);
                    dtgvban.DataSource = csdl.dsban();
                }
                else
                {
                    string tbtemp = "Bàn " + dong;
                    csdl.huyban(tbtemp);
                    dtgvban.DataSource = csdl.dsban();
                }
            }
            catch (Exception)
            { 
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            dtgvban.DataSource = csdl.dsban();
            dataGridView1.DataSource = csdl.showdsmon();
            int rows = dataGridView1.Rows.Count - 1;//bỏ dòng rổng cuối gridview    
            for (int i = 0; i < rows; i++)
            {
                double km = Convert.ToSingle(dataGridView1.Rows[i].Cells["khuyenmai"].Value) / 100;
                double giakm = Convert.ToSingle(dataGridView1.Rows[i].Cells["Column2"].Value) - (Convert.ToSingle(dataGridView1.Rows[i].Cells["Column2"].Value) * km);
                dataGridView1.Rows[i].Cells["giakm"].Value = Convert.ToUInt32(giakm);
            }
            lbtt.Text = "0";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Adminlogin frm = new Adminlogin();
            frm.ShowDialog();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            frm.ShowDialog();
        }

       

       
       
       

        
    }
   
}
