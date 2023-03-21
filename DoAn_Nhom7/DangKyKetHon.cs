using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom7
{
    public partial class DangKyKetHon : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr);
        DBConnection dbconnection = new DBConnection();
        CongDanDAO cddao = new CongDanDAO();
        public DangKyKetHon()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(dbconnection.KiemTraHonNhan(txtGiayToTuyThanNam.Text)==true && dbconnection.KiemTraHonNhan(txtGiayToTuyThanNu.Text)==true)
            {
                CongDan cdA = new CongDan(txtGiayToTuyThanNam.Text,txtHoTenNam.Text);
                CongDan cdB = new CongDan(txtGiayToTuyThanNu.Text,txtHoTenNu.Text);
                cddao.CapNhatKetHon(cdA,cdB);
            }
            else           
                MessageBox.Show("Co nguoi dang o tinh trang ket hon");               
        }
        private void txtGiayToTuyThanNam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dbconnection.LapDayThongTin(txtGiayToTuyThanNam, txtHoTenNam, txtNgaySinhNam, txtDanTocNam, txtQuocTichNam, txtNoiCuTruNam);

            }
        }

        private void txtGiayToTuyThanNu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dbconnection.LapDayThongTin(txtGiayToTuyThanNu, txtHoTenNu, txtNgaySinhNu,txtDanTocNu, txtQuocTichNu, txtNoiCuTruNu);
            }
        }

        private void DangKyKetHon_Load(object sender, EventArgs e)
        {

        }
    }
}
