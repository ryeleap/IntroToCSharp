using System;

namespace smallHourProject
{
  class Program
  {
    static int userInput;
    static string? input;
    static void PromptUser()
    {
      Console.WriteLine("Type 1 to add, 2 to remove, 3 to rename, 4 to reprioritize");
      input = Console.ReadLine();
      if (int.TryParse(input, out userInput))
      {
        switch (userInput)
        {
          case 1:
            Console.WriteLine("Test 1");
            break;
          case 2:
            Console.WriteLine("Test 2");
            break;
          case 3:
            Console.WriteLine("Test 3");
            break;
          case 4:
            Console.WriteLine("Test 4");
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

    static void Main(string[] args)
    {
      PromptUser();
    }
  }
}
