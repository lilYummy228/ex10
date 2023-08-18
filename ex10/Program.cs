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
            Random random = new Random();
            int number = random.Next(0, 100);
            Console.WriteLine($"Рандомное число: {number}");
            int sumOfNumbers = 0;
            int divisible3 = 3;
            int divisible5 = 5;
            int startNumber = 1;

            for (int i = startNumber; i <= number; i++)
            {
                if (i % divisible3 == 0 || i % divisible5 == 0)
                {
                    sumOfNumbers += i;
                    Console.WriteLine($"Число кратное {divisible3} или {divisible5}: {i}");
                }
            }

            Console.WriteLine($"Сумма чисел равна: {sumOfNumbers}");
        }
    }
}
