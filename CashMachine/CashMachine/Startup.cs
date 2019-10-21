using CashMachine.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashMachine
{
    public static class Startup
    {
        public static void LaunchCashMachine()
        {
            var owner = Communication.InsertCard();

            if (owner != null)
            {
                Communication.UserPanel(owner);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Good bye!");
            }
        }
    }
}
