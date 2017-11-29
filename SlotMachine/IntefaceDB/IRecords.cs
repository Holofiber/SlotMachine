using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.IntefaceDB
{
    interface IRecords
    {
        int Id { get; set; }
        int UserID { get; set; }
        int Bet { get; set; }
        int Win { get; set; }
    }
}