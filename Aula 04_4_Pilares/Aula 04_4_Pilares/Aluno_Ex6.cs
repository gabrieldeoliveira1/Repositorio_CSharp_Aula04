using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_4_Pilares
{
    internal class Aluno
    {
        //variavel 
        public string[] nome = new string[1] { "Gabriel"};
        public double[] notas = new double[4] {7, 8, 8.9, 9.5};
        public double media;
        public double soma;



        public string medias()
        {
            for (int i = 0; i < notas.Length; i++)
            {
                soma += notas[i];
            }

            media = soma / notas.Length;
            return Convert.ToString(media);
            
        }
    }
}


        