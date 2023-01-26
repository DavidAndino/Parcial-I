using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial//namespace sirve para encapsular bloques de codigo, para agregar seguridad al proyecto
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void sumarButton_Click(object sender, EventArgs e)
        {
            //Creando y definiendo variables
            decimal num1 = Convert.ToDecimal(num1TextBox.Text), num2 = Convert.ToDecimal(num2TextBox.Text);
            decimal res = num1 + num2;
            MessageBox.Show("El resultado de la suma es: "+res);

        }
    }
}
