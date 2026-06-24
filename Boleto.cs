using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaquillaCine
{
    public abstract class Boleto
    {
        public decimal PrecioBase { get; set; }

        public Boleto(decimal precioBase)
        {
            PrecioBase = precioBase;
        }

        public abstract decimal CalcularPrecioFinal();
    }
}
