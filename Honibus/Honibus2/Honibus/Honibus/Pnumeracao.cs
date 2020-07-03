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
    public partial class Pnumeracao : Form
    {
        private SqlConnection sqlConn;
        private SqlCommand comando;
        private SqlDataAdapter Adp;

        public Pnumeracao()
        {
            InitializeComponent();
            sqlConn = new SqlConnection("Data Source=ETEC-PC;Initial Catalog=dbHONIBUS;Integrated Security=True");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ocorrencias escolha = new Ocorrencias();
            escolha.numeracao.Text = dataGridView1[4, dataGridView1.CurrentRow.Index].Value.ToString();

            escolha.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string comando = "SELECT numeracao, fabricacao, placa, modelOnibus, situacao, motoristaUm, motoristaDois, periodoMotUm, periodoMotDois FROM tbONIBUS WHERE numeracao like '%" + textBox1.Text + "%'";
            DataTable dttbMOTORISTA = new DataTable();
            try
            {
                sqlConn.Open();
                if (sqlConn.State == ConnectionState.Open)
                {
                    SqlDataAdapter Adp = new SqlDataAdapter(comando, sqlConn);
                    Adp.Fill(dttbMOTORISTA);
                    dataGridView1.DataSource = dttbMOTORISTA;
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
    }
}
