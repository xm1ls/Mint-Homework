using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    internal class Role
    {
        public int RoleID { get; set; }
        public string RoleName { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder(100);
            sb.Append($"{nameof(RoleID).ToLowerInvariant()}: {RoleID}, ");
            sb.Append($"{nameof(RoleName).ToLowerInvariant()}: {RoleName}");
            return sb.ToString();
        }
    }

}
