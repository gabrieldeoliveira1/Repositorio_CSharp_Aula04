using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_04_4_Pilares
{
    internal class Livro_Ex4
    {
        //variavel 
        public string titulo;
        public Int32 anopublicacao;
        public Int32 edicao;
        public string edicao1;

        //construtor da classe

        public Livro_Ex4()
        {
            titulo = " ";
            anopublicacao = 0;
            edicao = 0; 



        }

        //metodo publico retorno do texto da placa
        public string edicoes()
        {
            edicao1 = titulo + ", Ano da publicação: " + anopublicacao + " e a edição é: " + edicao;
            return edicao1;
        }


    }
}