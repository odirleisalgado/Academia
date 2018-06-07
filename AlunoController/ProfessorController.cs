using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class ProfessorController
    {
        public static List<Professor> Professores = new List<Professor>();
        static int ultimoID = 0;

        public static void SalvarProfessor(Professor novo)
        {
            int id = ultimoID + 1;
            ultimoID = id;

            novo.IdProfessor = id;
            Professores.Add(novo);
        }

        public static string Busca(string CpfRec)
        {
            foreach (var x in Professores)
            {
                if (x.Cpf.Equals(CpfRec))
                {
                    return x.Senha;
                }
            }
            return null;
        }

        public static Professor RetornaProfessor(string CpfProfessor)
        {
            foreach (var x in Professores)
            {
                if (CpfProfessor.Equals(x.Cpf))
                {
                    return x;
                }
            }

            return null;
        }

        public static string BuscaProfessorCpf(string CpfProfessor)
        {
            foreach (var x in Professores)
            {
                if (CpfProfessor.Equals(x.Cpf))
                {
                    return x.Nome + " " + x.Sobrenome;
                }
            }
            return null;
        }
    }
}
