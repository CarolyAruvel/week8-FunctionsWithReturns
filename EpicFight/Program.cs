using System;

namespace EpicFight
{
    class Program
    { 
        static void Main(string[] args)
        {
            string hero, villain;
            hero = RandomHero();
            villain = RandomVillain();
            Console.WriteLine($"Random hero: {hero}");
            Console.WriteLine($"Random villain: {villain}");
        }

        private static string RandomHero()
        {
            string[] heroes = { "Batman", "Spongebob", "Spiderman", "Patric", "Lara Croft" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, heroes.Length);

            string randomHero = heroes[randomIndex];
            return randomHero;

        }
        private static string RandomVillain()
        {
        string[] villain = { "Mirjam", "Peppa pig", "Elise" };
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villain.Length);

            string randomVillain = villain[randomIndex];
            return randomVillain;
        }

        
        
            


            
        
    }
}
