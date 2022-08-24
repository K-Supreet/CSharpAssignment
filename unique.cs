using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    class UniqueElements
    {
        public static void Main()


        {
            int[] items = { 522, 333, 854, 4865, 333, 563, 546, 235,5694, 148 };
            int n = items.Length;

            Console.WriteLine("Unique array elements are: ");

            for (int i = 0; i < n; i++)
            {
                bool Same = false;
                for (int j = 0; j < i; j++)
                {
                    if (items[i] == items[j])
                    {
                        Same = true;
                        break;
                    }
                }

                if (!Same)
                {
                    Console.WriteLine(items[i]);

                }
            }

            Console.ReadLine();
        }
    }
}