using System;
using System.Collections.Generic;
using System.Linq;

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
			int[] nx = new int[2] { -1, -1 };
			List<int> counts = new List<int>();

			Func<int[], bool> checker = (c) => c[0] == 0 && c[1] == 0;

			while (checker.Invoke(nx) == false) {
				nx = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
				if (checker.Invoke(nx)) {
					break;
				}

				int n = nx[0];
				int x = nx[1];

				int count = 0;
				for (int i = 1; i <= n; ++i) {
					for (int j = i + 1; j <= n; ++j) {
						for (int k = j + 1; k <= n; ++k) {
							if (i + j + k == x) {
								++count;
							}
						}
					}
				}

				
				counts.Add(count);
			}

			foreach (var item in counts) {
				Console.WriteLine($"{item}");
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

