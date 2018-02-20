using System;
using System.Linq;
using System.Windows.Forms;
using SlotMachine.BusinessLogic;
namespace SlotMachine
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            
            WrongLogin wrongLogin = new WrongLogin();

            wrongLogin.Login();

            Account account =  wrongLogin.Account;

            Credits credit = wrongLogin.Credits;

            Application.Run(new MainForm(account, credit));
        }

        

    }
}
