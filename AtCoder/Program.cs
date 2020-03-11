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
			string s = Console.ReadLine();
			string p = Console.ReadLine();

			bool isOK = false;
			if (s.Contains(p)) {
				isOK = true;
			} else {
				for (int i = 1; i < s.Length; ++i) {
					string newStr = s.Substring(i, s.Length - i) + s.Substring(0, i);
					if (newStr.Contains(p)) {
						isOK = true;
						break;
					}
				}
			}

			string str = isOK ? "Yes" : "No";
			Console.WriteLine($"{str}");
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

