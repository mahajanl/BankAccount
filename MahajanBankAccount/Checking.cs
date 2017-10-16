using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahajanBankAccount
{
    class Checking : AbsAccount
    {
        public double chAccountBalance;
        
        //prop
        public double ChAccountBalance
        {get { return this.chAccountBalance; }
         set { this.chAccountBalance = value; }
        }

        //const
        public Checking()
        {
        }

        public Checking(int accountNumber, string accountType)
        {
            this.accountBalance = 50177.17d;
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            this.chAccountBalance = 20113.50d;
        }

        public override void GetAccountInfo()
        {
            Console.WriteLine("Your checking account balance is: $" + (chAccountBalance + deposit - withdraw));
        }

        public override string DepositOrWith()
        {
            return base.DepositOrWith();
            
        }

        public double CheckBalance()
        {return chAccountBalance;
        }

        public override string DepositMoney()
        {return "How much would you like to deposit?";
        }

        public override string WithMoney()
        {return "How much would you like to withdraw?";
        }







    }
}
