using CashMachine.Models.DataBase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CashMachine.Services
{
    public class Communication
    {
        public static string[] Options =
            {
                "1. Balance.",
                "2. Deposit.",
                "3. Withdraw.",
                "4. Exit."
            };

        public static Owner InsertCard()
        {
            string userCard = "";
            
            while(userCard != "exit")
            {
                Owner owner = null;

                while (owner == null)
                {
                    Console.WriteLine("Please insert card or type 'exit' to finish.");
                    userCard = Console.ReadLine();
                    if(userCard == "exit")
                    {
                        break;
                    }

                    owner = OwnerChecker.CheckOwner(userCard);
                    if (owner == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Your card does not exist.");
                        continue;
                    }
                }
                return owner;
            }

            return null;
        }

        public static void UserPanel(Owner owner)
        {
            int exitCommand = 0;

            Console.Clear();
            Console.WriteLine("You are welcome! What do you want today?\n{0}\n{1}\n{2}\n{3}\n", Options);
            while (exitCommand != 4)
            {
                try
                {
                    int userChoice = Convert.ToInt32(Console.ReadLine());
                    exitCommand = userChoice;
                    Console.Clear();

                    switch (userChoice)
                    {
                        case 1:
                            int userCash = CashChecker.CheckCash(owner);
                            Console.WriteLine("Your cash: {0}", userCash);
                            Console.WriteLine("\n{0}\n{1}\n{2}\n{3}", Options);
                            break;
                        case 2:
                            var resultDeposit = CashDepositer.DepositCash(owner);
                            if (!resultDeposit)
                            {
                                Console.Clear();
                                Console.WriteLine("Invalid data type.\n\n{0}\n{1}\n{2}\n{3}", Options);
                                break;
                            }
                            Console.WriteLine("\n{0}\n{1}\n{2}\n{3}", Options);
                            break;
                        case 3:
                            var resultWithdraw = CashWithdrawer.WithdrawCash(owner);
                            if (!resultWithdraw)
                            {
                                Console.Clear();
                                Console.WriteLine("Invalid data type.\n\n{0}\n{1}\n{2}\n{3}", Options);
                                break;
                            }
                            Console.WriteLine("\n{0}\n{1}\n{2}\n{3}", Options);
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Good bye!");
                            return;
                        default:
                            Console.Clear();
                            Console.WriteLine("Invalid data type.\n\n{0}\n{1}\n{2}\n{3}", Options);
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Invalid data type.\n\n{0}\n{1}\n{2}\n{3}", Options);
                }
            }
        }
    }
}
