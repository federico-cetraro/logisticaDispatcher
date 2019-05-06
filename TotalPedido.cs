using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestorLogistica
{
    public class TotalPedido
    {

        public string contratista;

        public double valorPedido;

        public string direccionPedido;

        public TotalPedido(string contratista, double valorPedido, string direccionPedido)
        {
            this.contratista = contratista;
            this.valorPedido = valorPedido;
            this.direccionPedido = direccionPedido;
        }
    }
}