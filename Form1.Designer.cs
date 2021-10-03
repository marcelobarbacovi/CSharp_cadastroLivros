
namespace projeto_Integrador
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.tbAutor = new System.Windows.Forms.TextBox();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.dtgrid = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTitulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEditora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbEditora = new System.Windows.Forms.TextBox();
            this.cbGenero = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btn_novo.Location = new System.Drawing.Point(17, 22);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(103, 38);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "NOVO";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btn_excluir.Location = new System.Drawing.Point(126, 22);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(140, 38);
            this.btn_excluir.TabIndex = 1;
            this.btn_excluir.Text = "DESATIVAR";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btn_salvar.Location = new System.Drawing.Point(272, 22);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(121, 38);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.Text = "SALVAR";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btn_editar.Location = new System.Drawing.Point(399, 22);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(115, 38);
            this.btn_editar.TabIndex = 3;
            this.btn_editar.Text = "EDITAR";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.btn_cancelar.Location = new System.Drawing.Point(520, 22);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(139, 38);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Genêro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label3.Location = new System.Drawing.Point(8, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Título";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label4.Location = new System.Drawing.Point(8, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Autor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label5.Location = new System.Drawing.Point(8, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ano";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label6.Location = new System.Drawing.Point(8, 381);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Editora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.label7.Location = new System.Drawing.Point(8, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Descrição";
            // 
            // tb_Id
            // 
            this.tb_Id.Enabled = false;
            this.tb_Id.Location = new System.Drawing.Point(117, 108);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(79, 22);
            this.tb_Id.TabIndex = 14;
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(117, 218);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(230, 22);
            this.tbTitulo.TabIndex = 15;
            // 
            // tbAutor
            // 
            this.tbAutor.Location = new System.Drawing.Point(117, 272);
            this.tbAutor.Name = "tbAutor";
            this.tbAutor.Size = new System.Drawing.Size(230, 22);
            this.tbAutor.TabIndex = 16;
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(117, 326);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(79, 22);
            this.tbAno.TabIndex = 17;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(117, 435);
            this.tbDescricao.Multiline = true;
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(236, 146);
            this.tbDescricao.TabIndex = 18;
            // 
            // dtgrid
            // 
            this.dtgrid.AllowUserToOrderColumns = true;
            this.dtgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.ColGenero,
            this.ColTitulo,
            this.ColAutor,
            this.ColAno,
            this.ColEditora,
            this.ColDescricao});
            this.dtgrid.Location = new System.Drawing.Point(45, 620);
            this.dtgrid.Name = "dtgrid";
            this.dtgrid.RowHeadersWidth = 51;
            this.dtgrid.RowTemplate.Height = 24;
            this.dtgrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgrid.Size = new System.Drawing.Size(877, 165);
            this.dtgrid.TabIndex = 22;
            this.dtgrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrid_CellContentClick);
            // 
            // colID
            // 
            this.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colID.HeaderText = "Codigo";
            this.colID.MinimumWidth = 6;
            this.colID.Name = "colID";
            this.colID.Width = 81;
            // 
            // ColGenero
            // 
            this.ColGenero.HeaderText = "Genero";
            this.ColGenero.MinimumWidth = 6;
            this.ColGenero.Name = "ColGenero";
            this.ColGenero.Width = 80;
            // 
            // ColTitulo
            // 
            this.ColTitulo.HeaderText = "titulo";
            this.ColTitulo.MinimumWidth = 6;
            this.ColTitulo.Name = "ColTitulo";
            this.ColTitulo.Width = 125;
            // 
            // ColAutor
            // 
            this.ColAutor.HeaderText = "Autor";
            this.ColAutor.MinimumWidth = 6;
            this.ColAutor.Name = "ColAutor";
            this.ColAutor.Width = 125;
            // 
            // ColAno
            // 
            this.ColAno.HeaderText = "Ano";
            this.ColAno.MinimumWidth = 6;
            this.ColAno.Name = "ColAno";
            this.ColAno.Width = 60;
            // 
            // ColEditora
            // 
            this.ColEditora.HeaderText = "Editora";
            this.ColEditora.MinimumWidth = 6;
            this.ColEditora.Name = "ColEditora";
            this.ColEditora.Width = 125;
            // 
            // ColDescricao
            // 
            this.ColDescricao.HeaderText = "Descrição";
            this.ColDescricao.MinimumWidth = 6;
            this.ColDescricao.Name = "ColDescricao";
            this.ColDescricao.Width = 125;
            // 
            // tbEditora
            // 
            this.tbEditora.Location = new System.Drawing.Point(117, 383);
            this.tbEditora.Name = "tbEditora";
            this.tbEditora.Size = new System.Drawing.Size(230, 22);
            this.tbEditora.TabIndex = 25;
            // 
            // cbGenero
            // 
            this.cbGenero.FormattingEnabled = true;
            this.cbGenero.Items.AddRange(new object[] {
            "Aventura",
            "Educação",
            "Infantil",
            "Romance"});
            this.cbGenero.Location = new System.Drawing.Point(117, 164);
            this.cbGenero.Name = "cbGenero";
            this.cbGenero.Size = new System.Drawing.Size(121, 24);
            this.cbGenero.TabIndex = 27;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::projeto_Integrador.Properties.Resources.livros;
            this.pictureBox1.Location = new System.Drawing.Point(381, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(895, 680);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbGenero);
            this.Controls.Add(this.tbEditora);
            this.Controls.Add(this.dtgrid);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.tbAutor);
            this.Controls.Add(this.tbTitulo);
            this.Controls.Add(this.tb_Id);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_excluir);
            this.Controls.Add(this.btn_novo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Livros";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.TextBox tbAutor;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.DataGridView dtgrid;
        private System.Windows.Forms.TextBox tbEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTitulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEditora;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescricao;
        private System.Windows.Forms.ComboBox cbGenero;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

