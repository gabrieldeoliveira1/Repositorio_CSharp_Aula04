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
    public partial class Ex9_code : Form
    {
        public Ex9_code()
        {
            InitializeComponent();
        }

        private void Ex9_code_Load(object sender, EventArgs e)
        {
            Produto_Ex9 pr = new Produto_Ex9();
            double[] valor = pr.Preco_com_desc();
            for (int i = 0; i < pr.desc.Length; i++)
            {
                MessageBox.Show("Produtos: " + pr.nome[i] + "\n\nValor com desconto de 10%: " + valor[i]);
            }



        }
    }
}
