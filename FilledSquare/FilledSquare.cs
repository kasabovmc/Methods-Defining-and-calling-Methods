using System;
namespace FilledSquare
{
    class FilledSquare
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintFilledSquare(input);
        }

        static void PrintHeader(int n)
        {
            string headaer = new string('-', n * 2);
            Console.WriteLine(headaer);
        }

        static void PrintBody(int n)
        {
            string body = "-";

            for (int i = 0; i < n - 1; i++)
            {
                body += @"\/";
            }

            body += "-";
            Console.WriteLine(body);
        }
        static void PrintFilledSquare(int n)
        {
            PrintHeader(n);
            for (int i = 0; i < n - 2; i++)
            {
                PrintBody(n);
            }
            PrintHeader(n);
        }
    }
}
