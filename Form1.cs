// biblioteca criada automaticamente pelo forms.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // inserido para fazer conexão com banco de dados


namespace projeto_Integrador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private MySqlConnectionStringBuilder conexaoBanco()
        {  //criado a conexão com banco de dados
            MySqlConnectionStringBuilder conexaoBD = new MySqlConnectionStringBuilder();
            conexaoBD.Server = "localhost";
            conexaoBD.Database = "livraria";
            conexaoBD.UserID = "root";
            conexaoBD.Password = "";
            conexaoBD.SslMode = 0;
            return conexaoBD;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            atualizaGrid();
        }

        private void atualizaGrid()
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();
                comandoMySql.CommandText = "SELECT * FROM cadastro WHERE ativoLivro = 1";// Seleciona todos os livros
                                                                                         // que tão ativo (1)
                MySqlDataReader reader = comandoMySql.ExecuteReader();

                dtgrid.Rows.Clear();

                while (reader.Read())
                {
                    DataGridViewRow row = (DataGridViewRow)dtgrid.Rows[0].Clone();//FAZ UM CAST E CLONA A LINHA DA TABELA
                    row.Cells[0].Value = reader.GetInt32(0);//ID
                    row.Cells[1].Value = reader.GetString(1);//genero
                    row.Cells[2].Value = reader.GetString(2);//titulo
                    row.Cells[3].Value = reader.GetString(3);//autor
                    row.Cells[4].Value = reader.GetInt32(4);//ANO
                    row.Cells[5].Value = reader.GetString(5);//editora               
                    row.Cells[6].Value = reader.GetString(6);//descricao
                    dtgrid.Rows.Add(row);//ADICIONO A LINHA NA TABELA
                }

                realizaConexacoBD.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! "); //Aparece esta mensagem caso não tenha conexão com banco de dados
                Console.WriteLine(ex.Message);
            }
        }

        
        

        private void btn_cancelar_Click(object sender, EventArgs e)

        {
            limparCampos();

        }

        private void limparCampos()// criada fun~ção para limpar os cambos dos componetentes abaixo:

        {
            tb_Id.Clear();//limpa campo o ID
            cbGenero.Text = "";//limpa o campo genero
            tbTitulo.Clear();//limpa o campo titulo
            tbAutor.Clear();//limpa o campo autor
            tbAno.Clear();//limpa o campo ano
            tbEditora.Clear();//limpa o campo editora
            tbDescricao.Clear(); //limpa o campo descicao
        }
      
       

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open();

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand();

                //faz uma insercao no banco de dados com insert in to. 1° informa os titulos que estão no banco de dados
                //depois informa na mesma ordem os campos que são preenchidos dentro do form para ao clicar em salvar seja alimentado o BD.
                comandoMySql.CommandText = "INSERT INTO cadastro (generoLivro,tituloLivro,autorLivro,anolivro,editoraLivro,descicaoLivro) " +
                "VALUES('" + cbGenero.Text + "', '" + tbTitulo.Text + "','" + tbAutor.Text + "', " + Convert.ToInt16(tbAno.Text) + ",'" 
                + tbEditora.Text + "','" + tbDescricao.Text + "')";

                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close();
                MessageBox.Show("Inserido com sucesso");
                atualizaGrid();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco
                
                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                //depois faz um update(atualização) nos campos abaixo, então seleciono no grid a linha que quero alterar
                //faço as alterações necessarias e clico em salvar, com isso o BD é atualizado.
                comandoMySql.CommandText = "UPDATE cadastro SET generoLivro = '" + cbGenero.Text + "', " +
                    "tituloLivro = '" + tbTitulo.Text + "', " +
                    "autorLivro = '" + tbAutor.Text + "', " +
                     "editoraLivro = '" + tbEditora.Text + "', " +
                    "descicaoLivro = '" + tbDescricao.Text + "', " +
                    "anoLivro = " + Convert.ToInt16(tbAno.Text) +                   
                    " WHERE idLivro = " + tb_Id.Text + "";
                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Atualizado com sucesso"); //Exibo mensagem de aviso
                atualizaGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder conexaoBD = conexaoBanco();
            MySqlConnection realizaConexacoBD = new MySqlConnection(conexaoBD.ToString());
            try
            {
                realizaConexacoBD.Open(); //Abre a conexão com o banco

                MySqlCommand comandoMySql = realizaConexacoBD.CreateCommand(); //Crio um comando SQL
                // "DELETE FROM cadastro WHERE idLivro = "+ textBoxId.Text +""
                //comandoMySql.CommandText = "DELETE FROM cadastro WHERE idLivro = " + tbID.Text + "";
                //nesta ponto quando eu excluo, na verdade eu esativo, pois estou fazendo uma atualização no campo de ativo
                //colocando como 0.
                //e como meu datadrid, só mostra os livros que são ativos (1) quando eu exluo o livro desaparece do meu grid.
                comandoMySql.CommandText = "UPDATE cadastro SET ativoLivro = 0 WHERE idLivro = " + tb_Id.Text + "";

                comandoMySql.ExecuteNonQuery();

                realizaConexacoBD.Close(); // Fecho a conexão com o banco
                MessageBox.Show("Deletado com sucesso"); //Exibo mensagem de aviso
                atualizaGrid();
                limparCampos();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Não foi possivel abrir a conexão! ");
                Console.WriteLine(ex.Message);
            }
        }

        private void dtgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dtgrid.CurrentRow.Selected = true;
                //preenche os textbox e combobox com as células da linha selecionada
                
                tb_Id.Text = dtgrid.Rows[e.RowIndex].Cells["colID"].FormattedValue.ToString();
                tbTitulo.Text = dtgrid.Rows[e.RowIndex].Cells["ColTitulo"].FormattedValue.ToString();
                cbGenero.Text = dtgrid.Rows[e.RowIndex].Cells["ColGenero"].FormattedValue.ToString();
                tbAutor.Text = dtgrid.Rows[e.RowIndex].Cells["ColAutor"].FormattedValue.ToString();
                tbAno.Text = dtgrid.Rows[e.RowIndex].Cells["ColAno"].FormattedValue.ToString();
                tbEditora.Text = dtgrid.Rows[e.RowIndex].Cells["ColEditora"].FormattedValue.ToString();
                tbDescricao.Text = dtgrid.Rows[e.RowIndex].Cells["ColDescricao"].FormattedValue.ToString();
                
               
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            limparCampos();
        }

        
    }
}
