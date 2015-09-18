namespace RegrassaoLinearGraph
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.LblFuncao = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblR2 = new System.Windows.Forms.Label();
            this.lblSyx = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxXi = new System.Windows.Forms.TextBox();
            this.txtBoxYi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblTipoR = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BackSecondaryColor = System.Drawing.Color.White;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "GraficoEquacaoLinear";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 68);
            this.chart1.Name = "chart1";
            series1.ChartArea = "GraficoEquacaoLinear";
            series1.Legend = "Legend1";
            series1.Name = "Dispercao";
            series2.ChartArea = "GraficoEquacaoLinear";
            series2.Legend = "Legend1";
            series2.Name = "EquacaoLinear";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(428, 217);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular Exemplo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Obter_Reta);
            // 
            // LblFuncao
            // 
            this.LblFuncao.AutoSize = true;
            this.LblFuncao.Location = new System.Drawing.Point(12, 35);
            this.LblFuncao.Name = "LblFuncao";
            this.LblFuncao.Size = new System.Drawing.Size(65, 13);
            this.LblFuncao.TabIndex = 2;
            this.LblFuncao.Text = "y = a0 + a1x";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(463, 68);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(457, 217);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "R² = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(464, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sy/x =";
            // 
            // lblR2
            // 
            this.lblR2.AutoSize = true;
            this.lblR2.Location = new System.Drawing.Point(504, 290);
            this.lblR2.Name = "lblR2";
            this.lblR2.Size = new System.Drawing.Size(13, 13);
            this.lblR2.TabIndex = 6;
            this.lblR2.Text = "0";
            // 
            // lblSyx
            // 
            this.lblSyx.AutoSize = true;
            this.lblSyx.Location = new System.Drawing.Point(504, 315);
            this.lblSyx.Name = "lblSyx";
            this.lblSyx.Size = new System.Drawing.Size(13, 13);
            this.lblSyx.TabIndex = 7;
            this.lblSyx.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Equação de Regressão Linear:";
            // 
            // txtBoxXi
            // 
            this.txtBoxXi.Location = new System.Drawing.Point(506, 390);
            this.txtBoxXi.Name = "txtBoxXi";
            this.txtBoxXi.Size = new System.Drawing.Size(100, 20);
            this.txtBoxXi.TabIndex = 9;
            // 
            // txtBoxYi
            // 
            this.txtBoxYi.Location = new System.Drawing.Point(506, 427);
            this.txtBoxYi.Name = "txtBoxYi";
            this.txtBoxYi.Size = new System.Drawing.Size(100, 20);
            this.txtBoxYi.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Xi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Yi";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(506, 463);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Inserir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(677, 309);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(243, 177);
            this.listView2.TabIndex = 14;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(506, 500);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Obter Reta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(15, 412);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Limpar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(464, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "R =";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Location = new System.Drawing.Point(504, 342);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(13, 13);
            this.lblR.TabIndex = 18;
            this.lblR.Text = "0";
            // 
            // lblTipoR
            // 
            this.lblTipoR.AutoSize = true;
            this.lblTipoR.Location = new System.Drawing.Point(518, 362);
            this.lblTipoR.Name = "lblTipoR";
            this.lblTipoR.Size = new System.Drawing.Size(27, 13);
            this.lblTipoR.TabIndex = 19;
            this.lblTipoR.Text = "N/A";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(464, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ajuste = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 535);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTipoR);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxYi);
            this.Controls.Add(this.txtBoxXi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSyx);
            this.Controls.Add(this.lblR2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.LblFuncao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Ramon Silva - Regressão Linear";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LblFuncao;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblR2;
        private System.Windows.Forms.Label lblSyx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxXi;
        private System.Windows.Forms.TextBox txtBoxYi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblTipoR;
        private System.Windows.Forms.Label label7;
    }
}

