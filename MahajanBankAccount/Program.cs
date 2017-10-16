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
            ClientInfo client = new ClientInfo(55271, "Don Quixote");
            Checking checking = new Checking(552711, "Checking");
            Savings savings = new Savings(552712, "Savings");
            
            client.PrintInfo();
            Console.WriteLine("Do you have business to conduct today? Type YES to proceed.");
            string startBanking = Console.ReadLine().Trim().ToLower();

            //start of mondo loopage
            while (startBanking == "yes")
            {
                Console.WriteLine("This menu will run until the EXIT option is chosen.");
                Console.WriteLine("Please select an action by typing the corresponding number from the following options below: \n1. Account Balance \n2. Client Information \n3. Deposit Funds \n4. Withdraw Funds \n5. Exit");
                int userChoice = int.Parse(Console.ReadLine());

              while (userChoice == 1)
              {Console.WriteLine("View account balance for: \na. Checking Account \nb. Savings Account");
               char userChar = char.Parse(Console.ReadLine());
 //checking
                 if (userChar == 'a')
                 {
                    checking.GetAccountInfo();
                    Console.WriteLine(checking.DepositOrWith());
                    int checkUserChoice = int.Parse(Console.ReadLine());
     //depo in check
                    if (checkUserChoice == 1)
                    {
                        Console.WriteLine(checking.DepositMoney());
                        double deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine("Your new balance is $" + (deposit + checking.CheckBalance()));
                    }
     //with in check
                    else if (checkUserChoice == 2)
                    {
                        Console.WriteLine(checking.WithMoney());
                        double withdraw = double.Parse(Console.ReadLine());
                        Console.WriteLine("Your new balance is $" + (checking.CheckBalance() - withdraw));
                    }
                        break;
                }
 //savings
                else if (userChar == 'b')
                {
                    savings.GetAccountInfo();
                    Console.WriteLine(savings.DepositOrWith());
                    string saveUserChoice = (Console.ReadLine());
                        //depo savings
                        if (saveUserChoice == "1")
                        {
                            Console.WriteLine(savings.DepositMoney());
                            double deposit = double.Parse(Console.ReadLine());
                            Console.WriteLine("Your new balance is $" + (deposit + savings.SaveDepositAmount()));
                            break;
                        }
                        //with savings; caveat min balance
                        else 
                           { while (saveUserChoice == "2")
                            {
                                Console.WriteLine(savings.WithMoney());
                                double withdraw = double.Parse(Console.ReadLine());

                                if (withdraw < savings.SaveAccountBalance)
                                { Console.WriteLine("Your new balance is $" + (savings.SaveDepositAmount() - withdraw));
                                }

                                else if (withdraw > savings.SaveAccountBalance)
                                { Console.WriteLine("Transaction cannot be completed without overdrawing account. Please enter another amount.");
                                }
                                break;
                            }
                        }
                }
            }
  // info                   
                while (userChoice == 2)
                    {   Console.WriteLine(client.GetClientInfo());
                        Console.WriteLine(client.GetTotalBalance());
                        Console.WriteLine(client.GetAccountNum());
                        Console.WriteLine();
                        break;
                    }
                
  //deposit from menu
                  while (userChoice == 3)
                    {
                        Console.WriteLine("Would you like to deposit into your: \na. Savings \nb.Checking");
                        char depoChoice = char.Parse(Console.ReadLine());
                        if (depoChoice == 'a')
                        {   Console.WriteLine(savings.DepositMoney());
                            double savDepo = double.Parse(Console.ReadLine());
                            Console.WriteLine("Your new balance is $ " + (savDepo + savings.SaveDepositAmount()));
                        }
                        else if (depoChoice == 'b')
                        {   Console.WriteLine(checking.CheckBalance());
                            double checkDepo = double.Parse(Console.ReadLine());
                            Console.WriteLine("Your new balance is $ " + (checkDepo + checking.CheckBalance()));
                        }
                    }

                    while (userChoice == 4)
                    {
                        Console.WriteLine("Would you like to withdraw from your: \na. Savings \nb.Checking");
                        char withChoice = char.Parse(Console.ReadLine());
//withdraw menu
                        if (withChoice == 'a')
                        {
                            Console.WriteLine("Your balance is $" + savings.SaveDepositAmount());
                            Console.WriteLine(savings.WithMoney());
                            double saveWith = double.Parse(Console.ReadLine());
    //withdraw caveat                    
                                if (saveWith < savings.SaveAccountBalance)
                                {Console.WriteLine("Your new balance is $" + (savings.SaveDepositAmount() - saveWith));
                                break;
                                }
                                else if (saveWith > savings.SaveAccountBalance)
                                {Console.WriteLine("Transaction cannot be completed without overdrawing account. Please enter another amount.");
                                 break;
                                }
                        }
//PROBLEM
                        else if (withChoice == 'b')
                        {
                            Console.WriteLine("Your Checking balance is $" +checking.CheckBalance());
                            Console.WriteLine(checking.WithMoney());
                            double checkWith = double.Parse(Console.ReadLine());
                            Console.WriteLine("Your new balance is $ " + (checking.CheckBalance() - checkWith));
                            break;
                        }
                    }

                    while (userChoice == 5)
                    {
                        Console.WriteLine("Thanks for using the system! Have a great day");
                        Environment.Exit(0);
                    }

                while (userChoice > 5)
                {
                    Console.WriteLine("That is not a valid selection. Try this again.");
                    break;
                }

            }
        }
      }
    }

