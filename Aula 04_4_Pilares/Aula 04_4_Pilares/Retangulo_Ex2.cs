using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_4_Pilares
{
    internal class Retangulo_Ex2
    {
        //variavel 
        public double Largura;
        public double Altura;
        public double Area;
        //construtor da classe

        public Retangulo_Ex2()
        {
            Largura = 0;
            Altura = 0;

        }

        //metodo publico retorno do texto da placa
        public string Areas()
        {
            Area = Largura * Altura;
            return Convert.ToString(Area);
        }


    }
}
