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
    public partial class Ex3_code : Form
    {
        public Ex3_code()
        {
            InitializeComponent();
        }

        private void Ex3_code_Load(object sender, EventArgs e)
        {
            //instanciando a classe veiculo
            //criando um novo veiculo chamado ve
            ContaBancaria_Ex3 cb = new ContaBancaria_Ex3();
            cb.saldo = 30;
            cb.limite = 50;
            cb.saque = 80;
            cb.deposit = 6;
            MessageBox.Show("O saldo, o limite, o saque e depósito são de : " + cb.saldo.ToString() + ", " + cb.limite.ToString() + ", " + cb.saque.ToString() + ", " + cb.deposit.ToString());
            if (cb.saldo > cb.limite) {
                MessageBox.Show("Não foi possivel concluir a ação, seu saldo é maior do que o limite.");
            } else
            {
                //recebe o metodo de acesso a variavel apresentação
                MessageBox.Show("O novo saldo é de: = " + cb.Newsaldos());
            }

            if (cb.saque > cb.limite)
            {
                MessageBox.Show("Você quer o que parça, vc está tentando tirar mais dinheiro do que você tem. Vai fazer um empréstimo meu consagrado.");
            }
        }
    }
}
