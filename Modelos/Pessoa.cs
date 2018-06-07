using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public abstract class Pessoa
    {
        public int TipoAcesso { get; set; } //id que identifica o tipo de acesso da pessoa(aluno,recepcionista, professor)
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Cpf { get; set; }
        public char Sexo { get; set; }
        public string DtNascimento { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string Bairro { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string DataCadastro { get; set; }
    }
}
