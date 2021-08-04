using System;

namespace effiecient
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = 0;
            int i = 0;
            Random rand = new Random();
            while (position != 100)
            {

                ++i;
                int diceRoll = rand.Next(1, 7);
                int snakeLadder = rand.Next(1, 4);
                switch (snakeLadder)
                {
                    case 2:
                        position += diceRoll;
                        Console.WriteLine("the  value is " + position);
                        break;
                    case 3:
                        position -= diceRoll;
                        Console.WriteLine("the value is " + position);
                        if (position < 0)
                        {
                            position = 0;
                        }
                        break;
                    default:
                        position += 0;
                        Console.WriteLine("the value is " + position);
                        break;
                }
                Console.WriteLine("the point of 1 dice is " + position);
            }
            Console.WriteLine("the number of times loop formed " + i);
        }
    }
}
