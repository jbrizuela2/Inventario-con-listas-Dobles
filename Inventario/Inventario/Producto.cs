using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Producto
    {
        public Producto siguiente;
        public Producto anterior;

        private string codigo;
        private string nombre;
        private int cantidad;
        private double precio;

        public Producto(string codigo, string nombre, int cantidad, double precio)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public override string ToString()
        {
            return cantidad + " " + nombre + " ID: " + codigo + " Precio: " + precio;
        }

        public string getCodigo()
        {
            return codigo;
        }

        public string getNombre()
        {
            return nombre;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public double getPrecio()
        {
            return precio;
        }

    }
}
