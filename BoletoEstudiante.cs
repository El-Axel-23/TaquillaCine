using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaquillaCine
{
    public class BoletoEstudiante : Boleto
    {
        public string Matricula;
        public BoletoEstudiante(decimal precioBase) : base(precioBase)
        {
        }

        public override decimal CalcularPrecioFinal()
        {
            decimal Descuento = PrecioBase * 30 / 100;
            return PrecioBase - Descuento;
        }
        
    }
}
