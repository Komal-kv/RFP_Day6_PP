using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assign06_PP
{
    internal class Class1
    {
        public static void Fibonacci_Iterative(int n)
        {
            int a = 0, b = 1, c = 0;
            Console.WriteLine("{0} {1} ",a, b);

            for (int i = 2; i < n; i++)
            {
                c = a + b;
                Console.WriteLine("{0}", c);

                a = b;
                b = c;
            }
        }
    }
}
