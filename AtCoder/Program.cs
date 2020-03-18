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
			List<double> stdevs = new List<double>();
			while (true) {
				string str = Console.ReadLine();
				if (str == "0") {
					break;
				}

				long n = long.Parse(str);
				var array = Console.ReadLine().Split(' ').Select(i => double.Parse(i)).ToArray();
				double ave = array.Average();
				double stdev = 0.0;
				for (var i = 0; i < array.Length; ++i) {
					stdev += (array[i] - ave) * (array[i] - ave);
				}

				stdev /= array.Length;
				stdevs.Add(Math.Sqrt(stdev));
			}

			
			foreach (var item in stdevs) {
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

