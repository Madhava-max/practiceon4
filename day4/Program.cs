using System;

namespace day4
{
    class Program
    {
        static void Main(string[] args)
        {
            int point = 0;
            Random rand = new Random();
            int a = rand.Next(1, 7);
            switch (a)
            {
                case 1:
                    Console.WriteLine("the dice value is " + a);
                    break;
                case 2:
                    Console.WriteLine("the dice value is " + a);
                    break;
                case 3:
                    Console.WriteLine("the dice value is " + a);
                    break;
                case 4:
                    Console.WriteLine("the dice value is " + a);
                    break;
                case 5:
                    Console.WriteLine("the dice value is " + a);
                    break;
                case 6:
                    Console.WriteLine("the dice value is " + a);
                    break;
                default:
                    Console.WriteLine("give the value between 1 and 6");
                    break;
            }
    }
}
