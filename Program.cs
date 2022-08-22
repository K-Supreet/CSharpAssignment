// See https://aka.ms/new-console-template for more information


namespace Assignment
{
    internal class Firstone
    {
        public static void Main()
        {
            int num1, num2, num3;

            Console.Write("Enter First Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Enter Second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Third Number: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int res = num1 * num2 * num3;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}", num1, num2, num3, res);
        }
    }
}

