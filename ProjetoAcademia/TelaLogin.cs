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
using System.Data.SqlClient;

namespace ProjetoAcademia
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }

        

        private void btnLogar_Click(object sender, EventArgs e)
        {
            PesquisaUsuario(txtUser.Text);
        }

       

        //Metodo que realiza a validação de Usuario e senha

        public void PesquisaUsuario(string p_Cpf)
        {
            //Variáveis
           string Alu, Prof, Recep, Admin;

            //Busca no Banco
           Alu= Controller.AlunoController.Busca(p_Cpf);
           Prof = Controller.ProfessorController.Busca(p_Cpf);
           Recep = Controller.RecepcionistaController.Busca(p_Cpf);
           Admin = Controller.AdminController.Busca(p_Cpf);

            //Realiza as Condicionais verificando 

            if (Alu == null)
            {
               if (Prof == null)
               {
                  if (Recep == null)
                  {
                     if (Admin == null)
                     {
                         MessageBox.Show("Usuário ou Senha Incorretos!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                         txtPassword.Clear();
                         txtUser.Clear();
                         txtUser.Focus();
                        }
                     else
                     {
                        if (Admin.Equals(txtPassword.Text))
                        {
                           Controller.PessoaLogController.UltimoLog(4,txtUser.Text);
                           this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                           MessageBox.Show("Usuário ou Senha Incorretos!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           txtPassword.Clear();
                           txtUser.Clear();
                           txtUser.Focus();
                        }
                     }

                  }
                  else
                  {
                      if (Recep.Equals(txtPassword.Text))
                      {
                            Controller.PessoaLogController.UltimoLog(3, txtUser.Text);
                            this.DialogResult = DialogResult.OK;
                      }
                      else
                      {
                            MessageBox.Show("Usuário ou Senha Incorretos!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtPassword.Clear();
                            txtUser.Clear();
                            txtUser.Focus();
                      }
                  }
               }
               else
               {
                    if (Prof.Equals(txtPassword.Text))
                    {
                        Controller.PessoaLogController.UltimoLog(2,txtUser.Text);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Usuário ou Senha Incorretos!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPassword.Clear();
                        txtUser.Clear();
                        txtUser.Focus();
                    }

                }
            }
            else
            {
               if (Alu.Equals(txtPassword.Text))
               {
                   Controller.PessoaLogController.UltimoLog(1,txtUser.Text);
                   this.DialogResult = DialogResult.OK;
               }
               else
               {
                   MessageBox.Show("Usuário ou Senha Incorretos!!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   txtPassword.Clear();
                   txtUser.Clear();
                   txtUser.Focus();
               }
            }
        }            
    }
}















