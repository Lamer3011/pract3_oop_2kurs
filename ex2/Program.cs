using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal MINSUM = 10000; // Мінімальна сума для бонусу
            const string RIGHT_PAROL = "myparol"; // Значення справжнього паролю

            string parol;
            decimal sum;
            Console.Write("Enter password: ");
            parol = Console.ReadLine();
            // Перевірка правильності паролю
            if (parol == RIGHT_PAROL)
            { // Пароль правильний

                Console.WriteLine("Enter the contribution amount: ");
                sum = int.Parse(Console.ReadLine());

                if (sum > MINSUM) // Перевіряємо суму внеску
                    Console.WriteLine("Congratulations! You get a bonus!");
                else
                    Console.WriteLine("Accumulate more!");

            }
            else // Пароль неправильний
                Console.WriteLine("Wrong password!");
        }
    }
}
