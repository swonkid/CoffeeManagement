namespace Server_QLTraSua
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dtgvban = new System.Windows.Forms.DataGridView();
            this.TenBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mabann = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtban = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnnhap = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.txtmon = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtgia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giakm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khuyenmai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnthanhtien = new System.Windows.Forms.Button();
            this.lbthanhtien = new System.Windows.Forms.Label();
            this.txtkm = new System.Windows.Forms.TextBox();
            this.lbtt = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.dtpk = new System.Windows.Forms.DateTimePicker();
            this.lbtenban = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvhoadon = new System.Windows.Forms.DataGridView();
            this.tenmonhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loạiMónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvban)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvhoadon)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.dtgvban);
            this.groupBox1.Location = new System.Drawing.Point(13, 97);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(156, 583);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SƠ ĐỒ BÀN";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(35, 494);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 37);
            this.button4.TabIndex = 2;
            this.button4.Text = "-";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(35, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 38);
            this.button3.TabIndex = 1;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // dtgvban
            // 
            this.dtgvban.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgvban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenBan,
            this.Mabann});
            this.dtgvban.Location = new System.Drawing.Point(4, 20);
            this.dtgvban.Name = "dtgvban";
            this.dtgvban.RowTemplate.Height = 24;
            this.dtgvban.Size = new System.Drawing.Size(148, 371);
            this.dtgvban.TabIndex = 0;
            this.dtgvban.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvban_CellClick);
            this.dtgvban.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvban_CellContentClick);
            // 
            // TenBan
            // 
            this.TenBan.DataPropertyName = "TenBan";
            this.TenBan.HeaderText = "Tên Bàn";
            this.TenBan.Name = "TenBan";
            // 
            // Mabann
            // 
            this.Mabann.DataPropertyName = "MaBan";
            this.Mabann.HeaderText = "Mã Bàn";
            this.Mabann.Name = "Mabann";
            this.Mabann.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(177, 97);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(560, 583);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MENU";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(478, 272);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "Refresh";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtban);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.btnnhap);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.txtsoluong);
            this.groupBox4.Controls.Add(this.txtmon);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtgia);
            this.groupBox4.Location = new System.Drawing.Point(7, 290);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(546, 286);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Order nhanh";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(228, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "ORDER";
            // 
            // txtban
            // 
            this.txtban.AutoSize = true;
            this.txtban.Location = new System.Drawing.Point(22, 81);
            this.txtban.Name = "txtban";
            this.txtban.Size = new System.Drawing.Size(33, 17);
            this.txtban.TabIndex = 3;
            this.txtban.Text = "Bàn";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 4;
            this.label13.Text = "Món:";
            // 
            // btnnhap
            // 
            this.btnnhap.Location = new System.Drawing.Point(411, 182);
            this.btnnhap.Name = "btnnhap";
            this.btnnhap.Size = new System.Drawing.Size(99, 33);
            this.btnnhap.TabIndex = 13;
            this.btnnhap.Text = "Nhập";
            this.btnnhap.UseVisualStyleBackColor = true;
            this.btnnhap.Click += new System.EventHandler(this.btnnhap_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 183);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 17);
            this.label14.TabIndex = 4;
            this.label14.Text = "Giá:";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(411, 118);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(99, 23);
            this.txtsoluong.TabIndex = 12;
            // 
            // txtmon
            // 
            this.txtmon.Location = new System.Drawing.Point(130, 118);
            this.txtmon.Name = "txtmon";
            this.txtmon.Size = new System.Drawing.Size(156, 23);
            this.txtmon.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(322, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 17);
            this.label16.TabIndex = 11;
            this.label16.Text = "Số Lượng";
            // 
            // txtgia
            // 
            this.txtgia.Location = new System.Drawing.Point(130, 182);
            this.txtgia.Name = "txtgia";
            this.txtgia.Size = new System.Drawing.Size(156, 23);
            this.txtgia.TabIndex = 6;
            this.txtgia.TextChanged += new System.EventHandler(this.txtgia_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(247, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "MENU";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.giakm,
            this.khuyenmai,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(7, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(546, 218);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "MaMon";
            this.Column4.HeaderText = "MaMon";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TenMon";
            this.Column1.HeaderText = "Tên Món";
            this.Column1.Name = "Column1";
            this.Column1.Width = 170;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Gia";
            this.Column2.HeaderText = "Giá Gốc";
            this.Column2.Name = "Column2";
            // 
            // giakm
            // 
            this.giakm.HeaderText = "Giá (KM)";
            this.giakm.Name = "giakm";
            // 
            // khuyenmai
            // 
            this.khuyenmai.DataPropertyName = "KhuyenMai";
            this.khuyenmai.HeaderText = "Khuyến Mãi (%)";
            this.khuyenmai.Name = "khuyenmai";
            this.khuyenmai.Width = 70;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenLoai";
            this.Column3.HeaderText = "Nhóm";
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.btnthanhtien);
            this.groupBox3.Controls.Add(this.lbthanhtien);
            this.groupBox3.Controls.Add(this.txtkm);
            this.groupBox3.Controls.Add(this.lbtt);
            this.groupBox3.Controls.Add(this.button5);
            this.groupBox3.Controls.Add(this.dtpk);
            this.groupBox3.Controls.Add(this.lbtenban);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.dtgvhoadon);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(745, 97);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(319, 583);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THÔNG TIN HOÁ ĐƠN";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 33);
            this.button2.TabIndex = 16;
            this.button2.Text = "Trả Món";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Tách - Gọp Bàn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btnthanhtien
            // 
            this.btnthanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtien.ForeColor = System.Drawing.Color.Red;
            this.btnthanhtien.Location = new System.Drawing.Point(22, 440);
            this.btnthanhtien.Name = "btnthanhtien";
            this.btnthanhtien.Size = new System.Drawing.Size(268, 39);
            this.btnthanhtien.TabIndex = 14;
            this.btnthanhtien.Text = "Thành Tiền";
            this.btnthanhtien.UseVisualStyleBackColor = true;
            this.btnthanhtien.Click += new System.EventHandler(this.btnthanhtien_Click);
            // 
            // lbthanhtien
            // 
            this.lbthanhtien.AutoSize = true;
            this.lbthanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthanhtien.ForeColor = System.Drawing.Color.Red;
            this.lbthanhtien.Location = new System.Drawing.Point(100, 494);
            this.lbthanhtien.Name = "lbthanhtien";
            this.lbthanhtien.Size = new System.Drawing.Size(16, 16);
            this.lbthanhtien.TabIndex = 13;
            this.lbthanhtien.Text = "$";
            // 
            // txtkm
            // 
            this.txtkm.Location = new System.Drawing.Point(111, 409);
            this.txtkm.Name = "txtkm";
            this.txtkm.Size = new System.Drawing.Size(140, 23);
            this.txtkm.TabIndex = 12;
            this.txtkm.Text = "0";
            // 
            // lbtt
            // 
            this.lbtt.AutoSize = true;
            this.lbtt.Location = new System.Drawing.Point(108, 376);
            this.lbtt.Name = "lbtt";
            this.lbtt.Size = new System.Drawing.Size(16, 17);
            this.lbtt.TabIndex = 11;
            this.lbtt.Text = "$";
            this.lbtt.Click += new System.EventHandler(this.bltt_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(22, 338);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(268, 33);
            this.button5.TabIndex = 10;
            this.button5.Text = "Tính tiền";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dtpk
            // 
            this.dtpk.CustomFormat = "dd/MM/yyyy";
            this.dtpk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpk.Location = new System.Drawing.Point(179, 67);
            this.dtpk.Name = "dtpk";
            this.dtpk.Size = new System.Drawing.Size(111, 23);
            this.dtpk.TabIndex = 9;
            // 
            // lbtenban
            // 
            this.lbtenban.AutoSize = true;
            this.lbtenban.Location = new System.Drawing.Point(155, 33);
            this.lbtenban.Name = "lbtenban";
            this.lbtenban.Size = new System.Drawing.Size(33, 17);
            this.lbtenban.TabIndex = 8;
            this.lbtenban.Text = "Bàn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(249, 494);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "VNĐ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(259, 444);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(257, 412);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "%";
            this.label10.Click += new System.EventHandler(this.label7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "VNĐ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Khuyến mãi:";
            // 
            // dtgvhoadon
            // 
            this.dtgvhoadon.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dtgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenmonhd,
            this.sl,
            this.dg});
            this.dtgvhoadon.Location = new System.Drawing.Point(4, 104);
            this.dtgvhoadon.Name = "dtgvhoadon";
            this.dtgvhoadon.RowTemplate.Height = 24;
            this.dtgvhoadon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvhoadon.Size = new System.Drawing.Size(304, 162);
            this.dtgvhoadon.TabIndex = 4;
            // 
            // tenmonhd
            // 
            this.tenmonhd.DataPropertyName = "TenMon";
            this.tenmonhd.HeaderText = "Tên Món";
            this.tenmonhd.Name = "tenmonhd";
            this.tenmonhd.Width = 120;
            // 
            // sl
            // 
            this.sl.DataPropertyName = "SoLuong";
            this.sl.HeaderText = "Số Lượng";
            this.sl.Name = "sl";
            this.sl.Width = 50;
            // 
            // dg
            // 
            this.dg.DataPropertyName = "DonGia";
            this.dg.HeaderText = "Đơn Giá";
            this.dg.Name = "dg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng tiền:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày lập hoá đơn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bàn:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.loạiMónToolStripMenuItem,
            this.tàiKhoảngToolStripMenuItem,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1074, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // loạiMónToolStripMenuItem
            // 
            this.loạiMónToolStripMenuItem.Name = "loạiMónToolStripMenuItem";
            this.loạiMónToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.loạiMónToolStripMenuItem.Text = "Loại Món";
            this.loạiMónToolStripMenuItem.Click += new System.EventHandler(this.loạiMónToolStripMenuItem_Click);
            // 
            // tàiKhoảngToolStripMenuItem
            // 
            this.tàiKhoảngToolStripMenuItem.Name = "tàiKhoảngToolStripMenuItem";
            this.tàiKhoảngToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.tàiKhoảngToolStripMenuItem.Text = "Tài Khoản";
            this.tàiKhoảngToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảngToolStripMenuItem_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.ForeColor = System.Drawing.Color.Red;
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1074, 63);
            this.panel1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(413, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "MILK - TEA SHOP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1074, 749);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý quán trà sữa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvban)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvhoadon)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgvban;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvhoadon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DateTimePicker dtpk;
        private System.Windows.Forms.Label lbtenban;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtgia;
        private System.Windows.Forms.TextBox txtmon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label txtban;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnnhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenmonhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mabann;
        private System.Windows.Forms.Label lbtt;
        private System.Windows.Forms.Label lbthanhtien;
        private System.Windows.Forms.TextBox txtkm;
        private System.Windows.Forms.Button btnthanhtien;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem loạiMónToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảngToolStripMenuItem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn giakm;
        private System.Windows.Forms.DataGridViewTextBoxColumn khuyenmai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label10;
    }
}

