using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AppGeradorLoterias.Formularios
{
    public partial class FormDiaDeSorte : Form
    {
        public List<int> NumerosDaSorte = new List<int>();

        public FormDiaDeSorte()
        {
            InitializeComponent();
        }

        private void Comparacao(int par, int impar)
        {
            lbPar.Text = "PARES: " + par;
            lbImpar.Text = "ÍMPARES: " + impar;
            if ((par == 3 && impar == 4) || (par == 4 && impar == 3))
            {
                lbClass.Text = "BALANCEADO!";
                lbClass.ForeColor = Color.Green;
            }
            else if (par > impar)
            {
                lbClass.Text = "MAIORIA PARES!";
                lbClass.ForeColor = Color.Orange;
            }
            else if (impar > par)
            {
                lbClass.Text = "MAIORIA ÍMPARES!";
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
            int numero;
            int cont = 0;
            int qtdPar = 0;
            int qtdImpar = 0;
            Random radNum = new Random();
            NumerosDaSorte.Clear();
            while (cont < 7)
            {
                numero = radNum.Next(1, 32);
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
            NumerosDaSorte = NumerosDaSorte.OrderBy(n => n).ToList();
            Comparacao(qtdPar, qtdImpar);
            // essa parte usei chat gpt para ficar mostrando o mes prof, nao pensei em uma solução que resolvesse, e não queria so mostrar o numero do mes ;D - Gabriel 
            dtvNumeros.DataSource = NumerosDaSorte.Select(n => new { Numero = n }).ToList();
            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            string mesSorte = meses[radNum.Next(0, 12)];
            lbMes.Text = "MÊS: " + mesSorte;
            // fim da parte que usei chat gpt
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
            lbMes.Text = "MÊS";
        }
    }
}
