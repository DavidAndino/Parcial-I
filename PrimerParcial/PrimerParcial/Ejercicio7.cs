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
            //creando matriz e inicializandola
            int[,] matriz = new int[3, 3] { { 3,6,3}, { 6,9,7}, {8,9,4 } };//matriz 3x3 1er valor: filas, 2do: columnas

            //creando otra matriz y llenandola randomly
            int[,] matriz2 = new int[3, 4];//matriz de 2 dimensiones, solo se tiene filas (0, 1ra dimension) y cols (1, 2da dimension)

            //creando instancia random
            Random generarNum = new Random();

            for (int i = 0; i < matriz2.GetLength(0); i++)//ciclo de recorrido de filas
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)//ciclo de recorrido de columnas
                {

                }
            }
        }
    }
}
