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
    public partial class Grade : Form

    {
        static SqlConnection sqlConn = new SqlConnection("Data Source=ETEC-PC;Initial Catalog=dbHONIBUS;Integrated Security=True");


        public Grade()
        {
            InitializeComponent();        
        }

     

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Grade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbHONIBUSDataSet.tbFLUXO' table. You can move, or remove it, as needed.
            this.tbFLUXOTableAdapter.Fill(this.dbHONIBUSDataSet.tbFLUXO);
            radioButton1.Checked = true;
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked)
            {
                string comando = "SELECT chegada, saida, data, registroMot, numeracao, confirmacao FROM tbFLUXO WHERE registroMot='" + textBox1.Text + "'";

                DataTable dttbFLUXO = new DataTable();
                try
                {
                    sqlConn.Open();
                    if (sqlConn.State == ConnectionState.Open)
                    {

                        SqlDataAdapter Adp = new SqlDataAdapter(comando, sqlConn);
                        Adp.Fill(dttbFLUXO);
                        dataGridView1.DataSource = dttbFLUXO;
                        dataGridView1.Columns[0].HeaderText = "Chegada";
                        dataGridView1.Columns[1].HeaderText = "Saída";
                        dataGridView1.Columns[2].HeaderText = "Data";
                        dataGridView1.Columns[3].HeaderText = "Registro Motorista";
                        dataGridView1.Columns[4].HeaderText = "Numeração";
                        dataGridView1.Columns[5].HeaderText = "Confirmação"; 
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
            if (Ocorrências.Checked)
            {
                string comando = "SELECT nOcorencia, motivoOcorencia, descricaoMotivo, motorista, data, numeracao, registroMot FROM tbOCORENCIA WHERE registroMot='" + textBox1.Text + "'";

                DataTable dttbFLUXO = new DataTable();
                try
                {
                    sqlConn.Open();
                    if (sqlConn.State == ConnectionState.Open)
                    {

                        SqlDataAdapter Adp = new SqlDataAdapter(comando, sqlConn);
                        Adp.Fill(dttbFLUXO);
                        dataGridView1.DataSource = dttbFLUXO;
                        dataGridView1.Columns[0].HeaderText = "Número";
                        dataGridView1.Columns[1].HeaderText = "Motivo";
                        dataGridView1.Columns[2].HeaderText = "Descrição";
                        dataGridView1.Columns[3].HeaderText = "Motorista";
                        dataGridView1.Columns[4].HeaderText = "Data";
                        dataGridView1.Columns[5].HeaderText = "Numeração";
                        dataGridView1.Columns[6].HeaderText = "Registro Motorista";
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
        public Grade(string texto)
        {
            InitializeComponent();
            textBox1.Text = texto;            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Ocorrências_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
