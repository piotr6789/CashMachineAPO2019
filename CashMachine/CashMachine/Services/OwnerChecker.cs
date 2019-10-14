using CashMachine.Data.DataBase;
using CashMachine.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashMachine.Services
{
    public static class OwnerChecker
    {
        public static Owner CheckOwner(string ownerId)
        {
            try
            {
                Guid ownerGuidId = new Guid(ownerId);

                using (var context = new CardDbContext())
                {
                    var owner = context.Owner
                                       .Where(o => o.Id == ownerGuidId)
                                       .FirstOrDefault();
                    return owner;
                }
            }
            catch
            {
                return null;
            }
            
        }
    }
}
