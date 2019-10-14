using CashMachine.Data.DataBase;
using CashMachine.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashMachine.Services
{
    public static class CashWithdrawer
    {
        public static bool WithdrawCash(Owner owner)
        {
            int cashToWithdraw;
            Console.WriteLine("How much money do you want to withdraw??");
            try
            {
                cashToWithdraw = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid data type.");
                return false;
            }

            using (var context = new CardDbContext())
            {
                var card = context.Card
                                   .Where(c => c.OwnerId == owner.Id)
                                   .FirstOrDefault();
                card.Money = card.Money - cashToWithdraw;
                context.SaveChanges();

                return true;
            }
        }
    }
}
