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
            int from = 0;
            int to = 100;
            Random random = new Random();
            int number = random.Next(from, to);
            Console.WriteLine($"Рандомное число: {number}");
            int sumOfNumbers = 0;
            int firstNumber = 3;
            int secondNumber = 5;
            int startNumber = 1;

            for (int i = startNumber; i <= number; i++)
            {
                if (i % firstNumber == 0 || i % secondNumber == 0)
                {
                    sumOfNumbers += i;
                    Console.WriteLine($"Число кратное {firstNumber} или {secondNumber}: {i}");
                }
            }

            Console.WriteLine($"Сумма чисел равна: {sumOfNumbers}");
        }
    }
}
