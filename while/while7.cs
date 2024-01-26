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

                /* ƒано целое число N (> 0). Ќайти наименьшее целое положительное
                число K, квадрат которого превосходит N: K
                2 > N. ‘ункцию извлечени€ квадратного корн€ не использовать.*/

                //-------------- in side programm ------------------------//                                                                                          
                int n = int.Parse(Console.ReadLine());
                int i = n;
                double k = 0;
                while (i-- > 0)
                {
                    if (k * k > n)
                    {
                        Console.WriteLine($"Adadi K = {k}");
                        break;
                    }
                    k++;
                }
                //------------ in side programm ------------------//
                Console.ReadLine();
            }
        }
    }
}
