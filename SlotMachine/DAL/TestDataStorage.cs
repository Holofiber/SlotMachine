using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlotMachine.BusinessLogic;

namespace SlotMachine.DAL
{
    class TestDataStorage
    {
        List<Account> accounts = new List<Account>();
        List<Record> recordses = new List<Record>();
        List<Credits> creditses = new List<Credits>();

        public TestDataStorage()
        {
            accounts.Add(new Account(){Id = 1, UserName = "Vasia", Password = "123"});
            accounts.Add(new Account(){Id = 2, UserName = "Petya", Password = "321"});

            recordses.Add(new Record(){Id=1, Bet=100, UserId = 1, Win = 50});
            recordses.Add(new Record() { Id = 2, Bet = 300, UserId = 2, Win = 500 });
            recordses.Add(new Record() { Id = 3, Bet = 400, UserId = 1, Win = 0 });

            creditses.Add(new Credits(){Id =1, UserId = 1, Amount = 5500});
            creditses.Add(new Credits(){Id = 2, UserId = 2, Amount = 3000});
        }



        public Account GetAccount(string userName, string password)
        {
            Account account = accounts.FirstOrDefault(t => t.UserName == userName && t.Password == password);

            return account;
        }

        public List<Record> GetRecords(int userId)
        {
            List<Record> records = recordses.Where(t => t.UserId == userId).ToList();
            return records;
        }

        public void SaveRecords(Record record)
        {
            
        }

        public Credits GetCredits(int userId)
        {
            Credits credit = creditses.FirstOrDefault(t => t.UserId == userId);
            return credit;
        }

    }
}
