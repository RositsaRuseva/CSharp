using System;
using System.Collections.Generic;
using System.Text;

namespace Stealer
{
    public class Hacker
    {
        public string username = "securityGod82";
        public string password = "mySuperSecretPassword";

        public string Password
        {
            get => this.password;
            set => this.password = value;
        }

        private int Id { get; set; }

        public double BankAccountBalance { get; private set; }

        public void DownloadAllBankAccountsInTheWorld()
        {

        }
    }
}
