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

                //-------------- in side programm ------------------------//                                                            
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int h = int.Parse(Console.ReadLine());
                int n = 0;
                double func;
                for (double i = a; i < b; i++)
                {
                    i = a + n * h;
                    n++;
                    func = 1 - Math.Cos(i);
                    if (b >= i)
                    {
                        Console.WriteLine(i + ",");
                        Console.WriteLine(func + ",");
                    }
                }
                //------------ in side programm ------------------//

                Console.ReadLine();
            }

        }
    }
}