using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorLogistica
{
    public class Contratista
    {

        public string nombre, radicacion, cuit;

        public Contratista(){}

        public Contratista(string nombre, string radicacion, string cuit)
        {
            this.nombre = nombre;
            this.radicacion = radicacion;
            this.cuit = cuit;
        }
    }
}