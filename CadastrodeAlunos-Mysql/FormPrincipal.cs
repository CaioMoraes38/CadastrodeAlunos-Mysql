using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastrodeAlunos_Mysql

{
    public partial class formPrincipal : MaterialForm
    {
        public formPrincipal()
        {
            InitializeComponent();
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAluno formAluno = new FormAluno();
            formAluno.MdiParent = this;
            formAluno.Show();
        }

        private void cursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCurso formCurso = new FormCurso();
            formCurso.MdiParent = this;
            formCurso.Show();
        }
    }
}
