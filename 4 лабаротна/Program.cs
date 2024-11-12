using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_лабаротна
{
    class Program
    {
        static int CountMethods(int n)
        {
            int[] methods = new int[n + 1];
            methods[0] = 1;
            int[] denominations = { 1, 2, 3, 5 };

            foreach (int denom in denominations)
            {
                for (int i = denom; i <= n; i++)
                {
                    methods[i] += methods[i - denom];
                }
            }

            return methods[n];
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Введіть число (суму грошей) для розрахунку способів або натисніть '0' для виходу:");

                string input = Console.ReadLine();

                if (input.ToUpper() == "0")
                {
                    Console.WriteLine("Вихід з програми...");
                    break;
                }

                if (int.TryParse(input, out int n) && n >= 0)
                {
                    int result = CountMethods(n);
                    Console.WriteLine($"Кількість способів надати {n} гривень(купюрами наміналом:1,2,3,4,5): {result}");
                }
                else
                {
                    Console.WriteLine("Будь ласка, введіть коректне ціле число або '1' для виходу.");
                }
                Console.ReadKey();
            }
        }
    }
}
