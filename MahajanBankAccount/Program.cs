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
            ClientInfo client = new ClientInfo(55271, "Michelle Wolf");
            
            client.PrintInfo();
            Console.WriteLine();
            Console.WriteLine("Choose the corresponding number from the following options and TYPE it below: \n1. Total Bank Account Balance \n2. Client Information \n3. Deposit Funds \n4. Withdraw Funds \n5. Exit");
            Checking checking = new Checking(552711, "Checking", 50177.17d);
            Savings savings = new Savings(552712, "Savings", 50177.17d);

            //user input for choice - need to have 5 different options
            int userChoice = int.Parse(Console.ReadLine());

                while (userChoice == 1)
                    { client.GetTotalBalance();
                      
                      Console.WriteLine("View account balance for: \na. Checking Account \nb. Savings Account");
                      char userChar = char.Parse(Console.ReadLine());
                //checking
                            if (userChar == 'a')
                                { checking.GetAccountInfo();
                                  Console.WriteLine(checking.DepositOrWith());
                                  int checkUserChoice = int.Parse(Console.ReadLine());
                    //depo in check
                                        if (checkUserChoice == 1)
                                            { Console.WriteLine(checking.DepositMoney());
                                             double deposit = double.Parse(Console.ReadLine());
                                             Console.WriteLine("Your new balance is $"+ (deposit + checking.CheckBalance()));
                                            }
                    //with in check
                                        else if (checkUserChoice == 2)
                                            { Console.WriteLine(checking.WithMoney());
                                              double withdraw = double.Parse(Console.ReadLine());
                                              Console.WriteLine("Your new balance is $" + (checking.CheckBalance() - withdraw));
                                            }
                                }
                
                     //savings
                            else if (userChar == 'b')
                                {
                                 savings.GetAccountInfo();
                                 Console.WriteLine(savings.DepositOrWith());
                                 string saveUserChoice = (Console.ReadLine());
                    //depo savings
                                        while (saveUserChoice == "1")
                                            {Console.WriteLine(savings.DepositMoney());
                                             double deposit = double.Parse(Console.ReadLine());
                                             Console.WriteLine("Your new balance is $" + (deposit + savings.SaveDepositAmount()));
                                            }
            //with savings; caveat min balance
                                        while (saveUserChoice == "2")
                                        { Console.WriteLine(savings.WithMoney());
                                            double withdraw = double.Parse(Console.ReadLine());

                                                if (withdraw < savings.SaveAccountBalance)
                                                { Console.WriteLine("Your new balance is $" + (savings.SaveDepositAmount() - withdraw));
                                                }
                                                else if (withdraw > savings.SaveAccountBalance)
                                                { Console.WriteLine("Transaction cannot be completed without overdrawing account. Please enter another amount.");
                                                }
                                                else
                                                { Console.WriteLine("That's not a valid choice. Try again.");
                                                }
                                }
                    }

                while (userChoice == 2)
                    { client.GetClientInfo();
                    }
           //deposit from menu
                while (userChoice == 3)
                    {Console.WriteLine("Would you like to deposit into your: \na. Savings \nb.Checking");
                     char depoChoice = char.Parse(Console.ReadLine());
                             if (depoChoice == 'a')
                                 { Console.WriteLine(savings.DepositMoney());
                                   double savDepo = double.Parse(Console.ReadLine());
                                   Console.WriteLine("Your new balance is $ " + (savDepo + savings.SaveDepositAmount()));
                                 }
                             else if (depoChoice == 'b')
                                { Console.WriteLine(checking.CheckBalance());
                                  double checkDepo = double.Parse(Console.ReadLine());
                                  Console.WriteLine("Your new balance is $ " + (checkDepo + checking.CheckBalance()));
                                }

                    }

                while (userChoice == 4)
                    {Console.WriteLine("Would you like to withdraw from your: \na. Savings \nb.Checking");
                        char withChoice = char.Parse(Console.ReadLine());
                        if (withChoice == 'a')
                        {
                            Console.WriteLine(savings.DepositMoney());
                            double saveWith = double.Parse(Console.ReadLine());
                            Console.WriteLine("Your new balance is $ " + (savings.SaveDepositAmount()- saveWith ));
                        }
                        else if (withChoice == 'b')
                        {
                            Console.WriteLine(checking.CheckBalance());
                            double checkWith = double.Parse(Console.ReadLine());
                            Console.WriteLine("Your new balance is $ " + (checking.CheckBalance()-checkWith));
                        }

                    }
                while (userChoice == 5)
                    { Console.WriteLine("Thanks for using the system! Have a great day");
                      //LOOK FOR THE EXIT DEALIO
                    }

}

        }

    
    }
}
