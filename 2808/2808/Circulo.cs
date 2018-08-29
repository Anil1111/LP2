using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2808
{
    class Circulo : Figura
    {
        private double raio;

        public Circulo(int x,int y, double raio): base(x,y)
        {
            Raio = raio;
        }
        
        public Circulo(): base(0,0)
        {
            
        }

        public override string ToString()
        {
            return base.ToString()+ "Raio: "+Raio;
        }
        public override double Area()
        {
            base.Area();

            return Math.PI * Math.Pow(raio,2);           
        }
        public double Raio
        {
            get { return raio; }       
            set { raio = value; }
        }

        public double Diametro
        {
            get { return raio * 2; }          
        }
    }
}
