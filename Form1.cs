using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TaquillaCine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Visible = false;
            textBox1.Visible = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Boleto boleto = null;
            decimal precioBase = 100m;

            if (cmbTipoBoleto.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un tipo de boleto");
                return;
            }

            string tipo = cmbTipoBoleto.SelectedItem.ToString();

            

            if (tipo == "Estudiante")
            {
                BoletoEstudiante miBoleto =new BoletoEstudiante(precioBase, textBox1.Text);
                //miBoleto.Matricula = textBox1.Text;
                boleto = miBoleto;
            }

            else if (tipo == "Adulto Mayor")
            {
                boleto = new BoletoAdultoMayor(precioBase, "INAPAMadultomayor123");
            }

            else if (tipo == "General")
            {
                boleto = new Boleto_General(precioBase);
            }

            if (boleto != null)
            {
                lblResultado.Text = "Total a pagar: $" + boleto.CalcularPrecioFinal();
            }

            textBox1.Clear();
        }

        private void cmbTipoBoleto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipo = cmbTipoBoleto.SelectedItem.ToString(); ;
            if (tipo == "Estudiante")
            {
                label1.Visible = true;
                textBox1.Visible = true;
            }
            else
            {
                label1.Visible = false;
                textBox1.Visible=false;
            }
        }
    }
}
