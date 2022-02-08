using System;
using System.Collections.Generic;

namespace PetStoreProject {
    class Program {
        static void Main(string[] args) {

            Parrot parrot = new Parrot() {
                Inventory = 17,
                Sound = "Squawk",
                Price = 3000,
                Longevity = 60
            };
            Hedgehog hedgehog = new Hedgehog() {
                Inventory = 3,
                Sound = "Grunt",
                Price = 200,
                CuteLevel = "Ultimate"
            };
            Hampster hampster = new Hampster() {
                Inventory = 200,
                Sound = "Squeak",
                Price = 200,
                Color = "Brown and Tan"
            };

            List<IPetAnimal> animals = new List<IPetAnimal>();   //there is no class that the animals have in common so we add and Interface

            animals.Add(hampster);
            animals.Add(hedgehog);
            animals.Add(parrot);

            decimal total = 0;
            foreach(IPetAnimal a in animals) {
                decimal value = a.Price * a.Inventory;
                total += value;
                Console.WriteLine($"All {a.GetType().Name}s will net {value:c}");
            }
            Console.WriteLine($"Total value is {total:c}");
        }
    }
}
