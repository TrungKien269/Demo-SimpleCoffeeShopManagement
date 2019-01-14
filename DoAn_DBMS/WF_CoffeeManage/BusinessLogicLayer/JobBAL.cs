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
    public class JobBAL
    {
        private DAL db;

        public JobBAL()
        {
            db = new DAL();
        }

        public DataSet GetJobList()
        {
            //string query = "Select * From Jobs";
            string query = "spGetCongViec";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, null);
        }

        public DataSet GetJobFromProperty(string property, string value)
        {
            string query = "spGetCongViecFromProperty";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, new SqlParameter("@Property", property),
                new SqlParameter("@Value", value));
        }
    }
}
