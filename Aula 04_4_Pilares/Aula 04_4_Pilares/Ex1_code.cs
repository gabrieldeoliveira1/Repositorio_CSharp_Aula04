namespace Aula_04_4_Pilares
{
    public partial class Ex1_code : Form
    {
        public Ex1_code()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //instanciando a classe veiculo
            //criando um novo veiculo chamado ve
            Pessoa pe= new Pessoa();
            pe.nome = "Gabriel de Oliveira";
            pe.idade = 5;
            MessageBox.Show("Nome = " + pe.nome);
            //recebe o metodo de acesso a variavel apresentação
            MessageBox.Show("Apresentação = " + pe.Apresentacao());
        }
    }
}
