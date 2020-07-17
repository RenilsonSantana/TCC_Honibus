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
    public partial class Ocorrencias : Form
    {
        SqlConnection sqlConn = null;
        private string strConn = @"Data Source=BmnGamer;Initial Catalog=dbHONIBUS;Integrated Security=True";
        private string _Sql = string.Empty;

        public Ocorrencias()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fluxoDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Ocorrencias Form2 = new Ocorrencias();
            Fluxo newForm4 = new Fluxo();
            newForm4.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Ocorrencias Form2 = new Ocorrencias();
            Consultas newForm3 = new Consultas();
            newForm3.ShowDialog();
        }

        private void ocorrênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Ocorrencias Form2 = new Ocorrencias();
            Ocorrencias newForm5 = new Ocorrencias();
            newForm5.ShowDialog();
        }

        private void cadastroÔnibusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Ocorrencias Form2 = new Ocorrencias();
            CadastroOni newForm6 = new CadastroOni();
            newForm6.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Ocorrencias Form2 = new Ocorrencias();
            CadastroMoto newForm7 = new CadastroMoto();
            newForm7.ShowDialog();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {

            if (nome.Text == "" || textBox4.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Preencha Campo(os) Vazio(os)");

            }
            else
            {
                _Sql = "INSERT INTO tbOCORENCIA (nOcorencia, motivoOcorencia, descricaoMotivo,  motorista, registroMot, numeracao, data ) VALUES (@nOcorencia, @motivoOcorencia, @descricaoMotivo, @motorista, @registroMot, @numeracao, @data ) ";

                sqlConn = new SqlConnection(strConn);
                SqlCommand comando = new SqlCommand(_Sql, sqlConn);

                comando.Parameters.Add("@nOcorencia", SqlDbType.Int).Value = Convert.ToInt32(textBox4.Text);
                comando.Parameters.Add("@descricaoMotivo", SqlDbType.VarChar).Value = textBox3.Text;
                comando.Parameters.Add("@motorista", SqlDbType.VarChar).Value = nome.Text;
                comando.Parameters.Add("@registroMot", SqlDbType.VarChar).Value = Convert.ToInt32(registro1.Text);
                comando.Parameters.Add("@numeracao", SqlDbType.VarChar).Value = Convert.ToInt32(numeracao.Text);
                comando.Parameters.Add("@data", SqlDbType.DateTime).Value = Convert.ToDateTime(data.Text);

                if (acidente.Checked)
                {
                    comando.Parameters.Add("@motivoOcorencia", SqlDbType.VarChar, 8).Value = "Acidente";
                }
                 else if (falha.Checked)
                {
                    comando.Parameters.Add("@motivoOcorencia", SqlDbType.VarChar, 5).Value = "Falha";
                }
                else
                {  
                        comando.Parameters.Add("@motivoOcorencia", SqlDbType.VarChar, 6).Value = "Outros";
                }

                try
                {
                    sqlConn.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com Sucesso");
                }
                catch (Exception)
                {
                    MessageBox.Show("Numero de ocorrencia invalido ou ja cadastrado");
                }
                finally
                {
                    sqlConn.Close();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ocorrencias_Load(object sender, EventArgs e)
        {
            acidente.Checked = true;
            data.Text = DateTime.Now.ToString();
            Random nAleatorio = new Random();            
            textBox4.Text = Convert.ToString(nAleatorio.Next(0, 100));
           
        }

        private void registro_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void registro1_TextChanged(object sender, EventArgs e)
        {

        }

        private void registro_Click(object sender, EventArgs e)
        {
 
        }

        private void numeracao_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pesquisa form = new Pesquisa();
            form.ShowDialog();
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void nome_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
