using Lab03_ED_2022.Comparison;
using Lab03_ED_2022.Pila;
using System.Collections;
using System.Collections.Generic;

namespace Lab03_ED_2022.BST
{
    public class BST<T> : IEnumerable<T>, IEnumerable
    {

        Nodo<T> raiz = new Nodo<T>();
        Nodo<T> actual = new Nodo<T>();
        Nodo<T> tempPadre = new Nodo<T>();
        Nodo<T> tempBorrar = new Nodo<T>();
        Nodo<T> tempHijo = new Nodo<T>();
        Nodo<T> sortOrder = new Nodo<T>();

        Nodo<T> maxNodo = new Nodo<T>();

        public void InsertarNodo(T data, Compare<T> comparar)
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

        public T Buscar(T valor, Compare<T> comparar)
        {
            return Buscar(valor, raiz, comparar);
        }

        private T Buscar(T elemento, Nodo<T> raiz, Compare<T> comparar)
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
                return Buscar(elemento, actual.Izquierda, comparar);
            }
            else
            {
                return Buscar(elemento, actual.Derecha, comparar);
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


        public  T inOrder(Nodo<T> padre)
        {
            padre = raiz;

            if (padre != null)
            {
                inOrder(padre.Izquierda);
                 yield return = padre.Data;
                inOrder(padre.Derecha);
            }
            return default(T);
          
        }
         
        

        public IEnumerator<T> GetEnumerator()
        {
            //if (raiz.Data != null)
            //{

            //    Pila<Nodo<T>> s = new Pila<Nodo<T>>();

            //    Nodo<T> actual = raiz;


            //    while (actual != null )
            //    {
            //        while (actual != null)
            //        {
            //            s.Insertar(actual);
            //            actual = actual.Izquierda;
            //        }

            //        actual = s.Quitar();


            //        yield return actual.Data;

            //        actual = actual.Derecha;
            //    }
            //}

            Nodo<T> nodo = raiz;

            yield return nodo.Data;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }


    }


}








