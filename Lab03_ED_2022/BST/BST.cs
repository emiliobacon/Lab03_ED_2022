using Lab03_ED_2022.Comparison;
using Lab03_ED_2022.Estructura_de_Datos;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Lab03_ED_2022.BST
{
    public class BST<T> : IEnumerable<T>, IEnumerable
    {


        public Compare<T> comparar { get; set; }
        public static Stopwatch tiempoOrdenamientoABB = new Stopwatch();
        public double x = 0;
        public int ComparacionesBusquedaABB = 0;



        Nodo<T> raiz;
        public BST()
        {
            this.raiz = null;
        }

        //Nodo<T> actual = new Nodo<T>();
        //Nodo<T> tempPadre = new Nodo<T>();
        //Nodo<T> tempBorrar = new Nodo<T>();
        //Nodo<T> tempHijo = new Nodo<T>();
        //Nodo<T> sortOrder = new Nodo<T>();
        //Nodo<T> maxNodo = new Nodo<T>();


        public void InsertarNodo(T data)
        {
            Nodo<T> newNode = new Nodo<T>(data);
            

            if (this.raiz == null)
            {
                this.raiz = newNode;
            }
            else
            {
                tiempoOrdenamientoABB.Start();
                raiz = this.InsertarNodo(raiz, newNode);
                tiempoOrdenamientoABB.Stop();
                x += tiempoOrdenamientoABB.Elapsed.TotalMilliseconds;

            }
        }

        private Nodo<T> InsertarNodo(Nodo<T> actualroot, Nodo<T> newNode) //Metodo para insertar un nodo sino 
        {
            if (actualroot != null)//recorrer las hojas o hijos
            {
                if (comparar(newNode.Data, actualroot.Data) < 0)//Cuando es menor
                {
                    actualroot.Izquierda = this.InsertarNodo(actualroot.Izquierda, newNode);//se manda a la nodo izquierdo
                   
                }
                else if (comparar(newNode.Data, actualroot.Data) > 0) //cuando es mayor
                {
                    actualroot.Derecha = this.InsertarNodo(actualroot.Derecha, newNode);//se manda a la nodo derecho
                 
                }
                else { }
               
                return actualroot;
            }
            else
            {
                actualroot = newNode;
                return actualroot;
            }
        }


        public T Buscar(T valor)
        {
            return Buscar(valor, raiz);
        }

       

        private T Buscar(T elemento, Nodo<T> raiz)
        {
            Nodo<T> aux_Node = raiz;

            if (aux_Node == null)
            {
                ComparacionesBusquedaABB++;
                return default(T);
            }
            else if (comparar(elemento, aux_Node.Data) == 0)
            {
                ComparacionesBusquedaABB++;
                return aux_Node.Data;
            }
            else if (comparar(elemento, aux_Node.Data) < 0)
            {
                ComparacionesBusquedaABB++;
                return Buscar(elemento, aux_Node.Izquierda);
            }
            else
            {
                ComparacionesBusquedaABB++;
                return Buscar(elemento, aux_Node.Derecha);
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

        //profundidad
        public static int altura = 0;
        private void RetornarAltura(Nodo<T> reco, int nivel)
        {
            if (reco != null)
            {
                RetornarAltura(reco.Izquierda, nivel + 1);
                if (nivel > altura)
                    altura = nivel;
                RetornarAltura(reco.Derecha, nivel + 1);
            }
        }

        public int RetornarAltura()
        {
            altura = 0;
            RetornarAltura(raiz, 1);
            return altura;
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
        public int Comparaciones()
        {
            return ComparacionesBusquedaABB;
        }

        public double TiempoDeOrdenamientoABB()
        {

            return x;
        }
    }
}








