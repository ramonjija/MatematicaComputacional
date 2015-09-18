using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using RegrassaoLinear;

namespace RegrassaoLinearGraph
{

    public partial class Form1 : Form
    {

        EquacaoLinear equacaoLinear = new EquacaoLinear();
        double[] valorx;
        double[] valory;
        List<double> listaY = new List<double>();
        List<double> listaX = new List<double>();
        ListViewItem itm;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView2.Columns.Add("Xi", 40);
            listView2.Columns.Add("Yi", 40);

            chart1.Series["Dispercao"].ChartType = SeriesChartType.FastPoint;
            chart1.Series["Dispercao"].Color = Color.DarkRed;
            chart1.Series["EquacaoLinear"].ChartType = SeriesChartType.FastLine;
            chart1.Series["EquacaoLinear"].Color = Color.Black;

        }

        private void Obter_Reta(object sender, EventArgs e)
        {
            //Label lblFunc = (Label)Controls.Find("LblFunc", true).FirstOrDefault();
            listView1.Clear();
            if (listView2.Items.Count < 1)
            {
                equacaoLinear.CalcularRegressaoLinear();
                valorx = new double[] { 1, 2, 3, 4, 5, 6, 7 };
                valory = new double[] { 0.5, 2.5, 2.0, 4.0, 3.5, 6.0, 5.5 };
            }
            else
            {
                /* int i = 0, j = 0;
                 foreach (double item in listaX)
                 {
                     valorx[i] = item;
                     i++;
                 }
                 foreach(double item in listaY)
                 {
                     valory[j] = item;
                     j++;
                 }*/


                equacaoLinear.CalcularRegressaoLinear(valorx, valory);
            }
            double[] valorAjustadoY = equacaoLinear.ObterValoresAjustados();
            double somatorioY = equacaoLinear.ObterSomatorioY();
            double somatorioSt = equacaoLinear.ObterSomatorioSt();
            double somatorioSr = equacaoLinear.ObterSomatorioSr();
            double valorR = Math.Abs(Math.Sqrt(equacaoLinear.ObterR2()));

            Label lblFunc = new Label();
            Label lblR2 = new Label();
            Label lblSyx = new Label();
            Label lblR = new Label();
            Label lblTipoR = new Label();
            lblFunc = (Label)Controls.Find("LblFuncao", true).FirstOrDefault();
            lblFunc.Text = equacaoLinear.ObterEquacao();
            lblR2 = (Label)Controls.Find("lblR2", true).FirstOrDefault();
            lblR2.Text = equacaoLinear.ObterR2().ToString();
            lblSyx = (Label)Controls.Find("lblSyx", true).FirstOrDefault();
            lblSyx.Text = equacaoLinear.ObterSYX().ToString();
            lblR = (Label)Controls.Find("lblR", true).FirstOrDefault();
            lblR.Text = valorR.ToString();
            lblTipoR = (Label)Controls.Find("lblTipoR", true).FirstOrDefault();
            lblTipoR.Text = VerificaTipoR(valorR);

            //Traça o Grafico

            for (int i = 0; i < valorx.Length; i++)
            {
                chart1.Series["Dispercao"].Points.AddXY(valorx[i], valory[i]);
                chart1.Series["EquacaoLinear"].Points.AddXY(valorx[i], valorAjustadoY[i]);
            }

            //Adiciona as colunas na ListView de calculo
            listView1.Columns.Add("X", 100);
            listView1.Columns.Add("Y", 100);
            listView1.Columns.Add("St", 100);
            listView1.Columns.Add("Sr", 100);
            ListViewItem itm;
            ListViewItem itmSomatorio;
            for (int i = 0; i < valorx.Length; i++)
            {
                itm = new ListViewItem(new[] {
                    valorx[i].ToString(),
                    valory[i].ToString(),
                    equacaoLinear.ObterSt()[i].ToString(),
                    equacaoLinear.ObterSr()[i].ToString()
                    }
                );
                listView1.Items.Add(itm);
            }
            itmSomatorio = new ListViewItem(new[] {
                "Somatório",
                somatorioY.ToString(),
                somatorioSt.ToString(),
                somatorioSr.ToString()
            });
            listView1.Items.Add(itmSomatorio);
            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.FullRowSelect = true;


        }

        private string VerificaTipoR(double valorR)
        {
            string resultado = null;

            if (valorR <= 0.5)
            {
                resultado = "Impróprio";
            }
            else if (valorR <= 0.6)
            {
                resultado = "Péssimo";
            }
            else if (valorR <= 0.7)
            {
                resultado = "Medíocre";
            }
            else if (valorR <= 0.8)
            {
                resultado = "Razoável";
            }
            else if (valorR <= 0.9)
            {
                resultado = "Bom";
            }
            else if (valorR <= 1)
            {
                resultado = "Ótimo";
            }

            return resultado;
        }

        private bool VerificaSeENumero(TextBox numeroDigitado)
        {
            bool numero = true;

            if (System.Text.RegularExpressions.Regex.IsMatch(numeroDigitado.Text, "^[ a-zA-Z á-ùÁ-Ù â-ûÂ-Û]*$"))
            {
                numero = false;
            }

            return numero;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            TextBox txtBoxXi = new TextBox();
            txtBoxXi = (TextBox)Controls.Find("txtBoxXi", true).FirstOrDefault();
            TextBox txtBoxYi = new TextBox();
            txtBoxYi = (TextBox)Controls.Find("txtBoxYi", true).FirstOrDefault();

            if (txtBoxXi.Text != "" && txtBoxYi.Text != "")
            {
                if (VerificaSeENumero(txtBoxXi) && VerificaSeENumero(txtBoxYi))
                {
                    listaX.Add(Convert.ToDouble(txtBoxXi.Text));
                    listaY.Add(Convert.ToDouble(txtBoxYi.Text));
                    itm = new ListViewItem(new[] { txtBoxXi.Text, txtBoxYi.Text });
                    listView2.Items.Add(itm);

                    listView2.GridLines = true;
                    listView2.View = View.Details;
                    listView2.FullRowSelect = true;
                    listView2.Update();
                }
                txtBoxXi.Clear();
                txtBoxYi.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0;
            valorx = new double[listaX.Count];
            valory = new double[listaY.Count];
            foreach (double valorxi in listaX)
            {
                valorx[i] = valorxi;
                i++;
            }
            //listaX.Clear();
            foreach (double valoryi in listaY)
            {
                valory[j] = valoryi;
                j++;
            }
            //listaY.Clear();
            if (listView2.Items.Count > 0)
            {
                listView1.Items.Clear();
                Obter_Reta(this, e);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView2.Items.Clear();
            listaX.Clear();
            listaY.Clear();
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }


            Label lblFunc = new Label();
            Label lblR2 = new Label();
            Label lblSyx = new Label();
            Label lblR = new Label();
            Label lblTipoR = new Label();
            lblFunc = (Label)Controls.Find("LblFuncao", true).FirstOrDefault();
            lblFunc.Text = "y = a0 + a1x";
            lblR2 = (Label)Controls.Find("lblR2", true).FirstOrDefault();
            lblR2.Text = "0";
            lblSyx = (Label)Controls.Find("lblSyx", true).FirstOrDefault();
            lblSyx.Text = "0";
            lblR = (Label)Controls.Find("lblR", true).FirstOrDefault();
            lblR.Text = "0";
            lblTipoR = (Label)Controls.Find("lblTipoR", true).FirstOrDefault();
            lblTipoR.Text = "N/A";
        }
    }
}
