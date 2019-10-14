using CashMachine.Data.DataBase;
using CashMachine.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashMachine.Services
{
    public static class CashChecker
    {
        public static int CheckCash(Owner owner)
        {
            using (var context = new CardDbContext())
            {
                var cash = context.Card
                                   .Where(c => c.OwnerId == owner.Id)
                                   .FirstOrDefault();
                return cash.Money;
            }
        }
    }
}
