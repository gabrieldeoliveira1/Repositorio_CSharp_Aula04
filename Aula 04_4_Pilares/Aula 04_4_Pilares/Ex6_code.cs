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
    public partial class Ex6_code : Form
    {
        public Ex6_code()
        {
            InitializeComponent();
        }

        private void Ex6_code_Load(object sender, EventArgs e)
        {
            Aluno al = new Aluno();
             foreach (string i in al.nome)
            {
                MessageBox.Show(i);
            }
            int valor = al.notas.Length;
            for (int i = 0; i < valor; i++)
            {
                MessageBox.Show("Nota: " + al.notas[i].ToString());
            }
            MessageBox.Show("A média é de: " + al.medias());
        }
    }
}
