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
    public partial class Phongban : Form
    {
        public Phongban()
        {
            InitializeComponent();
        }

        private void Phongban_Load(object sender, EventArgs e)
        {
            hienPhongban();
        }

        private void hienPhongban(string dieukienloc = "")
        {
            using (DataTable tblPhongban = getPhongban())
            {
                DataView dvPhongban = new DataView(tblPhongban);
                if (!string.IsNullOrEmpty(dieukienloc))
                    dvPhongban.RowFilter = dieukienloc;
                dgrPhongban.AutoGenerateColumns = false;
                dgrPhongban.DataSource = dvPhongban;
                //btnSua.Enabled = btnXoa.Enabled = (dgrPhongban.Rows.Count > 0);
            }
        }

        private DataTable getPhongban()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["qlNhanLuc"].ConnectionString;
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand("spPhongban_Get", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataAdapter Dv = new SqlDataAdapter(Cmd))
                    {
                        DataTable tbl = new DataTable("tblPhongban");
                        Dv.Fill(tbl);
                        return tbl;
                    }
                }//Cmd
            }
        }

        

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            txtTenphongban.Text
                = txtMaphongban.Text
                = String.Empty;
            txtMaphongban.Focus();
            btnNhap.Text = "Thêm mới";
            btnNhap.Tag = null;
            hienPhongban();
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
                if (kiemtraMPB() == 0)
                {
                    DataView dvPhongban = (DataView)dgrPhongban.DataSource;
                    DataRowView drvPhongban = dvPhongban[dgrPhongban.CurrentRow.Index];
                    string connectionString = ConfigurationManager.ConnectionStrings["qlNhanLuc"].ConnectionString;
                    using (SqlConnection Cnn = new SqlConnection(connectionString))
                    {
                        using (SqlCommand Cmd = new SqlCommand("spPhongban_Delete", Cnn))
                        {
                            Cmd.CommandType = CommandType.StoredProcedure;
                            Cmd.Parameters.AddWithValue("@sMaphongban", drvPhongban["sMaphongban"]);
                            Cnn.Open();
                            Cmd.ExecuteNonQuery();
                            Cnn.Close();
                            btnBoqua_Click(sender, e);
                            hienPhongban();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Phòng ban có dữ liệu liên quan, không xoá được"
                        , "Kết quả"
                        , MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
                }    
                
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("REFERENCE"))
                    MessageBox.Show("Phòng ban có dữ liệu liên quan, không xoá được"
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

        private int kiemtraMPB()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["qlNhanLUc"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                string k = txtMaphongban.Text;
                string strsql = "Select * from tblNhanvien where sMaphongban ='" + k.ToString() + "'";

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

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string filter = "sMaphongban is not null";
            if (!string.IsNullOrEmpty(txtTenphongban.Text.Trim()))
                filter += string.Format(" AND sTenphongban LIKE '%{0}%'", txtTenphongban.Text);
            if (!string.IsNullOrEmpty(txtMaphongban.Text.Trim()))
                filter += string.Format(" AND sMaphongban LIKE '%{0}%'", txtMaphongban.Text);
            hienPhongban(filter);
            /*
            string tim = "select * from tblNhanvien where sManhanvien is not null";
            if (tbManhanvien.Text != "")
            {
                //tim = tim + " and sMakhachhang= '" + tbTimkiem.Text + "'";
                tim = tim + " and sManhanvien like'%" + tbManhanvien.Text + "%'";
            }
            */
        }

        private void txtMaphongban_TextChanged(object sender, EventArgs e)
        {
            btnNhap.Enabled = (txtMaphongban.Text.Trim().Length > 0);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["qlNhanLuc"].ConnectionString;
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand("", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.CommandText = "spPhongban_Update";
                    Cmd.Parameters.AddWithValue("@sMaphongban", txtMaphongban.Text);
                    Cmd.Parameters.AddWithValue("@sTenphongban", txtTenphongban.Text);
                    DialogResult dg = MessageBox.Show("Bạn sửa thành công", "Thông báo");
                    Cnn.Open();
                    Cmd.ExecuteNonQuery();
                    Cnn.Close();
                    //btnSua.Enabled = btnXoa.Enabled = false;
                    btnBoqua_Click(sender, e);
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["qlNhanLuc"].ConnectionString;
            using (SqlConnection Cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand Cmd = new SqlCommand("", Cnn))
                {
                    Cmd.CommandType = CommandType.StoredProcedure;
                    Cmd.CommandText = "spPhongban_Insert";
                    Cmd.Parameters.AddWithValue("@sMaphongban", txtMaphongban.Text);
                    Cmd.Parameters.AddWithValue("@sTenphongban", txtTenphongban.Text);
                    DialogResult dg = MessageBox.Show("Bạn thêm thành công", "Thông báo");
                    Cnn.Open();
                    Cmd.ExecuteNonQuery();
                    Cnn.Close();
                    btnBoqua_Click(sender, e);
                }
            }
        }
        

        private void dgrPhongban_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtMaphongban.Text = dgrPhongban.CurrentRow.Cells[0].Value.ToString();
            txtTenphongban.Text = dgrPhongban.CurrentRow.Cells[1].Value.ToString();
            dgrPhongban.Enabled = true;
            btnNhap.Enabled = false;
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            //string filter = "sMaphongban is not null";
            //string filter = "{tblPhongban.sMaphongban} is not null ";
            //string filter = "select * from tblPhongban where sMaphongban is not null ";
            string filter = "NOT(IsNull({tblPhongban.sMaphongban}))";
            if (!string.IsNullOrEmpty(txtTenphongban.Text.Trim()))
                filter += string.Format(" AND {1} LIKE '*{0}*'"
                    , txtTenphongban.Text
                    , "{tblPhongban.sTenphongban}");
            if (!string.IsNullOrEmpty(txtMaphongban.Text.Trim()))
                filter += string.Format(" AND {1} LIKE '*{0}*'"
                    , txtMaphongban.Text
                    , "{tblPhongban.sMaphongban}");

            ///hienthi report

            frmReportsViewer reportViewerform = Program.findOpenForm("frmReportsViewer") as frmReportsViewer;
            if (reportViewerform == null)
                reportViewerform = new frmReportsViewer();
            reportViewerform.Show();
            reportViewerform.ShowReport("Phongban.rpt"
                , filter
                , "Danh sach Phong ban");
            reportViewerform.Activate();


        }

        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            Form1 fForm1 = new Form1();
            //this.Hide();
            fForm1.Show();
            Visible = false;

        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            Nhanvien fNhanvien = new Nhanvien();
            //this.Hide();
            fNhanvien.Show();
            Visible = false;
        }
    }
}
