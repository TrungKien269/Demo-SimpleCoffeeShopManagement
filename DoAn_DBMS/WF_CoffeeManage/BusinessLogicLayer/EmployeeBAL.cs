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
    public class EmployeeBAL
    {
        private DAL db;

        public EmployeeBAL()
        {
            db = new DAL();
        }

        public DataSet GetAllEmployeeList()
        {
            //string query = "Select * From Employees";
            string query = "Select * From NhanVien";
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public DataSet GetEmployeeList()
        {
            string query = "spGetNhanVien";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, null);
        }

        public DataSet GetEmployeeProfile()
        {
            string query = "spGetProfileNhanVien";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, null);
        }

        public DataSet GetEmployeeFromProperty(string property, string value)
        {
            string query = "spGetNhanVienFromProperty";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, new SqlParameter("@Property", property),
                new SqlParameter("@Value", value));
        }

        public string Insert(int MaNV, string HoTen, string GioiTinh, int Tuoi, string DiaChi, DateTime NgayBD,
            string UserName, int MaCV)
        {
            string query = "spInsertNhanVien";
            return db.ExecuteNonQuery(query, CommandType.StoredProcedure, new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@HoTen", HoTen), new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@Tuoi", Tuoi),
                new SqlParameter("@DiaChi", DiaChi), new SqlParameter("@NgayBD", NgayBD),
                new SqlParameter("@UserName", UserName),
                new SqlParameter("@MaCV", MaCV));
        }

        public string Update(int MaNV, string HoTen, string GioiTinh, int Tuoi, string DiaChi, DateTime NgayBD, int Luong,
            string UserName, int MaCV)
        {
            string query = "spUpdateNhanVien";
            return db.ExecuteNonQuery(query, CommandType.StoredProcedure, new SqlParameter("@MaNV", MaNV),
                new SqlParameter("@HoTen", HoTen), new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@Tuoi", Tuoi),
                new SqlParameter("@DiaChi", DiaChi), new SqlParameter("@NgayBatDau", NgayBD), new SqlParameter(@"Luong", Luong),
                new SqlParameter("@UserName", UserName),
                new SqlParameter("@MaCV", MaCV));
        }

        public string Delete(int MaNV)
        {
            string query = "spDeleteNhanVien";
            return db.ExecuteNonQuery(query, CommandType.StoredProcedure, new SqlParameter("@MaNV", MaNV));
        }
    }
}
