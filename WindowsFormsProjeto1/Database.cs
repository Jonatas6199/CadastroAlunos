using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsProjeto1.Model;

namespace CadastroAlunos
{
    public static class Database
    {
        public static bool SalvarAluno(AlunoModel aluno)
        {
            string stringDeConexao = "Server=localhost;Port=3306;User Id=root" +
                "; database=ti_113_windowsforms;";
            MySqlConnection conexao = new MySqlConnection(stringDeConexao);
            conexao.Open();

            string query = "insert into Alunos (Nome, NumeroMatricula, Cpf," +
                "Telefone,DataNascimento,NomeDaMae,Email)" +
                " values(@nome, @numeroMatricula, @cpf, @telefone, " +
                "@dataNascimento, @nomeDaMae, @email)";
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@nome", aluno.Nome);
            cmd.Parameters.AddWithValue("@numeroMatricula", aluno.NumeroMatricula);
            cmd.Parameters.AddWithValue("@cpf", aluno.CPF);
            cmd.Parameters.AddWithValue("@telefone", aluno.Telefone);
            cmd.Parameters.AddWithValue("@dataNascimento", aluno.DataNascimento);
            cmd.Parameters.AddWithValue("@nomeDaMae", aluno.NomeDaMae);
            cmd.Parameters.AddWithValue("@email", aluno.Email);
            int quantidade =cmd.ExecuteNonQuery();
            conexao.Close();
            if (quantidade == 0)
                return false;
            else
                return true;
        }

        public static bool SalvarEndereco(EnderecoModel endereco) 
        {
            string stringDeConexao = "Server=localhost;Port=3306;User Id=root" +
              "; database=ti_113_windowsforms;";
            MySqlConnection conexao = new MySqlConnection(stringDeConexao);
            conexao.Open();

            string query = "insert into EnderecoAluno (Logradouro, Numero, Cep," +
                "Bairro,Complemento,Cidade,Estado,Pais)" +
                " values(@logradouro, @numero, @cep, @bairro, " +
                "@complemento, @cidade, @estado, @pais)";
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@logradouro", endereco.Logradouro);
            cmd.Parameters.AddWithValue("@numero", endereco.Numero);
            cmd.Parameters.AddWithValue("@cep", endereco.Cep);
            cmd.Parameters.AddWithValue("@bairro", endereco.Bairro);
            cmd.Parameters.AddWithValue("@complemento", endereco.Complemento);
            cmd.Parameters.AddWithValue("@cidade", endereco.Cidade);
            cmd.Parameters.AddWithValue("@estado", endereco.Estado);
            cmd.Parameters.AddWithValue("@pais", endereco.Pais);
            int quantidade = cmd.ExecuteNonQuery();
            conexao.Close();

            if(quantidade == 0)
                return false;
            else
                return true;
        }
    }
}
