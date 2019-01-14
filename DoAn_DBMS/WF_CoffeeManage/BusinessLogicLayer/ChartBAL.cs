using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class ChartBAL
    {
        private DAL db;

        public ChartBAL()
        {
            db = new DAL();
        }

        public DataSet GetChartList(string ProcedureName)
        {
            string query = ProcedureName;
            return db.ExecuteQuery(query, CommandType.StoredProcedure, null);
        }
    }
}
