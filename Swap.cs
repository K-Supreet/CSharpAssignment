

namespace ConsoleApp33
{
    internal class Swap
    {
        public static void Swapnumber(ref int a, ref int b)
        {
            a += b;
            b = a - b;
            a -= b;
        }
        public static void Main()
        {
            int a = 30;
            int b = 40;
            Console.WriteLine($"Before Swap a={a} b={b}");
            Swapnumber(ref a, ref b);
            Console.WriteLine($"After Swap a={a} b={b}");
        }
    }
}
