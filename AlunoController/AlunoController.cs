using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class AlunoController
    {
        public static List<Aluno> Alunos = new List<Aluno>();
        static int ultimoID = 0;

        public static void SalvarAluno(Aluno novo)
        {
            int id = ultimoID + 1;
            ultimoID = id;

            novo.IdAluno = id;
            Alunos.Add(novo);
        }

        //Raliza a busca para a tela de Login
        public static string Busca(string novo)
        {
            foreach (var x in Alunos)
            {
                if (x.Cpf.Equals(novo))
                {
                    return x.Senha;
                }
               
            }
          return null;
        }

        public static string BuscaAlunoCpf(string CpfAluno)
        {
            foreach (var x in Alunos)
            {
                if (CpfAluno.Equals(x.Cpf))
                {
                    return x.Nome + " " + x.Sobrenome;
                }
            }
            return null;
        }

        public static Aluno RetornaAluno(string CpfAluno)
        {
            foreach (var x in Alunos)
            {
                if (CpfAluno.Equals(x.Cpf))
                {
                    return x;
                }
            }

            return null;
        }
    }
}
