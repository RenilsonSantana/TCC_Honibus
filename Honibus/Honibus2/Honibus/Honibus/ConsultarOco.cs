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
    public partial class ConsultarOco : Form
    {
        SqlConnection sqlConn = new SqlConnection(@"Data Source=BmnGamer;Initial Catalog=dbHONIBUS;Integrated Security=True");
        private string _Sql = string.Empty;

        public ConsultarOco()
        {
            InitializeComponent();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarOco Form2 = new ConsultarOco();
            Consultas newForm3 = new Consultas();
            newForm3.ShowDialog();
        }

        private void fluxoDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarOco Form2 = new ConsultarOco();
            Fluxo newForm4 = new Fluxo();
            newForm4.ShowDialog();
        }

        private void ocorrênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarOco Form2 = new ConsultarOco();
            Ocorrencias newForm5 = new Ocorrencias();
            newForm5.ShowDialog();
        }

        private void cadastroÔnibusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarOco Form2 = new ConsultarOco();
            CadastroOni newForm6 = new CadastroOni();
            newForm6.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarOco Form2 = new ConsultarOco();
            CadastroMoto newForm7 = new CadastroMoto();
            newForm7.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbOCORENCIA WHERE nOcorencia='" + nOcorrencia.Text + "' ";

            SqlCommand comando = new SqlCommand(sql, sqlConn);

            sqlConn.Open();

            SqlDataReader ler = comando.ExecuteReader();
            if (ler.Read() == true)
            {
                numeracao.Text = ler["numeracao"].ToString();
                motivo.Text = ler["motivoOcorencia"].ToString();
                motorista.Text = ler["motorista"].ToString();
                registroMot.Text = ler["registroMot"].ToString();
                descricao.Text = ler["descricaoMotivo"].ToString();
                data.Text = ler["data"].ToString();

            }
            else
            {
                MessageBox.Show("Registro não Cadastrado");
            }

            sqlConn.Close();
        }

        private void ConsultarOco_Load(object sender, EventArgs e)
        {

        }
    }
}
