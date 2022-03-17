using Lab03_ED_2022.Comparison;
using Lab03_ED_2022.Estructura_de_Datos;
using System.Collections;
using System.Collections.Generic;

namespace Lab03_ED_2022.BST
{
    public class BST<T> : IEnumerable<T>, IEnumerable
    {
        public Compare<T> comparar { get; set; }

        Nodo<T> raiz = new Nodo<T>();
        Nodo<T> actual = new Nodo<T>();
        Nodo<T> tempPadre = new Nodo<T>();
        Nodo<T> tempBorrar = new Nodo<T>();
        Nodo<T> tempHijo = new Nodo<T>();
        Nodo<T> sortOrder = new Nodo<T>();

        Nodo<T> maxNodo = new Nodo<T>();

        public void InsertarNodo(T data)
        {
            Nodo<T> nuevoNodo = new Nodo<T>();

            nuevoNodo.Data = data;



            if (raiz.Data == null) //cambiar a  recursivo 
            {
                raiz = nuevoNodo;
            }
            else
            {
                actual = raiz;

                while (true)
                {
                    tempPadre = actual;

                    if (comparar(nuevoNodo.Data, actual.Data) < 0)
                    {
                        actual = actual.Izquierda;
                        if (actual == null)
                        {
                            tempPadre.Izquierda = nuevoNodo;
                            nuevoNodo.Padre = tempPadre;
                            return;
                        }
                    }
                    else
                    {
                        actual = actual.Derecha;
                        if (actual == null)
                        {
                            tempPadre.Derecha = nuevoNodo;
                            nuevoNodo.Padre = tempPadre;
                            return;
                        }
                    }
                }
            }

        }



        public T Buscar(T valor)
        {
            return Buscar(valor, raiz);
        }

        private T Buscar(T elemento, Nodo<T> raiz)
        {
            actual = raiz;

            if (actual == null)
            {
                return default(T);
            }
            else if (comparar(elemento, actual.Data) == 0)
            {
                return actual.Data;
            }
            else if (comparar(elemento, actual.Data) < 0)
            {
                return Buscar(elemento, actual.Izquierda);
            }
            else
            {
                return Buscar(elemento, actual.Derecha);
            }
        }

        public Nodo<T> Max(Nodo<T> actual)
        {


            while (actual.Izquierda != null)
            {
                actual = actual.Izquierda;
            }
            return actual;
        }

        ////public Nodo<T> BorrarNodo(T llave, Compare<T> comparar)
        ////{
        ////    tempBorrar.Data = Buscar(llave, comparar); //arreglar eliminacion 

        ////    if (raiz != null)
        ////    {
        ////        if (comparar(llave, raiz.Data) == -1)
        ////        {
        ////            raiz.Izquierda = BorrarNodo(raiz.Izquierda, llave);
        ////        }
        ////        else if (comparar(llave, raiz.Data) == 1)
        ////        {

        ////        }
        ////        else
        ////        {

        ////        }
        ////        if ((tempBorrar.Izquierda == null) && (tempBorrar.Derecha == null))
        ////        {
        ////            tempPadre = tempBorrar.Padre;
        ////            if (comparar(tempBorrar.Data,tempPadre.Izquierda)==0)
        ////            {
        ////                tempPadre.Izquierda = null;
        ////            }
        ////            else
        ////            {
        ////                tempPadre.Derecha = null;
        ////            }
        ////        }
        ////        else if ((tempBorrar.Izquierda == null) || (tempBorrar.Derecha == null))
        ////        {
        ////            tempHijo = tempBorrar.Izquierda == null ? tempBorrar.Derecha : tempBorrar.Izquierda;
        ////            tempPadre = tempBorrar.Padre;
        ////            if (tempBorrar == tempPadre.Izquierda)
        ////            {
        ////                tempPadre.Izquierda = tempHijo;
        ////            }
        ////            else
        ////            {
        ////                tempPadre.Derecha = tempHijo;
        ////            }

        ////        }
        ////        else if ((tempBorrar.Izquierda != null) && (tempBorrar.Derecha != null))
        ////        {
        ////            maxNodo = Max(tempBorrar.Derecha);

        ////            tempBorrar.Data = maxNodo.Data;

        ////            BorrarNodo((tempBorrar.Derecha), maxNodo.Data, comparar);

        ////        }
        ////        return true;
        ////    }
        ////    else
        ////    {
        ////        return false;
        ////    }




        ////}

        public Nodo<T> BorrarNodo(Nodo<T> raiz, T llave, Compare<T> comparar)
        {
            if (raiz == null)
            {
                return raiz;
            }

            if (comparar(llave, raiz.Data) == -1)
            {
                raiz.Izquierda = BorrarNodo(raiz.Izquierda, llave, comparar);
            }
            else if (comparar(llave, raiz.Data) == 1)
            {
                raiz.Derecha = BorrarNodo(raiz.Derecha, llave, comparar);
            }
            else
            {
                if (raiz.Izquierda == null && raiz.Derecha == null)
                {
                    raiz = null;
                }
            }
            return raiz;
        }


        private void InOrder(Nodo<T> padre, ref ColaRecorrido<T> queue)
        {

            if (padre != null)
            {
                InOrder(padre.Izquierda, ref queue);
                queue.Encolar(padre.Data);
                InOrder(padre.Derecha, ref queue);
            }
            return;
        }




        public IEnumerator<T> GetEnumerator()
        {
            var queue = new ColaRecorrido<T>();
            InOrder(raiz, ref queue);

            while (!queue.ColaVacia())
            {
                yield return queue.DesEncolar();
            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        //actualizado 
        //nueva acutalizacion

    }
}








