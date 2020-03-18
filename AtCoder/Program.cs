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
			long n = long.Parse(Console.ReadLine());
			var vx = Console.ReadLine().Split(' ').Select(i => double.Parse(i)).ToArray();
			var vy = Console.ReadLine().Split(' ').Select(i => double.Parse(i)).ToArray();

			double[] distances = new double[4];
			double max = 0.0;
			for (var i = 0; i < n; ++i) {
				double diff = Math.Abs(vx[i] - vy[i]);
				distances[0] += diff;
				distances[1] += Math.Pow(diff, 2.0);
				distances[2] += Math.Pow(diff, 3.0);
				max = Math.Max(max, diff);
			}

			distances[1] = Math.Sqrt(distances[1]);
			distances[2] = Math.Pow(distances[2], 1.0 / 3.0);
			distances[3] = max;

			foreach (var item in distances) {
				Console.WriteLine($"{item:f6}");
			}
			
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

