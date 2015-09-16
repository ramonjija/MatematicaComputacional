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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Obter_Reta(object sender, EventArgs e)
        {
            //Label lblFunc = (Label)Controls.Find("LblFunc", true).FirstOrDefault();
            equacaoLinear.CalcularRegressaoLinear();
            double[] valorx = { 1, 2, 3, 4, 5, 6, 7 };
            double[] valory = { 0.5, 2.5, 2.0, 4.0, 3.5, 6.0, 5.5 };
            double[] valorAjustadoY = equacaoLinear.ObterValoresAjustados();

            Label lblFunc = new Label();
            lblFunc = (Label)Controls.Find("LblFuncao", true).FirstOrDefault();

            lblFunc.Text = equacaoLinear.ObterEquacao();

            for(int i = 0; i < valorx.Length; i++)
            {
                chart1.Series["Dispercao"].Points.AddXY(valorx[i], valory[i]);
                chart1.Series["EquacaoLinear"].Points.AddXY(valorx[i],valorAjustadoY[i]);
            }

            /*Random rdn = new Random();
            for (int i = 0; i < 50; i++)
            {
                chart1.Series["test1"].Points.AddXY
                                (rdn.Next(0, 10), rdn.Next(0, 10));
            }*/




            chart1.Series["Dispercao"].ChartType = SeriesChartType.FastPoint;
            chart1.Series["Dispercao"].Color = Color.DarkRed;
            chart1.Series["EquacaoLinear"].ChartType = SeriesChartType.FastLine;
            chart1.Series["EquacaoLinear"].Color = Color.Black;



        }
    }
}
