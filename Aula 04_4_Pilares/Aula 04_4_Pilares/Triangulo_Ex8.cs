using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_4_Pilares
{
    internal class Triangulo_Ex8
    {
        //variavel 

        public double ladA;
        public double ladB;
        public double ladC;
        public double peri;

        public Triangulo_Ex8() 
        { 
            ladA = 0.0; 
            ladB = 0.0;
            ladC = 0.0;
        }

        public string Peris()
        {
            peri = ladA + ladB + ladC;
            return Convert.ToString(peri);
        }


    }


}