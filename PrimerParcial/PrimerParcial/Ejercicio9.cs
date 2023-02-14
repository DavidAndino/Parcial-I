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
        //Globales
        Carro miCarro = null;//creando objeto vacio
        List <Carro> listaCarros = new List <Carro>();//creando lista

        private void button1_Click(object sender, EventArgs e)
        {
            //Carro miCarro = new Carro();//creando instancia u objeto de la clase "Carro", con el constructor vacio o "por default" en Java
            //Carro miCarro2 = new Carro("Subaru", "WRX");//utilizando constructor con parametros. Instanciar es crear un objeto de la clase (Carro en este caso)
            //definicion de constante
            const string valor = "ok";

            //validando precio
            decimal precio = precioTextBox.Text == string.Empty ? 0 : Convert.ToDecimal(precioTextBox.Text);/* "?" es "entonces: y precio = 0;// ":" es "else"
                                                                                                             */s
            //Definiendo e inicializando variables
            string marca = marcaTextBox.Text;
            string modelo = modelTextBox.Text;
            //decimal precio = Convert.ToDecimal(precioTextBox.Text);
            int km = Convert.ToInt32(kmTextBox.Text);

            miCarro = new Carro();//instanciando objeto
            miCarro.Marca = marca;//esto equivaldria utilizar instanciar con el constructor que tiene todos los parametros. utilizando "set"
            miCarro.Modelo = modelo;//utilizando "set" en todas estas
            miCarro.Precio = precio;
            miCarro.Km= km;

            //MessageBox.Show("Objeto Carro -> Marca: " + miCarro.Marca + " Modelo: " + miCarro.Modelo);
            
            listaCarros.Add(miCarro);//llenando lista mediante las modificaciones de los estados de los atributos por el usuario, cada vez que se de click
            carrosDataGridView.DataSource = null;//limpiando para que deje agregar mas registros o filas
            carrosDataGridView.DataSource = listaCarros;
            limpiarControles();
            marcaTextBox.Focus();//enviando el foco al primer textbox luego de operar

        }
        private void limpiarControles()
        {
            //limpieando cajas de texto de 3 maneras:
            marcaTextBox.Clear();
            modelTextBox.Text = string.Empty;
            precioTextBox.Text = "";
            kmTextBox.Clear();
        }
        //mostrando el puntero del mouse en la primera textbox cuando inicia el programa
        private void Ejercicio9_Load(object sender, EventArgs e)
        {
            marcaTextBox.Focus();
        }
    }
}
