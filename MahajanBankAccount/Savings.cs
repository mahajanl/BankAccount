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

        public Savings(int accountNumber, string accountType, double accountBalance)
        {
            this.accountBalance = accountBalance;
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
            return "Would you like to: \n1.Deposit Funds \n2.Withdraw Funds";
        }

    }
}
