using System;

namespace guliana
{
    class Program
    {
        static void Main()
        {
            for (int i = -10; i <= 10; i++)
            {
                Console.WriteLine($"число:{i}, результат:{ProcessNumber(i)}");
            }
        }
        static double ProcessNumber(int number)
        {
            if (number > 0)
            {
                return Math.Pow(number, 2);
            }
            else if (number < 0)
            {
                return Math.Pow(number, 3);
            }
            else
            {
                return 0;
            }
        }
    }
}


