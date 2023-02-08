using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO;//usando libreria o referencia POO

namespace PrimerParcial
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Carro miCarro = new Carro();//creando instancia u objeto de la clase "Carro", con el constructor vacio o "por default" en Java
            Carro miCarro2 = new Carro("Subaru", "WRX");//utilizando constructor con parametros. Instanciar es crear un objeto de la clase (Carro en este caso)
        }
    }
}
