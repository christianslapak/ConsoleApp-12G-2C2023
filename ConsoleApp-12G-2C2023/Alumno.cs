using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_12G_2C2023
{
    class Alumno:Persona
    {
        public int Legajo { get; set; }
        public string Materia { get; set; }

        public new string MostrarDatos()
        {
            string retorno = "";
            retorno = base.MostrarDatos() + " " + Legajo + " " + Materia;
            return retorno;
        }
    }
}
