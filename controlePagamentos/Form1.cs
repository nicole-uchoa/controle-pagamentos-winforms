using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlePagamentos
{
    public partial class Form1 : Form
    {
        private List<Alimentacao> alim = new List<Alimentacao>();
        private List<Saude> saude = new List<Saude>();

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Alimentação");
            comboBox1.Items.Add("Saúde");
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alimentacao a = new Alimentacao();
            a.cpf = Convert.ToInt64(cpfA.Text);
            a.valor = Convert.ToDouble(valorA.Text);
            a.codigo = Convert.ToInt16(codigoA.Text);
            a.descricao = descricao.Text;
            a.faturamento = a.valor * 1.05;
            alim.Add(a);

            cpfA.Clear();
            valorA.Clear();
            codigoA.Clear();
            descricao.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Saude s = new Saude();
            s.cpf = Convert.ToInt64(cpfS.Text);
            s.valor = Convert.ToDouble(valorS.Text);
            s.codigo = Convert.ToInt16(codigoS.Text);
            s.estabelecimento = estabelecimento.Text;
            s.faturamento = s.valor * 1.12;
            saude.Add(s);

            cpfS.Clear();
            valorS.Clear();
            codigoS.Clear();
            estabelecimento.Clear();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (comboBox1.SelectedItem.ToString().Equals("Alimentação"))
            {
                listView1.Columns.Clear();
                listView1.Columns.Add("CPF");
                listView1.Columns.Add("Valor");
                listView1.Columns.Add("Código");
                listView1.Columns.Add("Descrição");
                listView1.Columns.Add("Faturamento");

                foreach (Alimentacao a in alim)
                {
                    string[] pg = new string[5];
                    pg[0] = a.cpf.ToString();
                    pg[1] = a.valor.ToString();
                    pg[2] = a.codigo.ToString();
                    pg[3] = a.descricao.ToString();
                    pg[4] = a.faturamento.ToString();
                    ListViewItem l = new ListViewItem(pg);
                    listView1.Items.Add(l);
                }
            }
            else
            {
                listView1.Columns.Clear();
                listView1.Columns.Add("CPF");
                listView1.Columns.Add("Valor");
                listView1.Columns.Add("Código");
                listView1.Columns.Add("Estabelecimento");
                listView1.Columns.Add("Faturamento");

                foreach (Saude s in saude)
                {
                    string[] pg = new string[5];
                    pg[0] = s.cpf.ToString();
                    pg[1] = s.valor.ToString();
                    pg[2] = s.codigo.ToString();
                    pg[3] = s.estabelecimento.ToString();
                    pg[4] = s.faturamento.ToString();

                    ListViewItem l = new ListViewItem(pg);
                    listView1.Items.Add(l);
                }
            }
        }
    }
}
