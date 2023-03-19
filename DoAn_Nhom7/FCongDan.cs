using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom7
{
    public partial class FCongDan : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr);
        DBConnection dbconnection = new DBConnection();
        CongDanDAO cddao = new CongDanDAO();
        public FCongDan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CongDan cd = new CongDan(txtHoTen.Text, dTPNgaySinh.Text, txtGioiTinh.Text, txtCCCD.Text, txtDanToc.Text, txtHonNhan.Text, txtKhaiSinh.Text, txtQueQuan.Text, txtThuongTru.Text, txtHocVan.Text, txtNgheNghiep.Text, txtLuong.Text);
            cddao.Them(cd);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            CongDan cd = new CongDan(txtHoTen.Text, dTPNgaySinh.Text, txtGioiTinh.Text, txtCCCD.Text, txtDanToc.Text, txtHonNhan.Text, txtKhaiSinh.Text, txtQueQuan.Text, txtThuongTru.Text, txtHocVan.Text, txtNgheNghiep.Text, txtLuong.Text);
            cddao.Xoa(cd);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            CongDan cd = new CongDan(txtHoTen.Text, dTPNgaySinh.Text, txtGioiTinh.Text, txtCCCD.Text, txtDanToc.Text, txtHonNhan.Text, txtKhaiSinh.Text, txtQueQuan.Text, txtThuongTru.Text, txtHocVan.Text, txtNgheNghiep.Text, txtLuong.Text);
            cddao.Sua(cd);
            
        }

        private void txtCCCD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dbconnection.LapDayThongTinCD(txtCCCD, txtHoTen, dTPNgaySinh, txtGioiTinh, txtDanToc, txtHonNhan, txtKhaiSinh, txtQueQuan, txtThuongTru, txtHocVan, txtNgheNghiep, txtLuong);
            }
        }
    }
}
