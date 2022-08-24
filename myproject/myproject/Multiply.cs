using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    internal class Multiplication
    {
        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;

        }

        public static void Main()
        {
            int num1, num2, num3;

            Console.Write("Enter first number to multiply: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number to multiply: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number to multiply: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int Multiplication = Multiply(num1, num2, num3);
            Console.WriteLine($"multiplication of 3 no. is{Multiply}");

        }

    }

}

