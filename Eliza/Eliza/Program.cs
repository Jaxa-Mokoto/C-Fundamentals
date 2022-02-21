using System;

namespace ElizaIsSilly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Call the Intro() method in the Doctor class to initialize the program - this is called 'Dot Notation'
            Console.WriteLine(Doctor.Intro());

            var userInput = string.Empty; //Response you have entered into the console window.

            //Continuously ask for user's response until user quits application
            while (!userInput.Equals("Quit", StringComparison.OrdinalIgnoreCase)) //  StringComparison.OrdinalIgnoreCase will ignore the case of the string entered. i.e. 'qUiT' == 'Quit'
            {
                userInput = Console.ReadLine(); //Response entered which will be read by the sytem/ computer.

                //Get response from Eliza
                string response = Doctor.response(userInput);
                Console.WriteLine(response);
            };
        }
    }
}
