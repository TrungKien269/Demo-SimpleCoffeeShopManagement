using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class ExportBillBAL
    {
        private DAL db;

        public ExportBillBAL()
        {
            db = new DAL();
        }

        public DataSet GetBills(DateTime StartDate, DateTime EndDate)
        {
            string query = "spGetHoaDon";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, new SqlParameter("@StartDate", StartDate),
                new SqlParameter("@EndDate", EndDate));
        }

        public DataSet GetAllBills()
        {
            string query = "spGetALlHoaDon";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, null);
        }

        public DataSet GetBillDetail(int MaHD)
        {
            string query = "spGetChiTietHoaDon";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, new SqlParameter("@MaHD", MaHD));
        }

        public DataSet GetBillType()
        {
            string query = "spGetLoaiHoaDon";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, null);

        }

        public string GetNextHoaDon()
        {
            string query = "Select * from fnGetNextHoaDon()";
            return db.ExecuteQuery(query, CommandType.Text, null).Tables[0].Rows[0][0].ToString();
        }

        public DataSet GetEmployeeFromProperty(string property, string value)
        {
            string query = "spGetHoaDonFromProperty";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, new SqlParameter("@Property", property),
                new SqlParameter("@Value", value));
        }

        public string InsertHoaDon(int MaHD, DateTime ThoiDiem, int MaKH, int MaNV, int MaLoai)
        {
            string query = "spInsertHoaDon";
            return db.ExecuteNonQuery(query, CommandType.StoredProcedure, new SqlParameter("@MaHD", MaHD),
                new SqlParameter("@ThoiDiem", ThoiDiem),
                new SqlParameter("@MaKH", MaKH), new SqlParameter("@MaNV", MaNV), new SqlParameter("@MaLoai", MaLoai));
        }

        public string InsertChiTietHD(int MaHD, int MaTU, int SoLuong)
        {
            string query = "spInsertChiTietHD";
            return db.ExecuteNonQuery(query, CommandType.StoredProcedure, new SqlParameter("@MaHD", MaHD),
                new SqlParameter("@MaTU", MaTU), new SqlParameter("@SoLuong", SoLuong));
        }
    }
}
