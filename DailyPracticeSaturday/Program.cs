using System.Collections.Concurrent;

namespace DailyPracticeSaturday
{
    internal class Program
    {
       

        static void Main(string[] args)
        {

            int monsterHealth = 10;
            int heroHealth = 10;

            int monsterDamage;
            int heroDamage;

            Random monsterAttack = new Random();
            Random heroAttack = new Random();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\tThe final battle is between our hero, who quit his job as a piano teacher\n" +
                "\t\t\t  because he so badly wanted to become a good Software Developer\n\t\t\t    - and the monster, about whom we know very little.\n" +
                "\n\t\t\t\t Let the fight begin! Press Enter to start:\n\n\n");
            Console.ReadLine();
            do

            {

                if (monsterHealth >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("\tThe hero attacks....");

                    Thread.Sleep(heroAttack.Next(1000, 6000));
                    monsterDamage = heroAttack.Next(1, 11);
                    monsterHealth -= monsterDamage;

                    Console.ForegroundColor = ConsoleColor.Red;

                    if (monsterHealth <= 0)
                    {
                        monsterHealth = 0;
                        Console.WriteLine($"\tMonster took {monsterDamage} HP and has been defeated! Rest in pieces.....");

                        Console.ForegroundColor = ConsoleColor.Green;

                        Console.WriteLine("\tHero Wins!");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\tMonster took {monsterDamage} HP damage and has now {monsterHealth} left.\n");
                    }
                }

                if (heroHealth >= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tThe monster attacks....");

                    Thread.Sleep(heroAttack.Next(1000, 6000));
                    heroDamage = monsterAttack.Next(1, 11);
                    heroHealth -= heroDamage;


                    if (heroHealth <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        heroHealth = 0;
                        Console.WriteLine($"\tHero took {heroDamage} HP damage and has been defeated!\n\t\t\tR.I.P ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\tMonster Wins!");
                        Console.ReadLine();
                        break;


                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\tHero took {heroDamage} HP damage and has now {heroHealth} left.\n");

                }
            } while (true);








            //Random random = new();
            //int current = random.Next(1, 11);
            //int counter = 0;

            //do
            //{
            //    current = random.Next(1, 11);
            //    counter++;
            //    if (current >= 8) continue;

            //    Console.WriteLine(current);
            //} while (current != 7);


            //Console.WriteLine("\nNumber of iterations: " + counter);


            ////while (current >= 3)
            ////{
            ////    Console.WriteLine(current);
            ////    current = random.Next(1, 11);

            ////}
            ////Console.WriteLine($"Last number: {current}");














            //// The Fizz Buzz Challenge
            //for (int i = 1; i <= 100; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine($"{i} - FizzBuzz");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine($"{i} - Fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine($"{i} - Buzz");
            //    }
            //    else { Console.WriteLine(i); }
            //}

        }
    }
}
