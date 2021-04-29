using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Lesson4
{
    public class MyBenchClass
    {
        public static Random rand = new Random();
        //глубина списка
        public static int counts = 10000;

        public string[] myArray = new string[counts];

        /// <summary>
        /// Заполняет массив случайными числами 0-1000 типа string
        /// </summary>
        /// <returns></returns>
        public string[] RandomArrayPush()
        {
            for (int i = 0; i < counts; i++)
            {
                myArray[i] = Convert.ToString(rand.Next(0, 1000));
            }
            return myArray;
        }

        public HashSet<string> myHashSet = new HashSet<string>();

        /// <summary>
        /// Заполняет Хэш случайными числами 0-1000 типа string
        /// </summary>
        /// <returns></returns>
        public HashSet<string> RandomHashPush()
        {
            myArray = RandomArrayPush();
            for (int i = 0; i < counts; i++)
            {
                var number = Convert.ToString(rand.Next(0, 1000));
                myHashSet.Add(number);
            }
            return myHashSet;
        }
        /// <summary>
        /// Поиск значения в ХэшТаблице
        /// </summary>
        /// <param name="a">значение</param>
        /// <param name="Hash">Хэш-Таблица</param>
        /// <returns>true/false</returns>
        public bool HashSearch(string a, HashSet<string> Hash)
        {
            return Hash.Contains(a);
        }
        /// <summary>
        /// Поиск значения в массиве
        /// </summary>
        /// <param name="a">значение</param>
        /// <param name="array">массив</param>
        /// <returns>true/false</returns>
        public bool ArraySearch(string a, string[] array)
        {
            for (int i = 0; i < counts; i++)
            {
                if (array[i] == a)
                    return true;
            }
            return false;
        }

        [Benchmark]
        public void TestHash()
        {
            HashSearch(Convert.ToString(25), myHashSet);
        }
        [Benchmark]
        public void TestArray()
        {
            ArraySearch(Convert.ToString(25), myArray);
        }
    }
}
