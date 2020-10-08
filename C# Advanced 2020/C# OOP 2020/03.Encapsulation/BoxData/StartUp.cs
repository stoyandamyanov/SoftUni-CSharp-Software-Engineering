using System;

namespace BoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            

            try
            {
                Box BOX = new Box(lenght, width, height);
            }
            catch (ArgumentException ae)
            {

                Console.WriteLine(ae.Message);
            }
        }
    }
}
