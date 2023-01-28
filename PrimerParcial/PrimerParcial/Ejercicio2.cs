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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void ejecutarButton_Click(object sender, EventArgs e)
        {
            //Definiendo e inicializando variable
            //decimal num1 = Convert.ToDecimal(num1TextBox.Text), num2 = Convert.ToDecimal(num2TextBox.Text);
            //decimal res = 0;
            //Invoando funcion
            //res = ejecucion(num1, num2);
            //Mostrando resultado por medio de alerta o ventana
            //MessageBox.Show("El resultado de la operacion es: " + res, "Calculadora", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Mismo codigo sin tantas variables
            //validando entrada de los dos numeros
            if (num1TextBox.Text == "")
            {
                errorProvider1.SetError(num1TextBox, "No ingreso algun numero");//primer parametro: qué control devuelve el error. 2do: el mensaje de error (String)
                return;//Cancelando ejecucion del programa, para que no se ejecute el  codigo que sigue y que no muestre 0 en "respuestaTextBox"
            }
            if (num2TextBox.Text == "")
            {
                errorProvider1.SetError(num2TextBox, "No ingreso algun numero");//primer parametro: qué control devuelve el error. 2do: el mensaje de error (String)
                return;//Cancelando ejecucion del programa, para que no se ejecute el codigo que sigue y que no muestre 0 en "respuestaTextBox"

            }
            //Validando que se seleccione algun operador 
            if (oPcomboBox.Text == "")//error provider  muestra un error en el control (oPcomboBox en este caso) que le pasemos
            {
                errorProvider1.SetError(oPcomboBox, "No selecciono algun operador");//primer parametro: que control devuelve el error. 2do: el mensaje de error (String)
                return;//Cancelando ejecucion del programa, para que no se ejecute el  codigo que sigue y que no muestre 0 en "respuestaTextBox"
            }
            errorProvider1.Clear();//Eliminando advertencias si el usuario ya ingreso algun dato
            //Variable
            decimal respuesta = ejecucion(Convert.ToDecimal(num1TextBox.Text), Convert.ToDecimal(num2TextBox.Text));
            respuestaTextBox.Text = Convert.ToString(respuesta);//convirtiendo respuesta a String, porque es un textBox el que almacenara la resupesta, y dicho TextBox es de tipo String

        }
        //Metodos creados por usuario
        private decimal ejecucion(decimal num1, decimal num2)
        {
            //Creando variables locales
            string operacion = oPcomboBox.Text;//en esta variable se almacena lo que el  usuario elija en el combo box del form
            decimal resultado = 0;
            //Iniciando decision multiple
            switch (operacion)
            {
                case "+" :
                    resultado = num1 + num2;
                    break;
                case "-" :
                    resultado= num1 - num2;
                    break;
                case "x" :
                    resultado = num1 * num2;
                    break;
                case "/" :
                    resultado = num1 / num2;
                    break;
                default:
                    break;
            }
            return resultado;//retornando valor luego de evaluar la decision
        }
    }
}
