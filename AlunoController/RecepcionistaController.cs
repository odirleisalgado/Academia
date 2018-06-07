using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class RecepcionistaController
    {

        public static List<Recepcionista> Recepcionistas = new List<Recepcionista>();
        static int ultimoID = 0;

        public static void SalvarRecepcionista(Recepcionista novo)
        {
            int id = ultimoID + 1;
            ultimoID = id;

            novo.IdRecepcionista = id;
            Recepcionistas.Add(novo);
        }

        public static string Busca(string CpfRec)
        {
            foreach (var x in Recepcionistas)
            {
                if (x.Cpf.Equals(CpfRec))
                {
                    return x.Senha;
                }
            }
            return null;
        }

        public static Recepcionista RetornaRecepcao(string CpfRecepcao)
        {
            foreach (var x in Recepcionistas)
            {
                if (CpfRecepcao.Equals(x.Cpf))
                {
                    return x;
                }
            }

            return null;
        }

        public static string BuscaRecepcionistaCpf(string CpfRecep)
        {
            foreach (var x in Recepcionistas)
            {
                if (CpfRecep.Equals(x.Cpf))
                {
                    return x.Nome + " " + x.Sobrenome;
                }
            }
            return null;
        }
    }
}
