using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppGeradorLoterias.Formularios;

namespace AppGeradorLoterias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLotoFacil_Click(object sender, EventArgs e)
        {
            FormLotoFacil form = new FormLotoFacil();
            form.ShowDialog();
        }
    }
}
