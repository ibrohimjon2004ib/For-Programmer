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

                /* ���� ����� ����� N (> 0). ���� ��� �������� �������� ����� 3, ��
                    ������� TRUE, ���� �� �������� � ������� FALSE. */
                
                //-------------- in side programm ------------------------//                                                                           
                int n = int.Parse(Console.ReadLine());
                //bool i = n == 3;
                int j = 0;
                while (j++ <= n)
                {
                    Console.WriteLine(i);                 
                }
                //------------ in side programm ------------------//

                Console.ReadLine();
            }

        }
    }
}