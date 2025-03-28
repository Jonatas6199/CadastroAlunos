using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsProjeto1.Model;

namespace CadastroAlunos
{
    public partial class Detalhes_Cadastro : Form
    {
        public Detalhes_Cadastro()
        {
            InitializeComponent();
        }
        public Detalhes_Cadastro(AlunoModel aluno, EnderecoModel endereco)
        {
            InitializeComponent();
            AdicionaLinhas();
            // Preenche os campos com os dados recebidos
            lblNome.Text = aluno.Nome;
            lblMatricula.Text = aluno.NumeroMatricula;
            lblCpf.Text = aluno.CPF;
            lblTelefone.Text = aluno.Telefone;
            lblNascimento.Text = aluno.DataNascimento.ToString("dd/MM/yyyy");
            lblNomeMae.Text = aluno.NomeDaMae;
            lblEmail.Text = aluno.Email;

            lblLogradouro.Text = endereco.Logradouro;
            lblNumero.Text = endereco.Numero.ToString();
            lblCep.Text = endereco.Cep;
            lblBairro.Text = endereco.Bairro;
            lblComplemento.Text = endereco.Complemento;
            lblCidade.Text = endereco.Cidade;
            lblEstado.Text = endereco.Estado;
            lblPais.Text = endereco.Pais;
        }

        public void AdicionaLinhas()
        {
            AddLabelRow(this.tableLayoutPanelAluno, "Nome:", this.lblNome, 0);
            AddLabelRow(this.tableLayoutPanelAluno, "Matrícula:", this.lblMatricula, 1);
            AddLabelRow(this.tableLayoutPanelAluno, "CPF:", this.lblCpf, 2);
            AddLabelRow(this.tableLayoutPanelAluno, "Telefone:", this.lblTelefone, 3);
            AddLabelRow(this.tableLayoutPanelAluno, "Data Nasc.:", this.lblNascimento, 4);
            AddLabelRow(this.tableLayoutPanelAluno, "Nome da Mãe:", this.lblNomeMae, 5);
            AddLabelRow(this.tableLayoutPanelAluno, "Email:", this.lblEmail, 6);

            AddLabelRow(this.tableLayoutPanelEndereco, "Logradouro:", this.lblLogradouro, 0);
            AddLabelRow(this.tableLayoutPanelEndereco, "Número:", this.lblNumero, 1);
            AddLabelRow(this.tableLayoutPanelEndereco, "CEP:", this.lblCep, 2);
            AddLabelRow(this.tableLayoutPanelEndereco, "Bairro:", this.lblBairro, 3);
            AddLabelRow(this.tableLayoutPanelEndereco, "Complemento:", this.lblComplemento, 4);
            AddLabelRow(this.tableLayoutPanelEndereco, "Cidade:", this.lblCidade, 5);
            AddLabelRow(this.tableLayoutPanelEndereco, "Estado:", this.lblEstado, 6);
            AddLabelRow(this.tableLayoutPanelEndereco, "País:", this.lblPais, 7);

        }

    }
}
