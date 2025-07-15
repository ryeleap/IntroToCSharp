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
    static bool _running = true;
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
            removeTask();
            break;
          case 3:
            listTasks();
            break;
          case 4:
            renameTask();
            break;
          case 5:
            repoTask();
            break;
          case 6:
            _running = false;
            Console.WriteLine("Goodbye!");
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

    static void removeTask()
    {
      Console.WriteLine("What is the name of the task you wish to remove?");
      string name = Console.ReadLine();
      Task found = _tasks.Find(p => p.Name == name);
      Console.WriteLine("Removing " + found);
      _tasks.Remove(found);
    }

    static void listTasks()
    {
      int count = 1;
      for (int i = 0; i < _tasks.Count; i++)
      {
        Console.WriteLine(count + ". " + _tasks[i].Name + ", Priority " + _tasks[i].Priority);
        count++;
      }
    }

    static void renameTask()
    {
      try
      {
        Console.WriteLine("What is the name of the task you wish to rename?");
        string name = Console.ReadLine();
        Task found = _tasks.Find(p => p.Name == name);
        Console.WriteLine("What would you like to rename it to?");
        string rename = Console.ReadLine();
        found.Name = rename;
      }
      catch (Exception e)
      {
        Console.WriteLine("you stink (rename task)");
      }
    }
    static void repoTask()
    {
      try
      {
        Console.WriteLine("What is the name of the task you wish to reprioritize?");
        string name = Console.ReadLine();
        Task found = _tasks.Find(p => p.Name == name);
        Console.WriteLine("What would you like to reprioritize it to?");
        int priority = Int32.Parse(Console.ReadLine());
        found.Priority = priority;
      }
      catch (Exception e)
      {
        Console.WriteLine("you stink (reprioritize task)");
      }
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to my first C# Project :) sorry it sucks lol");
      Console.WriteLine("Current time is " + localDate);
      while (_running)
      {
        PromptUser();
      }
    }
  }
}
