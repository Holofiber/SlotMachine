using SlotMachine.IntefaceDB;

namespace SlotMachine.DataBase
{
    class Users : IUsers
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
