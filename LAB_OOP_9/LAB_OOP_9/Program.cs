using System;

class Program
{
    static double LeftRectangle(Func<double, double> f, double a, double b, int n)
    {
        var h = (b - a) / n;
        var sum = 0d;
        for (var i = 0; i <= n - 1; i++)
        {
            var x = a + i * h;
            sum += f(x);
        }

        var result = h * sum;
        return result;
    }



    static void Main(string[] args)
    {
        double f(double x) => x / (x - 1);

        var result = LeftRectangle(f, 4, 10, 1000);
        Console.WriteLine("Формула лівих прямокутників: {0}", result);


        Console.ReadKey();
    }
}