using System;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace EpicBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] heroes = { "Harry Potter", "Luke Skywalker", "Superman", "Bilbo Baggins" };
            string[] villians = { "Savisaar", "Markussssss", "Sauron", "Joker", "Darth Vader" };

            string hero = GetCharacter(heroes);
            string villian = GetCharacter(villians);


            int heroHP = GenerateHP();
            int villianHP = GenerateHP();
            Console.WriteLine($"{hero} with {heroHP} HP will fight {villian} " + $"{villianHP} HP");

            while (heroHP > 0 && villianHP > 0)
            {
                Random rnd = new Random();
                heroHP = heroHP - rnd.Next(0, 4);
                villianHP = villianHP - rnd.Next(0, 4);
            }

            if (heroHP == 0)
            {
                Console.WriteLine("Dark Side wins!");
            }
            else
            {
                Console.WriteLine($"{hero} saves the day!");
            }






        }
        public static string GetCharacter(string[] array)
        {
            Random rnd = new Random();
            string randomString = array[rnd.Next(0, array.Length)];
            return randomString;
        }


        public static int GenerateHP()
        {
            Random rnd = new Random();
            int HP = rnd.Next(5, 11);
            return HP;
        
    
      }

    }
}
