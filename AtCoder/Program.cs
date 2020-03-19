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

	public class Dice
	{
		public int[] Label = new int[6];
	}

	public class Question
	{
		public void Exec()
		{
			Dice dice = new Dice();
			var array = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
			for (var i = 0; i < 6; ++i) {
				dice.Label[i] = array[i];
			}

			string str =Console.ReadLine();
			int topIndex = 1;

			for (var i = 0; i < str.Length; ++i) {
				switch (str[i]) {
					case 'E':
					default:
						break;
					case 'N':
						break;
					case 'S':
						break;
					case 'W':
						break;
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

