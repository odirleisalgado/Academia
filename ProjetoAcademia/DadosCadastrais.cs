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
    public partial class DadosCadastrais : Form
    {
        public DadosCadastrais()
        {
            InitializeComponent();
        }

        private void btnFechar2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void DadosCadastrais_Load(object sender, EventArgs e)
        {
            if (Controller.PessoaLogController.ultimoTipo == 1)
            {
                Aluno DadosAluno = new Aluno();
            
                DadosAluno = Controller.AlunoController.RetornaAluno(Controller.PessoaLogController.ultimoUser);
                txtPlano.Visible = true;
                lblPlano.Visible = true;
                txtDtInicio.Visible = true;
                lblInicio.Visible = true;

                txtTipoUsuario.Text = "ALUNO";
                txtNome.Text = DadosAluno.Nome;
                txtSobrenome.Text = DadosAluno.Sobrenome;
                txtCpf.Text = DadosAluno.Cpf;
                txtFone.Text = DadosAluno.Telefone;
                txtNasc.Text = DadosAluno.DtNascimento;
                txtEndereco.Text = DadosAluno.Endereco;
                txtBairro.Text = DadosAluno.Bairro;
                txtEmail.Text = DadosAluno.Email;
                txtPlano.Text = DadosAluno.TipoPlano;
                txtDtInicio.Text = DadosAluno.DataCadastro;
                

                if (DadosAluno.Sexo =='M')
                {
                    txtSexo.Text="MASCULINO";
                }
                else
                {
                    txtSexo.Text = "FEMININO";
                }

                

            }
            else
            {
                if (Controller.PessoaLogController.ultimoTipo == 2)
                {
                    Professor DadosProfessor = new Professor();

                    DadosProfessor = Controller.ProfessorController.RetornaProfessor(Controller.PessoaLogController.ultimoUser);
                 
                    txtTipoUsuario.Text = "PROFESSOR";
                    txtNome.Text = DadosProfessor.Nome;
                    txtSobrenome.Text = DadosProfessor.Sobrenome;
                    txtCpf.Text = DadosProfessor.Cpf;
                    txtFone.Text = DadosProfessor.Telefone;
                    txtNasc.Text = DadosProfessor.DtNascimento;
                    txtEndereco.Text = DadosProfessor.Endereco;
                    txtBairro.Text = DadosProfessor.Bairro;
                    txtEmail.Text = DadosProfessor.Email;
                    txtDtInicio.Text = DadosProfessor.DataCadastro;


                    if (DadosProfessor.Sexo == 'M')
                    {
                        txtSexo.Text = "MASCULINO";
                    }
                    else
                    {
                        txtSexo.Text = "FEMININO";
                    }



                }
                else
                {
                    if (Controller.PessoaLogController.ultimoTipo == 3)
                    {
                        Recepcionista DadosRecepcionista = new Recepcionista();

                        DadosRecepcionista = Controller.RecepcionistaController.RetornaRecepcao(Controller.PessoaLogController.ultimoUser);

                        txtTipoUsuario.Text = "RECEPCIONISTA";
                        txtNome.Text = DadosRecepcionista.Nome;
                        txtSobrenome.Text = DadosRecepcionista.Sobrenome;
                        txtCpf.Text = DadosRecepcionista.Cpf;
                        txtFone.Text = DadosRecepcionista.Telefone;
                        txtNasc.Text = DadosRecepcionista.DtNascimento;
                        txtEndereco.Text = DadosRecepcionista.Endereco;
                        txtBairro.Text = DadosRecepcionista.Bairro;
                        txtEmail.Text = DadosRecepcionista.Email;
                        txtDtInicio.Text = DadosRecepcionista.DataCadastro;


                        if (DadosRecepcionista.Sexo == 'M')
                        {
                            txtSexo.Text = "MASCULINO";
                        }
                        else
                        {
                            txtSexo.Text = "FEMININO";
                        }



                    }
                    else
                    {
                        Admin DadosAdmin = new Admin();

                        DadosAdmin = Controller.AdminController.RetornaAdmin(Controller.PessoaLogController.ultimoUser);

                        txtTipoUsuario.Text = "ADMINISTRADOR";
                        txtNome.Text = DadosAdmin.Nome;
                        txtSobrenome.Text = DadosAdmin.Sobrenome;
                        txtCpf.Text = DadosAdmin.Cpf;
                        txtFone.Text = DadosAdmin.Telefone;
                        txtNasc.Text = DadosAdmin.DtNascimento;
                        txtEndereco.Text = DadosAdmin.Endereco;
                        txtBairro.Text = DadosAdmin.Bairro;
                        txtEmail.Text = DadosAdmin.Email;
                        txtDtInicio.Text = DadosAdmin.DataCadastro;


                        if (DadosAdmin.Sexo == 'M')
                        {
                            txtSexo.Text = "MASCULINO";
                        }
                        else
                        {
                            txtSexo.Text = "FEMININO";
                        }

                    }
                }
            }

        }

        private void btnSair_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }
    }
}
