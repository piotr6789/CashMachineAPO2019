using CashMachine.Data.DataBase;
using CashMachine.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashMachine.Services
{
    public static class CashDepositer
    {
        public static bool DepositCash(Owner owner)
        {
            int cashToDeposit;
            Console.WriteLine("How much money do you want to deposit?");
            try
            {
                cashToDeposit = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                return false;
            }

            using (var context = new CardDbContext())
            {
                var card = context.Card
                                   .Where(c => c.OwnerId == owner.Id)
                                   .FirstOrDefault();
                card.Money = card.Money + cashToDeposit;
                context.SaveChanges();

                return true;
            }
        }
    }
}
