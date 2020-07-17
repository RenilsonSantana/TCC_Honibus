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
    public partial class CadastroMoto : Form
    {
        SqlConnection sqlConn = null;
        private string strConn = @"Data Source=BmnGamer;Initial Catalog=dbHONIBUS;Integrated Security=True";
        private string _Sql = string.Empty;

        public CadastroMoto()
        {
            InitializeComponent();
        }


        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            Ativo.Checked = true;
            Random nAleatorio = new Random();
            textBox2.Text = Convert.ToString(nAleatorio.Next(0, 100));
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastroMoto Form2 = new CadastroMoto();
            Consultas newForm3 = new Consultas();
            newForm3.ShowDialog();
        }

        private void fluxoDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastroMoto Form2 = new CadastroMoto();
            Fluxo newForm4 = new Fluxo();
            newForm4.ShowDialog();
        }

        private void ocorrênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastroMoto Form2 = new CadastroMoto();
            Ocorrencias newForm5 = new Ocorrencias();
            newForm5.ShowDialog();
        }

        private void cadastroÔnibusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastroMoto Form2 = new CadastroMoto();
            CadastroOni newForm6 = new CadastroOni();
            newForm6.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            CadastroMoto Form2 = new CadastroMoto();
            CadastroMoto newForm7 = new CadastroMoto();
            newForm7.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || maskedTextBox1.Text == "" || textBox8.Text == "")
            {
                MessageBox.Show("Preencha Campo(os) Vazio(os)");

            }
            else
            {
                _Sql = "INSERT INTO tbMOTORISTA (nomeMotorista, registroMot, habilitacao, cpf, dataAdm, turno) VALUES (@nomeMotorista, @registroMot, @habilitacao, @cpf, @dataAdm, @turno) ";
                sqlConn = new SqlConnection(strConn);
                SqlCommand comando = new SqlCommand(_Sql, sqlConn);

                comando.Parameters.Add("@nomeMotorista", SqlDbType.VarChar).Value = textBox1.Text;
                comando.Parameters.Add("@registroMot", SqlDbType.Int).Value = Convert.ToInt32(textBox2.Text);
                comando.Parameters.Add("@habilitacao", SqlDbType.Decimal).Value = Convert.ToInt32(textBox3.Text);
                comando.Parameters.Add("@cpf", SqlDbType.Decimal).Value = Convert.ToInt32(textBox4.Text);
                comando.Parameters.Add("@dataAdm", SqlDbType.Date).Value = maskedTextBox1.Text;
                comando.Parameters.Add("@turno", SqlDbType.VarChar).Value = textBox8.Text;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Inativo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
