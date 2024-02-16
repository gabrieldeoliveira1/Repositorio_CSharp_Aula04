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
    public partial class Ex5_code : Form
    {
        public Ex5_code()
        {
            InitializeComponent();
        }

        private void Ex5_code_Load(object sender, EventArgs e)
        {
            Circulo cr = new Circulo();
            cr.raio = 5;
            MessageBox.Show("O raio é: " + cr.raio);
            MessageBox.Show("O diametro é de: = " + cr.calcss());
        }
    }
}
