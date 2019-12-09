using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Conversor : Form
    {
        private int[] valor = new int[100];
        private int i;
        string ope = "";
        public Conversor()
        {
            InitializeComponent();
            i = 0;
            label1.ResetText();
            label2.ResetText();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBox1.Text == "1" || textBox1.Text == "0")
            {
                valor[i] = int.Parse(textBox1.Text);
                ope += textBox1.Text;
                label2.Text = ope;
                textBox1.ResetText();
                label1.ResetText();
                i++;
            }
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            BinDec con = new BinDec();
           string res = con.conversorBinDec(valor, label2.Text.Length);
            label1.Text = res;
            valor = new int[100];
            i = 0;
            textBox1.Focus();
            ope = "";
        }
    }
}
