using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorLogistica
{
    public class Proveedor
    {

        public int paquete, cantidadArticulos;

        public string descripcion, codigoSeguimiento;

        public double valorEnvio;

        public Proveedor()
        {
        }

        public Proveedor(int paquete, string codigoSeguimiento, int cantidadArticulos, string descripcion, double valorEnvio)
        {
            this.paquete = paquete;
            this.codigoSeguimiento = codigoSeguimiento;
            this.cantidadArticulos = cantidadArticulos;
            this.descripcion = descripcion;
            this.valorEnvio = valorEnvio;
        }

    }
}