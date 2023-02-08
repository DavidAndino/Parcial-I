using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Carro/*internal es el modificador de acceso, e indica  que solo tendremos acceso a esta clase dentro
                         del espacio de nombre "POO" (se cambio a public luego)*/
    {
        //Creando atributos
        private string marca;
        private string modelo;
        //private decimal precio;

        //Propiedades o metodos getters y setters (en Java)

        //1ra forma de hacerlo
        public string Marca 
        { 
            get { return marca; }//obteniendo marca por medio del retorno
            set { marca = value; } //modificando valor (value) de marca
        }

        //2da forma de hacerlo
        public string Modelo { get => modelo; set => modelo = value; }

        //3ra forma (mas resumida), con esta forma, el atributo se crea automaticamente al mismo tiempo que se hace la propiedad
        public decimal Precio { get; set; }

        //"Prop" y dos veces TAB
        public int Km { get; set; }

        //CONSTRUCTORES
        public Carro()
        {

        }

        //Con parametros formales.
        public Carro(string _marca, string _modelo)
        {
            Marca = _marca;//pasandole el parametro a la propiedad antes creada: "Marca"; la propiedad le pasa valores a los atributos
            Modelo  = _modelo;//pasandole el parametro a la propiedad antes creada: "Modelo"; la propiedad le pasa valores a los atributos
        }

        //"Ctrl + ." acceso rapido para generar codigos, como este constructor:
        public Carro(string marca, string modelo, decimal precio, int km) : this(marca, modelo)/*"this", indica que este constructor hereda el antes creado
                                                                                                "this hace referencia a la clase actual"*/
        {
            Precio = precio;
            Km = km;
        }

        //METODOS GENERICOS
        public string estadosDeAtributos()
        {
            return "Marca: "+Marca + "Modelo: " + Modelo + "Precio: " + Precio;
        }
    }
}
