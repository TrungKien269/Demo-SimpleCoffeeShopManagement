using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class DrinkCategoryBAL
    {
        private DAL db;

        public DrinkCategoryBAL()
        {
            db = new DAL();
        }

        public DataSet GetDrinkCategoryList()
        {
            //string query = "Select * From DrinkCategories";
            string query = "spGetDanhMuc";
            return db.ExecuteQuery(query, CommandType.StoredProcedure, null);
        }
    }
}
