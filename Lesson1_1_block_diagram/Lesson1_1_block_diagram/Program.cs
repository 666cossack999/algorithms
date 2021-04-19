using System;

namespace Lesson1_1_block_diagram
{
    class Program
    {

        /// <summary>
        /// Вычисляет простое или не простое число
        /// </summary>
        /// <param name="number">Число</param>
        /// <returns>true - число простое; false - число не простое</returns>
        static bool Simple (int number)
        {
            int d = 0, i = 2;
            bool result;

            if (number < 2)
            {
                throw new ArgumentException("number должно быть больше 1");
            }

            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;                    
                }                
                i++;                
            }
            
            
            if (d == 0)
            {
                Console.WriteLine("Число простое"); 
                result = true;
            }
            else
            {
                Console.WriteLine("Число не простое"); 
                result = false;
            }
            

            return result;
        }

        public class TestCase
        {
            public int N { get; set; }
            public  bool Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }


        static void TestSimple(TestCase testCase)
        {
            try
            {
                var actual = Simple(testCase.N);

                if (actual == testCase.Expected)
                {
                    Console.WriteLine("VALID TEST");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                    Console.WriteLine();
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException == null)
                {
                    Console.WriteLine(ex);
                    Console.WriteLine();

                    Console.WriteLine("VALID TEST");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("INVALID TEST");
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                N = 6,
                Expected = false,
                ExpectedException = null
            };

            var testCase2 = new TestCase()
            {
                N = 5,
                Expected = true,
                ExpectedException = null
            };

            var testCase3 = new TestCase()
            {
                N = 1,
                Expected = false,
                ExpectedException = null
            };

            TestSimple(testCase1);
            TestSimple(testCase2);
            TestSimple(testCase3);
        }
    }

}
