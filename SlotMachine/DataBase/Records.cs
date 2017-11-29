using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlotMachine.IntefaceDB;

namespace SlotMachine.DataBase
{
    class Records : IRecords
    {
        public int Id { get; set; }
        public int UserID { get; set; }
        public int Bet { get; set; }
        public int Win { get; set; }
    }
}
