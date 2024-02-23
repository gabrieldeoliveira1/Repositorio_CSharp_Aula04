using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_4_Pilares
{
    internal class Funcionario_Ex10
    {
        //variavel 
        public string[] nome = new string[5] { "Gabriel", "Rafael", "Davi", "Salomão", "Paulo" };
        public double[] salarios = new double[5] { 1500.00, 2300.00, 3450.00, 5000.00, 6000.00 };
        public string[] nome1 = new string[5];
        public string[] salar1 = new string[5];
        public string[] desc = new string[5];
        public double[] desc1 = new double[5];

        public double[] Salario_anual()
        {
            for (int i = 0; i < nome.Length; i++)
            {
                nome1[i] += nome[i];
            }

            for (int i = 0; i < salarios.Length; i++)
            {
                salar1[i] += salarios[i];
            }
            for (int i = 0; i < nome1.Length; i++)
            {
                desc[i] = nome1[i] + "\n\nSalário" + salar1[i];


            }
            for (int i = 0; i < salarios.Length; i++)
            {
                desc1[i] = salarios[i] * 12;

            }


            return desc1;

        }
    }
}

