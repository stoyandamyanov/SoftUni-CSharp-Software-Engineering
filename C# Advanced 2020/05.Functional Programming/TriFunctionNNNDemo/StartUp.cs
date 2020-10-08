using System;

namespace TriFunctionNNNDemo
{
    class StartUp
    {
        static void Main(string[] args)
        {
			int totalScore = int.Parse(Console.ReadLine());
			string[] names = Console.ReadLine()
				.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			

			Func<string[], int, string> Winner = Names;
			string winner = Winner(names, totalScore);

			Console.WriteLine(winner);
		}

		public static string Names(string[] arr, int score)
		{
			int Currentscore = 0;
			string Winner = " ";

			foreach (var name in arr)
			{
				foreach (var ch in name)
				{
					Currentscore += (int)ch;
					
				}
				if (Currentscore >= score)
				{
					Winner = name;
					break;
				}
				else
				{
					Currentscore = 0;
				}

			}
			return Winner;
		}
	}
}
