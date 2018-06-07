using Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAcademia
{
    public partial class TelaInicial : Form
    {

        public TelaInicial()
        {
            InitializeComponent();
        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {
            int tipoLog;
            string cpfLog;

            this.Hide(); // deixa a tela inicial oculta
            using (TelaLogin Form = new TelaLogin())
            {
                Form.ShowDialog();//mostra a tela de login acima da tela inicial

                if (Form.DialogResult != DialogResult.OK) // result dialog do login não ok
                {
                    Application.Exit();

                    return;

                }
                // se o usuário e senha estiverem ok mostra novamente a tela Inicial
                this.Show();

                //retorna o ultimo tipo de log realizado pegando o tipo de pessoa que será logada

                tipoLog = Controller.PessoaLogController.RetornaUltimoTipoLog();
                cpfLog = Controller.PessoaLogController.RetornaUltimoCpfLog();

                //realiza a validação pra saber qual tipo de pessoa está logando

                if (tipoLog == 1)
                {
                    btnNovo.Visible = false;
                    btnUsuarios.Visible = false;
                    lblUserOn.Text = Controller.AlunoController.BuscaAlunoCpf(cpfLog);
                }
                else
                {
                    if (tipoLog == 2)
                    {
                        btnNovo.Visible = false;
                        lblUserOn.Text = Controller.ProfessorController.BuscaProfessorCpf(cpfLog);
                    }
                    else
                    {
                        if (tipoLog == 3)
                        {
                            btnAval.Visible = false;
                            lblUserOn.Text = Controller.RecepcionistaController.BuscaRecepcionistaCpf(cpfLog);

                        }
                        else
                        {
                            lblUserOn.Text = Controller.AdminController.BuscaAdminCpf(cpfLog);

                        }
                    }
                }


            }
        }



        private void btnNovo_Click(object sender, EventArgs e)
        {

            TelaDeCadastro formulario = new TelaDeCadastro();
            formulario.ShowDialog();


        }

        private void btnTreino_Click(object sender, EventArgs e)
        {

        }

        private void btnDados_Click(object sender, EventArgs e)
        {
            DadosCadastrais Dados = new DadosCadastrais();
            Dados.ShowDialog();
        }

        private void btnAval_Click(object sender, EventArgs e)
        {

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Listagem ListaUsuarios = new Listagem();
            ListaUsuarios.ShowDialog();
        }

        private void btnAltSenha_Click(object sender, EventArgs e)
        {

        }

        private void btnFechar3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void btnSair1_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            TelaLogin log = new TelaLogin();
            log.Show();
            this.Close();

        }


       
           
   
    }       
    
}
