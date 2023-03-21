using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom7
{

    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr);
        CongDanDAO congdandao = new CongDanDAO();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            FCongDan form2 = new FCongDan();
            form2.Show();
        }
        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            DangNhap form3 = new DangNhap();
            form3.Show();
        }
        public void LayDanhSach()
        {
            this.dGVDanhSach.DataSource = congdandao.DanhSach();

            if (rdbDaKetHon.Checked == true)
                TimNguoiDaKetHon();
            else if (rdbChuaKetHon.Checked == true)
                TimNguoiChuaKetHon();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LayDanhSach();
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap formdn = new DangNhap();
            formdn.ShowDialog();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DangKi formdk = new DangKi();
            formdk.ShowDialog();

        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataSet dts = congdandao.TimCongDanTheoCCCD(txtCCCD.Text, dGVDanhSach);
            this.dGVDanhSach.DataSource = dts.Tables["cmnd"];
        }
        private void button17_Click(object sender, EventArgs e)
        {
            FCongDan form1 = new FCongDan();
            form1.ShowDialog();
        }

        //public void LoadData()
        //{
        //    conn.Open();
        //    string sqlStr = "select * from CongDan";
        //    SqlCommand command = new SqlCommand(sqlStr, conn);
        //    SqlDataAdapter adapter = new SqlDataAdapter(command);
        //    DataSet set = new DataSet();
        //    adapter.Fill(set);
        //    dGVDanhSach.DataSource = set.Tables[0];
        //    conn.Close();            
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            LayDanhSach();
            txtCCCD.Text = "";
        }

        private void btnCCCD_Click(object sender, EventArgs e)
        {
            FCongDan formCCCD = new FCongDan();
            formCCCD.Show();
        }
        public void TimNguoiDaKetHon()
        {
            DataSet dts = congdandao.TimCongDanTheoTinhTrangHonNhan(rdbDaKetHon.Text,dGVDanhSach);
            this.dGVDanhSach.DataSource = dts.Tables["tinhTrangHonNhan"];
        }
        public void TimNguoiChuaKetHon()
        {
            DataSet dts = congdandao.TimCongDanTheoTinhTrangHonNhan(rdbChuaKetHon.Text, dGVDanhSach);
            this.dGVDanhSach.DataSource = dts.Tables["tinhTrangHonNhan"];
        }
        private void dGVDanhSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThue_Click(object sender, EventArgs e)
        {
            FThue fThue = new FThue();
            fThue.Show();
        }

        private void bthHonNhan_Click(object sender, EventArgs e)
        {
            HonNhanVaGiaDinh form1 = new HonNhanVaGiaDinh();
            form1.ShowDialog();
        }

        private void btnSoHoKhau_Click(object sender, EventArgs e)
        {
            FSoHoKhau form = new FSoHoKhau();
            form.ShowDialog();
        }

        private void cmbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTimKiem.Text == "Khai tu")
            {
                FKhaiTu form = new FKhaiTu();
                form.Show();
            }    
        }

        private void btnKhaiTu_Click(object sender, EventArgs e)
        {
            FKhaiTu form = new FKhaiTu();
            form.Show();
        }
    }
}
