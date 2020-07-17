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
    public partial class ConsultarFluxo : Form
    {
        SqlConnection sqlConn = new SqlConnection(@"Data Source=BmnGamer;Initial Catalog=dbHONIBUS;Integrated Security=True");
        private string _Sql = string.Empty;

        public ConsultarFluxo()
        {
            InitializeComponent();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarFluxo Form2 = new ConsultarFluxo();
            Consultas newForm3 = new Consultas();
            newForm3.ShowDialog();
        }

        private void fluxoDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarFluxo Form2 = new ConsultarFluxo();
            Fluxo newForm4 = new Fluxo();
            newForm4.ShowDialog();
        }

        private void ocorrênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarFluxo Form2 = new ConsultarFluxo();
            Ocorrencias newForm5 = new Ocorrencias();
            newForm5.ShowDialog();
        }

        private void cadastroÔnibusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarFluxo Form2 = new ConsultarFluxo();
            CadastroOni newForm6 = new CadastroOni();
            newForm6.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ConsultarFluxo Form2 = new ConsultarFluxo();
            CadastroMoto newForm7 = new CadastroMoto();
            newForm7.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
       
        }

        private void ConsultarFluxo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbHONIBUSDataSet.tbFLUXO' table. You can move, or remove it, as needed.
            this.tbFLUXOTableAdapter.Fill(this.dbHONIBUSDataSet.tbFLUXO);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var data = dateTimePicker_pesquisar.Value.Date;

            sqlConn.Open();
            SqlCommand sqlCommand = sqlConn.CreateCommand();

            sqlCommand.CommandText = ("select chegada, saida, data, registroMot, numeracao,confirmacao from tbFLUXO WHERE  convert(date, data) = @data ");

            SqlParameter parameterdata = new SqlParameter()
            {
                ParameterName = "@data",
                SqlDbType = SqlDbType.DateTime,
                Direction = ParameterDirection.Input,
                Value = data
            };

            sqlCommand.Parameters.Add(parameterdata);

    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
    DataTable dataTable = new DataTable();
    sqlDataAdapter.Fill(dataTable);
    sqlCommand.ExecuteNonQuery();

    dataGridView1.DataSource = dataTable;
    dataGridView1.Columns[0].HeaderText = "Chegada";
    dataGridView1.Columns[1].HeaderText = "Saída";
    dataGridView1.Columns[2].HeaderText = "Data";
    dataGridView1.Columns[3].HeaderText = "Registro Motorista";
    dataGridView1.Columns[4].HeaderText = "Numeração";
    dataGridView1.Columns[5].HeaderText = "Confirmação"; 

    sqlConn.Close();
}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        }
    }
