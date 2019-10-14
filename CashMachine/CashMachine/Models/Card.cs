using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CashMachine.Models.DataBase
{
    public class Card
    {
        public Guid Id { get; set; }
        [Required]
        public int Money { get; set; }
        [Required]
        public int Pin { get; set; }
        public string Type { get; set; }
        [Required]
        [ForeignKey("Owner")]
        public Guid OwnerId { get; set; } // karta przynależy do jednego użytkownika
        public Owner Owner { get; set; }
    }
}
