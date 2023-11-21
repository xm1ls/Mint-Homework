using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataBase.Constants;
using DataBase.Models;
using Dapper;

namespace DataBase.DataControllers
{
    internal class SubcategoriesDataController
    {
        public IEnumerable<Subcategory> GetAllSubcategories()
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Query<Subcategory>(
                    DataBaseConstants.GetAllSubcategories,
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }

        public bool CreateSubcategory(Subcategory subcategory)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DataBaseConstants.CreateSubcategory,
                    new
                    {
                        subcategory.SubcategoryName,
                        subcategory.SubcategoryCategoryID
                    },
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }

        public bool UpdateSubcategory(Subcategory subcategory)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DataBaseConstants.UpdateSubcategory,
                    new
                    {
                        subcategory.SubcategoryName,
                        subcategory.SubcategoryCategoryID
                    },
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }

        public bool DeleteSubcategory(int subcategoryId)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DataBaseConstants.DeleteSubcategory,
                    new
                    {
                        SubcategoryID = subcategoryId
                    },
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }
    }
}
