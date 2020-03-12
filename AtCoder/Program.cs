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
			List<string> answer = new List<string>();
			while (true) {
				string str = Console.ReadLine();
				if (str == "-") {
					break;
				}

				int m = int.Parse(Console.ReadLine());
				for (int i = 0; i < m; ++i) {
					int shuffle = int.Parse(Console.ReadLine());
					str = str.Substring(shuffle, str.Length - shuffle) + str.Substring(0, shuffle);
				}

				answer.Add(str);
			}

			foreach (var item in answer) {
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

