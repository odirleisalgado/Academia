using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Aluno:Pessoa
    {
       
        public int IdAvaliacao { get; set; }
        public int IdAluno { get; set; } //nro de identificação de cada aluno   
        public string TipoPlano { get; set; }
        

    }
}
