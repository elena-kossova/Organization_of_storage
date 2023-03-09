using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization_of_storage
{
    public class Check_User
    {
        public string Login { get; set; }
        public bool IsAdmin { get; }

        public string Status => IsAdmin ? "Admin" : "User";

        public Check_User(string log, bool isAd)
        {
            Login = log.Trim();
            IsAdmin = isAd;
        }
    }
}
