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

			double distance = Math.Sqrt(Math.Pow(array[0] - array[2], 2.0) + Math.Pow(array[1] - array[3], 2.0));

			Console.WriteLine($"{distance:f6}");

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

