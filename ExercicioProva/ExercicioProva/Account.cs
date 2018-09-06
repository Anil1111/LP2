using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProva
{
    class Account
    {
        private long number, agency;
        private double balance, availableCredit;
        private int password, accountTime;
        private Bank bank;
        private Client client;

        //construtor
        public Account(Client c, Bank b, int pwd)
        {
            client = c;
            bank = b;
            password = pwd;

        }

        public bool Withdraw(double amount, int pwd)
        {
            if(password == pwd && amount <= balance + availableCredit)
            {
                return true;
            }
            return true;
        }

        //propriedades
        public long Number
        {
            get
            {
                return number;
            }

            set
            {
                Console.WriteLine("Numero de conta invalido. Digite valor positivo");
                number = value >= 0 ? value : 0;
            }
        }

        public long Agency
        {
            get
            {
                return agency;
            }

            set
            {
                Console.WriteLine("Numero de conta invalido. Digite valor positivo");
                agency = value >= 0 ? value : 0;
            }
        }

        public int AccountTime
        {
            get
            {
                return accountTime;
            }

            set
            {
                accountTime = value >= 0 ? value : 0;
            }
        }
    }
}
