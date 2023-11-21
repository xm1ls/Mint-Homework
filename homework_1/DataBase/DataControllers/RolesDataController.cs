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
    internal class RolesDataController
    {
        public IEnumerable<Role> GetAllRoles()
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Query<Role>(
                    DataBaseConstants.GetAllRoles,
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }
    }
}
