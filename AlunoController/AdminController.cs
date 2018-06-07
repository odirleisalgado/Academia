using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class AdminController
    {
        public static List<Admin> Administradores = new List<Admin>();

        public static void SalvarAdmin(Admin novoAd)
        {
            Administradores.Add(novoAd);
        }

        public static string Busca(string novoAd)
        {
            foreach (var x in Administradores)
            {
                if (x.Cpf.Equals(novoAd))
                {
                    return x.Senha;
                }

            }
            return null;
        }

        public static Admin RetornaAdmin(string CpfAdmin)
        {
            foreach (var x in Administradores)
            {
                if (CpfAdmin.Equals(x.Cpf))
                {
                    return x;
                }
            }

            return null;
        }

        public static string BuscaAdminCpf(string CpfAdmin)
        {
            foreach (var x in Administradores)
            {
                if (CpfAdmin.Equals(x.Cpf))
                {
                    return x.Nome + " " + x.Sobrenome;
                }
            }
            return null;
        }
    }
}
