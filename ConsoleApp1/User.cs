using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class User
    {
        public string UserName { get; set; }
        public int UserId { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{nameof(UserName)}: {UserName}, {nameof(UserId)}: {UserId}, {nameof(Password)}: {Password}";
        }
    }

}
