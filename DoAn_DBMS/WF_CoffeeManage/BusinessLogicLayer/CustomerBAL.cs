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
    public class CustomerBAL
    {
        private DAL db;

        public CustomerBAL()
        {
            db = new DAL();
        }

        public DataSet GetAllCustomerList()
        {
            //string query = "Select * From Customers";
            string query = "Select * From KhachHang";
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public DataSet GetCustomerList()
        {
            //string query = "Select * From Customers";
            string query = "spGetKhachHang";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, null);
        }

        public string GetNextKhachHang()
        {
            string query = "fnGetNextKhachHang()";
            return db.ExecuteQuery(query, CommandType.Text, null).Tables[0].Rows[0][0].ToString();
        }

        public DataSet GetCustomerFromProperty(string property, string value)
        {
            string query = "spGetKhachHangFromProperty";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, new SqlParameter("@Property", property),
                new SqlParameter("@Value", value));
        }

        public string Insert(int MaKH, string HoTen, string GioiTinh, string DiaChi, string Phone, string ThanhPho)
        {
            string query = "spInsertKhachHang";
            return db.ExecuteNonQuery(query, CommandType.StoredProcedure, new SqlParameter("@MaKH", MaKH),
                new SqlParameter("@HoTen", HoTen), new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@Phone", Phone), new SqlParameter("@ThanhPho", ThanhPho));
        }

        public string Update(int MaKH, string HoTen, string GioiTinh, string DiaChi, string Phone, string ThanhPho)
        {
            string query = "spUpdateKhachHang";
            return db.ExecuteNonQuery(query, CommandType.StoredProcedure, new SqlParameter("@MaKH", MaKH),
                new SqlParameter("@HoTen", HoTen), new SqlParameter("@GioiTinh", GioiTinh),
                new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@Phone", Phone), new SqlParameter("@ThanhPho", ThanhPho));
        }

        public string Delete(int MaKH)
        {
            string query = "spDeleteKhachHang";
            return db.ExecuteNonQuery(query, CommandType.StoredProcedure, new SqlParameter("@MaKH", MaKH));
        }
    }
}
