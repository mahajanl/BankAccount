using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahajanBankAccount
{
    class Savings : AbsAccount
    {
        private double saveAccountBalance;

        //prop
        public double SaveAccountBalance
        {
            get { return this.saveAccountBalance; }
            set { this.saveAccountBalance = value; }
        }

        //const
        public Savings()
        {
        }

        public Savings(int accountNumber, string accountType)
        {
            this.accountBalance = 50177.17d;
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            this.saveAccountBalance = 30063.67d;
        }

        public override void GetAccountInfo()
        {
            base.GetAccountInfo();
            Console.WriteLine("Your checking account balance is: $" + saveAccountBalance);
        }

        public double SaveDepositAmount()
        {return saveAccountBalance + deposit;
        }

        public override string DepositOrWith()
        {
            return base.DepositOrWith();
        }

        public override string WithMoney()
        {
            return "How much would you like to withdraw?";
        }

    }
}
