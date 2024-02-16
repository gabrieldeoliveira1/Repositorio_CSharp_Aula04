namespace Aula_04_4_Pilares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instanciando a classe veiculo
            //criando um novo veiculo chamado ve
            Veiculo ve= new Veiculo();
            ve.chassi = "5462782528";
            MessageBox.Show("Chassi = " + ve.chassi);
            //recebe o metodo de acesso a variavel placa
            MessageBox.Show("Placa = " + ve.setPlaca());
        }
    }
}
