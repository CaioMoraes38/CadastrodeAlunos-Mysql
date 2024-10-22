using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;

namespace CadastrodeAlunos_Mysql
{
    public partial class FormCurso : MaterialForm
    {
        bool isAteracao = false;
        string conexao = @"server=127.0.0.1;" +
                "uid=root;" +
                "pwd=;" +
                "database=academico;";
        public FormCurso()
        {
            InitializeComponent();
        }
        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Código é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNomeCurso.Text))
            {
                MessageBox.Show("Nome do curso é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomeCurso.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cboArea.Text))
            {
                MessageBox.Show("O campo Area é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboArea.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cboNivel.Text))
            {
                MessageBox.Show("O campo nivel é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboNivel.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cboPeriodo.Text))
            {
                MessageBox.Show("O campo periodo é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPeriodo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cboSemestre.Text))
            {
                MessageBox.Show("O campo semestre é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboSemestre.Focus();
                return false;
            }

            return true;
        }

        private void LimpaCampos()
        {
            isAteracao = false;
            foreach (var control in tabCadastroCurso.Controls)
            {
                if (control is MaterialTextBoxEdit)
                {
                    ((MaterialTextBoxEdit)control).Clear();
                }
                if (control is MaterialMaskedTextBox)
                {
                    ((MaterialMaskedTextBox)control).Clear();
                }
            }
        }

        private void Salvar()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            string sql = " ";

            if (isAteracao)
            {
                sql = "UPDATE curso SET " +
                    "nome_curso = @nome_curso, " +
                    "semestre = @semestre, " +
                    "nivel = @nivel, " +
                    "area = @area, " +
                    "periodo = @periodo " +
                    "WHERE cod_curso = @cod_curso";
            }
            else
            {
                sql = "INSERT INTO curso " +
               "(cod_curso, nome_curso, periodo, semestre, nivel, area) " +
               "VALUES " +
               "(@cod_curso, @nome_curso, @periodo, @semestre, @nivel, @area)";
            }

            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@cod_curso", txtMatricula.Text);
            cmd.Parameters.AddWithValue("@nome_curso", txtNomeCurso.Text);
            cmd.Parameters.AddWithValue("@periodo", cboPeriodo.Text);
            cmd.Parameters.AddWithValue("@semestre", cboSemestre.Text);
            cmd.Parameters.AddWithValue("@nivel", cboNivel.Text);
            cmd.Parameters.AddWithValue("@area", cboArea.Text);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Registro salvo com sucesso", "Mensagem de informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();
                tabCadastroCurso.SelectedIndex = 1;
            }
        }

        private void CarregaGrid()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "SELECT * FROM curso";
            var sqlAd = new MySqlDataAdapter(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridViewCurso.DataSource = dt;
            con.Close();
        }

       

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpaCampos();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            tabCadastroCurso.SelectedIndex = 0;
            txtMatricula.Focus();
        }

        private void Excluir()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "DELETE FROM curso WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Registro excluído com sucesso", "Mensagem de informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExcluir_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewCurso.Rows.Count > 0)
            {
                if (MessageBox.Show("Deseja excluir o curso selecionado?", "IFSP Curso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    txtMatricula.Text = dataGridViewCurso.SelectedRows[0].Cells["cod_curso"].Value.ToString();
                    Excluir();
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Curso", "IFSP Curso");
            }
        }

        private void tabCadastroCurso_Selected(object sender, TabControlEventArgs e)
        {
            CarregaGrid();
        }
    }
}