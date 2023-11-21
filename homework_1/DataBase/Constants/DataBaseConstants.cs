using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Constants
{
    internal static class DataBaseConstants
    {
        private const string ConnectionString = @"Data Source=DESKTOP-VFBR1NU\SQLEXPRESS;Initial Catalog=StoreNetworkDB;Persist Security Info=True;User ID=sa;Password=1029";

        public static SqlConnection GetConnection()
            => new(ConnectionString);

        #region Store

        public const string GetAllStores = "sp_Stores_GetAll";
        public const string CreateStore = "sp_Stores_CreateStore";
        public const string UpdateStore = "sp_Stores_UpdateStore";
        public const string DeleteStore = "sp_Stores_DeleteStore";

        #endregion

        #region Roles

        public const string GetAllRoles = "sp_Roles_GetAll";
        public const string CreateRole = "sp_Roles_CreateRole";
        public const string UpdateRole = "sp_Roles_UpdateRole";
        public const string DeleteRole = "sp_Roles_DeleteRole";

        #endregion

        #region Users

        public const string GetAllUsers = "sp_Users_GetAll";
        public const string CreateUser = "sp_Users_CreateUser";
        public const string UpdateUser = "sp_Users_UpdateUser";
        public const string DeleteUser = "sp_Users_DeleteUser";

        #endregion

        #region Categories

        public const string GetAllCategories = "sp_Categories_GetAll";
        public const string CreateCategory = "sp_Categories_CreateCategory";
        public const string UpdateCategory = "sp_Categories_UpdateCategory";
        public const string DeleteCategory = "sp_Categories_DeleteCategory";

        #endregion

        #region Subcategories

        public const string GetAllSubcategories = "sp_Subcategories_GetAll";
        public const string CreateSubcategory = "sp_Subcategories_CreateSubcategory";
        public const string UpdateSubcategory = "sp_Subcategories_UpdateSubcategory";
        public const string DeleteSubcategory = "sp_Subcategories_DeleteSubcategory";

        #endregion

        #region Products

        public const string GetAllProducts = "sp_Products_GetAll";
        public const string CreateProduct = "sp_Products_CreateProduct";
        public const string UpdateProduct = "sp_Products_UpdateProduct";
        public const string DeleteProduct = "sp_Products_DeleteProduct";

        #endregion
    }
}
