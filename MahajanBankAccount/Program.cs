using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MahajanBankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientInfo client = new ClientInfo(55271, "Michelle Wolf", 50177.17d);
            Console.WriteLine();
            Console.WriteLine("Choose the corresponding number from the following options and TYPE it below: \n1. Total Bank Account Balance \n2. Client Information \n3. Deposit Funds \n4. Withdraw Funds \n5. Exit");
            
            //user input for choice - need to have 5 different options
            int userChoice = int.Parse(Console.ReadLine());

                while (userChoice == 1)
                    { client.GetTotalBalance();
                      Console.WriteLine("Would you like to see the balance of a specific account as well?");
                      Console.WriteLine("View account balance for: \na. Checking Account \nb. Savings Account");
                      char userChar = char.Parse(Console.ReadLine());

                            while (userChar == 'a')
                                { Checking checking = new Checking(552711, "Checking", 50177.17d, 20113.50d);
                                  checking.GetAccountInfo();
                                    Console.WriteLine("Would you like to: \n1. Deposit Funds \n2. Withdraw Funds");
                                    int checkUserChoice = int.Parse(Console.ReadLine());

                                        while (checkUserChoice == 1)
                                            {Console.WriteLine("How much would you like to deposit?");
                                             double deposit = double.Parse(Console.ReadLine());
                                             Console.WriteLine("Your new balance is $"+ (deposit + checking.CheckDepositAmount()));
                                             break;
                                            }
                                }

                            while (userChar == 'b')
                                {Savings savings = new Savings(552712, "Savings", 50177.17d, 30063.67);
                                 savings.GetAccountInfo();
                                }
                    }

                while (userChoice == 2)
                    { client.GetClientInfo();
                    }
                while (userChoice == 3)
                    {
                        

                    }

                while (userChoice == 4)
                    {

                    }
                while (userChoice == 5)
                    { Console.WriteLine("Thanks for using the system! Have a great day");
                      //LOOK FOR THE EXIT DEALIO
                    }



        }


    }
}
