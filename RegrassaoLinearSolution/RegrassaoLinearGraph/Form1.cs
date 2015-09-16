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
            double somatorioY = equacaoLinear.ObterSomatorioY();
            double somatorioSt = equacaoLinear.ObterSomatorioSt();
            double somatorioSr = equacaoLinear.ObterSomatorioSr();

            Label lblFunc = new Label();
            Label lblR2 = new Label();
            Label lblSyx = new Label();
            lblFunc = (Label)Controls.Find("LblFuncao", true).FirstOrDefault();
            lblFunc.Text = equacaoLinear.ObterEquacao();
            lblR2 = (Label)Controls.Find("lblR2", true).FirstOrDefault();
            lblR2.Text = equacaoLinear.ObterR2().ToString();
            lblSyx = (Label)Controls.Find("lblSyx", true).FirstOrDefault();
            lblSyx.Text = equacaoLinear.ObterSYX().ToString();


            for (int i = 0; i < valorx.Length; i++)
            {
                chart1.Series["Dispercao"].Points.AddXY(valorx[i], valory[i]);
                chart1.Series["EquacaoLinear"].Points.AddXY(valorx[i], valorAjustadoY[i]);
            }


            chart1.Series["Dispercao"].ChartType = SeriesChartType.FastPoint;
            chart1.Series["Dispercao"].Color = Color.DarkRed;
            chart1.Series["EquacaoLinear"].ChartType = SeriesChartType.FastLine;
            chart1.Series["EquacaoLinear"].Color = Color.Black;


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
    }
}
