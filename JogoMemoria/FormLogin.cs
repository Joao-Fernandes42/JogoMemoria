using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FormLogin : Form
    {

        string pathCd = "credenciais.txt";

        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonEntrar_Click(object sender, EventArgs e)
        {
            Form1.login = false;
            string user = textBoxUser.Text;
            string pass = textBoxPasse.Text;
            if ((user == "manga") && (pass == "jardim"))
                Form1.login = true;
            else
                VerificarLogin(user,pass);
            this.Close();
        }
        private bool VerificarLogin(string us, string ps)
        {
            if (File.Exists(pathCd))
            {
                string[] users = File.ReadAllLines(pathCd);
                foreach (string s in users)
                {
                    string[] dataUser = s.Split(':');
                    string nUser = dataUser[0];
                    string nPass = dataUser[1];
                    if (us == dataUser[0] && ps == dataUser[1])
                    {
                        MessageBox.Show("Seja Bemvindo !! " + us);
                        return true;
                    }
                } 
            }
            MessageBox.Show("Utilizador não existente!!");
            return false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Form1.login = false;
            this.Close();
        }

        private void linkLabelMostrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelMostrar.Text == "Mostrar")
            {
                textBoxPasse.UseSystemPasswordChar = false;
                linkLabelMostrar.Text = "Ocultar";
            }
            else
            {
                textBoxPasse.UseSystemPasswordChar = true;
                linkLabelMostrar.Text = "Mostrar";
            }
        }

        private void linkLabelNovoUtil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormNomeUtilizador frm = new FormNomeUtilizador();
            frm.ShowDialog();
            textBoxUser.Focus();
        }
    }
}
