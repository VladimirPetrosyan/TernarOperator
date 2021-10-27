using System;

namespace TernarOperator
{
    class Program
    {
         static void Main(string[] args)
        {
            int a, b, c, m;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            m=(a < b && a<c) ? (b < c && b<a) ? a : b : c;
            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}
