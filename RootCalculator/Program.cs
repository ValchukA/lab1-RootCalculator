using MathLibrary;
using System;

namespace RootCalculator
{
    class Program
    {
        static void Main()
        {
            double x;
            int y;
            double precision;

            Console.Write("Введите положительное число, из которого будет извлекаться корень n-ой степени: ");
            while(!Double.TryParse(Console.ReadLine(), out x) || x <= 0)
            {
                Console.Write("Неверный ввод. Попробуйте еще: ");
            }

            Console.Write("Введите положительное число n: ");
            while (!Int32.TryParse(Console.ReadLine(), out y) || y <= 0)
            {
                Console.Write("Неверный ввод. Попробуйте еще: ");
            }

            Console.Write("Точность вычисления: ");
            while (!Double.TryParse(Console.ReadLine(), out precision) || precision <= 0)
            {
                Console.Write("Неверный ввод. Попробуйте еще: ");
            }

            Console.WriteLine("Введите 1 для нахождения корня n-ой степени из числа.");
            Console.WriteLine("Введите 2 для нахождения корня n-ой степени из числа и сравнения результатов.");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine($"Корень степени {y} из числа {x} равен {Root.Calculate(x, y, precision)}.");
                    break;

                case "2":
                    (double resultFromCustomMethod, double resultFromMathPow) = Root.CalculateWithComparison(x, y, precision);
                    Console.WriteLine($"Корень степени {y} из числа {x} равен {resultFromCustomMethod}.");
                    Console.WriteLine($"Результат Math.Pow: {resultFromMathPow}.");
                    break;

                default:
                    Console.WriteLine("Такой команды нет!!!");
                    break;
            }
        }
    }
}
