﻿using System;
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
    public partial class MDIParentPrincipal : Form
    {
        private int childFormNumber = 0;

        public MDIParentPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }


        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form1 = new Form1();
            form1.MdiParent = this;
            form1.Show();
        }

        private void MDIParentPrincipal_Load(object sender, EventArgs e)
        {
            var form = new FrmCadastro();
            form.MdiParent = this;
            form.Show();
        }

        private void progressBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new FrmImportador();
            form.MdiParent = this;
            form.Show();
        }

        private void panelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmPanel().Show();
        }

        private void tabControlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTabControl().Show();
        }

        private void treeViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmTree().Show();
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmWebBrowser().Show();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }
    }
}
