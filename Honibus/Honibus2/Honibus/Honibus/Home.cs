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
    public partial class Home : Form
    {

        SqlConnection sqlConn = null;
        private string strConn = @"Data Source=BmnGamer;Initial Catalog=dbHONIBUS;Integrated Security=True";
        private string _Sql = string.Empty;

        public Home()
        {
            InitializeComponent();
        }

        public void logar()
        {
            sqlConn = new SqlConnection(strConn);
            string usuario, senha;
           
            try
            {
                usuario = textBox1.Text;
                senha = textBox2.Text;

                _Sql = "SELECT COUNT (usuario) FROM tbADM WHERE usuario = @usuario AND senha = @senha ";

                SqlCommand comando = new SqlCommand(_Sql,sqlConn);

                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("@senha", SqlDbType.VarChar).Value = senha;

                sqlConn.Open();
                int v = (int)comando.ExecuteScalar();

                if (v > 0)
                {
                    this.Visible = false;
                    Consultas Form2 = new Consultas();
                    Consultas newForm3 = new Consultas();
                    newForm3.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos");
                }

            }
            catch (SqlException erro)
            {
                MessageBox.Show(erro + "No banco");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            logar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void senha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
