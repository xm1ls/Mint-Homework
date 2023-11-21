using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    internal class Categories
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder(100);
            sb.Append($"{nameof(CategoryID).ToLowerInvariant()}: {CategoryID}, ");
            sb.Append($"{nameof(CategoryName).ToLowerInvariant()}: {CategoryName}");
            return sb.ToString();
        }
    }

}
