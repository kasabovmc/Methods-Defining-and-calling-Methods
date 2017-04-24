using System;

namespace Math_Power
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());
            double raised = double.Parse(Console.ReadLine());
            double result = MathPow(input, raised);
            Console.WriteLine(result);
        }
        static double MathPow(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
