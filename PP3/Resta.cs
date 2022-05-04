using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP3
{
    internal class Resta : IOperable
    {
        public double valor1
        {
            get { return valor1; }
            set { valor1 = value; }
        }
        public double valor2
        {
            get { return valor2; }
            set { valor2 = value; }
        }
        public double resultado
        {
            get { return resultado; }
            set { this.resultado = value; }
        }

        public void operar()
        {
            this.resultado = valor1 - valor2;
        }
    }
}
