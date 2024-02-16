using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_4_Pilares
{
    internal class Veiculo
    {
        //variavel 
        public string chassi;
        private string modelo;
        protected string placa;
        //construtor da classe

        public Veiculo()
        {
            modelo = "";
        
        }

        //metodo publico retormp fo texto da placa
        public string setPlaca()
        {
            placa = "AXD4232";
            return placa; 
        }
    }
}
