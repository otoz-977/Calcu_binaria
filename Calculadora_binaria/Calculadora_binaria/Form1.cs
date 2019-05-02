using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculadora_binaria.Clases;

namespace Calculadora_binaria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Bin_con con = new Bin_con();
            string tmp = "";
            string tmp2 = "";
            string box1 = numero1.Text;
            if (numero1.TextLength !=0)
            {
                tmp = con.binario(box1) ;
                binario1.Text = tmp;
            }
            string box2 = numero2.Text;
            if (numero2.TextLength != 0)
            {
                tmp2 = con.binario(box2);
                binario2.Text = tmp2;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void multi_Click(object sender, EventArgs e)
        {
            Bin_con con = new Bin_con();
            int num1 = Int32.Parse(numero1.Text);
            int num2 = Int32.Parse(numero2.Text);
            int res = num1 * num2;
            string R = res.ToString();
            string Res = con.binario(R);
            Resultado.Text = Res;            
        }
    }
}
