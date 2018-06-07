using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Treino
    {
        public int IdAluno { get; set; }
        public string IdInstrutor { get; set; }
        public string TipoTreino { get; set; }
        public string Duração { get; set; }
        public List<Exercicio> exercicios { get; set; }
       

    }
}
