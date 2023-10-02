using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_12G_2C2023
{
    class Persona
    {
        public int DNI { get; set; }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string MostrarDatos()
        {
            string retorno = "";
            retorno = "Datos: " + DNI + " " + Apellido + " " + Nombre;
            return retorno;
        }
    }
}
