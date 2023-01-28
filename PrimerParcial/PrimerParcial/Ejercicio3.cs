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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void ejecutarButtom_Click(object sender, EventArgs e)
        {
            string cadena = cadenaTextBox.Text;//inicializando variable en el cuadro de texto donde ingresara datos el  usuario
            //devolviendo longitud de cadena:
            longTextBox.Text = cadena.Length.ToString();//otra  forma de convertir datos 
            //ejemplo de uso de este metodo es validar  el  minimo de caracteres de una contraseña

            //devolviendo 1er caracter  de la cadena:
            primerChaTextBox.Text = cadena.Substring(0,1);//primer parametro: valor inicial. 2do: cuantas posiciones avanzara en su busqueda

            //devolviendo ultimo caracter de la cadena
            ultimoCharTextBox.Text = cadena.Substring(cadena.Length-1, 1);

            //devolviendo la cadena en mayusculas
            mayusTextBox.Text = cadena.ToUpper();

            //devolviendo la cadena en minusculas
            minusTextBox.Text = cadena.ToLower();

            //reemplazando caracteres  en la cadena
            replaceTextBox.Text = cadena.Replace(" ", "-");//1er parametro: caracter a cambiar. 2do: caracter nuevo
        }
    }
}
