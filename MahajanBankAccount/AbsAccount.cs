using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahajanBankAccount
{
    abstract class AbsAccount
    {
        public int accountNumber;
        public double accountBalance;
        public string accountType;
        public double deposit;
        public double withdraw;

        //props
        public double Deposit
        {
            get { return this.deposit; }
            set { this.deposit = value; }
        }

        public int AccountNumber
        {get { return this.accountNumber; }
         set { this.accountNumber = value; }
        }

        public double AccountBalance
        {get { return this.accountBalance; }
         set { this.accountBalance = value; }
        }

        public string AccountType
        {get { return this.accountType; }
         set { this.accountType = value; }
        }

        //constructors
        public AbsAccount()
        {
        }

        public AbsAccount(int accountNumber, string accountType)
        {
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            this.accountBalance = 50177.17d;
        }

        public virtual void GetAccountInfo()
        {
            Console.WriteLine("Account Type: {0} \nYour total account balance is: ${1}", accountType, accountBalance);
        }

        public virtual string DepositMoney()
        {
            return "How much would you like to deposit?";
        }

        public virtual string WithMoney()
        {
            return "How much would you like to withdraw?";
        }

        public virtual string DepositOrWith()
        { return "Would you like to: \n1.Deposit Funds \n2.Withdraw Funds";
        }

        public virtual double FinalBalance()
        {
            return (accountBalance + deposit - withdraw);
        }
    }
}
