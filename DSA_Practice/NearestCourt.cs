using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;

namespace DSA_Practice
{
	public class NearestCourt
	{
		public static void Main()
		{
			int tests = int.Parse(Console.ReadLine());

			for (int t = 1; t <= tests; t++)
			{

				var line = Console.ReadLine();

				var input = lineSplitter(line);

				var X = input[0];
				var Y = input[1];

				var mid = Math.Abs(X-Y) / 2.0;

				Console.WriteLine(Math.Ceiling(mid));
			}
		}

		public static List<int> lineSplitter(string line)
		{

			IEnumerable<string> input = line.Split(" ");

			List<int> finalInput = new List<int>();

			foreach (var item in input)
			{
				finalInput.Add(int.Parse(item));

			}

			return finalInput;
		}


	}
}
