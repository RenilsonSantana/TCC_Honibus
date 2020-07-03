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

namespace Honibus
{
    public partial class CadastroOni : Form
    {
        SqlConnection sqlConn = null;
        private string strConn = @"Data Source=ETEC-PC;Initial Catalog=dbHONIBUS;Integrated Security=True";
        private string _Sql = string.Empty;

        public CadastroOni()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Ativo.Checked = true;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastroOni Form2 = new CadastroOni();
            Consultas newForm3 = new Consultas();
            newForm3.ShowDialog();
        }

        private void fluxoDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastroOni Form2 = new CadastroOni();
            Fluxo newForm4 = new Fluxo();
            newForm4.ShowDialog();
        }

        private void ocorrênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastroOni Form2 = new CadastroOni();
            Ocorrencias newForm5 = new Ocorrencias();
            newForm5.ShowDialog();
        }

        private void cadastroÔnibusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastroOni Form2 = new CadastroOni();
            CadastroOni newForm6 = new CadastroOni();
            newForm6.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastroOni Form2 = new CadastroOni();
            CadastroMoto newForm7 = new CadastroMoto();
            newForm7.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox9.Text == "" || maskedTextBox1.Text == "" || textBox8.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Preencha Campo(os) Vazio(os)");

            }
            else
            {
                _Sql = "INSERT INTO tbONIBUS (numeracao, fabricacao, placa, modelOnibus, situacao, motoristaUm, motoristaDois, periodoMotUm, periodoMotDois) VALUES (@numeracao, @fabricacao, @placa, @modelOnibus, @situacao, @motoristaUm, @motoristaDois, @periodoMotUm, @periodoMotDois) ";
                sqlConn = new SqlConnection(strConn);
                SqlCommand comando = new SqlCommand(_Sql, sqlConn);

                comando.Parameters.Add("@numeracao", SqlDbType.VarChar).Value = textBox1.Text;
                comando.Parameters.Add("@fabricacao", SqlDbType.Date).Value = maskedTextBox1.Text;
                comando.Parameters.Add("@placa", SqlDbType.VarChar).Value = textBox8.Text;
                comando.Parameters.Add("@modelOnibus", SqlDbType.VarChar).Value = textBox9.Text;
                comando.Parameters.Add("@motoristaUm", SqlDbType.VarChar).Value = textBox4.Text;
                comando.Parameters.Add("@motoristaDois", SqlDbType.VarChar).Value = textBox5.Text;
                comando.Parameters.Add("@periodoMotUm", SqlDbType.VarChar).Value = textBox6.Text;
                comando.Parameters.Add("@periodoMotDois", SqlDbType.VarChar).Value = textBox7.Text;

                if (Ativo.Checked)
                {
                    comando.Parameters.Add("@situacao", SqlDbType.VarChar, 5).Value = "Ativo";
                }
                else
                {
                    comando.Parameters.Add("@situacao", SqlDbType.VarChar, 7).Value = "Inativo";
                }
                

                try
                {
                    sqlConn.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com Sucesso");
                }

                catch (Exception)
                {
                    MessageBox.Show("Cadastro já existente ou Informações Incorretas");
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

    }
}
