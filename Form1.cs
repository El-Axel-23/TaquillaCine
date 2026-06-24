using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaquillaCine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Boleto boleto = null;
            decimal precioBase = 80;
            string tipo = cmbTipoBoleto.SelectedItem.ToString();

            if (tipo == "Estudiante")
            {

            }

            else if (tipo == "Adulto Mayor")
            {

            }

            else if (tipo == "General")
            {
                boleto = new Boleto_General(precioBase);
            }

            if (boleto != null)
            {
                lblResultado.Text = "Total a pagar: $" + boleto.CalcularPrecioFinal();
            }
        }
    }
}
