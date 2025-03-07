using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AppGeradorLoterias.Formularios
{
    public partial class FormQuina : Form
    {
        public List<int> NumerosDaSorte = new List<int>();
        private Dictionary<int, int> FrequenciaNumeros = new Dictionary<int, int>();

        public FormQuina()
        {
            InitializeComponent();
            InicializarFrequencia();
        }

        private void InicializarFrequencia()
        {
            for (int i = 1; i <= 80; i++)
            {
                FrequenciaNumeros[i] = 0;
            }
        }

        private void AtualizarFrequencia()
        {
            foreach (int num in NumerosDaSorte)
            {
                FrequenciaNumeros[num]++;
            }
        }

        private void ExibirEstatisticas()
        {
            var maisSorteados = FrequenciaNumeros.OrderByDescending(n => n.Value).Take(3).Select(n => n.Key);
            var menosSorteados = FrequenciaNumeros.OrderBy(n => n.Value).Take(3).Select(n => n.Key);

            lbMaisSorteados.Text = "MAIS SORTEADOS: " + string.Join(", ", maisSorteados);
            lbMenosSorteados.Text = "MENOS SORTEADOS: " + string.Join(", ", menosSorteados);
        }

        private void Comparacao(int par, int impar)
        {
            lbPar.Text = "PARES: " + par;
            lbImpar.Text = "ÍMPARES: " + impar;
            if (par == 2 && impar == 3)
            {
                lbClass.Text = "EQUILIBRADO!";
                lbClass.ForeColor = Color.Green;
            }
            else if (par == 3 && impar == 2)
            {
                lbClass.Text = "TAMBÉM EQUILIBRADO!";
                lbClass.ForeColor = Color.DarkGreen;
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
                lbClass.Text = "ANÁLISE!";
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

            while (cont < 5)
            {
                numero = radNum.Next(1, 81);
                if (!NumerosDaSorte.Contains(numero))
                {
                    NumerosDaSorte.Add(numero);
                    if (numero % 2 == 0) qtdPar++;
                    else qtdImpar++;
                    cont++;
                }
            }

            NumerosDaSorte = NumerosDaSorte.OrderBy(n => n).ToList();
            Comparacao(qtdPar, qtdImpar);
            AtualizarFrequencia();
            ExibirEstatisticas();

            dtvNumeros.DataSource = NumerosDaSorte.Select(n => new { Numero = n }).ToList();
        }

        public void LimparTabela()
        {
            NumerosDaSorte.Clear();
            dtvNumeros.DataSource = NumerosDaSorte.Select(n => new { Numero = n }).ToList();
            lbMaisSorteados.Text = "MAIS SORTEADOS: ";
            lbMenosSorteados.Text = "MENOS SORTEADOS: ";
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