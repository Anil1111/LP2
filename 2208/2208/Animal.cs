using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2208
{
    class Animal
    {
        private String nome, apelido;
        private bool selvagem;
        private Pessoa dono; 

        public String Comunicar()
        {
            return (Nome+" Meow!");
        }

        public void Brincar()
        {
            Console.WriteLine(Nome+" está brincando.");
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Apelido
        {
            get { return apelido; }
            set { apelido = value; }
        }

        public bool Selvagem
        {
            get { return selvagem; }
            set { selvagem = value; }
        }

        public Pessoa Dono
        {
            get { return dono; }
            set { dono = value; }
        }
    }
}
