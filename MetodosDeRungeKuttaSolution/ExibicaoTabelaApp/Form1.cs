using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExibicaoTabelaApp
{
    public partial class Form1 : Form
    {
        List<double> listaY = new List<double>();
        List<double> listaX = new List<double>();
        ListViewItem itm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("Xi", 40);
            listView1.Columns.Add("Yi", 40);

            chart1.Series["Dispercao"].ChartType = SeriesChartType.FastPoint;
            chart1.Series["Dispercao"].Color = Color.DarkRed;
            chart1.Series["EquacaoLinear"].ChartType = SeriesChartType.FastLine;
            chart1.Series["EquacaoLinear"].Color = Color.Black;

        }
    }
}
