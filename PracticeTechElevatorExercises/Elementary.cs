using System;
using System.Collections.Generic;
using System.Text;

public class Elementary
{
    //Exercise 1
    public static void HelloWorld()
    {
        Console.WriteLine("Hello world!");
        Console.ReadKey();
    }
    //Exercise 2
    public static void PrintFirstName()
    {
        Console.WriteLine("Please write your first name: ");
        string name = Console.ReadLine().Trim();
        Console.WriteLine($"Hello {name}!");
        Console.ReadKey();
    }
    //Exercise 3
    public static void GreetOnlyBobOrAlice()
    {
        Console.WriteLine("Please write your first name: ");
        string name = Console.ReadLine().Trim();

        if (name == "Bob" || name == "Alice")
        {
            Console.WriteLine($"Hello {name}!");
        }
        else
        {
            Console.WriteLine("Sorry, you're not allowed to be greeted by name!");
        }

        Console.ReadKey();
    }
    //Exercise 4
    public static void CountToN()
    {
        Console.WriteLine("Please provide a number: ");
        int value = Convert.ToInt32(Console.ReadLine().Trim());

        for(int i = 1; i <= value; i++)
        {
            Console.Write($"{i} ");
        }

        Console.ReadKey();
    }
}
    
