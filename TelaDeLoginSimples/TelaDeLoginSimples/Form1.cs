using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaDeLoginSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bot_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            if(login == "admin" && senha == "ds@etefmc")
            {
                MessageBox.Show("login concluído divo");
            }
            else
            {
                MessageBox.Show("login ou senha incorreto");
            }
        }
    }
}
