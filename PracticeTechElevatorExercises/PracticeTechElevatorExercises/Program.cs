using System;

namespace PracticeTechElevatorExercises
{
    class Program
    {
        static void Main()
        {
            static void Exercise1()
            {
                Console.WriteLine("Tom needs a shower!");
                Console.ReadKey();
            }

            Exercise1(); //calling Exercise1 method

            static void Exercise2(string name)
            {
                Console.WriteLine(name + " needs a shower!");
                Console.ReadKey();
            }

            Exercise2("Irving"); //calling Exercise2 method
        }
    }
}
