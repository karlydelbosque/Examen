using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // A V I O N

            Avion avion1 = new Avion();
            avion1.Color = "Rosa";
            avion1.Acelerar();

            Avion avion2 = new Avion();
            avion2.Color = "Blanco";
            avion2.Acelerar();

            // B A R C O

            Barco barco1 = new Barco();
            barco1.Color = "Negro";
            barco1.Frenar();

            Barco barco2 = new Barco();
            barco2.Color = "Dorado";
            barco2.Frenar();

            // B I C I C L E T A 

            Bicicleta bicicleta1 = new Bicicleta();
            bicicleta1.Modelo = "BMX";
            bicicleta1.Acelerar();

            Bicicleta bicicleta2 = new Bicicleta();
            bicicleta2.Modelo = "De montaña";
            bicicleta2.Acelerar();

            // C A R R O

            Carro carro1 = new Carro();
            carro1.Marca = "Lamborghini";
            carro1.Acelerar();

            Carro carro2 = new Carro();
            carro2.Marca = "McLaren";

            // T R E N

            Tren tren1 = new Tren();
            tren1.Marca = "Auhagen";
            tren1.Chocar();

            Tren tren2 = new Tren();
            tren2.Marca = "Bachmann";
            tren2.Chocar();
        }
    }
}
