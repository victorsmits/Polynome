using System;
class Polynomial
{
    public int Degree;
    double[] liste;

    public Polynomial(double[] table)
    {
        liste = table;
        this.Degree = liste.Length - 1;
    }

    public override string ToString()
    {
        string result = "";
        int n = Degree;

        for (int i = 0; i <= Degree; i++)
        {
            if (liste[i] == 0) { result += ""; }

            else if (n == Degree) { result += liste[i] + "x^" + n; }

            else if (n > 0) { result += "+ " + liste[i] + "x^" + n; }

            else if (n == 0) { result += "+ " + liste[i]; }
            n--;
        }
        return result;
    }

    public double Evaluate(double value)
    {
        double result = 0;
        for (int i = Degree; i >= 0; i--)
        {
            double resultx = liste[liste.Length - (i + 1)] * Math.Pow(value, i);
            result = result + resultx;
            Console.WriteLine($"degree {i} : {result} et {resultx}");
        }
        return result;
    }
}
