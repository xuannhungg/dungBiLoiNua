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
    public partial class FKhaiTu : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.conStr);
        CongDanDAO cdDao = new CongDanDAO();
        ThueDAO thueDao = new ThueDAO();
        DBConnection dbC = new DBConnection();
        public FKhaiTu()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblThongTinNguoiYeuCau_Click(object sender, EventArgs e)
        {

        }

        private void FKhaiTu_Load(object sender, EventArgs e)
        {

        }
        private void btnNop_Click(object sender, EventArgs e)
        {
            if (cbToiDongY.Checked)
            {
                Thue thue = new Thue(txtCCCD.Text);
                thueDao.XoaDoiTuong(thue);
                CongDan cd = new CongDan(txtCCCD.Text);
                cdDao.Xoa(cd);
            }
            else
                MessageBox.Show("Vui long xac nhan!");
        }

        private void txtCCCD_KeyDown(object sender, KeyEventArgs e)
        {
            dbC.KhaiTu_KeyDown(txtCCCD, txtTen, txtNgaySinh, txtHonNhan, txtThuongTru, txtGioiTinh, txtDanToc, txtQuocTich, txtQueQuan, txtNgheNghiep);
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
