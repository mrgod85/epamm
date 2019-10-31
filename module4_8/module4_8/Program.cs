using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace module4_8
{
    class Program
    {
        
        static void Main()
        {
            Double a, b, c = 0, fa, fb, fc, Eps;
            Int32 Lich = 0;
            Console.Write("Enter a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter b: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Eps: ");
            Eps = Convert.ToDouble(Console.ReadLine());
            fa = f(a);
            fb = f(b);
            if (Math.Abs(fa) < Eps)
            {
                Lich = 1;
                c = a;
                goto m;
            }
            else
                 if (Math.Abs(fb) < Eps)
            {
                Lich = 1;
                c = b;
                goto m;
            }
            else
                     if (fa * fb > 0)
            {
                Console.WriteLine("No roots inside this interval!!!");
                goto m2;
            }
            Lich = 0;
            do
            {
                c = (a + b) / 2;
                fc = f(c);
                Lich++;
                if (Math.Abs(f(c)) < Eps) break;
                if (fa * fc > 0) { a = c; }
                else b = c;
            } while ((b - a > Eps) && (fa * fb < 0));
        m: Console.WriteLine("Root: {0}  podiliv: {1}", c, Lich);
        m2: Console.Read();
        }
        static Double f(Double x)
        {
            return x * x - 4;
        }
    }
}
