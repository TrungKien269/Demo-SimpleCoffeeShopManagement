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
    public class ElementBAL
    {
        private DAL db;

        public ElementBAL()
        {
            db = new DAL();
        }

        public DataSet GetAllElementList()
        {
            //string query = "Select * From Elements";
            string query = "Select * From NguyenLieu";
            return db.ExecuteQuery(query, CommandType.Text, null);
        }

        public DataSet GetElementList()
        {
            string query = "spGetNguyenLieu";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, null);
        }

        public DataSet GetElementFromProperty(string property, string value)
        {
            string query = "spGetNguyenLieuFromProperty";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, new SqlParameter("@Property", property),
                new SqlParameter("@Value", value));
        }
    }
}
