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
    public class AccountBAL
    {
        private DAL db;

        public AccountBAL()
        {
            db = new DAL();
        }

        public DataSet GetAllAccountList()
        {
            string query = "Select * From TaiKhoan";
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public DataSet GetAccountList()
        {
            string query = "spGetTaiKhoan";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, null);
        }

        public string GetPassword(string UserName)
        {
            string query = "spGetPassword";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, new SqlParameter("@UserName", UserName))
                .Tables[0].Rows[0][0].ToString();
        }

        public DataSet GetAccountFromProperty(string property, string value)
        {
            string query = "spGetTaiKhoanFromProperty";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, new SqlParameter("@Property", property),
                new SqlParameter("@Value", value));
        }

        public string InsertAccount(string Username, string Password, int Type)
        {
            return db.ExecuteNonQuery("spInsertTaiKhoan", CommandType.StoredProcedure,
                new SqlParameter("@UserName", Username),
                new SqlParameter("@Password", Password), new SqlParameter("@LoaiTK", Type));
        }

        public string UpdateAccount(string Username, string Password)
        {
            return db.ExecuteNonQuery("spUpdateTaiKhoan", CommandType.StoredProcedure,
                new SqlParameter("@UserName", Username),
                new SqlParameter("@Password", Password));
        }
    }
}
