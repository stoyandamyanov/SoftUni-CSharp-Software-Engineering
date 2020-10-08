using System;

namespace DateModifier
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();

            DateModifier dateMod = new DateModifier(date1, date2);

            var RES = dateMod.DiffDates();

            Console.WriteLine(Math.Abs(RES));
        }
    }
}
