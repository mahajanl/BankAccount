using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahajanBankAccount
{
    class ClientInfo
    {
        public int genAccountNum;
        public string name;
        public double totalBalance = 50177.17;
        public double checkBalance;
        public double savBalance;
        public double deposit;
        public double withdraw;

        //properties; need to be available to all; BUT changed the 1st three to static and I don't need these for the static guys
        public int GenAccountNum
        {   get { return this.genAccountNum; }
            set { this.genAccountNum = value; }
        }

        public string Name
        {   get { return this.name; }
            set { this.name = value; }
        }

        public double TotalBalance
        {   get { return this.totalBalance; }
            set { this.totalBalance = value; }
        }

        //NOT SURE YOU NEED A SET BECAUSE THEY CAN'T ENTER THEIR OWN BALANCE
        public double CheckBalance
        { get { return this.checkBalance; }
          set { this.checkBalance = value; }
        }

        public double SavBalance
        { get { return this.savBalance; }
          set { this.savBalance = value; }
        }

        //CONSTR
        public ClientInfo()
        {

        }

        public ClientInfo(int genAccountNum, string name)
        {   this.genAccountNum = genAccountNum;
            this.name = name;
            this.totalBalance = 50177.17d;
        }

        //METHODS
        public string GetClientInfo()
        {   return "Client Name: " + name;
        }

        public string GetTotalBalance()
        {
            return "Total Balance: $" +totalBalance;
        }

        public string GetAccountNum()
        { return "Account Number: " + genAccountNum;
        }

        public void PrintInfo()
        {
            Console.WriteLine("WELCOME, {0}! Your account balance is ${1}.", name, totalBalance);
        }

        

    }
}
