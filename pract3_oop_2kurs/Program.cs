using System;

namespace pract3_oop_2kurs
{
    class Program
    {
        static void Main(string[] args)
        {
            // шукаємо максимум з двох чисел,
            // використовуючи спочатку коротку, а потім – повну форму конструкції if.
            
            float x, y, max;
            Console.Write("Enter the value of x: ");
            x = float.Parse(Console.ReadLine());
            Console.Write("Enter the value of y: ");
            y = float.Parse(Console.ReadLine());
            max = x; 
            if (y > max) 
            max = y;
            Console.WriteLine("The maximum of {0} and {1} equal {2}", x, y, max);
            Console.WriteLine();
            if (y > x) max = y;
            else max = x;
            //інший спосіб
            Console.WriteLine("The maximum of {0} and {1} is {2}", x, y, max);
        }
    }
}
