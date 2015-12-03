using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Funcoes;
using MetodosDeRungeKutta;

namespace TabelaAppForm
{
    public partial class Form1 : Form
    {

        double[] valorx;
        double[] valory;
        double[] valoryEuler;
        double[] valoryRalston;
        double[] valoryRungeKutta4;
        List<double> listaY = new List<double>();
        List<double> listaX = new List<double>();
        ListViewItem itm;

        public Form1()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Columns.Add("X", 50);
            listView1.Columns.Add("Y Verdadeiro", 100);
            listView1.Columns.Add("Y Euler", 100);
            listView1.Columns.Add("Y Ralston (2ª Ordem)", 150);
            listView1.Columns.Add("Y Runge Kutta 4ª Ordem", 150);
        }





        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            valorx = new double[] { 0.0, 0.5, 1.0, 1.5, 2.0, 2.5, 3.0, 3.5, 4.0 };
            valory = new double[] { 1.0, 3.21875, 3.0, 2.21875, 2.0, 2.71875, 4.0, 4.71875, 3.0 };
            valoryEuler = ObtemValoresEuler(1, 0, 4, 0.5, 9);
            valoryRalston = ObtemValoresRalston(0, 4, 0.5);
            valoryRungeKutta4 = ObtemValoresRungeKutta4(0, 4, 0.5);

          
            for (int i = 0; i < valorx.Length; i++)
            {
                itm = new ListViewItem(new[]
                {
                valorx[i].ToString(), valory[i].ToString(),
                valoryEuler[i].ToString(), valoryRalston[i].ToString(),
                valoryRungeKutta4[i].ToString()
                }

                );
                listView1.Items.Add(itm);
             }
        }



        private double[] ObtemValoresEuler(double y, double xi, double xf, double dx, double xout)
        {
            double[] valoresEulerNaoPadronizados;
            double[] valoresEulerPadronizados = new double[Int32.Parse(xout.ToString())];
            FuncoesDeEuler execucaoEuler = new FuncoesDeEuler();
            valoresEulerNaoPadronizados = execucaoEuler.EulerModularMelhorada2(y, xi, xf, dx, xout);

            for(int i = 0; i < xout; i++)
            {
                valoresEulerPadronizados[i] = valoresEulerNaoPadronizados[i];
            }

            return valoresEulerPadronizados;
        }
        private double[] ObtemValoresRalston(double xi, double xf, double h)
        {
            double[] valoresRalston;
            FuncoesDeRKeRalston execucaoRalston = new FuncoesDeRKeRalston();
            valoresRalston = execucaoRalston.CalculaRalston(xi, xf, h);
            return valoresRalston;
        }
        private double[] ObtemValoresRungeKutta4(double xi, double xf, double h)
        {
            double[] valoresRungeKutta4;
            FuncoesDeRKeRalston execucaoRungeKutta4 = new FuncoesDeRKeRalston();
            valoryRungeKutta4 = execucaoRungeKutta4.CalculaRK4Ordem(xi, xf, h);
            return valoryRungeKutta4;
        }
    }
}
