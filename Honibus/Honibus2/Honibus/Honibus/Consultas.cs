using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Honibus
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void fluxoDoDiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Consultas Form2 = new Consultas();
            Fluxo newForm4 = new Fluxo();
            newForm4.ShowDialog();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Consultas Form2 = new Consultas();
            Consultas newForm3 = new Consultas();
            newForm3.ShowDialog();
        }

        private void ocorrênciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Consultas Form2 = new Consultas();
            Ocorrencias newForm5 = new Ocorrencias();
            newForm5.ShowDialog();
        }

        private void cadastroÔnibusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Consultas Form2 = new Consultas();
            CadastroOni newForm6 = new CadastroOni();
            newForm6.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Consultas Form2 = new Consultas();
            CadastroMoto newForm7 = new CadastroMoto();
            newForm7.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void consultasToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Consultas Form2 = new Consultas();
            ConsultarOni newForm8 = new ConsultarOni();
            newForm8.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Consultas Form2 = new Consultas();
            ConsultarMoto newForm10 = new ConsultarMoto();
            newForm10.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Consultas Form2 = new Consultas();
            ConsultarOco newForm12 = new ConsultarOco();
            newForm12.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Consultas Form2 = new Consultas();
            ConsultarFluxo newForm14 = new ConsultarFluxo();
            newForm14.ShowDialog();
        }
    }
}
