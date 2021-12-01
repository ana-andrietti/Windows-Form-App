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

    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "Olá, Ana " + ((Estado)cboEstados.SelectedItem).Id;
        }

        private void fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abrirCadastro_Click(object sender, EventArgs e)
        {
            new FrmCadastro().Show();
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            var form = new FrmShow();
            form.lblMensagem.Text = txtResultado.Text;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var contextMenu = new ContextMenu();
            contextMenu.MenuItems.Add(new MenuItem("Fechar", fechar_Click));
            contextMenu.MenuItems.Add(new MenuItem("Abrir cadastro", abrirCadastro_Click));
            notifyIcon.ContextMenu = contextMenu;

            atualizaHora();
            cboEstados.DataSource = Estado.Lista();
            cboEstados.Text = "Selecione";

            //dataGridView.DataSource = Estado.Lista();


            dataGridView.ColumnCount = 2;
            dataGridView.Columns[0].Name = "Id";
            dataGridView.Columns[1].Name = "Nome";

            var rows = new List<string[]>();
            foreach(Estado estado in Estado.Lista())
            {
                string[] row1 = new string[] { estado.Id.ToString(), estado.Nome };
                rows.Add(row1);
            }

            foreach(string[] rowArray in rows)
            {
                dataGridView.Rows.Add(rowArray);
            }
        }
        private void atualizaHora()
        {
            lblHoraAtual.Text = "Dia e hora atual: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void novoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmtexto = new FrmTexto();
            frmtexto.MdiParent = MDISingleton.InstanciaMDI();
            frmtexto.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSobre().Show();
        }

        private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLicenca().Show();
        }

        private void doaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDoacao().Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            atualizaHora();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmCadastro().Show();
        }


        private void btnNotificacao_Click(object sender, EventArgs e)
        {
            notifyIcon.ShowBalloonTip(10, "Notificação", "Erro na aplicação", ToolTipIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MDIParentPrincipal().Show();
        }

        private void cboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
