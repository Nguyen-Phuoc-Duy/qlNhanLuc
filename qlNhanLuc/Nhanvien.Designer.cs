
namespace qlNhanLuc
{
    partial class Nhanvien
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
            this.dgrNhanvien = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaphongban = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDienthoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbtnNu = new System.Windows.Forms.RadioButton();
            this.rbtnNam = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuaylai = new System.Windows.Forms.Button();
            this.btnPhongban = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrNhanvien
            // 
            this.dgrNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column5,
            this.Column4,
            this.Column6,
            this.Column3});
            this.dgrNhanvien.Location = new System.Drawing.Point(22, 199);
            this.dgrNhanvien.Name = "dgrNhanvien";
            this.dgrNhanvien.Size = new System.Drawing.Size(675, 161);
            this.dgrNhanvien.TabIndex = 82;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "sManhanvien";
            this.Column1.HeaderText = "Mã NV";
            this.Column1.Name = "Column1";
            this.Column1.Width = 70;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "sHoten";
            this.Column2.HeaderText = "Họ tên";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "bGioitinh";
            this.Column7.HeaderText = "Giới tính";
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "tNgaysinh";
            this.Column5.HeaderText = "Ngày sinh";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "sDienthoai";
            this.Column4.HeaderText = "Điện thoại";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "sDiachi";
            this.Column6.HeaderText = "Địa chỉ";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "sMaphongban";
            this.Column3.HeaderText = "Mã PB";
            this.Column3.Name = "Column3";
            this.Column3.Width = 70;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(617, 145);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 81;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(536, 145);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(75, 23);
            this.btnBoqua.TabIndex = 80;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(617, 102);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 79;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnBaocao
            // 
            this.btnBaocao.Location = new System.Drawing.Point(536, 102);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(75, 23);
            this.btnBaocao.TabIndex = 78;
            this.btnBaocao.Text = "Báo cáo";
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(617, 62);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 77;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnNhap
            // 
            this.btnNhap.Enabled = false;
            this.btnNhap.Location = new System.Drawing.Point(536, 62);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(75, 23);
            this.btnNhap.TabIndex = 76;
            this.btnNhap.Text = "Thêm mới";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(101, 146);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(394, 20);
            this.txtDiachi.TabIndex = 75;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 74;
            this.label7.Text = "Địa chỉ";
            // 
            // txtMaphongban
            // 
            this.txtMaphongban.Location = new System.Drawing.Point(386, 25);
            this.txtMaphongban.Name = "txtMaphongban";
            this.txtMaphongban.Size = new System.Drawing.Size(109, 20);
            this.txtMaphongban.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Mã phòng ban";
            // 
            // txtDienthoai
            // 
            this.txtDienthoai.Location = new System.Drawing.Point(101, 103);
            this.txtDienthoai.Name = "txtDienthoai";
            this.txtDienthoai.Size = new System.Drawing.Size(394, 20);
            this.txtDienthoai.TabIndex = 73;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Điện thoại";
            // 
            // rbtnNu
            // 
            this.rbtnNu.AutoSize = true;
            this.rbtnNu.Location = new System.Drawing.Point(456, 65);
            this.rbtnNu.Name = "rbtnNu";
            this.rbtnNu.Size = new System.Drawing.Size(39, 17);
            this.rbtnNu.TabIndex = 71;
            this.rbtnNu.Text = "Nữ";
            this.rbtnNu.UseVisualStyleBackColor = true;
            // 
            // rbtnNam
            // 
            this.rbtnNam.AutoSize = true;
            this.rbtnNam.Checked = true;
            this.rbtnNam.Location = new System.Drawing.Point(386, 65);
            this.rbtnNam.Name = "rbtnNam";
            this.rbtnNam.Size = new System.Drawing.Size(47, 17);
            this.rbtnNam.TabIndex = 70;
            this.rbtnNam.TabStop = true;
            this.rbtnNam.Text = "Nam";
            this.rbtnNam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Giới tính";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaysinh.Location = new System.Drawing.Point(101, 63);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(163, 20);
            this.dtpNgaysinh.TabIndex = 68;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Ngày sinh";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(101, 25);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(163, 20);
            this.txtHoten.TabIndex = 64;
            this.txtHoten.TextChanged += new System.EventHandler(this.txtHoten_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 63;
            this.label1.Text = "Họ tên";
            // 
            // btnQuaylai
            // 
            this.btnQuaylai.Location = new System.Drawing.Point(617, 24);
            this.btnQuaylai.Name = "btnQuaylai";
            this.btnQuaylai.Size = new System.Drawing.Size(75, 23);
            this.btnQuaylai.TabIndex = 83;
            this.btnQuaylai.Text = "Quay lại";
            this.btnQuaylai.UseVisualStyleBackColor = true;
            this.btnQuaylai.Click += new System.EventHandler(this.btnQuaylai_Click);
            // 
            // btnPhongban
            // 
            this.btnPhongban.Location = new System.Drawing.Point(536, 24);
            this.btnPhongban.Name = "btnPhongban";
            this.btnPhongban.Size = new System.Drawing.Size(75, 23);
            this.btnPhongban.TabIndex = 84;
            this.btnPhongban.Text = "Phòng ban";
            this.btnPhongban.UseVisualStyleBackColor = true;
            this.btnPhongban.Click += new System.EventHandler(this.btnPhongban_Click);
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.btnPhongban);
            this.Controls.Add(this.btnQuaylai);
            this.Controls.Add(this.dgrNhanvien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnBaocao);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnNhap);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMaphongban);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDienthoai);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbtnNu);
            this.Controls.Add(this.rbtnNam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpNgaysinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.label1);
            this.Name = "Nhanvien";
            this.Text = "Nhanvien";
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgrNhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgrNhanvien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaphongban;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDienthoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtnNu;
        private System.Windows.Forms.RadioButton rbtnNam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnQuaylai;
        private System.Windows.Forms.Button btnPhongban;
    }
}