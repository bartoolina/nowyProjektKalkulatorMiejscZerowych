using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nowyProjektKalkulatorMiejscZerowych
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2, x0;

            Console.WriteLine("Podaj trzy współczynniki aby obliczyć miejsca zerowe:");
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());

            delta = b * b - 4 * a * c;

            Console.WriteLine("Delta = {0}.", delta);

            x1 = -b - Math.Sqrt(delta) / 2 * a;
            x2 = -b + Math.Sqrt(delta) / 2 * a;
            x0 = -b / 2 * a;

            if (delta > 0)
            {
                Console.WriteLine("Miejsca zerowe to:\nx1 = {0}\nx2 = {1}", x1, x2);
            }
            else if (delta == 0)
            {
                Console.WriteLine("Miejsce zerowe to:\nx0 = {0}", x0);
            }
            else
            {
                Console.WriteLine("Brak miejsc zerowych.");
            }
            Console.ReadKey();
            {

            }
        }
    }
}
