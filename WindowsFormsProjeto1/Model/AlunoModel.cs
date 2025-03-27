using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProjeto1.Model
{
    public class AlunoModel
    {
        public string Nome { get; set; }
        public string NumeroMatricula { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public int IdEnderecoAluno { get; set; }
        public DateTime DataNascimento { get; set; }
        public string NomeDaMae { get; set; }
        public string Email { get; set; }

    }
}
