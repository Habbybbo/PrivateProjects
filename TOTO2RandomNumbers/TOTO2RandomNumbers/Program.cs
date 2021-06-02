using System;
using System.Linq;
using System.Collections.Generic;

namespace TOTO2RandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Random rnd = new Random();

            List<int> randomNumbers = new List<int>();

            Console.WriteLine("Generating 6 random numbers, using my random shit:");

            for (int i = 1; i <= 49; i++)
            {
                int randomInt = rnd.Next(1, 49);

                if (randomNumbers.Contains(randomInt))
                {
                    continue;
                }
                else
                {
                    randomNumbers.Add(randomInt);
                }
                
            }

            for (int i = 1; i <= 6; i++)
            {
                int currentNum = randomNumbers[i];
                Console.WriteLine(currentNum);
            }

            Console.WriteLine("Generating 6 random numbers, using only random:");

            for (int i = 1; i <= 1; i++)
            {
                RandomNumberLoop(rnd);
                for (int j = 0; j < 1; j++)
                {
                    RandomNumberLoop(rnd);
                    for (int k = 0; k < 1; k++)
                    {
                        RandomNumberLoop(rnd);
                        for (int y = 0; y < 1; y++)
                        {
                            RandomNumberLoop(rnd);
                            for (int g = 0; g < 1; g++)
                            {
                                RandomNumberLoop(rnd);
                                for (int e = 0; e < 1; e++)
                                {
                                    RandomNumberLoop(rnd);
                                }
                            }
                        }
                    }
                }
                
            }

            Console.ReadLine();


        }

        private static void RandomNumberLoop(Random rnd)
        {
            for (int j = 1; j <= 1; j++)
            {
                RandomNumber(rnd);
            }
        }

        private static void RandomNumber(Random rnd)
        {
            
            for (uint ctr = 1; ctr <= 1; ctr++)
                Console.WriteLine($"{rnd.Next(1, 49)}");
        }
    }
}
