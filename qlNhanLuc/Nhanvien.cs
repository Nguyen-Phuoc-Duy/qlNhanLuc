using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlNhanLuc
{
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {
            DateTime ngaysinh;
            btnNhap.Enabled = (txtHoten.Text.Trim().Length > 0)
                                && DateTime.TryParse(dtpNgaysinh.Text.Trim(), out ngaysinh);
        }

        private DataTable getNhanvien()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["qlNhanLuc"].ConnectionString;
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand("spNhanvien_Get", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter Dv = new SqlDataAdapter(Cmd))
                    {
                        DataTable tbl = new DataTable("tblNhanvien");
                        Dv.Fill(tbl);
                        return tbl;
                    }
                }//Cmd
            }
        }
        private void hienNhanvien(string dieukienloc = "")
        {
            using (DataTable tblNhanvien = getNhanvien())
            {
                DataView dvNhanvien = new DataView(tblNhanvien);
                if (!string.IsNullOrEmpty(dieukienloc))
                    dvNhanvien.RowFilter = dieukienloc;
                dgrNhanvien.AutoGenerateColumns = false;
                dgrNhanvien.DataSource = dvNhanvien;
                btnSua.Enabled = btnXoa.Enabled = (dgrNhanvien.Rows.Count > 0);
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["qlNhanLuc"].ConnectionString;
            string procedureName = btnNhap.Tag == null 
                ? "spNhanvien_Insert" : "spNhanvien_Update";
            long nhanvienID = Convert.ToInt64("0" + btnNhap.Tag);

            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                if (kiemtraMPB() == 0)
                {
                    MessageBox.Show("Không có mã phòng ban này, bạn phải nhập mã phòng ban", "Thông báo");
                    txtMaphongban.Focus();
                    Phongban fPhongban = new Phongban();
                    fPhongban.Show();

                }
                else
                {
                    using (SqlCommand Cmd = new SqlCommand(procedureName, Cnn))
                    {
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Parameters.Add("@sManhanvien", SqlDbType.BigInt);
                        if (nhanvienID == 0)
                            Cmd.Parameters["@sManhanvien"].Direction = ParameterDirection.Output;
                        else

                            Cmd.Parameters["@sManhanvien"].Value = nhanvienID;

                        Cmd.Parameters.AddWithValue("@sHoten", txtHoten.Text);
                        Cmd.Parameters.AddWithValue("@tNgaysinh", Convert.ToDateTime(dtpNgaysinh.Text));
                        Cmd.Parameters.AddWithValue("@bGioitinh", rbtnNam.Checked);
                        Cmd.Parameters.AddWithValue("@sDienthoai", txtDienthoai.Text);
                        Cmd.Parameters.AddWithValue("@sDiachi", txtDiachi.Text);
                        Cmd.Parameters.AddWithValue("@sMaphongban", txtMaphongban.Text);
                        Cnn.Open();
                        Cmd.ExecuteNonQuery();
                        Cnn.Close();
                        btnBoqua_Click(sender, e);

                    }
                }    
                
            }
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtHoten.Text
                = txtDienthoai.Text
                = txtDiachi.Text
                = txtMaphongban.Text
                = String.Empty;
            dtpNgaysinh.ResetText();
            txtHoten.Focus();
            btnNhap.Text = "Thêm mới";
            btnNhap.Tag = null;
            hienNhanvien();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            hienNhanvien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn xoá không ?"
                , "Khẳng định"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);
            if (rs == DialogResult.No)
                return;
            //----------------------
            try
            {
                DataView dvNhanvien = (DataView)dgrNhanvien.DataSource;
                DataRowView drvNhanvien = dvNhanvien[dgrNhanvien.CurrentRow.Index];
                string connectionString = ConfigurationManager.ConnectionStrings["qlNhanLuc"].ConnectionString;
                using (SqlConnection Cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand Cmd = new SqlCommand("spNhanvien_Delete", Cnn))
                    {
                        Cmd.CommandType = CommandType.StoredProcedure;
                        Cmd.Parameters.AddWithValue("@sManhanvien", drvNhanvien["sManhanvien"]);
                        Cnn.Open();
                        Cmd.ExecuteNonQuery();
                        Cnn.Close();               
                        hienNhanvien();
                    }
                }
            }
            catch (Exception ex)
            {

                if (ex.Message.Contains("REFERENCE"))
                    MessageBox.Show("Nhân viên có dữ liệu liên quan, không xoá được"
                        , "Kết quả"
                        , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                else
                    MessageBox.Show("Đã có lỗi xảy ra, hãy liên hệ với đội ngũ kĩ thuật"
                        , "Kết quả"
                        , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DataView dvNhanvien = (DataView)dgrNhanvien.DataSource;
            DataRowView drvNV = dvNhanvien[dgrNhanvien.CurrentRow.Index];
            chuyenTrangthaiSua(drvNV);
        }

        private void chuyenTrangthaiSua(DataRowView drvNV)
        {
            txtHoten.Text = drvNV["sHoten"].ToString();
            dtpNgaysinh.Text = Convert.ToString(drvNV["tNgaysinh"]);
            rbtnNam.Checked = Convert.ToBoolean(drvNV["bGioitinh"]);
            rbtnNu.Checked = rbtnNam.Checked;
            txtDienthoai.Text = drvNV["sDienthoai"].ToString();
            txtDiachi.Text = drvNV["sDiachi"].ToString();
            txtMaphongban.Text = drvNV["sMaphongban"].ToString();
            btnNhap.Text = "Cập nhật";
            btnNhap.Tag = drvNV["sManhanvien"].ToString();
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string filter = "sManhanvien > 0";
            if (!string.IsNullOrEmpty(txtHoten.Text.Trim()))
                filter += string.Format(" AND sHoten LIKE '%{0}%'", txtHoten.Text);
            if (!string.IsNullOrEmpty(txtDienthoai.Text.Trim()))
                filter += string.Format(" AND sDienthoai LIKE '%{0}%'", txtDienthoai.Text);
            hienNhanvien(filter);
        }

        private int kiemtraMPB()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["qlNhanLUc"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string k = txtMaphongban.Text;
                string strsql = "Select * from tblPhongban where sMaphongban ='" + k.ToString() + "'";

                using (SqlCommand cmd = new SqlCommand(strsql, cnn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                            return 1;//có 1 bản ghi, đã tồn tại
                        else
                            return 0;
                    }
                }
            }
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            string filter = "{tblNhanvien.sManhanvien} > 0";
            if (!string.IsNullOrEmpty(txtHoten.Text.Trim()))
                filter += string.Format(" AND {1} LIKE '*{0}*'"
                    , txtHoten.Text
                    , "{tblNhanvien.sHoten}");
            if (!string.IsNullOrEmpty(txtDienthoai.Text.Trim()))
                filter += string.Format(" AND {1} LIKE '*{0}*'"
                    , txtDienthoai.Text
                    , "{tblNhanvien.sDienthoai}");

            ///hienthi report

            frmReportsViewer reportViewerform = Program.findOpenForm("frmReportsViewer") as frmReportsViewer;
            if (reportViewerform == null)
                reportViewerform = new frmReportsViewer();
            reportViewerform.Show();
            reportViewerform.ShowReport("Nhanvien.rpt"
                , filter
                , "Danh sach Nhan vien");
            reportViewerform.Activate();
        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            Form1 fForm1 = new Form1();
            //this.Hide();
            fForm1.Show();
            Visible = false;
        }

        private void btnPhongban_Click(object sender, EventArgs e)
        {
            Phongban fPhongban = new Phongban();
            //this.Hide();
            fPhongban.Show();
            Visible = false;
        }
    }
}
