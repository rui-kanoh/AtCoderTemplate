using System;
using System.Collections.Generic;
using System.Linq;

namespace AtCoder
{
	class Program
	{
		static void Main(string[] args)
		{
			// 整数配列の入力
			var abk = Console.ReadLine().Split(' ').Select(i => long.Parse(i)).ToArray();
			long a = abk[0];
			long b = abk[1];
			long k = abk[2];

			List<long> listA = new List<long>();
			for (long i = a; i < a + k && i <= b; ++i) {
				listA.Add(i);
			}

			List<long> listB = new List<long>();
			for (long i = b; i > b - k + 1 && i >= a; --i) {
				listB.Add(i);
			}

			listB.Reverse();
			listA.AddRange(listB);
			var list = listA.Distinct();

			foreach (var item in list) {
				Console.WriteLine(item.ToString());
			}

			Console.Out.Flush();

			Console.ReadLine();
		}
	}
}

class BuyingSweets {

}

