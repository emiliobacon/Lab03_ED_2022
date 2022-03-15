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

        public T Quitar()
        {
            if (Cabeza == null)
            {
                return default(T);
            }
            T Retorno = Cabeza.Data;
            NodoPila<T> Top = Cabeza;
            Cabeza = Cabeza.Siguiente;
            
            return Retorno;
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
    }
}
