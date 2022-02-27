using System;

namespace StringFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String interpolation allows variable names to be embedded in a string. It will be used to print the value, as long as the string is prefixed with a $.
            string apples = "Apples";
            int appleQuantity = 8;
            int applePrice = 100;

            string oranges = "Oranges";
            int orangeQuantity = 12;
            int orangePrice = 80;

            string columnOneHeading = "Fruit";
            string columnTwoHeading = "Quantity";
            string columnThreeHeading = "Price";

            Console.WriteLine($"{columnOneHeading,-12} {columnTwoHeading,8} {columnThreeHeading,9}");
            Console.WriteLine($"{apples,-12} {appleQuantity,-8} {applePrice / 100.0,9:C}"); // :C displays the integer in a currency. For Linux machines, the default currency is dollars  ($).
            Console.WriteLine($"{oranges,-12} {orangeQuantity,-8} {orangePrice / 100.0,9:C}");

            //Experimenting with PI's multiple decimal places (using the F format string followed by demial places desired):
            //(Resource) Microsoft format strings documentation: https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings

            Console.WriteLine($"PI is {Math.PI}");
            Console.WriteLine($"PI is {Math.PI:F3}");
            Console.WriteLine($"PI is {Math.PI:F0}");
            Console.WriteLine($"PI is {Math.PI:F12}");
            Console.WriteLine($"PI is {Math.PI:f99}");

            Console.ReadLine();
        }
    }
}
