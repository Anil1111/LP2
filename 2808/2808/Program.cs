using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2808
{
    class Program
    {
        static void Main(string[] args)
        {
            Circulo c1 = new Circulo();
            Circulo c2 = new Circulo(10, 15, 4);

            Retangulo r1 = new Retangulo(5, 5, 10, 20);

            Triangulo t1 = new Triangulo(3,3,10,20);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(r1);
            Console.WriteLine(t1);

            Console.WriteLine(c1.Area());
            Console.WriteLine(c2.Area());
            Console.WriteLine(r1.Area());
            Console.WriteLine(t1.Area());

            Console.Read();
        }
    }
}
