using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab03_ED_2022.Pila
{
    public class Pila<T>
    {
        NodoPila<T> Cabeza = new NodoPila<T>();
        
        public void Insertar(T valor)
        {
            NodoPila<T> Nuevo = new NodoPila<T>();
            Nuevo.Data = valor;
            Nuevo.Siguiente = Cabeza;
            Cabeza = Nuevo;
        }

        public T QuitarUltimo()
        {
            NodoPila<T> aux = new NodoPila<T>();
            aux.Data = Cabeza.Data;
            if (Cabeza != null)
            {
                if (aux.Siguiente == null)
                {
                    Cabeza = null;
                    return aux.Data;
                }
                while (aux.Siguiente.Siguiente != null)
                {
                    aux = aux.Siguiente;
                }
                aux.Siguiente = null;
                return aux.Data;
            }
            else
            {
                return default (T);
            }
        }

        public int Size()
        {
            int Cantidad = 0;
            for (NodoPila<T> i = Cabeza; i != null; i = i.Siguiente)
            {
                Cantidad++;
            }
            return Cantidad;
        }

        public bool IsEmpty()
        {
            return (Cabeza == null);
        }
    }
}
