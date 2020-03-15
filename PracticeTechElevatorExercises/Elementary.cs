using System;
using System.Collections.Generic;
using System.Text;

public class Elementary
{
    public static void Exercise1()
    {
        Console.WriteLine("Hello World");
        Console.ReadKey();
    }
    public static void Exercise2(string name)
    {
        Console.WriteLine(name + " needs a shower!");
        Console.ReadKey();
    }

    public static void Exercise3(string name)
    {
        
        if(name == "Bob" || name == "Alice")
        {
            Console.WriteLine($"Welcome {name}!");
        }
        else
        {
            Console.WriteLine($"Sorry, I only greet Bob or Alice!");
            Console.ReadKey();
        }
    }
}

    
