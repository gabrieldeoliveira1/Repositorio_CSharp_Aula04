using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_04_4_Pilares
{
    public partial class Ex4_code : Form
    {
        public Ex4_code()
        {
            Livro_Ex4 lv = new Livro_Ex4();
            lv.titulo = "O mágico de Oz";
            lv.anopublicacao = 2018;
            lv.edicao = 5;
            MessageBox.Show("O título é: " + lv.titulo);
            MessageBox.Show("O ano da publicação e a edição do livro são: " + lv.anopublicacao.ToString() + ", " + lv.edicao.ToString());
            //recebe o metodo de acesso a variavel apresentação
            MessageBox.Show("Sobre o livro: = " + lv.edicoes());
        }
    }
}

