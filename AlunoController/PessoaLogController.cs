using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class PessoaLogController
    {
        public static int ultimoTipo;
        public static string ultimoUser;

        public static void UltimoLog(int tipo, string UserCpf)
        {
            ultimoTipo = tipo;
            ultimoUser = UserCpf;

        }
        public static int RetornaUltimoTipoLog()
        {
            return ultimoTipo;
        }
        public static string RetornaUltimoCpfLog()
        {
            return ultimoUser;
        }
    }
}
