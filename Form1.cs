using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
//
namespace NotasFiscais
{
    public partial class Form1 : Form
    {
        SqlDataAdapter sda;
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbGente;Integrated Security=True");
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }
        //
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNroNota.Enabled = true;
            txtCliente.Text = "";
            txtDtaEmissao.Text = "";
            txtNroNota.Text = "";
            dataGridItens.Rows.Clear();
        }
        //
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            //COMANDOS PARA INCLUSÃO DE UMA NOVA NOTA FISCAL (TOPO)
            try
            {
                //ABRE A CONEXÃO
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbGente;Integrated Security=True");
                con.Open();
                //PREPARA O COMANDO SQL
                sda = new SqlDataAdapter(@"INSERT INTO MLF_NOTAFISCAL (NUMERONF, DTAEMISSAO, VLRTOTAL, PESSOA)VALUES( @numeronf, @dtaemissao, 0.00, @pessoa)", con);
                //INFORMA OS PARÂMETROS DO COMANDO
                sda.SelectCommand.Parameters.AddWithValue("@numeronf", txtNroNota.Text);
                sda.SelectCommand.Parameters.AddWithValue("@dtaemissao", txtDtaEmissao.Value.ToString("MM/dd/yyyy"));
                sda.SelectCommand.Parameters.AddWithValue("@pessoa", txtCliente.Text);
                //EXECUTA O COMANDO
                sda.SelectCommand.ExecuteNonQuery();
                //DESABILITA O CAMPO DE NÚMERO DA NOTA FISCAL
                txtNroNota.Enabled = false;
                //INSERÇÃO FEITA COM SUCESSO
                MessageBox.Show("Topo da Nota inserido com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.None);
                //FECHA A CONEXÃO
                con.Close();
                con.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            //COMANDOS PARA A ATUALIZAÇÃO DE INFORMAÇÕES DO TOPO DA NOTA
            try
            {
                //ABRE A CONEXÃO
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbGente;Integrated Security=True");
                con.Open();
                //ARMAZENA O UPDATE GENÉRICO EM UMA STRING
                string cmdUpdate = "UPDATE MLF_NOTAFISCAL SET DTAEMISSAO = @dtaemissao, VLRTOTAL = @vlrtotal, PESSOA = @pessoa WHERE NUMERONF = @numeronf";
                //PREPARA O COMANDO SQL
                SqlCommand scUpdate = new SqlCommand(cmdUpdate, con);
                //INFORMA OS PARÂMETROS DO COMANDO
                scUpdate.Parameters.AddWithValue("@numeronf", txtNroNota.Text);
                scUpdate.Parameters.AddWithValue("@dtaemissao", txtDtaEmissao.Value.ToString("MM/dd/yyyy"));
                scUpdate.Parameters.AddWithValue("@pessoa", txtCliente.Text);
                scUpdate.Parameters.AddWithValue("@vlrtotal", txtQtdTotal.Text);
                //EXECUTA O COMANDO
                scUpdate.ExecuteNonQuery();
                //DESABILITA O CAMPO DE NÚMERO DA NOTA FISCAL
                txtNroNota.Enabled = false;
                //INSERÇÃO FEITA COM SUCESSO
                MessageBox.Show("Topo da Nota atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.None);
                //FECHA A CONEXÃO
                con.Close();
                con.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                //LEITURA DOS TXTBOXES PARA MOSTRAR A DATA DE EMISSÃO DA NOTA FISCAL. 
                try
                {
                    //ABRE A CONEXÃO
                    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbGente;Integrated Security=True");
                    con.Open();
                    //DESABILITA O CAMPO DE DIGITAÇÃO DE NÚMERO DA NOTA FISCAL
                    txtNroNota.Enabled = false;
                    //CRIA O COMANDO DE LEITURA
                    SqlCommand command = new SqlCommand("SELECT DTAEMISSAO, PESSOA FROM MLF_NOTAFISCAL WHERE NUMERONF = @numeronf", con);
                    //CARREGA OS PARÂMETROS DO COMANDO SQL
                    command.Parameters.AddWithValue("@numeronf", txtNroNota.Text);
                    //INSTANCIA O OBJETO DE LEITURA DOS CAMPOS DATA DE EMISSÃO E PESSOA DA NOTA FISCAL
                    SqlDataReader reader = command.ExecuteReader();
                    //ENQUANTO HOUVER LINHAS, HAVERÁ LEITURA DOS CAMPOS
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //RECUPERA INFORMAÇÕES DO SELECT E INSERE NOS CAMPOS CORRETOS
                            txtDtaEmissao.Text = reader["DTAEMISSAO"].ToString();
                            txtCliente.Text = reader["PESSOA"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Data de Emissão ou Pessoa não encontrados.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    //DESABILITA OS CAMPOS NUMERO DA NOTA FISCAL, QUANTIDADE TOTAL E VALOR TOTAL.
                    txtNroNota.Enabled = false;
                    txtQtdTotal.Enabled = false;
                    txtVlrTotal.Enabled = false;
                    //FECHA O OBJETO READER
                    reader.Close();
                    //FECHA A CONEXÃO
                    command.Dispose();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNroNota.Enabled = true;
                }
                //
                //LEITURA DO VALOR TOTAL DE ITENS DA NOTA FISCAL. 
                try
                {
                    //ABRE A CONEXÃO
                    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbGente;Integrated Security=True");
                    con.Open();
                    //PREPARA O COMANDO SQL
                    SqlCommand command = new SqlCommand("SELECT SUM (QUANTIDADE * VLRITEM) AS TOTAL FROM MLF_NFITEM WHERE NUMERONF = @numeronf", con);
                    //CARREGA OS PARÂMETROS DO COMANDO
                    command.Parameters.AddWithValue("@numeronf", txtNroNota.Text);
                    //INSTANCIA O LEITOR DO COMANDO 
                    SqlDataReader reader = command.ExecuteReader();
                    //ENQUANTO HOUVER LINHAS
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //RECUPERA INFORMAÇÕES DO SELECT E INSERE NOS CAMPOS CORRETOS
                            txtVlrTotal.Text = reader["TOTAL"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Valor total não encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    //DESABILITA OS CAMPOS NUMERO DA NOTA FISCAL, QUANTIDADE TOTAL E VALOR TOTAL.
                    txtNroNota.Enabled = false;
                    txtQtdTotal.Enabled = false;
                    txtVlrTotal.Enabled = false;
                    //FECHA O LEITOR
                    reader.Close();
                    //FECHA A CONEXÃO
                    command.Dispose();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNroNota.Enabled = true;
                }

                //LEITURA DA QUANTIDADE TOTAL DE ITENS DA NOTA FISCAL. 
                try
                {
                    //ABRE A CONEXÃO
                    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbGente;Integrated Security=True");
                    con.Open();
                    //PREPARA O COMANDO SQL
                    SqlCommand command = new SqlCommand("SELECT SUM (QUANTIDADE) AS TOTAL FROM MLF_NFITEM WHERE NUMERONF = @numeronf", con);
                    //CARREGA OS PARÂMETROS DO COMANDO
                    command.Parameters.AddWithValue("@numeronf", txtNroNota.Text);
                    //INSTANCIA O OBJETO DE LEITURA DO COMANDO
                    SqlDataReader reader = command.ExecuteReader();
                    //SE RETORNAR INFORMAÇÕES
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            //RECUPERA INFORMAÇÕES DO SELECT E INSERE NOS CAMPOS CORRETOS
                            txtQtdTotal.Text = reader["TOTAL"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Quantidade não encontrada.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtNroNota.Enabled = true;
                    }
                    //DESABILITA OS CAMPOS NUMERO DA NOTA FISCAL, QUANTIDADE TOTAL E VALOR TOTAL.
                    txtNroNota.Enabled = false;
                    txtQtdTotal.Enabled = false;
                    txtVlrTotal.Enabled = false;
                    //FECHA O LETOR
                    reader.Close();
                    //FECHA A CONEXÃO
                    command.Dispose();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNroNota.Enabled = true;
                }
                //LEITURA DOS ITENS DA NOTA FISCAL
                try
                {
                    //ABRE A CONEXÃO
                    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbGente;Integrated Security=True");
                    con.Open();
                    //PREPARA O COMANDO
                    sda = new SqlDataAdapter(@"SELECT SEQPRODUTO, dsPRODUTO, QUANTIDADE, VLRITEM, QUANTIDADE*VLRITEM as TOTAL FROM MLF_NFITEM WHERE NUMERONF = @numeronf", con);
                    //CARREGA OS PARÂMETROS ATRAVÉS DOS CAMPOS DO FORM
                    sda.SelectCommand.Parameters.AddWithValue("@numeronf", txtNroNota.Text);
                    //INSTANCIA A TABELA DE DADOS (DATATABLE)
                    dt = new DataTable();
                    //DESCARREGA AS INFORMAÇÕES DO SELECT NA DATA TABLE
                    sda.Fill(dt);
                    dataGridItens.Rows.Clear();
                    //PARA CADA LINHA DE RETORNO:
                    foreach (DataRow item in dt.Rows)
                    {
                        //ADICIONA UMA NOVA LINHA NA TABELA DE DADOS
                        int n = dataGridItens.Rows.Add();
                        //COM OS VALORES CORRETOS DE CADA RETORNO EM CADA COLUNA ESPECÍFICA
                        dataGridItens.Rows[n].Cells[0].Value = item["SEQPRODUTO"].ToString();
                        dataGridItens.Rows[n].Cells[1].Value = item["dsPRODUTO"].ToString();
                        dataGridItens.Rows[n].Cells[2].Value = item["QUANTIDADE"].ToString();
                        dataGridItens.Rows[n].Cells[3].Value = item["VLRITEM"].ToString();
                        dataGridItens.Rows[n].Cells[4].Value = item["TOTAL"].ToString();
                    }
                }
                catch
                {
                    MessageBox.Show("Itens não encontrados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNroNota.Enabled = true;
                }
                //DESABILITA OS CAMPOS NUMERO DA NOTA FISCAL, QUANTIDADE TOTAL E VALOR TOTAL.
                txtNroNota.Enabled = false;
                txtQtdTotal.Enabled = false;
                txtVlrTotal.Enabled = false;
                //FECHA A CONEXÃO
                con.Close();
                con.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void btnGravItens_Click(object sender, EventArgs e)
        {
            //ATUALIZAR ITENS DA NOTA FISCAL
            try
            {
                //ABRE A CONEXÃO
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbGente;Integrated Security=True");
                con.Open();
                //INSTANCIA O COMMAND BUILDER PARA MANIPULAÇÃO DA DATAGRID VIEW.
                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(sda);
                //GERA O COMANDO DE ATUALIZAÇÃO DOS DADOS
                sda.Update(dt);
                //MENSAGEM DE ATUALIZAÇÃO POSITIVA DOS DADOS
                MessageBox.Show("Itens Gravados com Sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //FECHA A CONEXÃO
            con.Close();
            con.Dispose();
        }

        private void btnInclItens_Click(object sender, EventArgs e)
        {
            //INCLUIR ITENS DA NOTA FISCAL
            try
            {
                //ABRE A CONEXÃO
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbGente;Integrated Security=True");
                con.Open();
                //INSERE OS ITENS NA GRID DE ACORDO COM OS CAMPOS
                int n = dataGridItens.Rows.Add();
                dataGridItens.Rows[n].Cells[0].Value = txtCodProd.Text;
                dataGridItens.Rows[n].Cells[1].Value = txtDsProduto.Text;
                dataGridItens.Rows[n].Cells[2].Value = txtQtdProd.Text;
                dataGridItens.Rows[n].Cells[3].Value = Convert.ToDecimal(txtVlrUnit.Text);
                dataGridItens.Rows[n].Cells[4].Value = Convert.ToDecimal(txtQtdProd.Text) * Convert.ToDecimal(txtVlrUnit.Text);
                //INSERE OS DADOS NO BANCO DE DADOS
                sda = new SqlDataAdapter(@"INSERT INTO MLF_NFITEM (NUMERONF, SEQPRODUTO, QUANTIDADE, VLRITEM, dsPRODUTO, PESSOA)VALUES( @numeronf, @seqproduto, @quantidade, @vlritem, @dsProduto, @pessoa)", con);
                //INFORMA OS PARÂMETROS DO COMANDO
                sda.SelectCommand.Parameters.AddWithValue("@numeronf", txtNroNota.Text);
                sda.SelectCommand.Parameters.AddWithValue("@seqproduto", txtCodProd.Text);
                sda.SelectCommand.Parameters.AddWithValue("@quantidade", txtQtdProd.Text);
                sda.SelectCommand.Parameters.AddWithValue("@vlritem", txtVlrUnit.Text);
                sda.SelectCommand.Parameters.AddWithValue("@dsProduto", txtDsProduto.Text);
                sda.SelectCommand.Parameters.AddWithValue("@pessoa", txtCliente.Text);
                //EXECUTA O COMANDO
                sda.SelectCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //FECHA A CONEXÃO
            con.Close();
            con.Dispose();
        }

        private void dataGridItens_KeyDown(object sender, KeyEventArgs e)
        {
            //EXCLUI ITENS DA NOTA FISCAL
            // SE A LINHA FOR SELECIONADA E A TECLA DELETE FOR PRESSIONADA
            if (e.KeyCode == Keys.Delete)
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir o produto?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {

                        //ABRE A CONEXÃO
                        SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbGente;Integrated Security=True");
                        con.Open();
                        //ARMAZENA O UPDATE GENÉRICO EM UMA STRING
                        string cmdDelete = "DELETE FROM MLF_NFITEM WHERE NUMERONF = @numeronf AND SEQPRODUTO = @seqproduto";
                        //PREPARA O COMANDO SQL
                        SqlCommand scDelete = new SqlCommand(cmdDelete, con);
                        //INFORMA OS PARÂMETROS DO COMANDO
                        scDelete.Parameters.AddWithValue("@numeronf", txtNroNota.Text);
                        scDelete.Parameters.AddWithValue("@seqproduto", txtCodProd.Text);
                        //EXECUTA O COMANDO
                        scDelete.ExecuteNonQuery();
                        //DESABILITA O CAMPO DE NÚMERO DA NOTA FISCAL
                        txtNroNota.Enabled = false;
                        //INSERÇÃO FEITA COM SUCESSO
                        MessageBox.Show("Item excluído com Sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.None);
                        //FECHA A CONEXÃO
                        con.Close();
                        con.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    con.Close();
                }
            }
        }

        private void dataGridItens_MouseClick(object sender, MouseEventArgs e)
        {
            txtCodProd.Text = dataGridItens.SelectedRows[0].Cells[0].Value.ToString();
            txtDsProduto.Text = dataGridItens.SelectedRows[0].Cells[1].Value.ToString();
            txtQtdProd.Text = dataGridItens.SelectedRows[0].Cells[2].Value.ToString();
            txtVlrUnit.Text = dataGridItens.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir a nota fiscal?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //ABRE A CONEXÃO
                    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DbGente;Integrated Security=True");
                    con.Open();
                    //ARMAZENA O UPDATE GENÉRICO EM UMA STRING
                    string cmdDeleteItem = "DELETE FROM MLF_NFITEM WHERE NUMERONF = @numeronf";
                    string cmdDeleteTopo = "DELETE FROM MLF_NOTAFISCAL WHERE NUMERONF = @numeronf";
                    //PREPARA O COMANDO SQL
                    SqlCommand scDeleteItem = new SqlCommand(cmdDeleteItem, con);
                    SqlCommand scDeleteTopo = new SqlCommand(cmdDeleteTopo, con);
                    //INFORMA OS PARÂMETROS DO COMANDO
                    scDeleteItem.Parameters.AddWithValue("@numeronf", txtNroNota.Text);
                    scDeleteTopo.Parameters.AddWithValue("@numeronf", txtNroNota.Text);
                    //EXECUTA O COMANDO
                    scDeleteItem.ExecuteNonQuery();
                    scDeleteTopo.ExecuteNonQuery();
                    //DESABILITA O CAMPO DE NÚMERO DA NOTA FISCAL
                    txtNroNota.Enabled = false;
                    //INSERÇÃO FEITA COM SUCESSO
                    MessageBox.Show("Nota Fiscal Excluída com Sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.None);
                    //FECHA A CONEXÃO
                    con.Close();
                    con.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        private void dataGridItens_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





        }
    }
}
