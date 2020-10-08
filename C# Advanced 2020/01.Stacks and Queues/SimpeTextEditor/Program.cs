using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpeTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<string> stack = new Stack<string>();

            StringBuilder text = new StringBuilder();
            int counter = 0;
            stack.Push(text.ToString());

            while (counter != n)
            {
                string[] command = Console.ReadLine()
                    .Split();

                if (command[0] == "1")
                {

                    text.Append(command[1]);

                    stack.Push(text.ToString());

                }
                else if (command[0] == "2")
                {
                    int inx = int.Parse(command[1]);

                    for (int i = 0; i < inx; i++)
                    {
                        text.Remove(text.Length - 1, 1);
                    }

                    stack.Push(text.ToString());
                }
                else if (command[0] == "3")
                {
                    int index = int.Parse(command[1]);

                    Console.WriteLine(text[index - 1]);


                }
                else if (command[0] == "4")
                {
                    stack.Pop();
                    text.Clear();
                    text.Append(stack.Peek());
                }
                counter++;
            }
        }
    }
}
