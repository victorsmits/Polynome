using System;

namespace Polynome
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Polynomial p = new Polynomial(new double[] { 1, 0, -2 });
            Console.WriteLine(p.Degree);
            Console.WriteLine(p);
            Console.WriteLine(p.Evaluate(4));
        }
    }
}
