using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    internal class Subcategory
    {
        public int SubcategoryID { get; set; }
        public string SubcategoryName { get; set; }
        public int SubcategoryCategoryID { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder(100);
            sb.Append($"{nameof(SubcategoryID).ToLowerInvariant()}: {SubcategoryID}, ");
            sb.Append($"{nameof(SubcategoryName).ToLowerInvariant()}: {SubcategoryName}, ");
            sb.Append($"{nameof(SubcategoryCategoryID).ToLowerInvariant()}: {SubcategoryCategoryID}");
            return sb.ToString();
        }
    }

}
