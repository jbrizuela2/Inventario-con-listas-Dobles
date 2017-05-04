using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class Inventario
    {

        private Producto inicial;
        private Producto final;

        public void agregar(Producto nuevo)
        {
            if(inicial == null){
                inicial = nuevo;
            }else{
                Producto actual = inicial;
                while(actual.siguiente != null){
                    actual = actual.siguiente;
                }
                actual.siguiente = nuevo;
                nuevo.anterior = actual;
                final = nuevo;
            }
        }

        public void agregarPrimero(Producto nuevo)
        {
            Producto temp = inicial;
            inicial = nuevo;
            nuevo.siguiente = temp;
            temp.anterior = inicial;
        }

        public void borrar(string cod)
        {
            Producto actual = inicial;
            if (actual.getCodigo().Equals(cod))
            {
                inicial = actual.siguiente;
            }
            else
            {
                while (actual.siguiente != null)
                {
                    if (actual.siguiente.getCodigo().Equals(cod))
                    {
                        actual.siguiente = actual.siguiente.siguiente;
                        actual.siguiente.anterior = actual;
                        return;
                    }
                    else
                    {
                        actual = actual.siguiente;
                    }
                }
            }
        }

        public void insertar(int posicion, Producto nuevo)
        {
            Producto actual = inicial;
            if (posicion == 0)
            {
                Producto temp = inicial;
                inicial = nuevo;
                inicial.siguiente = temp;
            }
            else
            {
                for (int i = 0; i < posicion - 1; i++)
                {
                    actual = actual.siguiente;
                }
                Producto temp = actual.siguiente;
                actual.siguiente = nuevo;
                actual.siguiente.anterior = actual;
                actual.siguiente.siguiente = temp;
                actual.siguiente.siguiente.anterior = actual.siguiente;
            }
        }

        public Producto buscar(string codigo)
        {
            Producto actual = inicial;
            while (actual != null)
            {
                if (actual.getCodigo().Equals(codigo))
                {
                    return actual;
                }
                else
                {
                    actual = actual.siguiente;
                }
            }
            return null;
        }

        public String reporte()
        {
            String s = "";
            Producto actual = inicial;
            while (actual != null)
            {
                s += actual.ToString() + Environment.NewLine;
                actual = actual.siguiente;
            }
            return s;
        }

        public String reporteInverso()
        {
            String s = "";
            Producto actual = final;
            do
            {
                s += actual.ToString() + Environment.NewLine;
                actual = actual.anterior;
            } while (actual != null);
            return s;
        }

        public void eliminarPrimero()
        {
            inicial = inicial.siguiente;
            inicial.anterior = null;
        }

        public void eliminarUltimo()
        {
            final = final.anterior;
            final.siguiente = null;
        }
    }
}
