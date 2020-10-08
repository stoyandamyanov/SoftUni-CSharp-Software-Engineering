using ShoppingSpree.Core;
using System;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
			try
			{
				Engine engine = new Engine();
				engine.Run();
			}
			catch (Exception E)
			{
				Console.WriteLine(E.Message);
			}
        }
    }
}
