using System;

namespace UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(name + " is " + age + " years old.");
            Console.ReadLine();
        }
    }
}
