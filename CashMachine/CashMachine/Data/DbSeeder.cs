using CashMachine.Models.DataBase;
using System;
using System.Collections.Generic;
using System.Text;

namespace CashMachine.Data
{
    public class DbSeeder
    {
        public static List<Card> GenerateCards()
        {
            return new List<Card>() {
                new Card() {
                    Id = new Guid("139f252b-b17b-43e3-af1b-f65a0a76e4db"),
                    Money = 100,
                    Pin = 2345,
                    Type = "Credid card",
                    OwnerId = new Guid("3686f45d-5e74-4666-ae76-6cf898d36f90")
                },
                new Card() {
                    Id = new Guid("73cd64ae-d13c-4be1-b4a0-4f055abd76f0"),
                    Money = 200,
                    Pin = 3456,
                    Type = "Debit card",
                    OwnerId = new Guid("98d50544-b91e-4491-9bf9-a4d601e5f873")
                },
                new Card() {
                    Id = new Guid("b50cbd75-9df7-4c3c-8296-68d12832b65f"),
                    Money = 300,
                    Pin = 4567,
                    Type = "Credid card",
                    OwnerId = new Guid("9710bb72-956f-4aca-ad4e-9fa133e385d4")
                },
                new Card() {
                    Id = new Guid("c66d5c50-1d97-469b-82c8-15e11ee0faf2"),
                    Money = 400,
                    Pin = 5678,
                    Type = "Payment card",
                    OwnerId = new Guid("8f18e657-4611-4ce1-9854-279fa327144c")
                }
            };
        }
        public static List<Owner> GenerateOwners()
        {
            return new List<Owner>() {
                new Owner() {
                    Id = new Guid("3686f45d-5e74-4666-ae76-6cf898d36f90"),
                    Name = "Piotr",
                    LastName = "Kowalski",
                    IsAbleToTransfer = true,
                },
                new Owner() {
                    Id = new Guid("98d50544-b91e-4491-9bf9-a4d601e5f873"),
                    Name = "Maciej",
                    LastName = "Nowak",
                    IsAbleToTransfer = true,
                },
                new Owner() {
                    Id = new Guid("9710bb72-956f-4aca-ad4e-9fa133e385d4"),
                    Name = "Wojciech",
                    LastName = "Janicki",
                    IsAbleToTransfer = true,
                },
                new Owner() {
                    Id = new Guid("8f18e657-4611-4ce1-9854-279fa327144c"),
                    Name = "Adam",
                    LastName = "Olejniczak",
                    IsAbleToTransfer = true,
                },
            };
        }
    }
}
