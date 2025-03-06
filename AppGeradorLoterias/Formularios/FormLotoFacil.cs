using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppGeradorLoterias.Formularios
{
    public partial class FormLotoFacil : Form
    {
        public List<int> NumerosDaSorte= new List<int>();

        public FormLotoFacil()
        {
            InitializeComponent();
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
            if (impar == 7 && par == 8) { lbClass.Text = "ALTO!"; lbClass.ForeColor = Color.Green; }
            if (impar == 9 && par == 6) { lbClass.Text = "MÉDIO!"; lbClass.ForeColor = Color.Orange; }
            if (impar == 6 && par == 9) { lbClass.Text = "BAIXO!"; lbClass.ForeColor = Color.OrangeRed; }
            if (impar <= 5 && par >= 10) { lbClass.Text = "MUITO BAIXO!"; lbClass.ForeColor = Color.Red; }
            if (impar >= 10 && par <= 5) { lbClass.Text = "MUITO BAIXO!"; lbClass.ForeColor = Color.Red; }
        }

        public void GerarNumeros()
        {
            int numero =0;
            int cont = 0;
            int qtdPar = 0;//quantidade de números pares
            int qtdImpar = 0;//quantidade de números ímpares
            Random radNum = new Random(); //objeto para gerar números aleatórios
            NumerosDaSorte.Clear();
          

            while (cont < 15)
            {
                numero = radNum.Next(1, 26); //números aleatórios
                if (!NumerosDaSorte.Contains(numero))  //Contains => verifica se o número está na lista
                {
                    NumerosDaSorte.Add(numero);
                    if (numero % 2 == 0) qtdPar++;
                    if (numero % 2 == 1) qtdImpar++;
                    cont++;
                }//fim do IF
               
            }//fim do laço
            NumerosDaSorte = NumerosDaSorte.OrderBy(num => num).ToList(); //colocar em ordem crescente  
            Comparacao(qtdPar, qtdImpar);
            dtvNumeros.DataSource = NumerosDaSorte.Select(Numeros => new { Numero = Numeros }).ToList();
            //colocar os números na GRID (Tabela)
        }//fim da função


        public void LimparTabela()
        {
            NumerosDaSorte.Clear();
            dtvNumeros.DataSource = NumerosDaSorte.Select(Numeros => new { Numero = Numeros }).ToList();
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
