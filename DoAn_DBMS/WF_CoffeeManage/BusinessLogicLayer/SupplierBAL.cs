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
    public class SupplierBAL
    {
        private DAL db;

        public SupplierBAL()
        {
            db = new DAL();
        }

        public DataSet GetAllSupplierList()
        {
            //string query = "Select * From Suppliers";
            string query = "Select * From NhaCungCap";
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public DataSet GetSupplierList()
        {
            //string query = "Select * From Suppliers";
            string query = "spGetNhaCungCap";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, null);
        }

        public DataSet GetSupplierFromProperty(string property, string value)
        {
            string query = "spGetNhaCungCapFromProperty";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, new SqlParameter("@Property", property),
                new SqlParameter("@Value", value));
        }

        public string Insert(int MaNCC, string TenNCC, string DiaChi, string SoDT)
        {
            string query = "spInsertNhaCungCap";
            return db.ExecuteNonQuery(query, CommandType.StoredProcedure, new SqlParameter("@MaNCC", MaNCC),
                new SqlParameter("@TenNCC", TenNCC), new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SoDT", SoDT));
        }

        public string Delete(int MaNCC)
        {
            string query = "spDeleteNhaCungCap";
            return db.ExecuteNonQuery(query, CommandType.StoredProcedure, new SqlParameter("@MaNCC", MaNCC));
        }

        public string Update(int MaNCC, string TenNCC, string DiaChi, string SoDT)
        {
            string query = "spUpdateNhaCungCap";
            return db.ExecuteNonQuery(query, CommandType.StoredProcedure, new SqlParameter("@MaNCC", MaNCC),
                new SqlParameter("@TenNCC", TenNCC), new SqlParameter("@DiaChi", DiaChi),
                new SqlParameter("@SoDT", SoDT));
        }
    }
}
