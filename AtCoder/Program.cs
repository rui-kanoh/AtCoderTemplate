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
		public static int Dice1(char c)
		{
			int ans;
			switch (c) {
				case 'E':
				default:
					ans = 4;
					break;
				case 'N':
					ans = 2;
					break;
				case 'S':
					ans = 5;
					break;
				case 'W':
					ans = 3;
					break;
			}

			return ans;
		}

		public static int Dice2(char c)
		{
			int ans;
			switch (c) {
				case 'E':
				default:
					ans = 4;
					break;
				case 'N':
					ans = 6;
					break;
				case 'S':
					ans = 1;
					break;
				case 'W':
					ans = 3;
					break;
			}

			return ans;
		}

		public static int Dice3(char c)
		{
			int ans;
			switch (c) {
				case 'E':
				default:
					ans = 2;
					break;
				case 'N':
					ans = 6;
					break;
				case 'S':
					ans = 1;
					break;
				case 'W':
					ans = 5;
					break;
			}

			return ans;
		}

		public static int Dice4(char c)
		{
			int ans;
			switch (c) {
				case 'E':
				default:
					ans = 6;
					break;
				case 'N':
					ans = 2;
					break;
				case 'S':
					ans = 5;
					break;
				case 'W':
					ans = 1;
					break;
			}

			return ans;
		}

		public static int Dice5(char c)
		{
			int ans;
			switch (c) {
				case 'E':
				default:
					ans = 4;
					break;
				case 'N':
					ans = 1;
					break;
				case 'S':
					ans = 6;
					break;
				case 'W':
					ans = 3;
					break;
			}

			return ans;
		}

		public static int Dice6(char c)
		{
			int ans;
			switch (c) {
				case 'E':
				default:
					ans = 4;
					break;
				case 'N':
					ans = 5;
					break;
				case 'S':
					ans = 2;
					break;
				case 'W':
					ans = 3;
					break;
			}

			return ans;
		}

		public static Func<char, int>[] funcs = {
			Dice1, Dice2, Dice3, Dice4, Dice5, Dice6,
		};

		public void Exec()
		{
			Dice dice = new Dice();
			var array = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
			for (var i = 0; i < 6; ++i) {
				dice.Label[i] = array[i];
			}

			string str = Console.ReadLine();
			int index = 1;
			for (var i = 0; i < str.Length; ++i) {
				if (i == 0) {
					index = funcs[0](str[i]);
				} else {
					index = funcs[index - 1](str[i]);
				}

				//Console.WriteLine($"{index}");
			}

			Console.WriteLine($"{dice.Label[index - 1]}");

			Console.ReadKey();
		}
	}
}

