using System;

namespace day4
{
    class Program
    {
        static void Main(string[] args)
        {
            int point = 0;
            Random rand = new Random();
            while (point <= 100)
            {
                int a = rand.Next(1, 7);
                switch (a)
                {
                    case 1:
                        Console.WriteLine("the dice value is " + a);
                        int b = rand.Next(1, 4);
                        switch (b)
                        {
                            case 2:
                                point += a;
                                Console.WriteLine("the  value is " + point);
                                break;
                            case 3:
                                point -= a;
                                Console.WriteLine("the value is " + point);
                                if (point < 0)
                                {
                                    point = 0;
                                }
                                break;
                            default:
                                point += 0;
                                Console.WriteLine("the value is " + point);
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("the value is " + a);
                        int c = rand.Next(1, 4);
                        switch (c)
                        {
                            case 2:
                                point += a;
                                Console.WriteLine("the  value is " + point);
                                break;
                            case 3:
                                point -= a;
                                Console.WriteLine("the  value is " + point);
                                if (point < 0)
                                {
                                    point = 0;
                                }
                                break;
                            default:
                                point += 0;
                                Console.WriteLine("the value is " + point);
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("the dice value is " + a);
                        int d = rand.Next(1, 4);
                        switch (d)
                        {
                            case 2:
                                point += a;
                                Console.WriteLine("the value is " + point);
                                break;
                            case 3:
                                point -= a;
                                Console.WriteLine("the value is " + point);
                                if (point < 0)
                                {
                                    point = 0;
                                }
                                break;
                            default:
                                point += 0;
                                Console.WriteLine("the value is " + point);
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine("the value is " + a);
                        int e = rand.Next(1, 4);
                        switch (e)
                        {
                            case 2:
                                point += a;
                                Console.WriteLine("the value is " + point);
                                break;
                            case 3:
                                point -= a;
                                Console.WriteLine("the value is " + point);
                                if (point < 0)
                                {
                                    point = 0;
                                }
                                break;
                            default:
                                point += 0;
                                Console.WriteLine("the value is " + point);
                                break;
                        }
                        break;
                    case 5:
                        Console.WriteLine("the dice value is " + a);
                        int f = rand.Next(1, 4);
                        switch (f)
                        {
                            case 2:
                                point += a;
                                Console.WriteLine("the value is " + point);
                                break;
                            case 3:
                                point -= a;
                                Console.WriteLine("the value is " + point);
                                if (point < 0)
                                {
                                    point = 0;
                                }
                                break;
                            default:
                                point += 0;
                                Console.WriteLine("the value is " + point);
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine("the dice value is " + a);
                        int g = rand.Next(1, 4);
                        switch (g)
                        {
                            case 2:
                                point += a;
                                Console.WriteLine("the value is " + point);
                                break;
                            case 3:
                                point -= a;
                                Console.WriteLine("the value is " + point);
                                if (point < 0)
                                {
                                    point = 0;
                                }
                                break;
                            default:
                                point += 0;
                                Console.WriteLine("the value is " + point);
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("give the value between 1 and 6");
                        break;
                }
                Console.WriteLine("the point of 1 dice is " + point);
            }
        }
    }
}
