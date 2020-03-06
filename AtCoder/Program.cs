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
			List<List<int>> lists = new List<List<int>>();
			var rc = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
			int r = rc[0];
			for (int i = 0; i < r; ++i) {
				List<int> list = new List<int>();
				var array = Console.ReadLine().Split(' ').Select(j => int.Parse(j)).ToArray();
				foreach (var item in array) {
					list.Add(item);
				}

				lists.Add(list);
			}

			for (int i = 0; i < r; ++i) {
				int sum = 0;
				for (int j = 0; j < lists[i].Count; ++j) {
					sum += lists[i][j];
				}

				lists[i].Add(sum);
			}

			List<int> totallist = new List<int>();
			for (int j = 0; j < lists[0].Count; ++j) {
				int sum = 0;
				for (int i = 0; i < lists.Count; ++i) {
					sum += lists[i][j];
				}

				totallist.Add(sum);
			}

			lists.Add(totallist);

			for (int i = 0; i < lists.Count; ++i) {
				for (int j = 0; j < lists[i].Count; ++j) {
					Console.Write($"{lists[i][j]}");

					if (j < lists[i].Count - 1) {
						Console.Write(" ");
					} else {
						Console.WriteLine("");
					}
				}
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

