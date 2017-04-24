using System;

namespace Printing_Triangle
{
    class PrintingTriangle
    {
        static void Main(string[] args)
        {
            int only = int.Parse(Console.ReadLine());
            PrintTriangle(only);
        }
        static void PrintLine(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void PrintTriangle(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(i);
            }
            for (int i = n-1; i > 0; i--)
            {
                PrintLine(i);
            }
        }
    }
}
