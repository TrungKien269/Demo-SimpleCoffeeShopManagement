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
    public class ImportBillBAL
    {
        private DAL db;

        public ImportBillBAL()
        {
            db = new DAL();
        }

        public DataSet GetAllBills()
        {
            string query = "spGetHopDongCC";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, null);
        }

        public DataSet GetImportBillFromProperty(string property, string value)
        {
            string query = "spGetHopDongCCFromProperty";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, new SqlParameter("@Property", property),
                new SqlParameter("@Value", value));
        }
    }
}
