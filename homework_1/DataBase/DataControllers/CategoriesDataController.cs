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
    internal class CategoriesDataController
    {
        public IEnumerable<Categories> GetAllCategories()
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Query<Categories>(
                    DataBaseConstants.GetAllCategories,
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }

        public bool CreateCategory(Categories category)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DataBaseConstants.CreateCategory,
                    new
                    {
                        category.CategoryName
                    },
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }

        public bool UpdateCategory(Categories category)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DataBaseConstants.UpdateCategory,
                    new
                    {
                        category.CategoryName
                    },
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }

        public bool DeleteCategory(int categoryId)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DataBaseConstants.DeleteCategory,
                    new
                    {
                        CategoryID = categoryId
                    },
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }
    }
}
