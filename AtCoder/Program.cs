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
			string str = "";
			string tempStr = "temp";
			while (string.IsNullOrWhiteSpace(tempStr) == false) {
				tempStr = Console.ReadLine();
				if (string.IsNullOrWhiteSpace(tempStr)) {
					break;
				}

				str += tempStr.ToLower();
			};

			//Console.WriteLine(str);
			List<string> alphabets = new List<string>();
			char[] chars = str.ToArray();
			for (char alpha = 'a'; alpha <= 'z'; ++alpha) {
				char[] finds = Array.FindAll(chars, item => item == alpha);
				int sum = finds.Length;
				alphabets.Add($"{alpha.ToString()} : {sum}");
			}

			for (int i = 0; i < alphabets.Count; ++i) {
				Console.WriteLine($"{alphabets[i]}");
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

