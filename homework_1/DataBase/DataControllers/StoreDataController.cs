using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using DataBase.Constants;
using DataBase.Models;

namespace DataBase.DataControllers
{
    internal class StoreDataController
    {
        public IEnumerable<Store> GetAllStores()
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Query<Store>(
                    DataBaseConstants.GetAllStores,
                    commandType: CommandType.StoredProcedure);
                return rows;
            }
        }

        public bool CreateStore(Store store)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DataBaseConstants.CreateStore,
                    new
                    {
                        store.StoreName,
                        store.StoreCity,
                        store.StoreAddress,
                        store.StoreEmail,
                        store.StorePhone,
                        store.StorePostalCode,
                        store.StoreManagerID
                    },
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }

        public bool UpdateStore(Store store)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DataBaseConstants.UpdateStore,
                    new
                    {
                        store.StoreID,
                        store.StoreName,
                        store.StoreCity,
                        store.StoreAddress,
                        store.StoreEmail,
                        store.StorePhone,
                        store.StorePostalCode,
                        store.StoreManagerID
                    },
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }

        public bool DeleteStore(int storeId)
        {
            using (var connection = DataBaseConstants.GetConnection())
            {
                connection.Open();
                var rows = connection.Execute(
                    DataBaseConstants.DeleteStore,
                    new
                    {
                        StoreID = storeId
                    },
                    commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
        }
    }
}
