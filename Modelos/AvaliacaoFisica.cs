using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
   public class AvaliacaoFisica
    {
        public int IdAval { get; set; }
        public bool Peso { get; set; }
        public bool Altura { get; set; }
       // public bool BracoDiCm { get; set; }
       // public bool BracoEsCm { get; set; }
       // public bool PernaDiCm { get; set; }
       // public bool PernaEsCm { get; set; }
       // public bool CinturaCm { get; set; }
       // public bool QuadrilCm { get; set; }
       // public bool PeitoralCm { get; set; }
        public bool Imc { get; set; }
        public string Situacao { get; set; }



    }
}
