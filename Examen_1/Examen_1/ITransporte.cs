using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    interface ITransporte
    {
        string Color { get; set; }
        string Marca { get; set; }
        string Modelo { get; set; }

        void Encender();
        void Apagar();
        void Acelerar();
    }
}
