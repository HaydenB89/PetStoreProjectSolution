using System;

namespace PetStoreProject {
    class Program {
        static void Main(string[] args) {

            Parrot parrot = new Parrot() {
                Inventory = 17,
                Sound = "Squawk",
                Price = 3000,
                Longevity = 60
            };
        }
    }
}
