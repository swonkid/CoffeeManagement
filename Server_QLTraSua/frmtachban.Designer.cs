namespace Server_QLTraSua
{
    partial class frmtachban
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
            this.dtgvbandich = new System.Windows.Forms.DataGridView();
            this.stt2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgvbangoc = new System.Windows.Forms.DataGridView();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.cbb2 = new System.Windows.Forms.ComboBox();
            this.lbbannguon = new System.Windows.Forms.Label();
            this.lbbandich = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.stt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbandich)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbangoc)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvbandich
            // 
            this.dtgvbandich.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgvbandich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvbandich.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt2,
            this.TenMon2,
            this.SoLuong2,
            this.DonGia2});
            this.dtgvbandich.Location = new System.Drawing.Point(372, 61);
            this.dtgvbandich.Name = "dtgvbandich";
            this.dtgvbandich.Size = new System.Drawing.Size(288, 259);
            this.dtgvbandich.TabIndex = 0;
            // 
            // stt2
            // 
            this.stt2.DataPropertyName = "STT";
            this.stt2.HeaderText = "STT";
            this.stt2.Name = "stt2";
            this.stt2.Visible = false;
            // 
            // TenMon2
            // 
            this.TenMon2.DataPropertyName = "TenMon";
            this.TenMon2.HeaderText = "Tên Món";
            this.TenMon2.Name = "TenMon2";
            // 
            // SoLuong2
            // 
            this.SoLuong2.DataPropertyName = "SoLuong";
            this.SoLuong2.HeaderText = "Số Lượng";
            this.SoLuong2.Name = "SoLuong2";
            this.SoLuong2.Width = 78;
            // 
            // DonGia2
            // 
            this.DonGia2.DataPropertyName = "DonGia";
            this.DonGia2.HeaderText = "Đơn Giá";
            this.DonGia2.Name = "DonGia2";
            // 
            // dtgvbangoc
            // 
            this.dtgvbangoc.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgvbangoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvbangoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt1,
            this.TenMon1,
            this.SoLuong1,
            this.DonGia1});
            this.dtgvbangoc.Location = new System.Drawing.Point(12, 61);
            this.dtgvbangoc.Name = "dtgvbangoc";
            this.dtgvbangoc.Size = new System.Drawing.Size(288, 259);
            this.dtgvbangoc.TabIndex = 1;
            // 
            // cbb1
            // 
            this.cbb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Location = new System.Drawing.Point(149, 34);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(151, 21);
            this.cbb1.TabIndex = 2;
            this.cbb1.SelectedIndexChanged += new System.EventHandler(this.cbb1_SelectedIndexChanged);
            this.cbb1.SelectedValueChanged += new System.EventHandler(this.cbb1_SelectedValueChanged);
            this.cbb1.TextChanged += new System.EventHandler(this.cbb1_TextChanged);
            this.cbb1.Click += new System.EventHandler(this.cbb1_Click);
            this.cbb1.Leave += new System.EventHandler(this.cbb1_Leave);
            this.cbb1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cbb1_MouseClick);
            // 
            // cbb2
            // 
            this.cbb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb2.FormattingEnabled = true;
            this.cbb2.Location = new System.Drawing.Point(485, 34);
            this.cbb2.Name = "cbb2";
            this.cbb2.Size = new System.Drawing.Size(175, 21);
            this.cbb2.TabIndex = 3;
            this.cbb2.SelectedIndexChanged += new System.EventHandler(this.cbb2_SelectedIndexChanged);
            // 
            // lbbannguon
            // 
            this.lbbannguon.AutoSize = true;
            this.lbbannguon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbannguon.Location = new System.Drawing.Point(12, 37);
            this.lbbannguon.Name = "lbbannguon";
            this.lbbannguon.Size = new System.Drawing.Size(131, 13);
            this.lbbannguon.TabIndex = 4;
            this.lbbannguon.Text = "Bàn Cần Tách - Gọp :";
            // 
            // lbbandich
            // 
            this.lbbandich.AutoSize = true;
            this.lbbandich.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbandich.Location = new System.Drawing.Point(369, 37);
            this.lbbandich.Name = "lbbandich";
            this.lbbandich.Size = new System.Drawing.Size(110, 13);
            this.lbbandich.TabIndex = 5;
            this.lbbandich.Text = "Bàn Chuyển Đến :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // stt1
            // 
            this.stt1.DataPropertyName = "STT";
            this.stt1.HeaderText = "STT";
            this.stt1.Name = "stt1";
            this.stt1.Visible = false;
            // 
            // TenMon1
            // 
            this.TenMon1.DataPropertyName = "TenMon";
            this.TenMon1.HeaderText = "Tên Món";
            this.TenMon1.Name = "TenMon1";
            // 
            // SoLuong1
            // 
            this.SoLuong1.DataPropertyName = "SoLuong";
            this.SoLuong1.HeaderText = "Số Lượng";
            this.SoLuong1.Name = "SoLuong1";
            this.SoLuong1.Width = 78;
            // 
            // DonGia1
            // 
            this.DonGia1.DataPropertyName = "DonGia";
            this.DonGia1.HeaderText = "Đơn Giá";
            this.DonGia1.Name = "DonGia1";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(307, 218);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(59, 29);
            this.button5.TabIndex = 10;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // frmtachban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(672, 360);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbbandich);
            this.Controls.Add(this.lbbannguon);
            this.Controls.Add(this.cbb2);
            this.Controls.Add(this.cbb1);
            this.Controls.Add(this.dtgvbangoc);
            this.Controls.Add(this.dtgvbandich);
            this.Name = "frmtachban";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tách - Gọp Bàn";
            this.Load += new System.EventHandler(this.frmtachban_Load);
            this.Click += new System.EventHandler(this.frmtachban_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbandich)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbangoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvbandich;
        private System.Windows.Forms.DataGridView dtgvbangoc;
        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.ComboBox cbb2;
        private System.Windows.Forms.Label lbbannguon;
        private System.Windows.Forms.Label lbbandich;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia1;
        private System.Windows.Forms.Button button5;
    }
}