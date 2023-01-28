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
        public Ejercicio1()//Ejercicio 1 es la clase
        {
            InitializeComponent();
        }
        //Variables globales
        decimal sumaTotal=0;
        private void sumarButton_Click(object sender, EventArgs e)
        {
            //Creando y definiendo variables
            decimal num1 = Convert.ToDecimal(num1TextBox.Text), num2 = Convert.ToDecimal(num2TextBox.Text);
            //decimal res = num1 + num2;

            //Resolucion por metodos
            //Void
            //sumar(num1, num2);
            //Funcion
            sumaTotal = suma(num1, num2);//asigando el valor retornado por la funcion a la variable global "sumaTotal"
            //Imprimiendo en etiqueta
            resultadoLabel.Text = Convert.ToString(sumaTotal);
            //Imprimiendo con ventana
            MessageBox.Show ("El resultado es: " + sumaTotal, "Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);//"Calculator es  el titulo de la ventana". Las comas separan parametros
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {

        }
        //Metodos creados
        private void sumar(decimal num1, decimal num2)
        {
            sumaTotal = num1 + num2;
        }
        private decimal suma(decimal num1, decimal num2)
        {   
            return num1+num2;//cuando son muchas lineas de codigo, se recomienda crear variables locales en la funcion
        }
    }
}
