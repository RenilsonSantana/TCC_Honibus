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
    public partial class ConsultarMoto : Form
    {
        SqlConnection conx = new SqlConnection(@"Data Source=ETEC-PC;Initial Catalog=dbHONIBUS;Integrated Security=True");
        private string _Sql = string.Empty;


        public ConsultarMoto()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM tbMOTORISTA WHERE registroMot='" + registroMot.Text + "' ";

            SqlCommand comando = new SqlCommand(sql, conx);

            conx.Open();

            SqlDataReader ler = comando.ExecuteReader();
            if (ler.Read() == true)
            {
                nome.Text = ler["nomeMotorista"].ToString();
                dataAdm.Text = ler["dataAdm"].ToString();
                habilitacao.Text = ler["habilitacao"].ToString();
                cpf.Text = ler["cpf"].ToString();
                turno.Text = ler["turno"].ToString();
                situacao.Text = ler["situacao"].ToString();
                numeracao.Text = ler["numeracao"].ToString();

            }
            else
            {
                MessageBox.Show("Registro não Cadastrado");
            }

            conx.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarMoto Form2 = new ConsultarMoto();
            Consultas newForm3 = new Consultas();
            newForm3.ShowDialog();
        }

        private void fluxoDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarMoto Form2 = new ConsultarMoto();
            Fluxo newForm4 = new Fluxo();
            newForm4.ShowDialog();
        }

        private void ocorrênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarMoto Form2 = new ConsultarMoto();
            Ocorrencias newForm5 = new Ocorrencias();
            newForm5.ShowDialog();
        }

        private void cadastroÔnibusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarMoto Form2 = new ConsultarMoto();
            CadastroOni newForm6 = new CadastroOni();
            newForm6.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarMoto Form2 = new ConsultarMoto();
            CadastroMoto newForm7 = new CadastroMoto();
            newForm7.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strSQL = "UPDATE tbMOTORISTA SET situacao='" + situacao.Text + "'";
            SqlCommand comando = new SqlCommand(strSQL, conx);
            try
            {
                conx.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Salvo com Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {

                conx.Close();

            }

        }

        private void ConsultarMoto_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var form = new Grade(registroMot.Text);
            form.Show();

        }
         
    }
}
