using System;
//For more information on the System namespace: https://docs.microsoft.com/en-us/dotnet/api/system?view=net-6.0

namespace HelloWorld
{
    internal class Program
    { //Curly braces define the code into 'blocks'
        static void Main(string[] args) 
            //parenthesis are called when defining methods. They can be given parameters.
            //For the Main() method, the parameter defined is 'args' 
        {
            //Console.WriteLine() is a method defined in the System namespace as defined above in 'using'
            //For the WriteLine() method, the parameters defined are of the String datatype
            Console.WriteLine("Hello World");
        }
    }
}