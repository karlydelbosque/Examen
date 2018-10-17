using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    class Transporte: ITransporte
    {
        string color = "", marca = "", modelo = "";

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }

        public string Marca
        {
            get { return this.marca; }
            set { this.marca = value; }
        }

        public string Modelo
        {
            get { return this.modelo; }
            set { this.modelo = value; }
        }

        public Transporte()
        {

        }

        public Transporte(string color, string marca, string modelo)
        {
            this.color = color;
            this.marca = marca;
            this.modelo = modelo;
        }

        public virtual void Acelerar()
        {
            Console.WriteLine("El transporte está acelerando");
        }

        public virtual void Frenar()
        {
            Console.WriteLine("El transporte está frenando");
        }

        public virtual void Chocar()
        {
            Console.WriteLine("El transporte chocó");
        }
    }
}
