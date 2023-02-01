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
            hornearPizza();
            MessageBox.Show("Mensaje normal");
            
        }
        private void hornearPizza()
        {
            Thread.Sleep(10000);//deteniendo por milisegundos =  10 segundos
        }
        private Task hornearPizzaAsync()
        {
            return Task.Delay(10000);
        }

        private void hornearAsinButton_Click(object sender, EventArgs e)
        {
            hornearPizzaAsync();
            MessageBox.Show("Mensaje asincrono");//ejecuta ambos procesos al mismo tiempo, o sea la funcion y el message
        }
        private async Task<decimal> sumarAsync(decimal n1, decimal n2)
        {
            decimal suma = await Task.Run(() =>
            {
                return n1 + n2;
            });
            return suma;
        }

        private async void calcularButtom_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(num1TextBox.Text), num2 = Convert.ToDecimal(num2TextBox.Text);
            decimal total = await sumarAsync(num1, num2);
            MessageBox.Show($"La suma es: {total}");
        }
    }
}
