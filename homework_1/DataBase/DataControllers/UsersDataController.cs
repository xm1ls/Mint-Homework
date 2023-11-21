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
    internal class UsersDataController
    {
        public IEnumerable<User> GetAllUsers()
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Query<User>(
                    DataBaseConstants.GetAllUsers,
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }
    }
}
