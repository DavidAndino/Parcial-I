using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class Ejercicio6 : Form
    {
        public Ejercicio6()
        {
            InitializeComponent();
        }

        private void arrayButton_Click(object sender, EventArgs e)
        {
            int[] array = new int [5];//creando arreglo
            //asignando valores al arreglo
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;
            array[3] = 40;
            array[4] = 50;

            //creando e inicializando arreglos
            int[] array2 = {1,2,3,4,5};
            int[] array3 = {10,20,30,40,50,60};
            int[] array4 = new int[] {10,20,40,50};

            string[] array5 = { "Hola", "Mundo", "Cruel"};

            for (int i = 0; i < array5.Length; i++)
            {
                arrayListBox.Items.Add(array5[i]);/*recorriendo cada una de las posiciones del arreglo y almacenandolo y mostrandolo en el arrayListBox
                                                   "Items" almacena elementos en el listBox, luego que el "Add" le agregara los  mismos
                                                    elementos al "Items"
                                                   */
            }

            foreach (string item in array5)/*var identifica el tipo de dato que se le asigna a una variable automaticamente. 
                                            Itera listas o colecciones de objetos*/
            {
                comboBox1.Items.Add(item);
            }

        }
    }
}
