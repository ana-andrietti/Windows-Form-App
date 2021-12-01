using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
            txtSenha.MaxLength = 50;
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == "anaclaudia" && txtSenha.Text == "2304")
            {
                new MDIParentPrincipal().Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos. Verifique o valor digitado e tente novamente");
            }
        }
    }
}
