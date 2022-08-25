using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    internal class Small
    {
        public static void minimum(int a1, int b1, out int min1)
        {
            if (a1 < b1)
            {
                min1 = a1;
            }
            else
            {
                min1 = b1;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("First number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Second number");
            int b = Convert.ToInt32(Console.ReadLine());
            int min;
            minimum(a, b, out min);

        }
    }
}