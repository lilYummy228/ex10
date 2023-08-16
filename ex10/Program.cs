using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int number = rand.Next(0, 100);
            Console.WriteLine($"Рандомное число: {number}");
            int sumOfNumbers = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sumOfNumbers += i;
                    Console.WriteLine($"Число кратное 3 или 5: {i}");
                }
                else
                {
                    continue;
                }
            }
                Console.WriteLine($"Сумма чисел равна: {sumOfNumbers}");
        }
    }
}
