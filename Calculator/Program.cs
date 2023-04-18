using System;

namespace Calculator{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("-----Calculator-----");

            int number1, number2, result;

            Console.WriteLine("\nType a number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type another number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n-----Choose a option:-----");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiply");
            Console.WriteLine("4 - Divide");

            string choosedOption = Console.ReadLine();

            switch(choosedOption){
                case "1":
                    result = number1 + number2;
                    Console.WriteLine($"\n{number1} + {number2} is: {result}");
                    break;
                case "2":
                    result = number1 - number2;
                    Console.WriteLine($"\n{number1} - {number2} is: {result}");
                    break;
                case "3": 
                    result = number1 * number2;
                    Console.WriteLine($"\n{number1} * {number2} is: {result}");
                    break;
                case "4":
                    result = number1 / number2;
                    Console.WriteLine($"\n{number1} / {number2} is: {result}");
                    break;
                default:
                    Console.WriteLine("\nChoose a valid option!");
                    break;
            }
        }
    }
}