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
			string origin = Console.ReadLine();
			int q = int.Parse(Console.ReadLine());

			List<string> answer = new List<string>();
			string str = origin;
			for (var i = 0; i < q; ++i) {
				string command = Console.ReadLine();
				string[] commands = command.Split(' ');
				int a = int.Parse(commands[1]);
				int b = int.Parse(commands[2]);
				string[] tempStr = new string[3];
				switch (commands[0]) {
					case "print":
						answer.Add(str.Substring(a, b - a + 1));
						break;
					case "reverse": {
							tempStr[0] = str.Substring(0, a);
							tempStr[1] = new string(str.Substring(a, b - a + 1).Reverse().ToArray());
							tempStr[2] = str.Substring(b + 1, str.Length - b - 1);
							str = tempStr[0] + tempStr[1] + tempStr[2];
						}
						break;
					case "replace": {
							tempStr[0] = str.Substring(0, a);
							tempStr[1] = commands[3];
							tempStr[2] = str.Substring(b + 1, str.Length - b - 1);
							str = tempStr[0] + tempStr[1] + tempStr[2];
						}
						break;
				}
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

