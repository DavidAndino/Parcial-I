using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class Ejercicio8 : Form
    {
        public Ejercicio8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            recorrerDe1En1(1, 150);
        }

        //creando funcion recursiva
        private void recorrerDe1En1(int valorInicial, int valorFinal)
        {
            listBox1.Items.Add(valorInicial);//llenando con el 1 (valor inicial)

            if (valorInicial < valorFinal)
            {
                recorrerDe1En1(valorInicial +1, valorFinal);//sumando la  unidad al valor inicial mientras este siga siendo menor que el valor final
            }
        }
    }
}
