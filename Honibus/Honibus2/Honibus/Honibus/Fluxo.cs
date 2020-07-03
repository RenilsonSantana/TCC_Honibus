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
using Honibus.dbHONIBUSDataSetTableAdapters;

namespace Honibus
{
    public partial class Fluxo : Form
    {
        private SqlConnection sqlConn;
        private SqlCommand comando;
        private string _Sql = string.Empty;

        public Fluxo()
        {
            InitializeComponent();
            sqlConn = new SqlConnection("Data Source=ETEC-PC;Initial Catalog=dbHONIBUS;Integrated Security=True");
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fluxoDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Fluxo Form2 = new Fluxo();
            Fluxo newForm4 = new Fluxo();
            newForm4.ShowDialog();
        }

        private void ocorrênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Fluxo Form2 = new Fluxo();
            Ocorrencias newForm5 = new Ocorrencias();
            newForm5.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Fluxo Form2 = new Fluxo();
            Consultas newForm3 = new Consultas();
            newForm3.ShowDialog();
        }

        private void cadastroÔnibusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Fluxo Form2 = new Fluxo();
            CadastroOni newForm6 = new CadastroOni();
            newForm6.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Fluxo Form2 = new Fluxo();
            CadastroMoto newForm7 = new CadastroMoto();
            newForm7.ShowDialog();
        }

        private void Fluxo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbHONIBUSDataSet.tbFLUXO' table. You can move, or remove it, as needed.
            this.tbFLUXOTableAdapter.Fill(this.dbHONIBUSDataSet.tbFLUXO);
            data.Text = DateTime.Now.ToString();

            
        }
 
   

        private void button1_Click(object sender, EventArgs e)
        {
            string comando = "SELECT chegada, saida, data, registroMot, numeracao FROM tbFLUXO WHERE data='" + data.Text + "' ";
          
             
            DataTable dttbFLUXO = new DataTable();
            try
            {
                sqlConn.Open();
                if (sqlConn.State == ConnectionState.Open)
                {
                    
                    SqlDataAdapter Adp = new SqlDataAdapter(comando, sqlConn);
                    Adp.Fill(dttbFLUXO);
                    dataFluxo.DataSource = dttbFLUXO;
                    dataFluxo.Columns[0].HeaderText = "Chegada";
                    dataFluxo.Columns[1].HeaderText = "Saída";
                    dataFluxo.Columns[2].HeaderText = "Data";
                    dataFluxo.Columns[3].HeaderText = "Registro Motorista";
                    dataFluxo.Columns[4].HeaderText = "Numeração";
                }
                else
                {
                    MessageBox.Show("Falha na conexão");
                }
            }
            catch
            {
                MessageBox.Show("ERRO NA LEITURA");
            }
            finally
            {

                sqlConn.Close();
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.Enabled = false;
            if (button2.Enabled == false)
            {
                button9.Enabled = false;
            }
            string strSQL = "update tbFLUXO set confirmacao='ok' where campo=1";
            SqlCommand comando = new SqlCommand(strSQL, sqlConn);
            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Confirmado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                sqlConn.Close();

            }
 
        }


        private void button9_Click(object sender, EventArgs e)
        {
            
            string strSQL = "update tbFLUXO set confirmacao='não confirmado' where campo=1";
            SqlCommand comando = new SqlCommand(strSQL, sqlConn);
            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                DialogResult confirm = MessageBox.Show("Adicionar Ocorrência?", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "OK")
                {
                    this.Visible = false;
                    Fluxo Form2 = new Fluxo();
                    Ocorrencias newForm5 = new Ocorrencias();
                    newForm5.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                sqlConn.Close();

            }
                    }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Enabled = false;
            if (button8.Enabled == false)
            {
                button7.Enabled = false;
            }

            string strSQL = "update tbFLUXO set confirmacao='ok' where campo=2";
            SqlCommand comando = new SqlCommand(strSQL, sqlConn);
            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Confirmado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                sqlConn.Close();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Enabled = false;
            if (button6.Enabled == false)
            {
                button5.Enabled = false;
            }
            string strSQL = "update tbFLUXO set confirmacao='ok' where campo=2";
            SqlCommand comando = new SqlCommand(strSQL, sqlConn);
            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Confirmado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                sqlConn.Close();

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Enabled = false;
            if (button4.Enabled == false)
            {
                button3.Enabled = false;
            }
            string strSQL = "update tbFLUXO set confirmacao='ok' where campo=3";
            SqlCommand comando = new SqlCommand(strSQL, sqlConn);
            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Confirmado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                sqlConn.Close();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string strSQL = "update tbFLUXO set confirmacao='não confirmado' where campo=2";
            SqlCommand comando = new SqlCommand(strSQL, sqlConn);
            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                DialogResult confirm = MessageBox.Show("Adicionar Ocorrência?", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "OK")
                {
                    this.Visible = false;
                    Fluxo Form2 = new Fluxo();
                    Ocorrencias newForm5 = new Ocorrencias();
                    newForm5.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                sqlConn.Close();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strSQL = "update tbFLUXO set confirmacao='não confirmado' where campo=3";
            SqlCommand comando = new SqlCommand(strSQL, sqlConn);
            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                DialogResult confirm = MessageBox.Show("Adicionar Ocorrência?", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "OK")
                {
                    this.Visible = false;
                    Fluxo Form2 = new Fluxo();
                    Ocorrencias newForm5 = new Ocorrencias();
                    newForm5.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                sqlConn.Close();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strSQL = "update tbFLUXO set confirmacao='não confirmado' where campo=4";
            SqlCommand comando = new SqlCommand(strSQL, sqlConn);
            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                DialogResult confirm = MessageBox.Show("Adicionar Ocorrência?", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

                if (confirm.ToString().ToUpper() == "OK")
                {
                    this.Visible = false;
                    Fluxo Form2 = new Fluxo();
                    Ocorrencias newForm5 = new Ocorrencias();
                    newForm5.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                sqlConn.Close();

            }
        }
    }
}
