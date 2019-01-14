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
    public class DrinkBAL
    {
        private DAL db;

        public DrinkBAL()
        {
            db = new DAL();
        }

        public DataSet GetDrinkList()
        {
            string query = "spGetThucUong";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, null);
        }

        public DataSet GetAllDrinkList()
        {
            string query = "spGetAllThucUong";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, null);
        }

        public DataSet GetDrinkListFromCategory(int MaMuc)
        {
            string query = "spGetDrinkListFromCategory";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, new SqlParameter("MaMuc", MaMuc));
        }

        public string GetDrinkImage(int MaTU)
        {
            string query = "spGetImageThucUong";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, new SqlParameter("@MaTU", MaTU)).Tables[0]
                .Rows[0][0].ToString();
        }

        public DataSet GetDrinkFromProperty(string property, string value)
        {
            string query = "spGetThucUongFromProperty";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, new SqlParameter("@Property", property),
                new SqlParameter("@Value", value));
        }

        public string Insert(int MaTU, string TenTU, int DonGia, string LinkAnh, int MaMuc)
        {
            string query = "spInsertThucUong";
            return db.ExecuteNonQuery(query, CommandType.StoredProcedure, new SqlParameter("@MaTU", MaTU),
                new SqlParameter("@TenTU", TenTU), new SqlParameter("@DonGia", DonGia),
                new SqlParameter("@LinkAnh", LinkAnh),
                new SqlParameter("@MaMuc", MaMuc));
        }

        public string Delete(int MaTU)
        {
            string query = "spDeleteThucUong";
            return db.ExecuteNonQuery(query, CommandType.StoredProcedure, new SqlParameter("@MaTU", MaTU));
        }

        public string Update(int MaTU, string TenTU, int DonGia, string LinkAnh, int MaMuc)
        {
            string query = "spUpdateThucUong";
            return db.ExecuteNonQuery(query, CommandType.StoredProcedure, new SqlParameter("@MaTU", MaTU),
                new SqlParameter("@TenTU", TenTU), new SqlParameter("@DonGia", DonGia),
                new SqlParameter("@LinkAnh", LinkAnh),
                new SqlParameter("@MaMuc", MaMuc));
        }
    }
}
