using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_04_4_Pilares
{
    public partial class Ex7_code : Form
    {
        public Ex7_code()
        {
            InitializeComponent();
        }

        private void Ex7_code_Load(object sender, EventArgs e)
        {
            Carro v1 = new Carro();
            string[] valor = v1.descricao();
            for(int i = 0; i < v1.desc.Length; i++)
            {
                MessageBox.Show("Descrição: " + valor[i]);
            }

           
           
        }
    }
}
