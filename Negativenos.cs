// See https://aka.ms/new-console-template for more information

namespace ConsoleApp2
{
    internal class negativenumbers
    {
        public static void Main()
        {
            int[] arr = { 60, 25, -21 , 3, -85, 32 };
            int i, n;
            n = arr.Length;
            for (i = 1; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    Console.Write($"{arr[i]}");
                }

            }
        }
    }
}