using System;

namespace Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var personInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string fullName = $"{personInfo[0]} {personInfo[1]}";
            string adress = $"{personInfo[2]}";

            var nameandBeer = Console.ReadLine()
                .Split();

            string name = nameandBeer[0];
            int beerAmount = int.Parse(nameandBeer[1]);

            var intandDouble = Console.ReadLine()
                .Split();

            int Int = int.Parse(intandDouble[0]);
            double Double = double.Parse(intandDouble[1]);

            Tuple<string, string> firstTuple = new Tuple<string, string>(fullName, adress);
            Tuple<string, int> secondTuple = new Tuple<string, int>(name, beerAmount);
            Tuple<int, double> thirdTuple = new Tuple<int, double>(Int, Double);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
