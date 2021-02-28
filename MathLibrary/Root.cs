using System;
using System.Collections.Generic;
using System.Text;

namespace MathLibrary
{
    public static class Root
    {
        public static double Calculate(double x, int y, double precision)
        {
            if (x <= 0 || y <= 0 || precision <= 0)
            {
                throw new ArgumentException("All arguments must be positive numbers.");
            }

            double result = x / 5;
            double prevResult = int.MaxValue;          

            while (Math.Abs(result - prevResult) > precision)
            {
                prevResult = result;
                result -= (RaiseToPower(y) - x) / (y * RaiseToPower(y - 1));
            }

            return result;

            double RaiseToPower(int n)
            {
                double resultOfRaising = 1;

                for (int i = 0; i < n; i++)
                {
                    resultOfRaising *= result;
                }

                return resultOfRaising;
            }
        }

        public static (double, double) CalculateWithComparison(double x, int y, double precision)
        {
            double resultFromCustomMethod = Calculate(x, y, precision);
            double resultFromMathPow = Math.Pow(x, 1d / y);

            return (resultFromCustomMethod, resultFromMathPow);
        }
    }
}
