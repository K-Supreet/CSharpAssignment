

namespace ConsoleApp33
{
         internal class Minimummaximum
        {
            public static void Main()
            {
                int[] arr = { 14, 82, 9, 69, 35, 65 };
                int i, max, min, n;
    
                n = arr.Length;
                max = arr[0];
                min = arr[0];
                for (i = 1; i < n; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                    if (arr[i] < min)
                    {
                        min = arr[i];
                    }
                }
                Console.Write("Maximum number = {0}\n", max);
                Console.Write("Minimum number = {0}\n", min);
            }
        }
    }