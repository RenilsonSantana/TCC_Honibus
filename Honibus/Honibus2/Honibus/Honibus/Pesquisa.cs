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
    public partial class Pesquisa : Form
    {
        private SqlConnection sqlConn;
        private SqlDataAdapter Adp;

        public Pesquisa()
        {
            InitializeComponent();
            sqlConn = new SqlConnection("Data Source=BmnGamer;Initial Catalog=dbHONIBUS;Integrated Security=True");

        }

        
        private void carregar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Ocorrencias escolha = new Ocorrencias();
            escolha.registro1.Text = carregar[1, carregar.CurrentRow.Index].Value.ToString();
            escolha.nome.Text = carregar[0, carregar.CurrentRow.Index].Value.ToString();
            escolha.numeracao.Text = carregar[7, carregar.CurrentRow.Index].Value.ToString();
            escolha.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (nome.Checked == true)
            {
                string comando = "SELECT nomeMotorista ,registroMot ,cpf ,turno, habilitacao , dataAdm , situacao , numeracao FROM tbMOTORISTA WHERE nomeMotorista like '%" + textBox1.Text + "%'";
                DataTable dttbMOTORISTA = new DataTable();
                try
                {
                    sqlConn.Open();
                    if (sqlConn.State == ConnectionState.Open)
                    {
                        SqlDataAdapter Adp = new SqlDataAdapter(comando, sqlConn);
                        Adp.Fill(dttbMOTORISTA);
                        carregar.DataSource = dttbMOTORISTA;
                    }
                    else
                    {
                        MessageBox.Show("Nome Incorreto");
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
            else
            {
                string comando = "SELECT nomeMotorista ,registroMot ,cpf ,turno, habilitacao , dataAdm , situacao , numeracao FROM tbMOTORISTA WHERE registroMot like '%" + textBox1.Text + "%'";
                DataTable dttbMOTORISTA = new DataTable();
                try
                {
                    sqlConn.Open();
                    if (sqlConn.State == ConnectionState.Open)
                    {
                        SqlDataAdapter Adp = new SqlDataAdapter(comando, sqlConn);
                        Adp.Fill(dttbMOTORISTA);
                        carregar.DataSource = dttbMOTORISTA;
                    }
                    else
                    {
                        MessageBox.Show("Registro Incorreto");
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

        private void Pesquisa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbHONIBUSDataSet1.tbOCORENCIA' table. You can move, or remove it, as needed.
            this.tbOCORENCIATableAdapter.Fill(this.dbHONIBUSDataSet1.tbOCORENCIA);
            // TODO: This line of code loads data into the 'dbHONIBUSDataSet1.tbMOTORISTA' table. You can move, or remove it, as needed.
            this.tbMOTORISTATableAdapter.Fill(this.dbHONIBUSDataSet1.tbMOTORISTA);
            // TODO: This line of code loads data into the 'dbHONIBUSDataSet.tbMOTORISTA' table. You can move, or remove it, as needed.
            this.tbMOTORISTATableAdapter.Fill(this.dbHONIBUSDataSet.tbMOTORISTA);
            nome.Checked = true;            
        }

        private void carregar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
