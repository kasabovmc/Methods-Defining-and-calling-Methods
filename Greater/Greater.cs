using System;

namespace Greater
{
    class Greater
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input == "int")
            {
                int input1 = int.Parse(Console.ReadLine());
                int input2 = int.Parse(Console.ReadLine());
                GetMax(input1, input2);
            }
            else if(input == "char")
            {
                var input1 = char.Parse(Console.ReadLine());
                var input2 = char.Parse(Console.ReadLine());
                GetHigher(input1, input2);
            }
            else if(input == "string")
            {
                var input1 = Console.ReadLine();
                var input2 = Console.ReadLine();
                GetLarger(input1, input2);
            }

        }
        static void GetMax (int a, int b)
        {
            if (a >= b)
            {
                Console.WriteLine(a);
            }
            else Console.WriteLine(b);
        }
        static void GetLarger(string a, string b)
        {
            if (a.Length >= b.Length)
            {
                Console.WriteLine(a);
            }
            else Console.WriteLine(b);
        }
        static void GetHigher(char a, char b)
        {
            if (a >= b)
            {
                Console.WriteLine(a);
            }
            else Console.WriteLine(b);
        }
    }
}
