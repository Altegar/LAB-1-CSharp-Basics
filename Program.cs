// Сушинський Ігор
// Лабораторна робота № 1
// Функції, що містять аритметичний вираз.
// Варіант 3

namespace LAB_1_CSharp
{
    internal class Program
    {
        private static double k1(double x, double y)
        {
            return Math.Sin(x) / (Math.Pow(x, 2) + Math.Pow(y, 2)) + Math.Cos(y) / (1 + Math.Abs(x * y));
        }

        private static void k2(double x, double y, ref double z)
        {
            z = Math.Sin(x) / (Math.Pow(x, 2) + Math.Pow(y, 2)) + Math.Cos(y) / (1 + Math.Abs(x * y));
        }

        private static void k3(double x, double y, out double z)
        {
            z = Math.Sin(x) / (Math.Pow(x, 2) + Math.Pow(y, 2)) + Math.Cos(y) / (1 + Math.Abs(x * y));
        }

        private static void Main(string[] args)
        {
            Console.Write("p = ");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.Write("q = ");
            double q = Convert.ToDouble(Console.ReadLine());

            double f1 = (k1(1 + Math.Pow(p, 2), 1 - Math.Pow(q, 2)) - Math.Pow(k1(1, p * q), 2)) / (1 + k1(p * q, 1));
            Console.WriteLine($"f = {f1}");

            double r1 = 0, r2 = 0, r3 = 0;
            k2(1 + Math.Pow(p, 2), 1 - Math.Pow(q, 2), ref r1);
            k2(1, p * q, ref r2);
            k2(p * q, 1, ref r3);
            double f2 = (r1 - Math.Pow(r2, 2)) / (1 + r3);
            Console.WriteLine($"f = {f2}");

            double t1, t2, t3;
            k3(1 + Math.Pow(p, 2), 1 - Math.Pow(q, 2), out t1);
            k3(1, p * q, out t2);
            k3(p * q, 1, out t3);
            double f3 = (t1 - Math.Pow(t2, 2)) / (1 + t3);
            Console.WriteLine($"f = {f3}");
        }

        /*static double f1(double x, double y)
        {
            return Math.Sin(x) + Math.Cos(y);
}
        static void f2(double x, double y, ref double z)
        {
            z = Math.Sin(x) + Math.Cos(y);
        }

        static void f3(double x, double y, out double z)
        {
            z = Math.Sin(x) + Math.Cos(y);
        }

        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());

            double c1 = (f1(1, a) + f1(b, 2)) / (1 + f1(a, b));
            Console.WriteLine("c = " + c1);

            double r1 = 0, r2 = 0, r3 = 0;
            f2(1, a, ref r1);
            f2(b, 2, ref r2);
            f2(a, b, ref r3);
            double c2 = (r1 + r2) / (1 + r3);
            Console.WriteLine("c = " + c2);

            double t1, t2, t3;
            f3(1, a, out t1);
            f3(b, 2, out t2);
            f3(a, b, out t3);
            double c3 = (t1 + t2) / (1 + t3);
            Console.WriteLine("c = " + c3);
        }*/
    }
}