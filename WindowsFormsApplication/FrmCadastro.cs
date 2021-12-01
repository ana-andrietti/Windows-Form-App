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
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            var nome = txtNome.Text;
            try
            {
                int numero = int.Parse(txtNumero.Text);
                numero += 100;

                throw new ErroDeProposito("Erro de propósito");

            }
            catch (FormatException errFormat)
            {
                MessageBox.Show("Olá. Acho que você digitou letras e não número", errFormat.Message);
                txtNumero.Focus();
            }
            catch (ErroDeProposito errProposito)
            {
                MessageBox.Show("Erro de propósito - " + errProposito.StackTrace);
            }
            catch (Exception err)
            {
                MessageBox.Show("Olá. Acho que você digitou letras e não número", err.Message);
            }
            finally
            {
                MessageBox.Show("Todas as minhas exceções tratadas");
            }
        }
        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            if (!maskedTextBox1.MaskCompleted)
            {
                MessageBox.Show("Digitação incompleta");
            }         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O valor digitado é " + maskedTextBox1.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Estou buscando no banco de dados com o termo " + txtBuscaTool.Text);
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    public class ErroDeProposito : Exception
    {
        public ErroDeProposito (string erro) : base (erro) 
        {
        }
    }
}
