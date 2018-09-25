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
            //Console.WriteLine(p.Evaluate(2));
        }
    }

    class Polynomial
    {
        public int Degree;
        double[] liste;

        public Polynomial(double[] table)
        {
            liste = table;
            Degree = liste.Length - 1;
        }

        ////public double Evaluate(int x)
        //{
            
        //}

        public override string ToString()
        {
            string result = "";
            int n = Degree;
            for (int i = 0; i <=Degree ; i++)
            {
                if (liste[i] == 0)
                {
                    result += "";
                }
                else if (n == Degree)
                {
                    result += liste[i] + "x^" + n;
                }
                else if (n>0)
                {
                    result += "+ " + liste[i] + "x^" + n;
                }
                else if (n == 0)
                {
                    result += "+ " + liste[i];
                }
                n--;
            }
            return result;
        }

    }
}
