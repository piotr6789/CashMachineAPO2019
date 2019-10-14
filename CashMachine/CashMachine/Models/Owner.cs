using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CashMachine.Models.DataBase
{
    public class Owner
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public bool IsAbleToTransfer { get; set; } // Sprawdza czy użytkownik może dokonywać przelewu w bankomacie
        public ICollection<Card> Cards { get; set; } // użytkownik może mieć wiele kart
    }
}
