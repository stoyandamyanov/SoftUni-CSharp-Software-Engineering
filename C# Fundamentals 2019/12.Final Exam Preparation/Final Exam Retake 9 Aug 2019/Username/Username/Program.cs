using System;

namespace Username
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string[] input = Console.ReadLine()
                .Split();

            while (true)
            {
                if (input[0] == "Sign")
                {
                    break;
                }

                if (input[0] == "Case")
                {
                    if(input[1] == "lower")
                    {
                        username = username.ToLower();
                        Console.WriteLine(username);
                    }
                    else if(input[1] == "upper")
                    {
                        username = username.ToUpper();
                        Console.WriteLine(username);
                    }
                }
                else if(input[0] == "Reverse")
                {
                    int start = int.Parse(input[1]);
                    int end = int.Parse(input[2]);
                    int total = end - start;
                    
                    if (start >= 0 && end <= username.Length - 1)
                    {
                        string sub = username.Substring(start, total + 1);
                        for (int i = sub.Length - 1; i >= 0; i--)
                        {
                            char ch = sub[i];
                            Console.Write(ch);
                        }
                        Console.WriteLine();
                    }
                }
                else if(input[0] == "Cut")
                {
                    string sub = input[1];
                    if(username.Contains(sub))
                    {
                        int start = username.IndexOf(sub);
                        username = username.Remove(start, sub.Length);
                        Console.WriteLine(username);
                    }
                    else
                    {
                        Console.WriteLine($"The word {username} doesn't contain {sub}.");
                    }
                }
                else if(input[0] == "Replace")
                {
                    char ch = char.Parse(input[1]);

                    username = username.Replace(ch, '*');
                    Console.WriteLine(username);
                }
                else if(input[0] == "Check")
                {
                    char chh = char.Parse(input[1]);
                    if(username.Contains(chh))
                    {
                        Console.WriteLine("Valid");
                    }
                    else
                    {
                        Console.WriteLine($"Your username must contain {chh}.");
                    }
                }

                
                input = Console.ReadLine()
                    .Split();
            }
        }
    }
}
