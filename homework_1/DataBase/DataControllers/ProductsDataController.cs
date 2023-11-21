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
    internal class ProductsDataController
    {
        public IEnumerable<Product> GetAllProducts()
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Query<Product>(
                    DataBaseConstants.GetAllProducts,
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }
    }
}
