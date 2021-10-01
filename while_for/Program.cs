using System;

namespace while_for
{
    class Program
    {
        static void Main(string[] args)
        {
            short start = 1;
            short end = 15;

            Console.WriteLine("While condition:");
            while (start <= end)
            {
                Console.Write($"{start}...");
                start++;
            }
            Console.WriteLine();
            Console.WriteLine("For condition:");
            for (end = 15; end < 31; end++)
            {
                Console.Write($"{end}..");
            }
            Console.Read();
        }
    }
}
