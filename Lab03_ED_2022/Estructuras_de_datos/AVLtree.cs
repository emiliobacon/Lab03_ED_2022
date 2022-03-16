using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab03_ED_2022.Comparison;


namespace Lab03_ED_2022.Estructuras_de_datos
{
    public class AVLtree<T> : IEnumerable<T>, IEnumerable  // interfaz
    {
        //Varible
        AVLnode<T> root;

        //Contructor de mi clase
        public AVLtree()
        {
            this.root = null;
        }
        
        //----------------------- Métodos ----------------------------
        /*Metodo de insertar un nuevo nodo (inserción).
         * Cuando no existe raíz en el árbol
         */
        public void insert(T value, Compare<T> comparar)
        {
            AVLnode<T> newNode = new AVLnode<T>(value);

            if (this.root == null)
            {
                this.root = newNode;
            }
            else
            {
                this.root = this.insertNode(this.root, newNode, comparar);
            }
        }

        public AVLnode<T> insertNode(AVLnode<T> actualroot, AVLnode<T> newNode, Compare<T> comparar) //Metodo para insertar un nodo sino 
        {
            if (actualroot != null)//recorrer las hojas o hijos
            {
                if (comparar(newNode.value, actualroot.value) < 0)//Cuando es menor
                {
                    actualroot.left = this.insertNode(actualroot.left, newNode , comparar);//se manda a la nodo izquierdo
                    //Factor de balanceo
                    if (this.node_Height(actualroot.right) - this.node_Height(actualroot.left) == -2)
                    {
                        //Entra a rotacion izquierda
                        if (comparar(newNode.value,actualroot.left.value) < 0)
                        {
                            //Entra a rotacion L
                            actualroot = this.left_Rotation(actualroot);
                        }
                        else //rotacion left-right
                        {
                            actualroot = this.left_Right_Rotation(actualroot);
                        }
                    }
                }
                else if (comparar(newNode.value,actualroot.value) > 0)
                {
                    actualroot.right = this.insertNode(actualroot.right, newNode, comparar);//se manda a la nodo derecho
                    if (this.node_Height(actualroot.right) - this.node_Height(actualroot.left) == 2)
                    {
                        //Entra a rotacion derecha
                        if (comparar(newNode.value, actualroot.right.value) > 0)
                        {
                            //Entra a rotacion R
                            actualroot = this.right_Rotation(actualroot);
                        }
                        else //rotacion right - left
                        {
                            actualroot = this.right_Left_Rotation(actualroot);
                        }
                    }
                }
                else {}
                actualroot.height = this.max_Height(this.node_Height(actualroot.right), this.node_Height(actualroot.left)) + 1;
                return actualroot;
            }
            else
            {
                actualroot = newNode;
                return actualroot;
            }
        }

        //Para retornar la altura de los nodos
        public int node_Height(AVLnode<T> node)
        {
            if (node != null)
            {
                return node.height;
            }
            else
            {
                return -1;
            }
        }
        //Para comparar dos alturas y retorna la mayor
        public int max_Height(int height1, int height2)
        {
            if (height2 >= height1)
            {
                return height2;
            }
            else
            {
                return height1;
            }
        }

        //Rotaciones
        public AVLnode<T> left_Rotation(AVLnode<T> node) //rotacion simple izquierda
        {
            AVLnode<T> aux_Node = node.left;
            node.left = aux_Node.right;
            aux_Node.right = node;
            node.height = this.max_Height(this.node_Height(node.right), this.node_Height(node.left)) + 1;
            aux_Node.height = this.max_Height(node.height, this.node_Height(node.left)) + 1;
            return aux_Node;
        }
        public AVLnode<T> right_Rotation(AVLnode<T> node) //rotacion simple derecha
        {
            AVLnode<T> aux_Node = node.right;
            node.right = aux_Node.left;
            aux_Node.left = node;
            node.height = this.max_Height(this.node_Height(node.left), this.node_Height(node.right)) + 1;
            aux_Node.height = this.max_Height(node.height, this.node_Height(node.right)) + 1;
            return aux_Node;
        }
        public AVLnode<T> left_Right_Rotation(AVLnode<T> node) //rotacion izquierda - derecha
        {
            node.left = this.right_Rotation(node.left);
            AVLnode<T> aux_Node = this.left_Rotation(node);
            return aux_Node;
        }
        public AVLnode<T> right_Left_Rotation(AVLnode<T> node) //rotacion derecha - izquierda
        {
            node.right = this.left_Rotation(node.right);
            AVLnode<T> aux_Node = this.right_Rotation(node);
            return aux_Node;
        }

        public T Buscar(T valor, Compare<T> comparar)
        {
            return Buscar(valor, root, comparar);
        }

        private T Buscar(T elemento, AVLnode<T> raiz, Compare<T> comparar)
        {
            AVLnode<T> aux_Node = raiz;

            if (aux_Node == null)
            {
                return default(T);
            }
            else if (comparar(elemento, aux_Node.value) == 0)
            {
                return aux_Node.value;
            }
            else if (comparar(elemento, aux_Node.value) < 0)
            {
                return Buscar(elemento, aux_Node.left, comparar);
            }
            else
            {
                return Buscar(elemento, aux_Node.right, comparar);
            }
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

            AVLnode<T> valor = root;
            yield return valor.value;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
