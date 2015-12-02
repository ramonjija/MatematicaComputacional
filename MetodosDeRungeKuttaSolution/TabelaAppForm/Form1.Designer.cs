namespace TabelaAppForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ObterListas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(548, 356);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // ObterListas
            // 
            this.ObterListas.Location = new System.Drawing.Point(485, 374);
            this.ObterListas.Name = "ObterListas";
            this.ObterListas.Size = new System.Drawing.Size(75, 23);
            this.ObterListas.TabIndex = 1;
            this.ObterListas.Text = "Obter Listas";
            this.ObterListas.UseVisualStyleBackColor = true;
            this.ObterListas.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 409);
            this.Controls.Add(this.ObterListas);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Tabela de Comparação";
            this.ResumeLayout(false);

           }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button ObterListas;
    }
}

