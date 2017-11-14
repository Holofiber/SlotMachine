using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Record
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int Bet { get; set; }
        public int Win { get; set; }

        public override string ToString()
        {
            return $"{nameof(ID)}: {ID}, {nameof(UserID)}: {UserID}, {nameof(Bet)}: {Bet}, {nameof(Win)}: {Win}";
        }
    }
}
