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
    public partial class FSoHoKhau : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr);
        SoHoKhauDAO hkdao = new SoHoKhauDAO();
        DBConnection dbconnection = new DBConnection();
        public FSoHoKhau()
        {
            InitializeComponent();
        }
        public void LayDanhSach()
        {
            this.gvSoHoKhau.DataSource = hkdao.DanhSach();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            SoHoKhau hk = new SoHoKhau(txtMaKhuVuc.Text, txtXaPhuong.Text, txtQuanHuyen.Text, txtTinhThanhPho.Text, txtCMND.Text, txtMaSoHoKhau.Text, txtHoTenChuHo.Text, txtDiaChi.Text, tpNgayLap.Text);
            hkdao.ThemSoHoKhau(hk);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SoHoKhau hk = new SoHoKhau(txtMaKhuVuc.Text, txtXaPhuong.Text, txtQuanHuyen.Text, txtTinhThanhPho.Text, txtCMND.Text, txtMaSoHoKhau.Text, txtHoTenChuHo.Text, txtDiaChi.Text, tpNgayLap.Text);
            hkdao.XoaSoHoKhau(hk);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SoHoKhau hk = new SoHoKhau(txtMaKhuVuc.Text, txtXaPhuong.Text, txtQuanHuyen.Text, txtTinhThanhPho.Text, txtCMND.Text, txtMaSoHoKhau.Text, txtHoTenChuHo.Text, txtDiaChi.Text, tpNgayLap.Text);
            hkdao.SuaSoHoKhau(hk);
        }

        private void gvSoHoKhau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LayDanhSach();
        }

        private void FSoHoKhau_Load(object sender, EventArgs e)
        {
            LayDanhSach();
        }


    }
}
