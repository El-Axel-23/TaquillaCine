using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaquillaCine
{
    internal class Boleto_General : Boleto
    {
        //Constructor
        public Boleto_General(decimal precioBase):base(precioBase)
        {
        
        }
        //Calcula el precio final pero no tiene descuento asi q lo retorno
        public override decimal CalcularPrecioFinal()
        {
            return PrecioBase;
        }
    }
}
 