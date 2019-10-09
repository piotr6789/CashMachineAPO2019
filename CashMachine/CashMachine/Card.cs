using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase
{
    public class Card
    {
        public Guid Id { get; set; }
        [Required]
        public int Money { get; set; }
        [Required]
        public int Pin { get; set; }
        [Required]
        [ForeignKey("Owner")]
        public Guid OwnerId { get; set; } // karta przynależy do jednego użytkownika
        public Owner Owner { get; set; }
    }
}
