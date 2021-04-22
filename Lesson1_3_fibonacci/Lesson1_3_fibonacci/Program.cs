using System;

namespace Lesson1_3_fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число для которого хотите вычислить последовательность Фибоначчи: ");
            int userNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Число Фибоначчи для вашего значения = " + Calculator.goldenRatio(userNumber));
            Console.WriteLine();
            Console.WriteLine("Число Фибоначчи для вашего значения = " + Calculator.FibonacciNumber(userNumber));

            Console.ReadLine();
        }
    }

    public class Calculator
    {
        public static int FibonacciNumber(int sequenceNumber)
        {
            int first = 0, second = 1, fibonacci = 0;
             
            if (Math.Abs(sequenceNumber) == 1) fibonacci = second;

            for (int i = 0; i < Math.Abs(sequenceNumber) - 1; i++)
            {
                fibonacci = first + second;
                first = second;
                second = fibonacci;
            }
            return Math.Sign(sequenceNumber) * fibonacci;
        }

        ///Рекурсивная функция принимающая значение и возвращающая для него число Фибоначчи
        public static int goldenRatio(int number)
        {   //F(number) = F(number-1) + F(number-2) 
            return number < 2 ? number : goldenRatio(number - 1) + goldenRatio(number - 2);
        }
    }
}
