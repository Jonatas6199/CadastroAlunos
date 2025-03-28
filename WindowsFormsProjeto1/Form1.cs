using CadastroAlunos;
using System.ComponentModel;
using WindowsFormsProjeto1.Model;

namespace WindowsFormsProjeto1
{
    public partial class Form1 : Form
    {
        //variável para saber qual o idEnderecoAluno que foi cadastrado.
        private int IdEnderecoAlunoAuxiliar;
        public Form1()
        {
            InitializeComponent();
            IdEnderecoAlunoAuxiliar = 0;
            AtualizaLista();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarEndereço();
            SalvarAluno();
            //LimparCampos();
            LimparCampos(tabControl1);
        }
        public void LimparCampos()
        {
            txtNome.Clear();
            txtLogradouro.Clear();
            txtNomeDaMae.Clear();
            txtBairro.Clear();
            txtCPF.Clear();
            txtCelular.Clear();
            txtDataNascimento.Clear();
            txtEmail.Clear();
            txtNumero.Clear();
            txtCep.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtPaís.Clear();
            txtComplemento.Clear();
        }
        public void LimparCampos(Control control)
        {
            foreach (Control elemento in control.Controls)
            {
                if (elemento is Panel)
                {
                    foreach (Control subElemento in elemento.Controls)
                    {
                        if (subElemento is TextBox)
                            ((TextBox)subElemento).Clear();
                        else if (subElemento is MaskedTextBox)
                            ((MaskedTextBox)subElemento).Clear();
                    }
                }
            }
        }


        public bool SalvarEndereço()
        {
            EnderecoModel novoEndereco = new EnderecoModel();
            novoEndereco.Logradouro = txtLogradouro.Text;

            novoEndereco.Numero = Convert.ToInt32(txtNumero.Text);

            novoEndereco.Complemento = txtComplemento.Text;

            novoEndereco.Cep = txtCep.Text;

            novoEndereco.Bairro = txtBairro.Text;

            novoEndereco.Cidade = txtCidade.Text;

            novoEndereco.Estado = txtEstado.Text;

            novoEndereco.Pais = txtPaís.Text;

            bool resultado = Database.SalvarEndereco(novoEndereco, out IdEnderecoAlunoAuxiliar);
            return resultado;
        }

        public bool SalvarAluno()
        {
            AlunoModel novoAluno = new AlunoModel();
            novoAluno.Nome = txtNome.Text;

            string cpf = txtCPF.Text.Replace("-", "");
            cpf = cpf.Replace(",", "");
            novoAluno.CPF = cpf;

            novoAluno.Email = txtEmail.Text;

            string telefone = txtCelular.Text.Replace("(", "");
            telefone = telefone.Replace(")", "");
            telefone = telefone.Replace("-", "");
            novoAluno.Telefone = telefone;

            novoAluno.DataNascimento = Convert.ToDateTime(txtDataNascimento.Text);

            novoAluno.NomeDaMae = txtNomeDaMae.Text;

            Random geraNumeroAleatorio = new Random();
            int numeroAleatorio = geraNumeroAleatorio.Next(1, 1000000);
            novoAluno.NumeroMatricula = numeroAleatorio.ToString();

            novoAluno.IdEnderecoAluno = IdEnderecoAlunoAuxiliar;
            return Database.SalvarAluno(novoAluno);
        }

        private bool ValidaNome(string nome)
        {
            if (nome == null || nome.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool ValidaCpf(string cpf)
        {
            cpf = cpf.Remove(3, 1);
            cpf = cpf.Remove(6, 1);
            cpf = cpf.Remove(9, 1);
            if (cpf == null || cpf.Trim() == "" || !cpf.All(char.IsDigit) || cpf.Length != 11)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private bool ValidaDataNascimento(string dataNascimento)
        {
            if (string.IsNullOrEmpty(dataNascimento))
                return false;

            DateTime hoje = DateTime.Today;
            DateTime nascimento = Convert.ToDateTime(dataNascimento);

            if (nascimento > hoje)
                return false;

            return true;
        }

        private bool ValidaDataNascimento2(string dataNascimento)
        {
            //Verifica se o valor que vem na data de nascimento é vazio ou nulo
            if (string.IsNullOrEmpty(dataNascimento))
                return false;

            //Utiliza a estrutura DateTime para buscar o valor da data de hoje e armazenar na variável hoje
            DateTime hoje = DateTime.Today;
            DateTime nascimento;

            //Executa o método TryParse, que tenta converter o valor dataNascimento, que é uma string
            //em uma data, caso dê sucesso, irá armazenar o valor da dataNascimento na variável nascimento.
            bool sucesso = DateTime.TryParse(dataNascimento, out nascimento);

            //Verifica se a conversão de data foi bem sucedida e se a data de nascimento é maior que a data de hoje.
            if (!sucesso || nascimento > hoje)
                return false;

            return true;
        }


        private bool ValidaEmail(string email)
        {
            if (!email.Contains("@"))
                return false;

            int posicaoDoArroba = email.IndexOf("@");

            if (posicaoDoArroba > 0)
            {
                string restanteDoEmail = email.Substring(posicaoDoArroba + 1);

                if (restanteDoEmail.Length > 1 &&
                restanteDoEmail[0] != '.' &&
                !restanteDoEmail.Contains("@") &&
                restanteDoEmail.Contains("."))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            return false;

        }


        private void txtPaís_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                MessageBox.Show("Apertou o Enter");
            }
        }

        public void AtualizaLista()
        {
            List<AlunoModel> alunos = Database.GetAlunos();
            List<EnderecoModel> enderecoModels = Database.GetEnderecos();

            foreach (AlunoModel aluno in alunos)
            {
                ListViewItem registro = new ListViewItem(aluno.Nome);
                registro.SubItems.Add(aluno.NumeroMatricula);
                registro.SubItems.Add(aluno.DataNascimento.ToString());

                //Pega o endereço do aluno
                EnderecoModel enderecoAluno = enderecoModels.First(
                        endereco => endereco.Id == aluno.IdEnderecoAluno);

                registro.SubItems.Add(enderecoAluno.Logradouro);
                registro.SubItems.Add(enderecoAluno.Estado);
                lvRegistros.Items.Add(registro);

            }

        }

        private void lvRegistros_Click(object sender, EventArgs e)
        {
            Detalhes_Cadastro detalhes_Cadastro = new Detalhes_Cadastro();
            detalhes_Cadastro.ShowDialog();
        }
    }
}
