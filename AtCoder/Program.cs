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
			var nml = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
			int n = nml[0];
			int m = nml[1];
			int l = nml[2];
			int[,] A = new int[n, m];
			for (int j = 0; j < n; ++j) {
				var aij = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
				for (int k = 0; k < aij.Length; ++k) {
					A[j, k] = aij[k];
				}
			}

			int[,] B = new int[m, l];
			for (int j = 0; j < m; ++j) {
				var bij = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
				for (int k = 0; k < bij.Length; ++k) {
					B[j, k] = bij[k];
				}
			}

			int[,] C = new int[n, l];
			for (int j = 0; j < C.GetLength(0); ++j) {
				for (int k = 0; k < C.GetLength(1); ++k) {
					for (int i = 0; i < m; ++i) {
						C[j, k] += A[j, i] * B[i, k];
					}
				}
			}

			for (int j = 0; j < C.GetLength(0); ++j) {
				for (int k = 0; k < C.GetLength(1); ++k) {
					Console.Write($"{C[j, k]}");
					if (k < C.GetLength(1) - 1) {
						Console.Write(" ");
					}
				}
				Console.WriteLine("");
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

