using System;

namespace Calculator
{
    public static class Program
    {
        public static void Main()
        {
            int result = 0;
            Console.Write("Enter your first number: ");
            int firstNum = int.Parse( Console.ReadLine());
            Console.Write("Enter your second number: ");
            int secNum = int.Parse(Console.ReadLine());
            Console.Write("Would you like to add, subtract, multiply, or divide? ");
            string operate = Console.ReadLine();

            if (operate == "add"){
                 result = firstNum + secNum; }

            if (operate == "subtract"){
                result = firstNum - secNum;}
            if (operate == "multiply"){
                result = firstNum * secNum;}
            if (operate == "divide"){
                result = firstNum / secNum;}

            Console.WriteLine($"Total = {result}");

            Console.ReadLine();
        }
    }
}
