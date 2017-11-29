using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.IntefaceDB
{
    interface IUsers
    {
        int UserId { get; set; }
        string UserName { get; set; }
        string Password { get; set; }
    }
}
