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
    public partial class ConsultarOni : Form
    {
        SqlConnection sqlConn = new SqlConnection(@"Data Source=BmnGamer;Initial Catalog=dbHONIBUS;Integrated Security=True");

        public ConsultarOni()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbONIBUS WHERE numeracao='" + numeracao.Text + "' ";

            SqlCommand comando = new SqlCommand(sql, sqlConn);

            sqlConn.Open();

            SqlDataReader ler = comando.ExecuteReader();
            if (ler.Read() == true)
            {
                fabricacao.Text = ler["fabricacao"].ToString();
                placa.Text = ler["placa"].ToString();
                modelo.Text = ler["modelOnibus"].ToString();
                situacao.Text = ler["situacao"].ToString();
                motorista1.Text = ler["motoristaUm"].ToString();
                motorista2.Text = ler["motoristaDois"].ToString();
                periodo1.Text = ler["periodoMotUm"].ToString();
                periodo2.Text = ler["periodoMotDois"].ToString();


            }
            else
            {
                MessageBox.Show("Registro não Cadastrado");
            }

            sqlConn.Close();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarOni Form2 = new ConsultarOni();
            Consultas newForm3 = new Consultas();
            newForm3.ShowDialog();
        }

        private void fluxoDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarOni Form2 = new ConsultarOni();
            Fluxo newForm4 = new Fluxo();
            newForm4.ShowDialog();
        }

        private void ocorrênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarOni Form2 = new ConsultarOni();
            Ocorrencias newForm5 = new Ocorrencias();
            newForm5.ShowDialog();
        }

        private void cadastroÔnibusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarOni Form2 = new ConsultarOni();
            CadastroOni newForm6 = new CadastroOni();
            newForm6.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarOni Form2 = new ConsultarOni();
            CadastroMoto newForm7 = new CadastroMoto();
            newForm7.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strSQL = "UPDATE tbONIBUS SET situacao='" + situacao.Text + "'";
            SqlCommand comando = new SqlCommand(strSQL, sqlConn);
            try
            {
                sqlConn.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Salvo com Sucesso!");
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

        private void ConsultarOni_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Grade2(numeracao.Text);
            form.Show();
        }
    }
}
