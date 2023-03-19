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

namespace DoAn_Nhom7
{
    public partial class FThue : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.conStr);
        ThueDAO thueDao = new ThueDAO();
        public FThue()
        {
            InitializeComponent();
        }

        private void FThue_Load(object sender, EventArgs e)
        {
            LayDanhSach();           
        }
        public void LayDanhSach()
        {
            this.dGVThue.DataSource = thueDao.DanhSach();
            this.dGVChinhSuaDanhSach.DataSource = thueDao.DanhSach();
        }
        private void cbChuaDong_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void LayThongTinCongDan()
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM CongDan WHERE cmnd = '" + txtCCCD.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "CCCD");
            if (ds.Tables["CCCD"].Rows.Count > 0)
                dGVCongDan.DataSource = ds.Tables["CCCD"];

            txtLuong.Text = ds.Tables["CCCD"].Rows[0][11].ToString();
            txtTen.Text = ds.Tables["CCCD"].Rows[0][0].ToString();
            txtNgheNghiep.Text = ds.Tables["CCCD"].Rows[0][10].ToString();

            con.Close();

        }
        private void dGVThue_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dGVThue.Rows[e.RowIndex];
            txtCCCD.Text = row.Cells[0].Value.ToString();
            txtLoaiThue.Text = row.Cells[1].Value.ToString();
            txtMucThue.Text = row.Cells[2].Value.ToString();
            if (row.Cells[3].Value.ToString() == "Chua dong")
            {
                cbChuaDong.Checked = true;
                cbDaDong.Checked = false;
            }
            else if (row.Cells[3].Value.ToString() == "Da dong")
            {
                cbDaDong.Checked = true;
                cbChuaDong.Checked = false;
            }

            tinhSoTienCanDong();
            LayThongTinCongDan();
        }
        private void tinhSoTienCanDong()
        {
            if (cbChuaDong.Checked == true)
            {
                Thue thue = new Thue(txtCCCD.Text, txtLoaiThue.Text, Convert.ToDouble(txtMucThue.Text), cbChuaDong.Text);
                DataSet dts = thueDao.timCongDanTheoCCCD(thue);
                double luong = Convert.ToDouble(dts.Tables[0].Rows[0][11].ToString());
                double mucThue = Convert.ToDouble(txtMucThue.Text);
                double soTien = (luong * mucThue) / 100;
                txtSoTienCanDong.Text = Convert.ToString(soTien);
                cbDaDong.Checked = false;
            }
            else
            {
                cbDaDong.Checked = true;
                txtSoTienCanDong.Text = "0";
            }            
        }
        private void txtSoTienCanDong_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void btnDongTien_Click(object sender, EventArgs e)
        {
            if (cbDaDong.Checked == true)
                MessageBox.Show("Ban da dong tien roi!");
            else
            {
                Thue thue = new Thue(txtCCCD.Text, txtLoaiThue.Text, Convert.ToDouble(txtMucThue.Text), cbDaDong.Text);
                thueDao.DongTien(thue);
                cbChuaDong.Checked = false;
                cbDaDong.Checked = true;
                txtSoTienCanDong.Text = "0";
                LayDanhSach();
            }
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThemDoiTuong_Click(object sender, EventArgs e)
        {
            Thue thue = new Thue(txtCCCD2.Text, txtLoaiThue2.Text, Convert.ToDouble(txtMucThue2.Text), txtTinhTrang2.Text);
            thueDao.ThemDoiTuong(thue);
            LayDanhSach();
        }

        private void btnSuaDoiTuong_Click(object sender, EventArgs e)
        {
            Thue thue = new Thue(txtCCCD2.Text, txtLoaiThue2.Text, Convert.ToDouble(txtMucThue2.Text), txtTinhTrang2.Text);
            thueDao.SuaDoiTuong(thue);
            LayDanhSach();
        }

        private void btnXoaDoiTuong_Click(object sender, EventArgs e)
        {
            Thue thue = new Thue(txtCCCD2.Text, txtLoaiThue2.Text, Convert.ToDouble(txtMucThue2.Text), txtTinhTrang2.Text);
            thueDao.XoaDoiTuong(thue);
            LayDanhSach();
        }

        private void txtLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNgheNghiep_TextChanged(object sender, EventArgs e)
        {

        }

        private void dGVChinhSuaDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dGVThue.Rows[e.RowIndex];
            txtCCCD2.Text = row.Cells[0].Value.ToString();
            txtLoaiThue2.Text = row.Cells[1].Value.ToString();
            txtMucThue2.Text = row.Cells[2].Value.ToString();
            txtTinhTrang2.Text = row.Cells[3].Value.ToString();
        }

        private void dGVCongDan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
