using System;

namespace Threeuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var personInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string fullName = $"{personInfo[0]} {personInfo[1]}";
            string address = personInfo[2];
            string town = personInfo[3];
            if(personInfo.Length > 4)
            {
                town = $"{personInfo[3]} {personInfo[4]}";
            }

            var NameandBeer = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string name = NameandBeer[0];
            var LitresofBeer = int.Parse(NameandBeer[1]);
            
            bool drunkornot = false;
            if(NameandBeer[2] == "drunk")
            {
                drunkornot = true;
            }

            var BankInfo = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string namePerson = BankInfo[0];
            var AccBalance = double.Parse(BankInfo[1]);
            string BankName = BankInfo[2];

            Threeple<string, string, string> firstThreeple = new Threeple<string, string, string>(fullName, address, town);
            Threeple<string, int, bool> secondThreeple = new Threeple<string, int, bool>(name, LitresofBeer, drunkornot);
            Threeple<string, double, string> thirdThreeple = new Threeple<string, double, string>(namePerson, AccBalance, BankName);

            Console.WriteLine(firstThreeple);
            Console.WriteLine(secondThreeple);
            Console.WriteLine(thirdThreeple);
        }
    }
}
