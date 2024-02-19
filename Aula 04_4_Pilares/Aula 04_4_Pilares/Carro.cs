using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_4_Pilares
{
    internal class Carro
    {
        //variavel 
        public string[] marca = new string[5] { "Renault", "Subaru", "Toyota", "Mazda", "Porsche" };
        public string[] modelo = new string[5] { "Sandero", "Wrx_STI", "Corolla_GR", "Rx-7", "911-TurboS" };
        public string[] car = new string[5];
        public string[] car1 = new string[5];
        public string[] desc = new string[5];
  
     public string[] descricao()
        {
            for (int i = 0; i < marca.Length; i++)
            {
                car[i] += marca[i];
            }

            for (int i = 0; i < modelo.Length; i++)
            {
                car1[i] += modelo[i];
            }
            for(int i = 0; i < car1.Length; i++)
            {
                desc[i] = car[i] + ", Modelo: " + car1[i];
                

            }
            return desc;

        }
    }
}