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
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Alimentacao a = new Alimentacao();
            a.cpf = Convert.ToInt64(cpfA.Text);
            a.valor = Convert.ToDouble(valorA.Text);
            a.codigo = Convert.ToInt16(codigoA.Text);
            a.descricao = descricao.Text;
            alim.Add(a);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Saude s = new Saude();
            s.cpf = Convert.ToInt64(cpfS.Text);
            s.valor = Convert.ToDouble(valorS.Text);
            s.codigo = Convert.ToInt16(codigoS.Text);
            s.estabelecimento = estabelecimento.Text;
            saude.Add(s);
        }

        private void TabChange(object sender, EventArgs e)
        {

        }
    }
}
