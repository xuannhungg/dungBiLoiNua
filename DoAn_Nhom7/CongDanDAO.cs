using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom7
{
    public class CongDanDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr);
        DBConnection dbconnection = new DBConnection();
        public void Them(CongDan cd)
        {
            string sqlStr = string.Format("INSERT INTO CongDan( hoTen , ngayThangNamSinh , gioiTinh , cmnd , danToc , tinhTrangHonNhan , noiDangKiKhaiSinh,queQuan,noiThuongTru,trinhDoHocVan,ngheNghiep, luong)  VALUES ('{0}', '{1}','{2}', '{3}','{4}', '{5}','{6}','{7}','{8}','{9}','{10}', '{11}')",cd.HoTen,cd.NgayThangNamSinh,cd.GioiTinh,cd.CMND,cd.DanToc,cd.TinhTrangHonNhan,cd.NoiDangKiKhaiSinh,cd.QueQuan,cd.NoiThuongTru,cd.TrinhDoHocVan,cd.NgheNghiep, cd.Luong);
            dbconnection.XuLy(sqlStr);
        }
        public void Sua(CongDan cd)
        {
            string sqlStr = string.Format("UPDATE CongDan SET hoTen ='{12}',  ngayThangNamSinh = '{0}', gioiTinh= '{1}' , cmnd = '{2}', danToc= '{3}', tinhTrangHonNhan='{4}', noiDangKiKhaiSinh= '{5}', queQuan='{6}', noiThuongTru= '{7}', trinhDoHocVan= '{8}', ngheNghiep='{9}', luong = '{10}' WHERE cmnd = '{11}'",  cd.NgayThangNamSinh, cd.GioiTinh, cd.CMND, cd.DanToc, cd.TinhTrangHonNhan, cd.NoiDangKiKhaiSinh, cd.QueQuan, cd.NoiThuongTru, cd.TrinhDoHocVan, cd.Luong, cd.NgheNghiep,cd.CMND,cd.HoTen);
            dbconnection.XuLy(sqlStr);
        }
        public void Xoa(CongDan cd)
        {
            string sqlStr = string.Format("DELETE FROM CongDan WHERE cmnd = '{0}'", cd.CMND);
            dbconnection.XuLy(sqlStr);
        }
        public DataTable DanhSach()
        {
            string sqlStr ="select * from CongDan";
            return dbconnection.DanhSach(sqlStr);
        }
        public void CapNhatLyHon(CongDan cd)
        {
            string sqlStr = string.Format("UPDATE CongDan SET  tinhTrangHonNhan='Doc Than' WHERE CMND = '{0}'",cd.CMND);
            dbconnection.XuLy(sqlStr);
        }
        public void CapNhatKetHon(CongDan nam,CongDan nu)
        {
            string sqlStr = string.Format("UPDATE CongDan SET  tinhTrangHonNhan='Da Ket Hon Voi "+nu.hoTen+" Co CMND La "+nu.CMND+"' WHERE CMND = '{0}'", nam.CMND);
            dbconnection.XuLy(sqlStr);
            string sqlStr1 = string.Format("UPDATE CongDan SET  tinhTrangHonNhan='Da Ket Hon Voi "+nam.hoTen+" Co CMND La "+nam.CMND+"' WHERE CMND = '{0}'", nu.CMND);
            dbconnection.XuLy(sqlStr1);
        }
        public DataSet TimCongDanTheoTinhTrangHonNhan(string tthn, DataGridView dtgv)
        {
            string sqlStr = "SELECT * from CongDan WHERE tinhTrangHonNhan = '" + tthn + "'";
            return dbconnection.TimCongDanDaKetHon(sqlStr, dtgv);
        }
        public DataSet TimCongDanTheoCCCD(string cccd, DataGridView dtgv)
        {
            string sqlStr = "SELECT * from CongDan WHERE cmnd = '" + cccd + "'";
            return dbconnection.TimCongDanTheoCCCD(sqlStr, dtgv);
        }
    }
}
