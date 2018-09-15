using System;
using System.Collections.Generic;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Todo> todos = new List<Todo>()
            {
                new Todo { Description = "Task 1", EstimateHours = 6, Status = Status.Complete},
                new Todo { Description = "Task 2", EstimateHours = 2, Status = Status.InProgress},
                new Todo { Description = "Task 3", EstimateHours = 8, Status = Status.NotStarted},
                new Todo { Description = "Task 4", EstimateHours = 12, Status = Status.Deleted},
                new Todo { Description = "Task 5", EstimateHours = 6, Status = Status.InProgress},
                new Todo { Description = "Task 6", EstimateHours = 2, Status = Status.NotStarted},
                new Todo { Description = "Task 7", EstimateHours = 14, Status = Status.Complete},
                new Todo { Description = "Task 8", EstimateHours = 8, Status = Status.Complete},
                new Todo { Description = "Task 9", EstimateHours = 8, Status = Status.Complete},
                new Todo { Description = "Task 10", EstimateHours = 8, Status = Status.Complete},
                new Todo { Description = "Task 11", EstimateHours = 4, Status = Status.NotStarted},
                new Todo { Description = "Task 12", EstimateHours = 10, Status = Status.Complete},
                new Todo { Description = "Task 13", EstimateHours = 12, Status = Status.Deleted},
                new Todo { Description = "Task 14", EstimateHours = 6, Status = Status.Complete}
            };

            Console.ForegroundColor = ConsoleColor.DarkRed;

            PrintAssessment(todos);
        }

        private static void PrintAssessment(List<Todo> todos)
        {
            foreach(var todo in todos)
            {
                switch(todo.Status)
                {
                    case Status.NotStarted:
                        Console.ForegroundColor = ConsoleColor.Red;
                        break;
                    case Status.InProgress:
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                    case Status.OnHold:
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        break;
                    case Status.Complete:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case Status.Deleted:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                    default:
                        break;

                }
                Console.WriteLine(todo.Description);
            }
        }
    }

    class Todo
    {
        public string Description { get; set; }
        public int EstimateHours { get; set; }
        public Status Status { get; set; }
    }

    enum Status
    {
        NotStarted,
        InProgress,
        OnHold,
        Complete,
        Deleted
    }
}
