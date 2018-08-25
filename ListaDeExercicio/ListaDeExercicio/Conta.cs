using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicio
{
    class Conta
    {
        private long numConta, numAgencia;
        private int tempoConta;
        private double saldo, limite;
        private Cliente cli = new Cliente();
        private Banco b = new Banco();

        public bool Sacar(double valor, long senha)
        {
            long senhat = Console.Read();
        
                if (valor<=Saldo || senhat == senha)
                {
                    return true;
                }
                else
                {
                    return false;
                }
           
        }

        public void Depositar(double valor, long senha)
        {
            Console.WriteLine(cli.Nome+" digite o valor que vai ser depositado: ");
            valor = Console.Read();
        }

        public double SolicitarLimite(double valor, long senha)
        {
            return Limite;
        }

        public long NumConta
        {
            get { return numConta; }
            set { numConta = value;
            }
        }

        public long NumAgencia
        {
            get { return numAgencia; }
            set { numAgencia = value; }
        }

        public int TempoConta
        {
            get { return tempoConta; }
            set { tempoConta = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public double Limite
        {
            get { return limite; }       
            set { limite = value; }
        }


    }
}
