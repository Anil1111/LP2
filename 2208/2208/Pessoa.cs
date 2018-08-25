using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2208
{
    class Pessoa
    {
        private const int max = 10;
        private String nome, profissao;
        private int idade;
        private long identidade;
        private Animal [] pet = new Animal[max];
        private int qttd = 0;

        public String Falar()
        {
            return (Nome+"Chocolate!");
        } 

        public void Trabalhar(int horas)
        {
            Console.WriteLine(Nome+" trabalhou "+horas+" horas."); 
        }

        public void Comer()
        {
            Console.WriteLine(Nome+" está comendo chocolate!");
        } 

        public void Add(Animal a)
        {
            if (qttd < max)
            {
                pet[qttd] = a;
                qttd++;
            }
            else
            {
                Console.WriteLine("Sem espaço!!!!!!");
            }
        }

        public void Remove(Animal a)
        {
            for(int i=0; i< qttd; i++)
            {            
                 pet[i] = pet[i + 1];                   
                 qttd--;
                 break;     
                             
            }
        }

        public void SizeOf()
        {
            Console.WriteLine(nome+" tem "+qttd+" pet!");
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Profissao
        {
            get { return profissao; }
            set { profissao = value; }
        }

        public int Idade
        {
            get { return idade; }
            set { idade = value; }
        }

        public long Identidade
        {
            get { return identidade; }
            set { identidade = value; }
        }



    }
}
