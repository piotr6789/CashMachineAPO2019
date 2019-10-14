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

        public static void Start()
        {
            string userCard;
            while (true)
            {
                Console.WriteLine("Please insert card or type 'exit' to finish.");

                userCard = Console.ReadLine();
                if (userCard == "exit")
                {
                    Console.WriteLine("Good bye!");
                    return;
                }

                var owner = OwnerChecker.CheckOwner(userCard);
                if(owner != null)
                {
                    UserPanel(owner);
                }
                else
                {
                    Console.WriteLine("Your card does not exist.");
                }
            }
        }

        public static void UserPanel(Owner owner)
        {
            int exitCommand = 0;

            Console.WriteLine("You are welcome! What do you want today?\n{0}\n{1}\n{2}\n{3}", Options);
            while (exitCommand != 4)
            {
                try
                {
                    int userChoice = Convert.ToInt32(Console.ReadLine());
                    exitCommand = userChoice;
                    if (userChoice == 4)
                    {
                        Console.WriteLine("Good bye!");
                        return;
                    }
                    if (userChoice == 1)
                    {
                        int userCash = CashChecker.CheckCash(owner);
                        Console.WriteLine("Your cash: {0}", userCash);
                    }
                    if (userChoice == 2)
                    {
                        CashDepositer.DepositCash(owner);
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid command, try again.");
                }
            }
        }
    }
}
