using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlotMachine.BusinessLogic;
using SlotMachine.DAL;

namespace SlotMachine
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
           Application.EnableVisualStyles();
           Application.SetCompatibleTextRenderingDefault(false);


            var loginWindow = new LoginWindow();
            DialogResult dialogResult = loginWindow.ShowDialog();


            string login = null;
            string password = null;

            if (dialogResult == DialogResult.OK)
            {
                login = loginWindow.Login;
                password = loginWindow.Password;
            }
            else
            {
                Environment.Exit(0);
            }

            TestDataStorage storage = new TestDataStorage();

            Account account = storage.GetAccount(login, password);

            Credits credit = storage.GetCredits(account.Id);


            Application.Run(new MainForm(account, credit));
        }
    }
}
