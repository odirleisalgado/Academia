using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoAcademia
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]

      
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Construtor();//Inicializa o programa com dados previamente cadastrados()); 
            Application.Run(new TelaInicial());
        }

        
        public static void Construtor()
        {

            Professor novoProfessor = new Professor();
            Aluno novoAluno = new Aluno();
            Recepcionista novaRecep = new Recepcionista();
            Admin novoAdmin = new Admin();

            novoProfessor.TipoAcesso = 2;
            novoProfessor.Nome = "João";
            novoProfessor.Sobrenome = "Pedro da Silva";
            novoProfessor.Cpf = "222222";
            novoProfessor.Sexo = 'M';
            novoProfessor.DtNascimento = "10/10/1950";
            novoProfessor.Endereco = "Rua das Andorinhas";
            novoProfessor.Telefone = "41914845685";
            novoProfessor.Bairro = "Boa Vista";
            novoProfessor.Email = "joao.silva@hotmail.com";
            novoProfessor.Login = novoProfessor.Cpf;
            novoProfessor.Senha = "bbbbbb";
            novoProfessor.IdProfessor = 1;
          

            Controller.ProfessorController.SalvarProfessor(novoProfessor);

            novoAluno.TipoAcesso = 1;
            novoAluno.Nome = "MARIA";
            novoAluno.Sobrenome = "SILVA";
            novoAluno.Cpf = "111111";
            novoAluno.Sexo = 'F';
            novoAluno.DtNascimento = "10/10/1950";
            novoAluno.Endereco = "Rua das Andorinhas";
            novoAluno.Telefone = "41914845685";
            novoAluno.Bairro = "Boa Vista";
            novoAluno.Email = "maria.silva@hotmail.com";
            novoAluno.Login = novoAluno.Cpf;
            novoAluno.Senha = "aaaaaa";
            novoAluno.IdAluno = 1;
            novoAluno.TipoPlano = "SEMESTRAL";
            novoAluno.DataCadastro = DateTime.Now.ToString("dd/MM/yyyy");

            Controller.AlunoController.SalvarAluno(novoAluno);

            novaRecep.TipoAcesso = 3;
            novaRecep.Nome = "Marcia";
            novaRecep.Sobrenome = "Moreia Garcez";
            novaRecep.Cpf = "333333";
            novaRecep.Sexo = 'F';
            novaRecep.DtNascimento = "10/10/1955";
            novaRecep.Endereco = "Rua das Andorinhas nova";
            novaRecep.Telefone = "41914845685";
            novaRecep.Bairro = "Boa Vista";
            novaRecep.Email = "marcia.moreira@hotmail.com";
            novaRecep.Login = novaRecep.Cpf;
            novaRecep.Senha = "cccccc";
            novaRecep.IdRecepcionista = 1;
           

            Controller.RecepcionistaController.SalvarRecepcionista(novaRecep);


            novoAdmin.TipoAcesso = 4;
            novoAdmin.Nome = "Odirlei";
            novoAdmin.Sobrenome = "Salgado";
            novoAdmin.Cpf = "07186682944";
            novoAdmin.Sexo = 'M';
            novoAdmin.DtNascimento = "10/10/1989";
            novoAdmin.Endereco = "Rua Fake";
            novoAdmin.Telefone = "41914845685";
            novoAdmin.Bairro = "Boa Vista";
            novoAdmin.Email = "odirleisalgado@hotmail.com";
            novoAdmin.Login = novoAdmin.Cpf;
            novoAdmin.Senha = "123456";
            novoAdmin.IdAdmin = 1;


            Controller.AdminController.SalvarAdmin(novoAdmin);

        }
    }
}
