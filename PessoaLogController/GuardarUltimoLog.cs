using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PessoaLogController
{
    public class GuardarUltimoLog
    {

        public string ultimo;

        public static void GuardarLog(string nome) => ultimo = nome;

    }
}
