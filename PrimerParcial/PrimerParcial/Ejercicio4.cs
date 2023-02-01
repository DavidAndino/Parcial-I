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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void ejecutarButton_Click(object sender, EventArgs e)
        {
            DateTime fecha = fechaDateTimePicker.Value;//pasando fecha que ingreso el usuario en la interfaz de  calendario a la variable "fecha"
            diaTextBox.Text = fecha.Day.ToString();//llaves son propiedades, cubos son funciones. Extrayendo dia de la  variable fecha
            weekTextBox.Text = fecha.ToString("dddd");//dentro de las comillas esta el formato que devuelve el dia de la semana en letras
            mesTextBox.Text = fecha.ToString("MMMM");//dentro de las comillas esta el formato que devuelve el mes en letras
            anioTextBox.Text = fecha.Year.ToString();
            horaTextBox.Text = fecha.ToString("T");//dentro de las comillas esta el formato que devuelve la hora con mins y segundos
            //citas procesos
      
            int dias = Convert.ToInt32(diasTextBox.Text);//capturando los dias ingresados por el usuario
            DateTime fechaActual = DateTime.Now;//asigando fecha actual del sistema a la variable "fechaActual"
            citaTextBox.Text = fechaActual.AddDays(dias).ToShortDateString();//obteniendo a la fecha actual del sistema. El .ToShortString() muestra fecha corta

            //restando dias a una fecha
            int restados = Convert.ToInt32(restarDiasTextBox.Text);
            newDateTextBox.Text = fecha.AddDays(-restados).ToShortDateString();//restando dias segun el numero que ingreso el usuario
            //Imprimiendo mensaje
            MessageBox.Show("La edad  es: " + edad(fecha));//pasando como argumento la fecha seleccionada en el calendario

        }
        private int edad(DateTime fechaBorn)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = 0;
            if (fechaBorn >= fechaActual)
            {
                return 0;
            } 
            else
            {
                edad = fechaActual.Year - fechaBorn.Year;//lo que se restan son los anios, es por eso que va ".Year"
                //validando meses para no dar una edad mas alta en anios
                if (fechaBorn.Month >  fechaActual.Month)
                {
                    --edad;/*restandole un anio a la edad si el usuario todavia no ha cumplido anios, 
                           o sea si todavia no ha pasado su mes de nacimiento en la fecha actual */
                    //edad - =1;//otra forma de decrementar
                }
                return edad;//retornando la edad despues de haber validado
            }
           
        }
    }
}
