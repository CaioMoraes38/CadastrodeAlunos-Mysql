namespace CadastrodeAlunos_Mysql
{
    partial class FormCurso
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabCadastroCurso = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastroCurso = new TabPage();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            cboArea = new ReaLTaiizor.Controls.MaterialComboBox();
            cboPeriodo = new ReaLTaiizor.Controls.MaterialComboBox();
            cboSemestre = new ReaLTaiizor.Controls.MaterialComboBox();
            cboNivel = new ReaLTaiizor.Controls.MaterialComboBox();
            txtNomeCurso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtMatricula = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            Consulta = new TabPage();
            dataGridViewCurso = new DataGridView();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            tabCadastroCurso.SuspendLayout();
            tabPageCadastroCurso.SuspendLayout();
            Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCurso).BeginInit();
            SuspendLayout();
            // 
            // tabCadastroCurso
            // 
            tabCadastroCurso.Controls.Add(tabPageCadastroCurso);
            tabCadastroCurso.Controls.Add(Consulta);
            tabCadastroCurso.Depth = 0;
            tabCadastroCurso.Location = new Point(6, 67);
            tabCadastroCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabCadastroCurso.Multiline = true;
            tabCadastroCurso.Name = "tabCadastroCurso";
            tabCadastroCurso.SelectedIndex = 0;
            tabCadastroCurso.Size = new Size(788, 377);
            tabCadastroCurso.TabIndex = 1;
            tabCadastroCurso.Selected += tabCadastroCurso_Selected;
            // 
            // tabPageCadastroCurso
            // 
            tabPageCadastroCurso.Controls.Add(txtId);
            tabPageCadastroCurso.Controls.Add(btnCancelar);
            tabPageCadastroCurso.Controls.Add(btnSalvar);
            tabPageCadastroCurso.Controls.Add(cboArea);
            tabPageCadastroCurso.Controls.Add(cboPeriodo);
            tabPageCadastroCurso.Controls.Add(cboSemestre);
            tabPageCadastroCurso.Controls.Add(cboNivel);
            tabPageCadastroCurso.Controls.Add(txtNomeCurso);
            tabPageCadastroCurso.Controls.Add(txtMatricula);
            tabPageCadastroCurso.Location = new Point(4, 34);
            tabPageCadastroCurso.Name = "tabPageCadastroCurso";
            tabPageCadastroCurso.Padding = new Padding(3);
            tabPageCadastroCurso.Size = new Size(780, 339);
            tabPageCadastroCurso.TabIndex = 0;
            tabPageCadastroCurso.Text = "Cadastro";
            tabPageCadastroCurso.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.LeadingIcon = null;
            txtId.Location = new Point(642, 33);
            txtId.Margin = new Padding(4);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(131, 48);
            txtId.TabIndex = 9;
            txtId.TabStop = false;
            txtId.Text = "ID";
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(680, 291);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(554, 291);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // cboArea
            // 
            cboArea.AutoResize = false;
            cboArea.BackColor = Color.FromArgb(255, 255, 255);
            cboArea.Depth = 0;
            cboArea.DrawMode = DrawMode.OwnerDrawVariable;
            cboArea.DropDownHeight = 174;
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArea.DropDownWidth = 121;
            cboArea.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboArea.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboArea.FormattingEnabled = true;
            cboArea.Hint = "Área ";
            cboArea.IntegralHeight = false;
            cboArea.ItemHeight = 43;
            cboArea.Items.AddRange(new object[] { "Lincenciatura", "Informática ", "Industria", "Administração" });
            cboArea.Location = new Point(470, 205);
            cboArea.MaxDropDownItems = 4;
            cboArea.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(303, 49);
            cboArea.StartIndex = 0;
            cboArea.TabIndex = 6;
            // 
            // cboPeriodo
            // 
            cboPeriodo.AutoResize = false;
            cboPeriodo.BackColor = Color.FromArgb(255, 255, 255);
            cboPeriodo.Depth = 0;
            cboPeriodo.DrawMode = DrawMode.OwnerDrawVariable;
            cboPeriodo.DropDownHeight = 174;
            cboPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPeriodo.DropDownWidth = 121;
            cboPeriodo.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboPeriodo.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboPeriodo.FormattingEnabled = true;
            cboPeriodo.Hint = "Periodo";
            cboPeriodo.IntegralHeight = false;
            cboPeriodo.ItemHeight = 43;
            cboPeriodo.Items.AddRange(new object[] { "Matutino ", "Vespertino", "Noturno ", "Integral" });
            cboPeriodo.Location = new Point(7, 205);
            cboPeriodo.MaxDropDownItems = 4;
            cboPeriodo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboPeriodo.Name = "cboPeriodo";
            cboPeriodo.Size = new Size(196, 49);
            cboPeriodo.StartIndex = 0;
            cboPeriodo.TabIndex = 5;
            // 
            // cboSemestre
            // 
            cboSemestre.AutoResize = false;
            cboSemestre.BackColor = Color.FromArgb(255, 255, 255);
            cboSemestre.Depth = 0;
            cboSemestre.DrawMode = DrawMode.OwnerDrawVariable;
            cboSemestre.DropDownHeight = 174;
            cboSemestre.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSemestre.DropDownWidth = 121;
            cboSemestre.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboSemestre.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboSemestre.FormattingEnabled = true;
            cboSemestre.Hint = "Semestre";
            cboSemestre.IntegralHeight = false;
            cboSemestre.ItemHeight = 43;
            cboSemestre.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboSemestre.Location = new Point(209, 205);
            cboSemestre.MaxDropDownItems = 4;
            cboSemestre.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboSemestre.Name = "cboSemestre";
            cboSemestre.Size = new Size(105, 49);
            cboSemestre.StartIndex = 0;
            cboSemestre.TabIndex = 4;
            // 
            // cboNivel
            // 
            cboNivel.AutoResize = false;
            cboNivel.BackColor = Color.FromArgb(255, 255, 255);
            cboNivel.Depth = 0;
            cboNivel.DrawMode = DrawMode.OwnerDrawVariable;
            cboNivel.DropDownHeight = 174;
            cboNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNivel.DropDownWidth = 121;
            cboNivel.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboNivel.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboNivel.FormattingEnabled = true;
            cboNivel.Hint = "Nível";
            cboNivel.IntegralHeight = false;
            cboNivel.ItemHeight = 43;
            cboNivel.Items.AddRange(new object[] { "Médio", "Técnico", "Superior" });
            cboNivel.Location = new Point(320, 205);
            cboNivel.MaxDropDownItems = 4;
            cboNivel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboNivel.Name = "cboNivel";
            cboNivel.Size = new Size(144, 49);
            cboNivel.StartIndex = 0;
            cboNivel.TabIndex = 3;
            // 
            // txtNomeCurso
            // 
            txtNomeCurso.AnimateReadOnly = false;
            txtNomeCurso.AutoCompleteMode = AutoCompleteMode.None;
            txtNomeCurso.AutoCompleteSource = AutoCompleteSource.None;
            txtNomeCurso.BackgroundImageLayout = ImageLayout.None;
            txtNomeCurso.CharacterCasing = CharacterCasing.Normal;
            txtNomeCurso.Depth = 0;
            txtNomeCurso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeCurso.HideSelection = true;
            txtNomeCurso.Hint = "NOME DO CURSO";
            txtNomeCurso.LeadingIcon = null;
            txtNomeCurso.Location = new Point(7, 110);
            txtNomeCurso.Margin = new Padding(4);
            txtNomeCurso.MaxLength = 32767;
            txtNomeCurso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNomeCurso.Name = "txtNomeCurso";
            txtNomeCurso.PasswordChar = '\0';
            txtNomeCurso.PrefixSuffixText = null;
            txtNomeCurso.ReadOnly = false;
            txtNomeCurso.RightToLeft = RightToLeft.No;
            txtNomeCurso.SelectedText = "";
            txtNomeCurso.SelectionLength = 0;
            txtNomeCurso.SelectionStart = 0;
            txtNomeCurso.ShortcutsEnabled = true;
            txtNomeCurso.Size = new Size(766, 48);
            txtNomeCurso.TabIndex = 2;
            txtNomeCurso.TabStop = false;
            txtNomeCurso.TextAlign = HorizontalAlignment.Left;
            txtNomeCurso.TrailingIcon = null;
            txtNomeCurso.UseSystemPasswordChar = false;
            // 
            // txtMatricula
            // 
            txtMatricula.AnimateReadOnly = false;
            txtMatricula.AutoCompleteMode = AutoCompleteMode.None;
            txtMatricula.AutoCompleteSource = AutoCompleteSource.None;
            txtMatricula.BackgroundImageLayout = ImageLayout.None;
            txtMatricula.CharacterCasing = CharacterCasing.Normal;
            txtMatricula.Depth = 0;
            txtMatricula.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtMatricula.HideSelection = true;
            txtMatricula.Hint = "CÓDIGO DO CURSO";
            txtMatricula.LeadingIcon = null;
            txtMatricula.Location = new Point(10, 33);
            txtMatricula.Margin = new Padding(4);
            txtMatricula.MaxLength = 32767;
            txtMatricula.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtMatricula.Name = "txtMatricula";
            txtMatricula.PasswordChar = '\0';
            txtMatricula.PrefixSuffixText = null;
            txtMatricula.ReadOnly = false;
            txtMatricula.RightToLeft = RightToLeft.No;
            txtMatricula.SelectedText = "";
            txtMatricula.SelectionLength = 0;
            txtMatricula.SelectionStart = 0;
            txtMatricula.ShortcutsEnabled = true;
            txtMatricula.Size = new Size(620, 48);
            txtMatricula.TabIndex = 1;
            txtMatricula.TabStop = false;
            txtMatricula.TextAlign = HorizontalAlignment.Left;
            txtMatricula.TrailingIcon = null;
            txtMatricula.UseSystemPasswordChar = false;
            // 
            // Consulta
            // 
            Consulta.BackColor = Color.White;
            Consulta.BackgroundImageLayout = ImageLayout.Center;
            Consulta.Controls.Add(dataGridViewCurso);
            Consulta.Controls.Add(btnNovo);
            Consulta.Controls.Add(btnExcluir);
            Consulta.Controls.Add(btnEditar);
            Consulta.Location = new Point(4, 34);
            Consulta.Name = "Consulta";
            Consulta.Padding = new Padding(3);
            Consulta.Size = new Size(780, 339);
            Consulta.TabIndex = 1;
            Consulta.Text = "Consulta";
            // 
            // dataGridViewCurso
            // 
            dataGridViewCurso.AllowUserToAddRows = false;
            dataGridViewCurso.AllowUserToDeleteRows = false;
            dataGridViewCurso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCurso.Dock = DockStyle.Top;
            dataGridViewCurso.Location = new Point(3, 3);
            dataGridViewCurso.Name = "dataGridViewCurso";
            dataGridViewCurso.RowHeadersWidth = 62;
            dataGridViewCurso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCurso.Size = new Size(774, 288);
            dataGridViewCurso.TabIndex = 22;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(518, 300);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(64, 36);
            btnNovo.TabIndex = 14;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(696, 300);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(80, 36);
            btnExcluir.TabIndex = 13;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click_1;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(602, 300);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 12;
            btnEditar.Text = "Editar";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // FormCurso
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabCadastroCurso);
            DrawerTabControl = tabCadastroCurso;
            Name = "FormCurso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro do Curso";
            tabCadastroCurso.ResumeLayout(false);
            tabPageCadastroCurso.ResumeLayout(false);
            tabPageCadastroCurso.PerformLayout();
            Consulta.ResumeLayout(false);
            Consulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCurso).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTabControl tabCadastroCurso;
        private TabPage tabPageCadastroCurso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialButton btnCancelar;
        private ReaLTaiizor.Controls.MaterialButton btnSalvar;
        private ReaLTaiizor.Controls.MaterialComboBox cboArea;
        private ReaLTaiizor.Controls.MaterialComboBox cboPeriodo;
        private ReaLTaiizor.Controls.MaterialComboBox cboSemestre;
        private ReaLTaiizor.Controls.MaterialComboBox cboNivel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeCurso;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtMatricula;
        private TabPage Consulta;
        private ReaLTaiizor.Controls.MaterialButton btnNovo;
        private ReaLTaiizor.Controls.MaterialButton btnExcluir;
        private ReaLTaiizor.Controls.MaterialButton btnEditar;
        private DataGridView dataGridViewCurso;
    }
}