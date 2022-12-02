using System;

namespace Assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            //character

            Console.WriteLine("Welcome to the Adventure of Assignment 5!");

            Character hero = new Character("Bob", RaceCategory.Human, 100);

            Console.WriteLine("{0} has entered the forest", hero.Name);

            string monster = "goblin";
            int damage = 10;

            Console.WriteLine("A {0} appeared and attacks {1}", monster, hero.Name);

            Console.WriteLine("{0} takes {1} damage", hero.Name, damage);

            hero.TakeDamage(damage);
            Console.WriteLine(hero);

            Console.WriteLine("{0} flees from the enemy", hero.Name);

            string item = "small health potion";
            int restoreAmount = 10;

            Console.WriteLine("{0} find a {1} and drinks it", hero.Name, item);

            Console.WriteLine("{0} restores {1} health", hero.Name, restoreAmount);

            hero.RestoreHealth(restoreAmount);

            Console.WriteLine(hero);

            if (hero.IsAlive)
            {
                Console.WriteLine("Congratulations! {0} survived.", hero.Name);
            }
            else
            {
                Console.WriteLine("{0} has died.", hero.Name);
            }

            //Inventory

            Inventory inventory = new Inventory(10);

            Item sword = new Item("Sword", 1, ItemGroup.Equipment);
            Item bow = new Item("Bow", 1, ItemGroup.Equipment);
            Item healthPotion = new Item("Health Potion", 1, ItemGroup.Consumable);

            inventory.AddItem(sword);
            inventory.AddItem(bow);
            inventory.AddItem(healthPotion);

            Item item1;

            string itemToTake = "mana";

            if (inventory.TakeItem(itemToTake, out item1))
            {
                Console.WriteLine("Take out {0}", item1.Name);
            }
            else
            {
                Console.WriteLine("{0} does not exists", itemToTake);
            }

        }
    }
}
