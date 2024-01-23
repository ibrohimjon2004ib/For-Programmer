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

                /*Дано целое число N (> 0). Последовательность вещественных чисел AK
                определяется следующим образом:
                A0 = 2, AK = 2 + 1 / AK−1, K = 1, 2, . . . .
                Вывести элементы A1, A2, . . . , AN. */

                //-------------- in side programm ------------------------//                                                            
                int n = int.Parse(Console.ReadLine());
                double a = 2;

                for (double i = 1; i <= n; i++)
                {
                    a = 2 + 1 / (a);
                    Console.WriteLine("A" + i + " = " + a);
                }
                //------------ in side programm ------------------//

                Console.ReadLine();
            }

        }
    }
}
