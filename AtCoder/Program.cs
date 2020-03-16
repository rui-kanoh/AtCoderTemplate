using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AtCoder
{
	class Program
	{
		static void Main(string[] args)
		{
			var Instance = new Question();
			Instance.Exec();
		}
	}

	public class Question
	{
		public void Exec()
		{
			var array = Console.ReadLine().Split(' ').Select(i => double.Parse(i)).ToArray();

			double a = array[0];
			double b = array[1];
			double c_rad = array[2] / 180.0 * Math.PI;
			double height = b * Math.Sin(c_rad);
			double area = a * height / 2.0;
			double c = Math.Sqrt(a * a + b * b - 2.0 * a * b * Math.Cos(c_rad));
			double length = a + b + c;

			Console.WriteLine($"{area:f6}");
			Console.WriteLine($"{length:f6}");
			Console.WriteLine($"{height:f6}");

			Console.ReadKey();
		}
	}
}

namespace Temp {
	public class QuestionA
	{
		void swap(ref long x, ref long y)
		{
			long temp = y;
			y = x;
			x = temp;
		}

		public void Exec()
		{
			long n = long.Parse(Console.ReadLine());
			//var array = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
			var array = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();

			Console.Out.Flush();

			Console.ReadLine();
		}
	}

	public class QuestionAA
	{
		public void Exec()
		{
			long n = long.Parse(Console.ReadLine());
			var array = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

			Console.Out.Flush();

			Console.ReadLine();
		}
	}
}

