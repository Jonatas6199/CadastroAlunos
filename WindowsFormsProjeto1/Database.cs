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
        private static string stringDeConexao = "Server=localhost; port=3307;User ID=root;Password=root;Database=ti_113_windowsforms;AllowUserVariables=True";
        public static bool SalvarAluno(AlunoModel aluno)
        {
            MySqlConnection conexao = new MySqlConnection(stringDeConexao);
            conexao.Open();

            string query = "insert into Alunos (Nome, NumeroMatricula, Cpf," +
                "Telefone,DataNascimento,NomeDaMae,Email, IdEnderecoAluno)" +
                " values(@nome, @numeroMatricula, @cpf, @telefone, " +
                "@dataNascimento, @nomeDaMae, @email, @idEnderecoAluno)";
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = query;
            cmd.Parameters.AddWithValue("@nome", aluno.Nome);
            cmd.Parameters.AddWithValue("@numeroMatricula", aluno.NumeroMatricula);
            cmd.Parameters.AddWithValue("@cpf", aluno.CPF);
            cmd.Parameters.AddWithValue("@telefone", aluno.Telefone);
            cmd.Parameters.AddWithValue("@dataNascimento", aluno.DataNascimento);
            cmd.Parameters.AddWithValue("@nomeDaMae", aluno.NomeDaMae);
            cmd.Parameters.AddWithValue("@email", aluno.Email);
            cmd.Parameters.AddWithValue("@idEnderecoAluno", aluno.IdEnderecoAluno);
            int quantidade =cmd.ExecuteNonQuery();
            conexao.Close();
            if (quantidade == 0)
                return false;
            else
                return true;
        }

        public static bool SalvarEndereco(EnderecoModel endereco, out int idEndereco) 
        {
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
            idEndereco = Convert.ToInt32(cmd.LastInsertedId);
            conexao.Close();

            if(quantidade == 0)
                return false;
            else
                return true;
        }

        public static List<AlunoModel> GetAlunos()
        {
            MySqlConnection conexao = new MySqlConnection(stringDeConexao);
            conexao.Open();

            string query = "select * from alunos";
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = query;

            MySqlDataReader sqlDataReader = cmd.ExecuteReader();

            List<AlunoModel> alunos = new List<AlunoModel>();
            while (sqlDataReader.Read()) 
            {
                alunos.Add(new AlunoModel
                {
                    Nome = sqlDataReader.GetString("Nome"),
                    NumeroMatricula = sqlDataReader.GetString("NumeroMatricula"),
                    CPF = sqlDataReader.GetString("Cpf"),
                    Telefone = sqlDataReader.GetString("Telefone"),
                    DataNascimento = sqlDataReader.GetDateTime("DataNascimento"),
                    NomeDaMae = sqlDataReader.GetString("NomeDaMae"),
                    Email = sqlDataReader.GetString("Email"),
                    IdEnderecoAluno = sqlDataReader.GetInt32("IdEnderecoAluno")
                });
            }
            return alunos;
        }

        public static List<EnderecoModel> GetEnderecos()
        {
            MySqlConnection conexao = new MySqlConnection(stringDeConexao);
            conexao.Open();

            string query = "select * from enderecoaluno";
            MySqlCommand cmd = conexao.CreateCommand();
            cmd.CommandText = query;

            MySqlDataReader sqlDataReader = cmd.ExecuteReader();

            List<EnderecoModel> enderecos = new List<EnderecoModel>();
            while (sqlDataReader.Read())
            {
                enderecos.Add(new EnderecoModel
                {
                    Id = sqlDataReader.GetInt32("Id"),
                    Logradouro = sqlDataReader.GetString("Logradouro"),
                    Numero = sqlDataReader.GetInt32("Numero"),
                    Cep = sqlDataReader.GetString("Cep"),
                    Bairro = sqlDataReader.GetString("Bairro"),
                    Complemento = sqlDataReader.GetString("Complemento"),
                    Cidade = sqlDataReader.GetString("Cidade"),
                    Estado = sqlDataReader.GetString("Estado"),
                    Pais = sqlDataReader.GetString("Pais"),
                });
            }
            return enderecos;
        }


    }
}
