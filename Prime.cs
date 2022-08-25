using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{

    public class PrimeNumber
    {
        public static bool CheckPrime(int num)
        {
            for (int i = 2; i < num; i++)
                if (num % i == 0)
                    return false;
            return true;
        }
        public static void Main1()
        {
            Console.Write("Input a number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (checkPrime(n))
                Console.WriteLine(n + " is a prime number");
            else
                Console.WriteLine(n + " is not a prime number");
        }
    }
}
Footer
© 2022 GitHub,