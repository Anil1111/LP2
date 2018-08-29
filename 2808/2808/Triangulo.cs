using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2808
{
    class Triangulo : Figura
    {
        private double baseT, altura;

        public Triangulo(int x, int y, double baseT, double altura) : base(x, y)
        {
            BaseT = baseT;
            Altura = altura;
        }

        public string GetTipo()
        {
            return "Triangulo retangulo";
        }

        public override double Area()
        {
            base.Area();

            return baseT * altura/2;
        }

        public override string ToString()
        {
            return base.ToString() + "Base: " + BaseT + " Altura: " + Altura;
        }

        public double Altura
        {
            get { return altura; }
            set { altura = value; }
        }
        public double BaseT
        {
            get { return baseT; }
            set { baseT = value; }
        }

    }
}
