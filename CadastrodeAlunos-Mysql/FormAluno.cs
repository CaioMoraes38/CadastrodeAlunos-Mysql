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
    public partial class FormAluno : MaterialForm
    {
        bool isAteracao = false;
        string conexao = @"server=127.0.0.1;" +
                "uid=root;" +
                "pwd=;" +
                "database=academico;";
        public FormAluno()
        {
            InitializeComponent();
        }
        private bool ValidaFormulario()
        {
            if (string.IsNullOrEmpty(txtMatricula.Text))
            {
                MessageBox.Show("Matricula é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMatricula.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNome.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtEndereco.Text))
            {
                MessageBox.Show("O campo Endereço é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEndereco.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtBairro.Text))
            {
                MessageBox.Show("O campo Bairro é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBairro.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                MessageBox.Show("O campo Cidade é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCidade.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("O campo Senha é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Focus();
                return false;
            }

            if (!DateTime.TryParse(txtDataNascimento.Text, out DateTime result))
            {
                MessageBox.Show("O campo Data de Nascimento é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDataNascimento.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cboEstado.Text))
            {
                MessageBox.Show("O campo Estado é obrigatório", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboEstado.Focus();
                return false;
            }
            return true;
        }
        private void LimpaCampos()
        {
            isAteracao = false;
            foreach (var control in tabPageCadastro.Controls)
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
                sql = "UPDATE aluno SET " +
                    "dt_nascimento = @dt_nascimento, " +
                    "nome = @nome, " +
                    "endereco = @endereco, " +
                    "bairro = @bairro, " +
                    "cidade = @cidade, " +
                    "estado = @estado, " +
                    "senha = @senha " +
                    "WHERE matricula = @matricula";
            }
            else
            {
                sql = "INSERT INTO aluno " +
               "(matricula, dt_nascimento, nome, endereco, bairro, cidade, estado, senha) " +
               "VALUES " +
               "(@matricula, @dt_nascimento, @nome, @endereco, @bairro, @cidade, @estado, @senha)";
            }

            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@matricula", txtMatricula.Text);
            DateTime.TryParse(txtDataNascimento.Text, out DateTime result);
            cmd.Parameters.AddWithValue("@dt_nascimento", result); // Adicionando o parâmetro @dt_nascimento
            cmd.Parameters.AddWithValue("@nome", txtNome.Text);
            cmd.Parameters.AddWithValue("@endereco", txtEndereco.Text);
            cmd.Parameters.AddWithValue("@bairro", txtBairro.Text);
            cmd.Parameters.AddWithValue("@cidade", txtCidade.Text);
            cmd.Parameters.AddWithValue("@estado", cboEstado.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
            if (isAteracao)
            {
                cmd.Parameters.AddWithValue("@matricula", txtId.Text);
            }
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidaFormulario())
            {
                Salvar();
                tabCadastro.SelectedIndex = 1;
            }
        }
        private void CarregaGrid()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "SELECT * FROM aluno";
            var sqlAd = new MySqlDataAdapter(sql, con);
            var dt = new DataTable();
            sqlAd.Fill(dt);
            dataGridViewAluno.DataSource = dt;
            con.Close();

        }
        private void Editar()
        {
            if (dataGridViewAluno.SelectedRows.Count > 0)
            {
                isAteracao = true;
                var linha = dataGridViewAluno.SelectedRows[0];
                txtId.Text = linha.Cells["id"].Value.ToString();
                txtMatricula.Text = linha.Cells["matricula"].Value.ToString();
                txtDataNascimento.Text = linha.Cells["dt_nascimento"].Value.ToString();
                txtEndereco.Text = linha.Cells["endereco"].Value.ToString();
                txtBairro.Text = linha.Cells["bairro"].Value.ToString();
                txtCidade.Text = linha.Cells["cidade"].Value.ToString();
                cboEstado.Text = linha.Cells["estado"].Value.ToString();
                txtSenha.Text = linha.Cells["senha"].Value.ToString();
                tabCadastro.SelectedIndex = 0;
                txtMatricula.Focus();

            }
            else
            {
                MessageBox.Show("Selecione um Aluno", "IFSP Aluno");

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }


        private void Excluir()
        {
            var con = new MySqlConnection(conexao);
            con.Open();
            var sql = "DELETE FROM aluno WHERE id = @id";
            var cmd = new MySqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewAluno.Rows.Count > 0)
            {
                if (MessageBox.Show("Deseja excluir o aluno selecionado?", "IFSP Aluno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dataGridViewAluno.SelectedRows[0].Cells["id"].Value;
                    Excluir();
                    CarregaGrid();
                }
            }
            else
            {
                MessageBox.Show("Selecione um Aluno", "IFSP Aluno");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "Ateção: informações não salvas serão perdididas", "Confirmação", 
                MessageBoxButtons.YesNo,
               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LimpaCampos();
                tabCadastro.SelectedIndex = 1;
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            LimpaCampos();
            tabCadastro.SelectedIndex = 0;
            txtBairro.Focus();
        }

        private void tabCadastro_Selected(object sender, TabControlEventArgs e)
        {
            CarregaGrid();
        }
    }
}
   

