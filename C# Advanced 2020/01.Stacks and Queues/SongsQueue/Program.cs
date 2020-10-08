using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]songs = Console.ReadLine()
                 .Split(", ");

            List<string> totalSongs = new List<string>(songs);

            string[] commands = Console.ReadLine()
                .Split();

            Queue<string> playlist = new Queue<string>(songs);
            playlist.Dequeue();

            StringBuilder song = new StringBuilder();

            while (true)
            {
                if (commands[0] == "Play")
                {
                    if(playlist.Count == 0)
                    {
                        Console.WriteLine("No more songs!");
                        break;
                    }
                    playlist.Dequeue();
                }
                else if (commands[0] == "Add")
                {
                    string Song = "";
                    for (int i = 1; i <= commands.Length - 1; i++)
                    {
                         song.Append(commands[i]).Append(" ");
                        Song = song.ToString();
                        
                    }
                    Song = Song.Remove(Song.Length - 1);

                    if (totalSongs.Contains(Song))
                    {
                        Console.WriteLine($"{Song} is already contained!");
                        if (!playlist.Contains(Song))
                        {
                            playlist.Enqueue(Song);
                        }
                    }
                    else
                    {
                        totalSongs.Add(Song);
                        playlist.Enqueue(Song);
                    }
                }
                else if(commands[0] == "Show")
                {
                    if (playlist.Count == 0)
                    {
                       
                    }
                    else
                    {
                        Console.WriteLine(string.Join(", ", playlist));
                    }
                }
                song.Clear();
                commands = Console.ReadLine()
                    .Split();
            }
            
        }
    }
}
