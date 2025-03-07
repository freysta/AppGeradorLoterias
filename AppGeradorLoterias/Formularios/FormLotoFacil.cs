using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AppGeradorLoterias.Formularios
{
    public partial class FormLotoFacil : Form
    {
        public List<int> NumerosDaSorte = new List<int>();
        private Dictionary<int, int> FrequenciaNumeros = new Dictionary<int, int>();

        public FormLotoFacil()
        {
            InitializeComponent();
            InicializarFrequencia();
        }

        private void InicializarFrequencia()
        {
            for (int i = 1; i <= 25; i++)
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
            var maisSorteados = FrequenciaNumeros.OrderByDescending(n => n.Value).Take(5).Select(n => n.Key);
            var menosSorteados = FrequenciaNumeros.OrderBy(n => n.Value).Take(5).Select(n => n.Key);

            lbMaisSorteados.Text = "MAIS SORTEADOS: " + string.Join(", ", maisSorteados);
            lbMenosSorteados.Text = "MENOS SORTEADOS: " + string.Join(", ", menosSorteados);
        }

        private void Comparacao(int par, int impar)
        {
            lbPar.Text = "PARES: " + par;
            lbImpar.Text = "ÍMPARES: " + impar;
            if (impar == 8 && par == 7)
            {
                lbClass.Text = "MUITO ALTO!";
                lbClass.ForeColor = Color.Green;
            }
            else if (impar == 7 && par == 8) { lbClass.Text = "ALTO!"; lbClass.ForeColor = Color.Green; }
            else if (impar == 9 && par == 6) { lbClass.Text = "MÉDIO!"; lbClass.ForeColor = Color.Orange; }
            else if (impar == 6 && par == 9) { lbClass.Text = "BAIXO!"; lbClass.ForeColor = Color.OrangeRed; }
            else if (impar <= 5 && par >= 10) { lbClass.Text = "MUITO BAIXO!"; lbClass.ForeColor = Color.Red; }
            else if (impar >= 10 && par <= 5) { lbClass.Text = "MUITO BAIXO!"; lbClass.ForeColor = Color.Red; }
        }

        public void GerarNumeros()
        {
            int numero;
            int cont = 0;
            int qtdPar = 0;
            int qtdImpar = 0;
            Random radNum = new Random();
            NumerosDaSorte.Clear();

            while (cont < 15)
            {
                numero = radNum.Next(1, 26);
                if (!NumerosDaSorte.Contains(numero))
                {
                    NumerosDaSorte.Add(numero);
                    if (numero % 2 == 0) qtdPar++;
                    else qtdImpar++;
                    cont++;
                }
            }

            NumerosDaSorte = NumerosDaSorte.OrderBy(num => num).ToList();
            Comparacao(qtdPar, qtdImpar);
            AtualizarFrequencia();
            ExibirEstatisticas();

            dtvNumeros.DataSource = NumerosDaSorte.Select(Numeros => new { Numero = Numeros }).ToList();
        }

        public void LimparTabela()
        {
            NumerosDaSorte.Clear();
            dtvNumeros.DataSource = NumerosDaSorte.Select(Numeros => new { Numero = Numeros }).ToList();
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
