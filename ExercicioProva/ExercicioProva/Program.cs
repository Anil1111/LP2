using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProva
{
    class Program
    {
        static void Main(string[] args)
        {
            Client c1 = new Client();
            Bank b1 = new Bank();
            Bank b2 = new Bank();
            Bank b3 = new Bank();

            Account ac1 = new Account(c1, b1, 123);
            Account ac2 = new Account(c1, b2, 123);
            Account ac3 = new Account(c1, b3, 123);

            c1.Add(ac1);
            c1.Add(ac2);
            c1.Add(ac3);

            c1.Remove(ac2);

            c1.Add(ac3);

            Console.Read();

        }
    }
}
