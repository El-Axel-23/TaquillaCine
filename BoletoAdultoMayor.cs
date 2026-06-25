using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaquillaCine
{
    internal class BoletoAdultoMayor:Boleto
    {
        public string NumCredencialInapam { get; set; }

        public BoletoAdultoMayor(decimal precioBase, string numCredencialInapam): base(precioBase)
        {
            NumCredencialInapam = numCredencialInapam;
        }

        public override decimal CalcularPrecioFinal()
        {
            return PrecioBase * 0.50m; // 50% de descuento
        }
    }
}
