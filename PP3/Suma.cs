using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP3
{
    internal class Suma : IOperable
    {
        public double valor1 { get; set; }
        public double valor2 { get; set; }
        public double resultado { get; set; } 

        public void operar()
        {
            this.resultado =  this.valor1 + this.valor2;
        }
    }
}
