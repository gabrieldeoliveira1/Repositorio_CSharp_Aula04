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
    public partial class Ex8_code : Form
    {
        public Ex8_code()
        {
            InitializeComponent();
        }

        private void Ex8_code_Load(object sender, EventArgs e)
        {

            Triangulo_Ex8 tr = new Triangulo_Ex8();
            tr.ladA = 5.5;
            tr.ladB = 4.7;
            tr.ladC = 7.8;
            MessageBox.Show("Os lados ABC são respectivamente: " + "\n\n" + tr.ladA.ToString() + "\n" + tr.ladB.ToString() + "\n" + tr.ladC.ToString());
            MessageBox.Show("O perímetro é de: = " + tr.Peris());
        }
    }
}
