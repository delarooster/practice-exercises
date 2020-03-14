using System;
using System.Collections.Generic;
using System.Text;

public class Elementary
{
    public static void Exercise1()
    {
        Console.WriteLine("Hello world!");
        Console.ReadKey();
    }
    public static void Exercise2()
    {
        Console.WriteLine("Please write your first name: ");
        string name = Console.ReadLine().Trim();
        Console.WriteLine($"Hello {name}!");
        Console.ReadKey();
    }
    public static void Exercise3()
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
}
    
