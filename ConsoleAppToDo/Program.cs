using System;

namespace smallHourProject
{

  public class Task
  {
    public string Name { get; set; }
    public int Priority { get; set; }
    public Task(string name, int priority)
    {
      Name = name;
      Priority = priority;
    }
  }


  class Program
  {
    static int userInput;
    static string? input;
    static DateTime localDate = DateTime.Now;
    static int count = 0;
    static private List<Task> _tasks = new List<Task>();

    static void PromptUser()
    {
      Console.WriteLine("Type 1 to add, 2 to remove, 3 to list, 4 to rename, 5 to reprioritize");
      input = Console.ReadLine();
      if (int.TryParse(input, out userInput))
      {
        switch (userInput)
        {
          case 1:
            createTask();
            break;
          case 2:
            // deleteTask();
            break;
          case 3:
            // renameTask();
            break;
          case 4:
            // repoTask();
            break;
          default:
            Console.WriteLine("Invalid Input, reprompting");
            PromptUser();
            break;
        }
      }
      else
      {
        Console.WriteLine("Not a number, try again");
        PromptUser();
      }
    }



    static void createTask()
    {
      Console.WriteLine("Assign a name to this task");
      string name = Console.ReadLine();
      Console.WriteLine("Assign a priority to this task 1 through 5");
      int priority = Int32.Parse(Console.ReadLine());
      Task task = new Task(name, priority);
      _tasks.Add(task);
    }

    void removeTask(Task task)
    {

    }


    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to my first C# Project :) sorry it sucks lol");
      Console.WriteLine("Current time is " + localDate);
      PromptUser();
    }
  }
}
