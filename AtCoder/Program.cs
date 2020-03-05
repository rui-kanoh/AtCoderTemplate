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

	public struct Exam
	{
		public int Middle;
		public int End;
		public int Retry;
	}

	public class Question
	{
		public void Exec()
		{
			Exam exam = new Exam();
			List<string> results = new List<string>();
			Func<Exam, bool> checker = (e) => e.Middle == -1 && e.End == -1 && e.Retry == -1;
			while (checker.Invoke(exam) == false) {
				int[] mfr = Console.ReadLine().Split(' ').Select(i => int.Parse(i)).ToArray();
				exam.Middle = mfr[0];
				exam.End = mfr[1];
				exam.Retry = mfr[2];
				if (checker.Invoke(exam)) {
					break;
				}

				string result = "";
				if (exam.Middle == -1 || exam.End == -1) {
					result = "F";
				} else if (exam.Middle + exam.End >= 80) {
					result = "A";
				} else if (exam.Middle + exam.End >= 65) {
					result = "B";
				} else if (exam.Middle + exam.End >= 50) {
					result = "C";
				} else if (exam.Middle + exam.End >= 30) {
					if (exam.Retry >= 50) {
						result = "C";
					} else {
						result = "D";
					}
				} else {
					result = "F";
				}

				results.Add(result);
			}

			foreach (var item in results) {
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

