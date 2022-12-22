using System;

namespace Homework.Gohar2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t1.Enter 2 numbers and operation to proceed +, _, *,/");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            string operation = Console.ReadLine();

            switch (operation)
            {
                case "+" :
                    Console.WriteLine($"a+b = {a + b}");
                    break;
                case "-" :
                    Console.WriteLine($"a-b = {a - b}");
                    break;
                case "*" :
                    Console.WriteLine($"a*b = {a * b}");
                    break;
                case "/" :
                    Console.WriteLine($"a/b = {a / b}");
                    break;
                case "/%":
                    Console.WriteLine($"a%b = {a % b}");
                    break;


                default:
                    Console.WriteLine("N/D");
                    break;
            }
        }

    }

}