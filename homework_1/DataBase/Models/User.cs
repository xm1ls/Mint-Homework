using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Models
{
    internal class User
    {
        public int UserID { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserMiddleName { get; set; }
        public int UserBirthYear { get; set; }
        public DateTime UserEmploymentDate { get; set; }
        public string UserStatus { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public int UserRoleID { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder(100);
            sb.Append($"{nameof(UserID).ToLowerInvariant()}: {UserID}, ");
            sb.Append($"{nameof(UserFirstName).ToLowerInvariant()}: {UserFirstName}, ");
            sb.Append($"{nameof(UserLastName).ToLowerInvariant()}: {UserLastName}, ");
            // Add other properties as needed
            return sb.ToString();
        }
    }

}
