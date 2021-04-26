using System;
using System.Collections.Generic;
using System.Text;
using BenchmarkDotNet.Attributes;


namespace Lesson3_Bench
{
	public class BenchmarkClass
	{
		/// <summary>
		/// Рассчитывает дистанцию между двумя точками (PointClass — координаты типа float)
		/// </summary>
		/// <param name="pointOne">1я точка</param>
		/// <param name="pointTwo">2я точка</param>
		/// <returns>Расстояние</returns>
		public static float PointDistanceRef(PointClass pointOne, PointClass pointTwo)
		{
			float x = pointOne.X - pointTwo.X;
			float y = pointOne.Y - pointTwo.Y;
			return MathF.Sqrt((x * x) + (y * y));
		}

		[Benchmark]
		public void TestPointDistanceRef()
		{
			PointClass pointOne = new PointClass { X = 17, Y = 18 };
			PointClass pointTwo = new PointClass { X = 25, Y = 16 };
			PointDistanceRef(pointOne, pointTwo);
		}

		/// <summary>
		/// Рассчитывает дистанцию между двумя точками (PointStruct — координаты типа float)
		/// </summary>
		/// <param name="pointOne">1я точка</param>
		/// <param name="pointTwo">2я точка</param>
		/// <returns> Расстояние </returns>
		public static float PointDistance(PointStruct pointOne, PointStruct pointTwo)
		{
			float x = pointOne.X - pointTwo.X;
			float y = pointOne.Y - pointTwo.Y;
			return MathF.Sqrt((x * x) + (y * y));
		}

		[Benchmark]
		public void TestPointDistance()
		{
			PointStruct pointOne = new PointStruct { X = 17, Y = 18 };
			PointStruct pointTwo = new PointStruct { X = 25, Y = 16 };
			PointDistance(pointOne, pointTwo);
		}

		/// <summary>
		/// Рассчитывает дистанцию между двумя точками (PointStruct — координаты типа double).
		/// </summary>
		/// <param name="pointOne">1я точка</param>
		/// <param name="pointTwo">2я точка</param>
		/// <returns>Расстояние</returns>
		public static double PointDistanceDouble(PointStruct pointOne, PointStruct pointTwo)
		{
			double x = pointOne.X - pointTwo.X;
			double y = pointOne.Y - pointTwo.Y;
			return Math.Sqrt((x * x) + (y * y));
		}

		[Benchmark]
		public void TestPointDistanceDouble()
		{
			PointStruct pointOne = new PointStruct { X = 17, Y = 18 };
			PointStruct pointTwo = new PointStruct { X = 25, Y = 16 };
			PointDistanceDouble(pointOne, pointTwo);
		}

		/// <summary>
		/// Рассчитывает дистанцию между двумя точками без квадратного корня со значимым типом (PointStruct — координаты типа float).
		/// </summary>
		/// <param name="pointOne">1я точка</param>
		/// <param name="pointTwo">2я точка</param>
		/// <returns>Расстояние</returns>
		public static float PointDistanceShort(PointStruct pointOne, PointStruct pointTwo)
		{
			float x = pointOne.X - pointTwo.X;
			float y = pointOne.Y - pointTwo.Y;
			return (x * x) + (y * y);
		}
		[Benchmark]
		public void TestPointDistanceShort()
		{
			PointStruct pointOne = new PointStruct { X = 17, Y = 18 };
			PointStruct pointTwo = new PointStruct { X = 25, Y = 16 };
			PointDistanceShort(pointOne, pointTwo);
		}
	}

}
