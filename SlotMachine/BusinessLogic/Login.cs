using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SlotMachine.DAL;

namespace SlotMachine.BusinessLogic
{
    public class WrongLogin
    {
        public void Login()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginWindow = new LoginWindow();
            var dialogResult = loginWindow.ShowDialog();

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

            

            Account  = storage.GetAccount(login, password);
            if (Account == null)
            {
                Environment.Exit(0);
            }
            else
            {
                Credits = storage.GetCredits(Account.Id);
            }
        }
        public Account Account = new Account();
        public Credits Credits = new Credits();

        public void ShowMessage()
        {
            var message = "Wrong Login name or password!!!\nPlease try again!";
            MessageBox.Show(message);
        }
    }

}