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
                /* Дано целое число N (> 0). Найти наибольшее целое число K,
                 * квадрат которого не превосходит N: K 2 ≤ N. Функцию извлечения квадратного
                 * корня не использовать.*/
                //-------------- in side programm ------------------------//                                                                                          
                int n = int.Parse(Console.ReadLine());
                int i = n;
                double k = 0;

                while (i-- > 0)
                {
                    if (k * k <= n)
                    {
                        k++;
                    }
                }
                Console.WriteLine($"k = {k - 1}");
                //------------ in side programm ------------------//
                Console.ReadLine();
            }
        }
    }
}
