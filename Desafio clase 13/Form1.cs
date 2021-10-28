using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_clase_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double precio1 = 0, precio2 = 0, precio3=0, precioFinal, txbPiso, txbPreciobase, txbAntiguedad;
            double txbVentanas, txbMetros, precio4=0, precio5=0, precio6=0, precioFinal2;

            txbPreciobase = double.Parse(precioBase.Text);
            txbAntiguedad = double.Parse(Antiguedad.Text);
            txbPiso = double.Parse(Pisos.Text);
            txbVentanas = double.Parse(Ventanas.Text);
            txbMetros = double.Parse(Metros.Text);

            

            if (rbPiso.Checked == true)
            {
                if (txbPiso > 3)
                {
                    precio1 = (txbPreciobase + txbPreciobase * 0.03)-txbPreciobase;
                }
                if (txbAntiguedad <= 15)
                {
                precio2 = (txbPreciobase - (txbPreciobase * 0.01))-txbPreciobase;
                }
                if (txbAntiguedad > 15)
                {
                 precio3 = (txbPreciobase - (txbPreciobase * 0.02))-txbPreciobase;
                }
                
                precioFinal = (precio1+precio2+precio3)+txbPreciobase;
                MessageBox.Show("El precio final es de: $" + precioFinal );
            }

            if(rbLocal.Checked== true)
            {
                if (txbAntiguedad <= 15)
                {
                    precio2 = (txbPreciobase - (txbPreciobase * 0.01)) - txbPreciobase;
                }
                if (txbAntiguedad > 15)
                {
                    precio3 = (txbPreciobase - (txbPreciobase * 0.02)) - txbPreciobase;
                }
                if(txbMetros > 50)
                {
                    precio4= (txbPreciobase + txbPreciobase * 0.01) - txbPreciobase;
                }
                if (txbVentanas <= 1)
                {
                    precio5 = (txbPreciobase - txbPreciobase * 0.02) - txbPreciobase;
                }
                if (txbVentanas >= 4)
                {
                    precio6 = (txbPreciobase + txbPreciobase * 0.02) - txbPreciobase;
                }
                precioFinal2 = (precio4 + precio5 + precio6) + txbPreciobase;
                MessageBox.Show("El precio final es de: $" + precioFinal2);
            }

        }

    }
}
