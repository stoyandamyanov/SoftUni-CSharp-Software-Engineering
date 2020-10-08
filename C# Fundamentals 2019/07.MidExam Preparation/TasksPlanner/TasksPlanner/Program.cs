using System;
using System.Collections.Generic;
using System.Linq;

namespace TasksPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> TasksH = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int index = 0;
            int time = 0;
            int countDropped = 0;
            int countCompleted = 0;
            int countIncomplited = 0;
            

            while (true)
            {
                List<string> command = Console.ReadLine()
                  .Split()
                  .ToList();
                if (command[0] == "End")
                {
                    List<int> IncompleteTasks = new List<int>();

                    for (int i = 0; i <= TasksH.Count - 1; i++)
                    {
                        if (TasksH[i] > 0)
                        {
                            IncompleteTasks.Add(TasksH[i]);
                        }

                    }

                    Console.WriteLine(string.Join(" ", IncompleteTasks));
                    break;
                }

                else if (command[0] == "Complete")
                {
                    index = int.Parse(command[1]);
                    if (index >= 0 && index < TasksH.Count) // <=
                    {
                        if (index == TasksH.Count)
                        {
                            TasksH[TasksH.Count - 1] = 0;
                        }
                        else
                        {
                            TasksH[index] = 0;

                        }
                    }
                }

                else if (command[0] == "Change")
                {
                    index = int.Parse(command[1]);
                    time = int.Parse(command[2]);

                    if (index >= 0 && index <= TasksH.Count) //=
                    {
                        if(index == TasksH.Count)
                        {
                            TasksH[TasksH.Count - 1] = time;
                        }
                        else
                        {
                            TasksH[index] = time;
                        }
                        
                    }
                }
                else if (command[0] == "Drop")
                {
                    index = int.Parse(command[1]);

                    if (index >= 0 && index <= TasksH.Count)
                    {
                        if(index == TasksH.Count)
                        {
                            TasksH[TasksH.Count - 1] = -1;
                        }
                        else
                        {
                            TasksH[index] = -1;
                        }
                        
                    }
                }
                else if (command[1] == "Completed")
                {
                    for (int i = 0; i <= TasksH.Count - 1; i++) //=
                    {
                        if (TasksH[i] == 0)
                        {
                            countCompleted++;
                        }
                    }

                    Console.WriteLine(countCompleted);
                }
                else if (command[1] == "Incomplete")
                {
                    for (int i = 0; i <= TasksH.Count - 1; i++)
                    {
                        if(TasksH[i] > 0)
                        {
                            countIncomplited++;
                        }
                    }

                    Console.WriteLine(countIncomplited);
                }
                else if(command[1] == "Dropped")
                {
                    for (int i = 0; i <= TasksH.Count - 1; i++)
                    {
                        if (TasksH[i] == -1)
                        {
                            countDropped++;
                        }
                    }
                    Console.WriteLine(countDropped);
                }
                

            }
            


        }
    }
}
