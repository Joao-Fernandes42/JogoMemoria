using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace JogoMemoria
{
    public partial class FormNomeUtilizador : Form
    {
        string pathCd = "credenciais.txt";
        public FormNomeUtilizador()
        {
            InitializeComponent();
        }

        private void buttonRegistar_Click(object sender, EventArgs e)
        {
            if(textBoxPass.Text==textBoxRepPasse.Text)
            {
                if(!UtilizadorJaExiste(textBoxUser.Text))
                {
                    RegistarUtilizador(textBoxUser.Text, textBoxPass.Text);
                }
                else
                {
                    MessageBox.Show("Utilizador já existente!! Insira novos dados");
                    textBoxUser.Text = "";
                    textBoxPass.Text = "";
                    textBoxRepPasse.Text = "";
                    textBoxUser.Focus();
                }
            }
            else
            {
                MessageBox.Show("As passwords não coincidem!!");
                textBoxPass.Text = "";
                textBoxRepPasse.Text = "";
                textBoxPass.Focus();
            }
        }
        private bool UtilizadorJaExiste(string user)
        {
            if (File.Exists(pathCd))
            {
                try
                {
                    string[] dadosUsers = File.ReadAllLines(pathCd);
                    foreach (string linha in dadosUsers)
                    {
                        string[] dadosUsr = linha.Split(':');
                        if(user == dadosUsr[0]) return true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            return false;
        }

        private void RegistarUtilizador(string user, string pass)
        {
            try
            {
                string texto = "\n" + user + ':' + pass;
                File.AppendAllText(pathCd, texto);

                MessageBox.Show("Dados do utilizador registados com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }

}
