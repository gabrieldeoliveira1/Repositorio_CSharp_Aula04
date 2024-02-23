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
    public partial class Ex10_code : Form
    {
        public Ex10_code()
        {
            InitializeComponent();
        }

        private void Ex_10_Load(object sender, EventArgs e)
       {
            Funcionario_Ex10 sf = new Funcionario_Ex10();
            double[] valor = sf.Salario_anual();
            for (int i = 0; i < sf.desc.Length; i++)
            {
                MessageBox.Show("Nomes: " + sf.nome[i] + "\n\nSalário Anual: " + valor[i]);
            }



        }
    }
}


