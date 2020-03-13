using System;
using System.Collections.Generic;
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
			int taro = 0;
			int hanako = 0;
			for (int i = 0; i < n; ++i) {
				var array = Console.ReadLine().Split(' ');
				int comparison = string.Compare(
					array[0], array[1], comparisonType: StringComparison.OrdinalIgnoreCase);
				if (comparison < 0) {
					hanako += 3;
				} else if (comparison > 0) {
					taro += 3;
				} else {
					++taro;
					++hanako;
				}
			}

			Console.WriteLine($"{taro} {hanako}");

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
			var array = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();

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

