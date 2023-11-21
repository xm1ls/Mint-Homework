using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    internal class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductBarcode { get; set; }
        public decimal ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public int ProductCategoryID { get; set; }
        public int? ProductSubcategoryID { get; set; }
        public string ProductTaxGroup { get; set; }
        public bool Product18Plus { get; set; }
        public bool ProductExciseRequired { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder(100);
            sb.Append($"{nameof(ProductID).ToLowerInvariant()}: {ProductID}, ");
            sb.Append($"{nameof(ProductName).ToLowerInvariant()}: {ProductName}, ");
            sb.Append($"{nameof(ProductBarcode).ToLowerInvariant()}: {ProductBarcode}, ");
            // Add other properties as needed
            return sb.ToString();
        }
    }

}
