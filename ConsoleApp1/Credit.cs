using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Credit
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int Amount { get; set; }

        public override string ToString()
        {
            return $"{nameof(ID)}: {ID}, {nameof(UserID)}: {UserID}, {nameof(Amount)}: {Amount}";
        }
    }
}
