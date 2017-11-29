using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.IntefaceDB
{
    interface ICredits
    {
        int Id { get; set; }
        int UserId { get; set; }
        int Amount { get; set; }

    }
}
