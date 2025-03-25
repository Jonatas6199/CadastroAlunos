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
        public int NumeroMatricula { get; set; }
        public Int64 CPF { get; set; }
        public Int64 Telefone { get; set; }
        public EnderecoModel EnderecoAluno { get; set; } 
        public DateTime DataNascimento { get; set; }
        public string NomeDaMae { get; set; }
        public string Email { get; set; }

    }
}
