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
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Limpiando listBox para que no se vean luego de  dar click en el boton
            listBox1.Items.Clear();

            //creando matriz e inicializandola
            int[,] matriz = new int[3, 3] { { 3,6,3}, { 6,9,7}, {8,9,4 } };//matriz 3x3 1er valor: filas, 2do: columnas

            //creando instancia de la clase random para darle un numero aleatorio de dimensiones a la matriz

            //Random dimensiones = new Random();

            //int valorFila = dimensiones.Next(1, 10);//"Next" es  una funcion que genera un numero entero
            //int valorCol = dimensiones.Next(1, 10);
            //declarando e inicializando filas y cols con valores ingresados por  el usuario
            int filas = Convert.ToInt32(filasTextBox.Text), cols = Convert.ToInt32(colsTextBox.Text);
            
            //creando otra matriz y llenandola randomly
            int[,] matriz2 = new int[filas, cols];//matriz de 2 dimensiones, solo se tiene filas (0, 1ra dimension) y cols (1, 2da dimension)

            //creando instancia random para llenar matriz
            Random generarNum = new Random();

            //llenando matriz 
            for (int i = 0; i < matriz2.GetLength(0); i++)//ciclo de recorrido de dimension de filas
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)//ciclo de recorrido de dimension de columnas
                {
                    matriz2[i, j]= generarNum.Next(1,50);//generando valores del 1 al 50 que llenaran la matriz
                }
            }

            //creando ciclos para imprimir contenido de la matriz
            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    listBox1.Items.Add("El índice: [" + i + "," + j + "] = " + matriz2[i, j]);
                }
            }

            textBox1.Text = matriz2.GetLength(0).ToString() + "x" + matriz2.GetLength(1).ToString();//imprimiendo dimension de matriz
        }
    }
}
