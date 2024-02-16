using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_4_Pilares
{
    internal class ContaBancaria_Ex3
    {
        //variavel 
        public double saldo;
        public double limite;
        public double saque;
        public double deposit;
        public double newsaldo;
        //construtor da classe

        public ContaBancaria_Ex3()
        {
            saldo = 0;
            limite = 0;
            saque = 0;
            deposit = 0;

        }

        //metodo publico retorno do texto da placa
        public string Newsaldos()
        {
            newsaldo = (saldo + deposit);
            newsaldo -= saque;
            return Convert.ToString(newsaldo);
        }


    }
}
