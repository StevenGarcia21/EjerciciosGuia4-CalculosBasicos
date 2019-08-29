using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjerciciosGuia4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listbArreglo.Items.Add(btnNumero.Text);
            btnNumero.Clear();
            btnNumero.Focus();
            
        }

        private void btnNumero_Click(object sender, EventArgs e)
        {
            int mayorneg = -1000;
            for (int i = 0; i < listbArreglo.Items.Count; i++)
            {
                string valor = listbArreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero < 0 && numero % 2 == 0)
                {
                    if (numero > mayorneg)
                    {
                        mayorneg = numero;
                        txtNumero.Text = mayorneg.ToString();
                    }
                }
                else
                {
                    txtNumero.Text = "No hay números negativos pares";
                }
            }
        }

        private void btnPorcentaje_Click(object sender, EventArgs e)
        {
            double cantidadnumeros = listbArreglo.Items.Count;

            double cantidadceros = 0;
            double porcentaje = 0;

            for (int i = 0; i < listbArreglo.Items.Count; i++)
            {
                string valor = listbArreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero == 0)
                {
                    cantidadceros = cantidadceros + 1;
                }
            }
            porcentaje = (cantidadceros / cantidadnumeros) * 100;
            txtPorcentaje.Text = porcentaje.ToString() + "%";
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {
            double prom;
            double cantidadimpares = 0;
            double suma = 0;

            for (int i = 0; i <listbArreglo.Items.Count; i++)
            {
                string valor = listbArreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if (numero > 0 && numero % 2!=0)
                {
                    suma = suma + numero;
                    cantidadimpares = cantidadimpares + 1;
                }
            }
            prom = suma / cantidadimpares;
            txtPromedio.Text = prom.ToString();
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            int mayor = 0;
            for (int i = 0; i < listbArreglo.Items.Count; i++)
            {
                string valor = listbArreglo.Items[i].ToString();
                int numero = int.Parse(valor);
                if(numero > 0 && numero % 2 == 0)
                {
                    if (numero > mayor)
                        mayor = numero;
                }
            }
        }

        private void IngresoDeValor_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
