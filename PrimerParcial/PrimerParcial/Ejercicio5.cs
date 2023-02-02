using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void hornearButton_Click(object sender, EventArgs e)
        {
            hornearPizza();//invocando procedimiento
            MessageBox.Show("Mensaje normal");
            
        }
        private void hornearPizza()
        {
            Thread.Sleep(10000);//deteniendo por milisegundos 10000 =  10 segundos
        }
        //con la programacion asincrona se aprovechan todos los recursos que ofrece la CPU
        private Task hornearPizzaAsync()
        {
            return Task.Delay(10000);//deteniendo por milisegundos 10000 =  10 segundos
        }

        private void hornearAsinButton_Click(object sender, EventArgs e)
        {
            hornearPizzaAsync();
            MessageBox.Show("Mensaje asincrono");//ejecuta ambos procesos al mismo tiempo, o sea la funcion y el message
        }

        private async void calcularButtom_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(num1TextBox.Text), num2 = Convert.ToDecimal(num2TextBox.Text);//creando variables para los textBoxes
            decimal total = await sumarAsync(num1, num2);//invocanco funcion asincrona (siempre se necesita el await y el async)
            MessageBox.Show($"La suma es: {total}");//mostrando mensaje sin utilizar la concatenacion
        }
        private async Task<decimal> sumarAsync(decimal n1, decimal n2)
        {
            decimal suma = await Task.Run(() =>//devolviendo una tarea que devuelve un valor decimal//await le devuelve la tarea al async
            {
                return n1 + n2;//esta suma esta almacenada en la variable "suma"
            });
            return suma;//retornando lo que esta almacenado en la variable "suma"
        }
    }
}
