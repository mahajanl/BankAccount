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
            Checking checking = new Checking(552711, "Checking", 50177.17d, 20113.50d);


            //user input for choice - need to have 5 different options
            int userChoice = int.Parse(Console.ReadLine());

                while (userChoice == 1)
                    { client.GetTotalBalance();
                      Console.WriteLine("Would you like to see the balance of a specific account as well?");
                      Console.WriteLine("View account balance for: \na. Checking Account \nb. Savings Account");
                      char userChar = char.Parse(Console.ReadLine());

                            while (userChar == 'a')
                                { 
                                  checking.GetAccountInfo();
                                  Console.WriteLine(checking.DepositOrWith());
                                  int checkUserChoice = int.Parse(Console.ReadLine());

                                        while (checkUserChoice == 1)
                                            { Console.WriteLine(checking.DepositMoney());
                                             double deposit = double.Parse(Console.ReadLine());
                                             Console.WriteLine("Your new balance is $"+ (deposit + checking.CheckDepositAmount()));
                                             
                                            }

                                        while (checkUserChoice == 2)
                                            { Console.WriteLine(checking.WithMoney());
                                              double withdraw = double.Parse(Console.ReadLine());
                                              Console.WriteLine("Your new balance is $" + (checking.CheckDepositAmount() - withdraw));
                                            }
                                }

                            while (userChar == 'b')
                                {Savings savings = new Savings(552712, "Savings", 50177.17d, 30063.67);
                                 savings.GetAccountInfo();
                                 Console.WriteLine(savings.DepositOrWith());
                                 string saveUserChoice = (Console.ReadLine());

                                        while (saveUserChoice == "1")
                                            {Console.WriteLine(savings.DepositMoney());
                                             double deposit = double.Parse(Console.ReadLine());
                                             Console.WriteLine("Your new balance is $" + (deposit + savings.SaveDepositAmount()));
                                            }

                    while (saveUserChoice == "2")
                    { Console.WriteLine(savings.WithMoney());
                        double withdraw = double.Parse(Console.ReadLine());
                        if (withdraw < savings.SaveAccountBalance)
                        { Console.WriteLine("Your new balance is $" + (savings.SaveDepositAmount() - withdraw));
                        }
                        else if (withdraw > savings.SaveAccountBalance)
                        { Console.WriteLine("Transaction cannot be completed without overdrawing account. Please enter another amount.");
                            break;
                        }
                    }
                                }
                    }

                while (userChoice == 2)
                    { client.GetClientInfo();
                    }
                while (userChoice == 3)
                    {Console.WriteLine("Would you like to deposit into your: \na. Savings \nb.Checking");
                     char depoChoice = char.Parse(Console.ReadLine());
                if (depoChoice == 'a')
                { }
                    

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
