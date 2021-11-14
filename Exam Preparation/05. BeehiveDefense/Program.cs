using System;

namespace _05._BeehiveDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            int numBees = int.Parse(Console.ReadLine());
            int health = int.Parse(Console.ReadLine());
            int attack = int.Parse(Console.ReadLine());
            int beesHealth = 0;
            int bearHealth = 0;

            while (numBees >= 100)
            {
               
                for (int i = 1; i <= attack; i++)
                {
                     if (numBees < 0)
                    {
                        Console.WriteLine($"The bear stole the honey! Bees left 0.");
                        return;
                    }
                    else if (numBees <100)
                    {
                        Console.WriteLine($"The bear stole the honey! Bees left {Math.Abs(numBees)}.");
                        return;
                    }
                    else if (health <= 0)
                    {
                        Console.WriteLine($"Beehive won! Bees left {numBees}.");
                        return;
                    }
                    numBees = numBees - attack;
                    health = health - numBees * 5;

                }
                
            }
            
        }
    }
}
