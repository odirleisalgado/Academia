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
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }

        private void btnFechar_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Cadastra a Pessoa conforme o Tipo selecionado na combobox
            if (cmbTipo.Text.Equals("ALUNO"))
            {  
                //CADASTRO DE ALUNO
                Aluno novoAluno = new Aluno();
                novoAluno.TipoAcesso = 1;
                novoAluno.Nome = txtNome.Text;
                novoAluno.Sobrenome = txtSobrenome.Text;
                novoAluno.Cpf = txtCpf.Text;
                novoAluno.DtNascimento = txtNasc.Text;
                novoAluno.Endereco = txtEndereco.Text;              
                novoAluno.Telefone = txtFone.Text;
                novoAluno.Bairro = txtBairro.Text;
                novoAluno.Email = txtEmail.Text;
                novoAluno.Login = novoAluno.Cpf;
                novoAluno.Senha = "123456";

                if (txtNome.Text == "" || txtCpf.Text == "" || txtNasc.Text == "" || txtSobrenome.Text=="" || txtEmail.Text == "" || radioF.Checked==false & radioM.Checked==false)
                {
                    MessageBox.Show("Por Favor. Preencha os campos obrigatórios '*'", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Controller.AlunoController.SalvarAluno(novoAluno);
                    MessageBox.Show("Aluno Cadastrado com Sucesso", "Sucesso");
                    //Limpa os campos para novo cadastro
                    LimpaCampos();

                }

                if (radioF.Checked)
                {
                    novoAluno.Sexo = 'F';               
                }
                else
                {
                    if (radioM.Checked)
                    {
                        novoAluno.Sexo = 'M';
                    }
                }

            }
            else
            {   //CADASTRO DE PROFESSOR
                if (cmbTipo.Text.Equals("PROFESSOR"))
                {
                    Professor novoProfessor = new Professor();
                    novoProfessor.TipoAcesso = 2;
                    novoProfessor.Nome = txtNome.Text;
                    novoProfessor.Sobrenome = txtSobrenome.Text;
                    novoProfessor.Cpf = txtCpf.Text;
                    novoProfessor.DtNascimento = txtNasc.Text;
                    novoProfessor.Endereco = txtEndereco.Text;
                    novoProfessor.Telefone = txtFone.Text;
                    novoProfessor.Bairro = txtBairro.Text;
                    novoProfessor.Email = txtEmail.Text;
                    novoProfessor.Login = novoProfessor.Cpf;
                    novoProfessor.Senha = "123456";

                    if (txtNome.Text == "" || txtCpf.Text == "" || txtNasc.Text == "" || txtSobrenome.Text == "" || txtEmail.Text == "" || radioF.Checked == false & radioM.Checked == false)
                    {
                        MessageBox.Show("Por Favor. Preencha os campos obrigatórios '*'", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Controller.ProfessorController.SalvarProfessor(novoProfessor);
                        MessageBox.Show("Professor Cadastrado com Sucesso", "Sucesso");
                        //Limpa os campos para novo cadastro
                        LimpaCampos();

                    }

                    if (radioF.Checked)
                    {
                        novoProfessor.Sexo = 'F';
                    }
                    else
                    {
                        if (radioM.Checked)
                        {
                            novoProfessor.Sexo = 'M';
                        }
                    }
                }
                else
                {   //CADASTRO DE RECEPCIONISTA
                    if (cmbTipo.Text.Equals("RECEPCIONISTA"))
                    {
                        Recepcionista novoRecep = new Recepcionista();
                        novoRecep.TipoAcesso = 3;
                        novoRecep.Nome = txtNome.Text;
                        novoRecep.Sobrenome = txtSobrenome.Text;
                        novoRecep.Cpf = txtCpf.Text;
                        novoRecep.DtNascimento = txtNasc.Text;
                        novoRecep.Endereco = txtEndereco.Text;
                        novoRecep.Telefone = txtFone.Text;
                        novoRecep.Bairro = txtBairro.Text;
                        novoRecep.Email = txtEmail.Text;
                        novoRecep.Login = novoRecep.Cpf;
                        novoRecep.Senha = "123456";

                        if (txtNome.Text == "" || txtCpf.Text == "" || txtNasc.Text == "" || txtSobrenome.Text == "" || txtEmail.Text == "" || radioF.Checked == false & radioM.Checked == false)
                        {
                            MessageBox.Show("Por Favor. Preencha os campos obrigatórios '*'", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            Controller.RecepcionistaController.SalvarRecepcionista(novoRecep);
                            MessageBox.Show("Recepicionista Cadastrado com Sucesso", "Sucesso");
                           
                            //Limpa os campos para novo cadastro
                            LimpaCampos();

                        }

                        if (radioF.Checked)
                        {
                            novoRecep.Sexo = 'F';
                        }
                        else
                        {
                            if (radioM.Checked)
                            {
                                novoRecep.Sexo = 'M';
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selecione o Tipo de Usuário", "Atenção", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Metodo que limpa os campos do formulário      
        public void LimpaCampos()
        {
            txtCpf.Clear();  
            txtNome.Clear();
            txtSobrenome.Clear();
            txtNasc.Clear();
            txtEndereco.Clear();
            txtFone.Clear();
            txtBairro.Clear();
            txtEmail.Clear();
            radioF.Checked = false;
            radioM.Checked = false;
            cmbTipo.SelectedIndex = -1;
        }

        
    }
}
