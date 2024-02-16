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
    public partial class Ex2_Retangulo : Form
    {
        public Ex2_Retangulo()
        {
            InitializeComponent();
        }

        private void Ex2_Retangulo_Load(object sender, EventArgs e)
        {
           
            Retangulo_Ex2 re = new Retangulo_Ex2();
            re.Largura = 4;
            re.Altura = 4;
            MessageBox.Show("A largura e a Altura são: " + re.Largura.ToString() + ", " + re.Altura.ToString());
            //recebe o metodo de acesso a variavel apresentação
            MessageBox.Show("A área é de: = " + re.Areas());
        }
    }
}
