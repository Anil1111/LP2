using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicio
{
    class Cliente
    {
        private const int max = 10;
        private String nome;
        private long cpf;
        private Conta [] c = new Conta[max];       

        public void ListarContas()
        {
            Console.WriteLine(Nome+" tem: "+c);
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public long Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
    }
}
