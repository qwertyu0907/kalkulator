using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summ
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string A2, B2;
                int A, B, C;
                Console.WriteLine(
                    "Введите Первое Число");
                A2 = Console.ReadLine();
                Console.WriteLine("Введите Второе Число");
                B2 = Console.ReadLine();
                A = Int32.Parse(A2);
                B = Int32.Parse(B2);
                C = A - B;
                Console.WriteLine("Получилось: " + C + "!");
            }
        }
    }
}
