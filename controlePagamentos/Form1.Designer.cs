
namespace controlePagamentos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Relatorio = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.descricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.codigoA = new System.Windows.Forms.TextBox();
            this.valorA = new System.Windows.Forms.TextBox();
            this.cpfA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.estabelecimento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.codigoS = new System.Windows.Forms.TextBox();
            this.valorS = new System.Windows.Forms.TextBox();
            this.cpfS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Relatorio.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Relatorio
            // 
            this.Relatorio.Controls.Add(this.tabPage1);
            this.Relatorio.Controls.Add(this.tabPage2);
            this.Relatorio.Controls.Add(this.tabPage3);
            this.Relatorio.Location = new System.Drawing.Point(-3, 0);
            this.Relatorio.Name = "Relatorio";
            this.Relatorio.SelectedIndex = 0;
            this.Relatorio.Size = new System.Drawing.Size(636, 272);
            this.Relatorio.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.descricao);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.codigoA);
            this.tabPage1.Controls.Add(this.valorA);
            this.tabPage1.Controls.Add(this.cpfA);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(628, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alimentação";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Enviar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // descricao
            // 
            this.descricao.Location = new System.Drawing.Point(71, 116);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(139, 20);
            this.descricao.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Descrição";
            // 
            // codigoA
            // 
            this.codigoA.Location = new System.Drawing.Point(71, 80);
            this.codigoA.Name = "codigoA";
            this.codigoA.Size = new System.Drawing.Size(139, 20);
            this.codigoA.TabIndex = 5;
            // 
            // valorA
            // 
            this.valorA.Location = new System.Drawing.Point(71, 46);
            this.valorA.Name = "valorA";
            this.valorA.Size = new System.Drawing.Size(139, 20);
            this.valorA.TabIndex = 4;
            // 
            // cpfA
            // 
            this.cpfA.Location = new System.Drawing.Point(71, 15);
            this.cpfA.Name = "cpfA";
            this.cpfA.Size = new System.Drawing.Size(139, 20);
            this.cpfA.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CPF";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.estabelecimento);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.codigoS);
            this.tabPage2.Controls.Add(this.valorS);
            this.tabPage2.Controls.Add(this.cpfS);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(628, 246);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Saúde";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(268, 14);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // estabelecimento
            // 
            this.estabelecimento.Location = new System.Drawing.Point(101, 117);
            this.estabelecimento.Name = "estabelecimento";
            this.estabelecimento.Size = new System.Drawing.Size(139, 20);
            this.estabelecimento.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Estabelecimento";
            // 
            // codigoS
            // 
            this.codigoS.Location = new System.Drawing.Point(101, 81);
            this.codigoS.Name = "codigoS";
            this.codigoS.Size = new System.Drawing.Size(139, 20);
            this.codigoS.TabIndex = 14;
            // 
            // valorS
            // 
            this.valorS.Location = new System.Drawing.Point(101, 47);
            this.valorS.Name = "valorS";
            this.valorS.Size = new System.Drawing.Size(139, 20);
            this.valorS.TabIndex = 13;
            // 
            // cpfS
            // 
            this.cpfS.Location = new System.Drawing.Point(101, 16);
            this.cpfS.Name = "cpfS";
            this.cpfS.Size = new System.Drawing.Size(139, 20);
            this.cpfS.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Código";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Valor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "CPF";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.listView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(628, 246);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Relatório";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(198, 6);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(427, 234);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 268);
            this.Controls.Add(this.Relatorio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Relatorio.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Relatorio;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox codigoA;
        private System.Windows.Forms.TextBox valorA;
        private System.Windows.Forms.TextBox cpfA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox estabelecimento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox codigoS;
        private System.Windows.Forms.TextBox valorS;
        private System.Windows.Forms.TextBox cpfS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

