using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int t = 0; t < 20; t++)
            {
                Console.Clear();

                /*Дано целое число N (> 0). Найти двойной факториал N:
                N!! = N·(N−2)·(N−4)·. . .
                (последний сомножитель равен 2, если N — четное, и 1, если N — нечетное). Чтобы избежать 
                целочисленного переполнения, вычислять это произведение с помощью вещественной переменной 
                и вывести его как вещественное число.*/ 

                //-------------- in side programm ------------------------//                                                                           
                int n = int.Parse(Console.ReadLine());
                double i = 0;
                double a = 1;
                if (n % 2 == 0)
                {
                    while (i <= n)
                    {
                        i++;
                        if (i % 2 == 0)
                        {
                            a *= i;
                        }

                    }
                    Console.WriteLine(a);
                }
                else if (n % 2 == 1)
                {
                    while (i <= n)
                    {
                        if (i % 2 == 1)
                        {
                            a = a * i;
                        }
                        i++;
                    }
                    Console.WriteLine(a);
                }            
                //------------ in side programm ------------------//
                Console.ReadLine();
            }
        }
    }
}
