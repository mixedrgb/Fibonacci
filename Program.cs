using System.Globalization;

namespace Fibonacci
{
    public class Program
    {
        static void Main()
        {
            int a = 1;
            int b = 1;
            int c = 0;
            while (a < 100)
            {
                Console.WriteLine(a);
                c = a + b; // i is 2
                a = b; // j is 2
                b = c;
                // 1, 2, 3, 5, 8, 13, 21, 34
                // 
            }
        }
    }
}