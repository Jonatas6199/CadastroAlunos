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
        public static void SalvarAluno(AlunoModel aluno)
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
            cmd.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
