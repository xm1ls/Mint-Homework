using DataBase.DataControllers;
using DataBase.Extensions;
using DataBase.Models;
using System.ComponentModel;
using System.Text;

namespace DataBase
{
    internal class Program
    {
        static CategoriesDataController categoriesDataController = new();

        static void Main(string[] args)
        {
            var categories = categoriesDataController.GetAllCategories();
            categories.PrintColleciton();

            var result = categoriesDataController.CreateCategory(new() { CategoryName = "SomeNewCategory4" });
            if (!result)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not success to create new category");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                var data = categoriesDataController.GetAllCategories();
                data.PrintColleciton();
            }
        }

    }
}
