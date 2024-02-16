using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_4_Pilares
{
    internal class Pessoa 
    {
        //variavel 
        public string nome;
        public Int32 idade;
        public string Apresentar;
        //construtor da classe

        public Pessoa()
        {
            nome = " ";
            idade = 0;
        
        }

        //metodo publico retorno do texto da placa
        public string Apresentacao()
        {
            Apresentar = nome + ", " + idade;   
            return Apresentar; 
        }
        

    }
}
