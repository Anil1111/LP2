using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProva
{
    class Bank
    {
        const int max = 2;
        private int numContas = 0;
        private int number;
        private Account[] accounts = new Account[max];

        public void Add(Account a)
        {
            if (numContas < max)
            {
                accounts[numContas++] = a;
            }
            else
                Console.WriteLine("Nao foi possivel add uma nova conta");
        }

        public void Remove(Account a)
        {
            int idx = -1;
            for (int i = 0; i < numContas; i++)
                if (accounts[i] == a)
                    idx = i;

            if (idx >= 0)
            {
                for (int i = idx; i < numContas - 1; i++)
                    accounts[i] = accounts[i + 1];

                accounts[numContas - 1] = null;
            }

        }


        //propriedades
        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                Console.WriteLine("Numero do banco invalido. Digite valor positivo");
                number = value >=0?value:0;
            }
        }
    }
}
