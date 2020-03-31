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
		public static int[] Label = new int[6];

		public static void East()
		{
			int label = Label[0];
			Label[0] = Label[3];
			Label[3] = Label[5];
			Label[5] = Label[2];
			Label[2] = label;
		}

		public static void West()
		{
			int label = Label[0];
			Label[0] = Label[2];
			Label[2] = Label[5];
			Label[5] = Label[3];
			Label[3] = label;
		}

		public static void North()
		{
			int label = Label[0];
			Label[0] = Label[1];
			Label[1] = Label[5];
			Label[5] = Label[4];
			Label[2] = label;
		}

		public static void South()
		{
			int label = Label[0];
			Label[0] = Label[3];
			Label[3] = Label[5];
			Label[5] = Label[2];
			Label[2] = label;
		}
	}

	public class Question
	{
		public void Exec()
		{
			Dice dice = new Dice();
			var array = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
			for (var i = 0; i < 6; ++i) {
				Dice.Label[i] = array[i];
			}

			string str =Console.ReadLine();
			int index = 1;
			for (var i = 0; i < str.Length; ++i) {
				switch (c) {
					case 'E':
					default:
						Dice.East();
						break;
					case 'N':
						Dice.North();
						break;
					case 'S':
						Dice.South();
						break;
					case 'W':
						Dice.West();
						break;
				}
			}

			Console.WriteLine($"{Dice.Label[index - 1]}");

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

