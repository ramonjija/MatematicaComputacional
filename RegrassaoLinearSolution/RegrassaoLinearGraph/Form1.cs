using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RegrassaoLinearGraph
{
    public partial class Form1 : Form
    {
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

            Label lblFunc = new Label();
            lblFunc = (Label)Controls.Find("LblFuncao", true).FirstOrDefault();

            lblFunc.Text = RegrassaoLinear.Program.FuncRegressaoLinear(); ;
        }
    }
}
