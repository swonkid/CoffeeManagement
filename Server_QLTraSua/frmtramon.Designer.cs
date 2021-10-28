namespace Server_QLTraSua
{
    partial class frmtramon
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
            this.lbbannguon = new System.Windows.Forms.Label();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.dtgvbangoc = new System.Windows.Forms.DataGridView();
            this.stt1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbangoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lbbannguon
            // 
            this.lbbannguon.AutoSize = true;
            this.lbbannguon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbannguon.Location = new System.Drawing.Point(66, 39);
            this.lbbannguon.Name = "lbbannguon";
            this.lbbannguon.Size = new System.Drawing.Size(131, 13);
            this.lbbannguon.TabIndex = 7;
            this.lbbannguon.Text = "Bàn Cần Tách - Gọp :";
            // 
            // cbb1
            // 
            this.cbb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Location = new System.Drawing.Point(271, 36);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(116, 21);
            this.cbb1.TabIndex = 6;
            this.cbb1.SelectedValueChanged += new System.EventHandler(this.cbb1_SelectedValueChanged);
            // 
            // dtgvbangoc
            // 
            this.dtgvbangoc.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dtgvbangoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvbangoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt1,
            this.TenMon,
            this.Column2,
            this.Column3});
            this.dtgvbangoc.Location = new System.Drawing.Point(66, 63);
            this.dtgvbangoc.Name = "dtgvbangoc";
            this.dtgvbangoc.Size = new System.Drawing.Size(321, 223);
            this.dtgvbangoc.TabIndex = 5;
            // 
            // stt1
            // 
            this.stt1.DataPropertyName = "STT";
            this.stt1.HeaderText = "STT";
            this.stt1.Name = "stt1";
            this.stt1.Visible = false;
            // 
            // TenMon
            // 
            this.TenMon.DataPropertyName = "TenMon";
            this.TenMon.HeaderText = "Tên Món";
            this.TenMon.Name = "TenMon";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "SoLuong";
            this.Column2.HeaderText = "Số Lượng";
            this.Column2.Name = "Column2";
            this.Column2.Width = 78;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "DonGia";
            this.Column3.HeaderText = "Đơn Giá";
            this.Column3.Name = "Column3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Trả Món";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmtramon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(450, 327);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbbannguon);
            this.Controls.Add(this.cbb1);
            this.Controls.Add(this.dtgvbangoc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmtramon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả Món";
            this.Load += new System.EventHandler(this.frmtramon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvbangoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbbannguon;
        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.DataGridView dtgvbangoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button button1;

    }
}