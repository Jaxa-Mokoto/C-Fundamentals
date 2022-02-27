using System;

namespace StringFormatting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string apples = "Apples";
            int appleQuantity = 8;
            int applePrice = 100;

            string oranges = "Oranges";
            int orangeQuantity = 12;
            int orangePrice = 80;

            string columnOneHeading = "Fruit";
            string columnTwoHeading = "Quantity";
            string columnThreeHeading = "Price";

            Console.WriteLine($"{columnOneHeading, -12} {columnTwoHeading, 8} {columnThreeHeading, 8}");
            Console.WriteLine($"{apples, -12} {appleQuantity, -8} {applePrice, 6} cents");
            Console.WriteLine($"{oranges, -12} {orangeQuantity, -8} {orangePrice, 6} cents");
            Console.ReadLine();
        }
    }
}
