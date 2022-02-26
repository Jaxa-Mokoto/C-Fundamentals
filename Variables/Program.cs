using System;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random(); //decalares a new random variable and assigns the Random instance to that variable.

            /*
             * C# is a statically typed language.
             * Before using a variable in C#, you need to decalare it.
             * Declaring a variable is telling the complier what its name is and what type of data it can store.
            */

            /*
             * Rules on naming variables in C#:
             * Can start with a letter or an underscore.
             * They can contain numbers but must not start with one.
             * Variables must not have the same name as a C# keyword i.e. 'class'
            */

            int firstNumber = random.Next(2, 10); //int is the type of the variable
            int secondNumber = random.Next(2, 10);
            var subtraction = random.Next(2,10); //var does not explicitly state that our variable is of a specific type. C# documentation suggests that  var should be used only when neccessary.
            int answer; //with explicitly typed variables (type defined), we are able to not set the initial value. However with inferred variables (i.e. 'var') we must initialise the varible to suggest the returned type.
            string prompt = ". Dont type in the answer, just press ENTER when ready.";

            Console.WriteLine("Pick a number between 1-10" + prompt);
            Console.ReadKey(); //waits until a key is pressed - not specific on which one.
            Console.WriteLine("Multiply your number by " + firstNumber + prompt);
            Console.ReadKey();
            Console.WriteLine("Now multiply the result by " + secondNumber + prompt);
            Console.ReadKey();
            Console.WriteLine("Divide the result by the number you originally thought of" + prompt);
            Console.ReadKey();
            Console.WriteLine("Now subtract " + subtraction + prompt);
            Console.ReadKey();

            answer = firstNumber * secondNumber - subtraction;
            Console.WriteLine("The answer is " + answer);
            Console.ReadKey();

            /*
             * 
            */

        }
    }
}
