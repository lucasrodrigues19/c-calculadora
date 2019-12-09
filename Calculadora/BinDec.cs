using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class BinDec
    {
        private int convert, k,soma=0;

        public string conversorBinDec(int[] valor, int tamanho)
        {
            string res="";
            for(int i = tamanho -1; i >= 0; i--)
            {
                k = (tamanho - i) - 1;
                convert = (int) Math.Pow(2, i) * valor[k];
                soma += convert;
                
            }
            res += soma.ToString();
            return res;
        }
    }
}
