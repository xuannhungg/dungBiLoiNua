using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DoAn_Nhom7
{
    internal class ThueDAO
    {
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.conStr);
        DBConnection dbconnection = new DBConnection();
        public DataTable DanhSach()
        {
            string sqlStr = string.Format("SELECT *FROM Thue");
            return dbconnection.DanhSach(sqlStr);
        }
        public DataSet timCongDanTheoCCCD(Thue thue)
        {
            string sqlStr = "SELECT * from CongDan WHERE cmnd LIKE '%" + thue.CCCD + "%' ";
            DataSet dts = dbconnection.timCongDanTheoCCCD(sqlStr, thue);
            return dts;
        }
        public void DongTien(Thue thue)
        {
            string sqlStr = string.Format("UPDATE Thue SET TinhTrang = '{0}' WHERE CCCD = '{1}'",thue.TinhTrang,thue.CCCD);
            dbconnection.XuLy(sqlStr);
        }
        public void ThemDoiTuong(Thue thue)
        {
            string sqlStr = string.Format("INSERT INTO Thue( CCCD, LoaiThue, MucThue, TinhTrang)  VALUES ('{0}', '{1}','{2}', '{3}')", thue.CCCD, thue.LoaiThue, thue.MucThue, thue.TinhTrang);
            dbconnection.XuLy(sqlStr);
        }
        public void SuaDoiTuong(Thue thue)
        {
            string sqlStr = string.Format("UPDATE Thue SET LoaiThue = '{0}' , MucThue = '{1}', TinhTrang = '{2}' WHERE CCCD = '{3}'", thue.LoaiThue, thue.MucThue, thue.TinhTrang, thue.CCCD);
            dbconnection.XuLy(sqlStr);
        }
        public void XoaDoiTuong(Thue thue)
        {
            string sqlStr = string.Format("DELETE FROM Thue WHERE CCCD = '{0}'", thue.CCCD);
            dbconnection.XuLy(sqlStr);
        }
    }
}
