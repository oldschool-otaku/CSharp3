using System;

namespace CSharp3
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Выберите пример:");
            // ReSharper disable once SuggestVarOrType_BuiltInTypes
            int choice = Convert.ToInt32(Console.ReadLine());
            int a, b, c, d, x, y;
            
            switch (choice)
            {
                case 1:
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    c = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine((b + Math.Sqrt(Math.Pow(a, 2)+4 * a * c))
                        /(2 * a)-Math.Pow(a, 3) * c + Math.Pow(b, -2));
                    break;
                
                
                case 2:
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());
                    c = Convert.ToInt32(Console.ReadLine());
                    d = Convert.ToInt32(Console.ReadLine());
                    
                    Console.WriteLine(a / c * (b / d) - (a * b - c) / (c * d));
                    break;
                
                
                case 3:
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Math.Tan(Math.Sin(x) + Math.Cos(y)) / Math.Cos(x) - Math.Sin(y) * x * y);
                    break;
                
                
                case 4:
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(((x + y) / (y + 1)) - ((x * y + 12) / (34 + x)));
                    break;
                
                
                case 5:
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine((3 - Math.Pow(Math.E, y - 1)) /
                                      (1 + Math.Pow(x, 2) * Math.Abs(y - Math.Tan(x))));
                    break;
                
                
                case 6:
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(x - (Math.Pow(x, 3) / 3) +
                                      (Math.Pow(x, 5)));
                    break;
                
                
                case 7:
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Math.Log(Math.Abs(y - Math.Sqrt(x) * x - 
                                                        (x - y / (x + (Math.Pow(x, 2) / 4))))));
                    break;
                
                
                case 8:
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine((Math.Pow(1 - Math.Tan(x), 1 / Math.Tan(x) + Math.Cos(x - y))));
                    break;
                
                
                case 9:
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine((Math.Log(Math.Abs(Math.Cos(x)))) 
                                      / (Math.Log(1 + Math.Pow(x, 2))));
                    break;
                
                
                case 10:
                    x = Convert.ToInt32(Console.ReadLine());
                    y = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine(Math.Pow((x + 1) / (x - 1), x) 
                                      + 18 * x * Math.Pow(y, 2));
                    break;
                
                
                default:
                    Console.WriteLine("Уютненько, обед");
                    break;
            }
        }
    }
}