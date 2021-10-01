using System;

namespace swith_case
{
    class Program
    {
        static void Main(string[] args)
        {
            char op;
            int x = 10, y = 20;
            Console.WriteLine($"Enter a character for the number operation {x} {y}");

            op = (char)Console.Read();

            switch (op)
            {
                case'+':
                    Console.WriteLine($"{x} {op} {y} = {x + y}");
                    break;
                case '-':
                    Console.WriteLine($"{x} {op} {y} = {x - y}");
                    break;
                case '*':
                    Console.WriteLine($"{x} {op} {y} = {x * y}");
                    break;
                case '/':
                    Console.WriteLine($"{x} {op} {y} = {x / y}");
                    break;
                case '%':
                    Console.WriteLine($"{x} {op} {y} = {x % y}");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }
        }
    }
}
