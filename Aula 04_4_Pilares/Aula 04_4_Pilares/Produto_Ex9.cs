using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_4_Pilares
{
    internal class Produto_Ex9
    {
        //variavel 
        public string[] nome = new string[5] { "Coca-Cola", "Banana", "Cookies", "Picanha", "Vinho" };
        public double[] preco = new double[5] {6.05, 3.25, 5.99, 100.00, 40.55};
        public string[] nome1 = new string[5];
        public string[] preco1 = new string[5];
        public string[] desc = new string[5];
        public double[] desc1 = new double[5];

        public double[] Preco_com_desc()
        {
            for (int i = 0; i < nome.Length; i++)
            {
                nome1[i] += nome[i];
            }

            for (int i = 0; i < preco.Length; i++)
            {
                preco1[i] += preco[i];
            }
            for (int i = 0; i < nome1.Length; i++)
            {
                desc[i] = nome1[i] + "\n\nPreço: R$" + preco1[i];


            }
            for (int i = 0; i < preco.Length; i++)
            {
                desc1[i] = preco[i] - preco[i] * 0.10;
                
            }


            return desc1;

        }
    }
}