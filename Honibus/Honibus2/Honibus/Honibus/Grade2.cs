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
    public partial class Grade2 : Form
    {
        static SqlConnection sqlConn = new SqlConnection("Data Source=ETEC-PC;Initial Catalog=dbHONIBUS;Integrated Security=True");

        public Grade2()
        {
            InitializeComponent();
        }

        private void Buscar_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                string comando = "SELECT chegada, saida, data, registroMot, numeracao, confirmacao FROM tbFLUXO WHERE numeracao='" + textBox1.Text + "'";

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
                string comando = "SELECT nOcorencia, motivoOcorencia, descricaoMotivo, motorista, data, numeracao, registroMot FROM tbOCORENCIA WHERE numeracao='" + textBox1.Text + "'";

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
        public Grade2(string texto)
        {
            InitializeComponent();
            textBox1.Text = texto;            
        }

        private void Grade2_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;


        }
    }
}
