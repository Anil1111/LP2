using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2208
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Pessoa p3 = new Pessoa();

            Animal pet1 = new Animal();
            Animal pet2 = new Animal();
            Animal pet3 = new Animal();
            Animal pet4 = new Animal();
            Animal pet5 = new Animal();

            pet1.Nome = "Kyo";
            pet1.Apelido = "Fedorento";
            pet1.Dono = p1;
            pet1.Selvagem = true;

            pet2.Nome = "Melancia";
            pet2.Apelido = "Mel";
            pet2.Dono = p1;
            pet2.Selvagem = false;

            p1.Nome = "Myllena";
            p1.Idade = 20;
            p1.Identidade = 123456;
            p1.Profissao = "Designer";

            p1.Trabalhar(12);
            p1.Add(pet1);
            p1.Add(pet2);
            

            Console.Read();
        }
    }
}
