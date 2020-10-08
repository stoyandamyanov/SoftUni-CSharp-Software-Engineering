using System;

namespace ObjectsClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat.GetDayName(DateTime.Parse("23/10/2009").DayOfWeek);

           // DateTime now = DateTime.Now;
           // string s = now.DayOfWeek.ToString();

            //Console.WriteLine(s);

            Console.WriteLine("Enter the Day Number: ");
            int day = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Month:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Year: ");
            int year = int.Parse(Console.ReadLine());
            DateTime mydate = new DateTime(year, month, day);
            string formatteddate = string.Format("{0:dddd}", mydate);
            Console.WriteLine("The day should be " + formatteddate);

        }
    }
}
