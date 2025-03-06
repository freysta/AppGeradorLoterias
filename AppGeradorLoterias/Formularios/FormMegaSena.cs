using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGeradorLoterias.Formularios
{
    public partial class FormMegaSena : Form
    {
        public List<int> NumerosDaSorte = new List<int>();

        public FormMegaSena()
        {
            InitializeComponent();
        }

        private void Comparacao(int par, int impar)
        {
            lbPar.Text = "PARES: " + par;
            lbImpar.Text = "ÍMPARES: " + impar;

            // Classificação para 6 números:
            if (par == 3 && impar == 3)
            {
                lbClass.Text = "BALANCEADO!";
                lbClass.ForeColor = Color.Green;
            }
            else if ((par == 4 && impar == 2) || (par == 2 && impar == 4))
            {
                lbClass.Text = "MEDIANO!";
                lbClass.ForeColor = Color.Orange;
            }
            else if ((par == 5 && impar == 1) || (par == 1 && impar == 5))
            {
                lbClass.Text = "DESEQUILIBRADO!";
                lbClass.ForeColor = Color.OrangeRed;
            }
            else if ((par == 6 && impar == 0) || (par == 0 && impar == 6))
            {
                lbClass.Text = "EXTREMAMENTE DESEQUILIBRADO!";
                lbClass.ForeColor = Color.Red;
            }
            else
            {
                lbClass.Text = "ANALISAR";
                lbClass.ForeColor = Color.Black;
            }
        }

        public void GerarNumeros()
        {
            int numero = 0;
            int cont = 0;
            int qtdPar = 0;   
            int qtdImpar = 0; 
            Random radNum = new Random(); 
            NumerosDaSorte.Clear();

            while (cont < 6)
            {
                numero = radNum.Next(1, 61); 
                if (!NumerosDaSorte.Contains(numero))
                {
                    NumerosDaSorte.Add(numero);
                    if (numero % 2 == 0)
                        qtdPar++;
                    else
                        qtdImpar++;
                    cont++;
                }
            }
            NumerosDaSorte = NumerosDaSorte.OrderBy(num => num).ToList();
            Comparacao(qtdPar, qtdImpar);
            dtvNumeros.DataSource = NumerosDaSorte.Select(n => new { Numero = n }).ToList();
        }

        public void LimparTabela()
        {
            NumerosDaSorte.Clear();
            dtvNumeros.DataSource = NumerosDaSorte.Select(n => new { Numero = n }).ToList();
        }

        private void btGerar_Click(object sender, EventArgs e)
        {
            GerarNumeros();
        }

        private void btLimpar_Click(object sender, EventArgs e)
        {
            LimparTabela();
            lbClass.Text = "CLASSIFICAÇÃO";
            lbPar.Text = "PARES";
            lbImpar.Text = "ÍMPARES";
        }
    }
}
