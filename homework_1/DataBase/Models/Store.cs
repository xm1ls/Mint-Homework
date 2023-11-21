using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    internal class Store
    {
        public int StoreID { get; set; }
        public string StoreName { get; set; }
        public string StoreCity { get; set; }
        public string StoreAddress { get; set; }
        public string StoreEmail { get; set; }
        public string StorePhone { get; set; }
        public string StorePostalCode { get; set; }
        public int StoreManagerID { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder(100);
            sb.Append($"{nameof(StoreID).ToLowerInvariant()}: {StoreID}, ");
            sb.Append($"{nameof(StoreName).ToLowerInvariant()}: {StoreName}, ");
            sb.Append($"{nameof(StoreCity).ToLowerInvariant()}: {StoreCity}, ");
            // Add other properties as needed
            return sb.ToString();
        }
    }

}
