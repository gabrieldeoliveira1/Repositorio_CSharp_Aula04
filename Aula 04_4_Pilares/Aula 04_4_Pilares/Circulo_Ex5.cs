using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_4_Pilares
{
    internal class Circulo
    {
        //variavel 
        public double raio;
        public double diam;
        public double calc;
        

        public Circulo()
        {
            raio = 0;
   
        }

        
        public string calcss()
        {
            calc = raio * 2; 
            return Convert.ToString(calc);
        }


    }
}