using AppGeradorLoterias.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGeradorLoterias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btMega_Click(object sender, EventArgs e)
        {
            FormMegaSena formMega = new FormMegaSena();
            formMega.Show();
        }

        private void btLotoFacil_Click(object sender, EventArgs e)
        {
            FormLotoFacil formLoto = new FormLotoFacil();
            formLoto.Show();
        }

        private void btQuina_Click(object sender, EventArgs e)
        {
            FormQuina formQuina = new FormQuina();
            formQuina.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLotomania formLotomania = new FormLotomania();
            formLotomania.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDiaDeSorte formDiaDeSorte = new FormDiaDeSorte();
            formDiaDeSorte.Show();
        }

        private void buttonSuperSete_Click(object sender, EventArgs e)
        {
            FormSuperSete formSuperSete = new FormSuperSete();
            formSuperSete.Show();
        }
    }
}