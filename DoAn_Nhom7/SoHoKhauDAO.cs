using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn_Nhom7
{
    internal class SoHoKhauDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr);
        DBConnection dbconnection = new DBConnection();
        public DataTable DanhSach()
        {
            string sqlStr = string.Format("SELECT *FROM SoHoKhau");
            return dbconnection.DanhSach(sqlStr);
        }
        public void ThemSoHoKhau(SoHoKhau hk)
        {
            string sqlStr = string.Format("INSERT INTO SoHoKhau (maKV, xaPhuong, quanHuyen, tinhTP,cmnd, maSoHoKhau, hoTenChuHo, diaChi,ngayLap)  VALUES ('{0}', '{1}','{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", hk.MaKV, hk.XaPhuong, hk.QuanHuyen, hk.TinhThanhPho
            , hk.CMND, hk.MaSoHoKhau, hk.HoTenChuHo, hk.DiaChi, hk.NgayLap);
            dbconnection.XuLy(sqlStr);
        }
        public void SuaSoHoKhau(SoHoKhau hk)
        {
            string sqlStr = string.Format("UPDATE SoHoKhau SET xaPhuong = '{0}' , quanHuyen = '{1}', tinhTP = '{2}',cmnd='{3}', maSoHoKhau = '{4}', hoTenChuHo = '{5}', diaChi = '{6}', ngayLap = '{7}' WHERE maKV = '{8}'", hk.XaPhuong, hk.QuanHuyen, hk.TinhThanhPho
            , hk.CMND, hk.MaSoHoKhau, hk.HoTenChuHo, hk.DiaChi, hk.NgayLap, hk.MaKV);
            dbconnection.XuLy(sqlStr);
        }
        public void XoaSoHoKhau(SoHoKhau hk)
        {
            string sqlStr = string.Format("DELETE FROM SoHoKhau WHERE maKV = '{0}'", hk.MaKV);
            dbconnection.XuLy(sqlStr);
        }
    }
}
