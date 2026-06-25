using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaquillaCine
{
    public class BoletoEstudiante : Boleto
    {
        public string Matricula { get; set; }
        public BoletoEstudiante(decimal precioBase, string matricula) : base(precioBase)
        {
            Matricula = matricula;
        }

        public override decimal CalcularPrecioFinal()
        {
            decimal Descuento = PrecioBase * 30 / 100;
            return PrecioBase - Descuento;
        }
        
    }
}
