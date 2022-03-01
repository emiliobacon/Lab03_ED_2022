using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



namespace Lab03_ED_2022.Estructuras_de_datos
{
    public class AVLtree<T> where T : IComparable<T>
    {
        AVLnode<T> root;

        //Contructor de mi clase
        public AVLtree()
        {
            this.root = null;
        }


        /*Metodo de insertar un nuevo nodo (inserción).
         * Cuando no existe raíz en el árbol
         */
        public void insert(T value)
        {
            AVLnode<T> newNode = new AVLnode<T>(value);

            if (this.root == null)
            {
                this.root = newNode;
            }
            else
            {
                this.root = this.insertNode(this.root, newNode);
            }
        }

        public AVLnode<T> insertNode(AVLnode<T> actualroot, AVLnode<T> newNode)
        {
            if (actualroot != null)//recorrer las hojas o hijos
            {
                if (newNode.value.CompareTo(actualroot.value) < 0)//Cuando es menor
                {
                    actualroot.left = this.insertNode(actualroot.left, newNode);//se manda a la nodo izquierdo
                    //Factor de balanceo
                    if (this.node_Height(actualroot.right) - this.node_Height(actualroot.left) == -2)
                    {
                        //Entra a rotacion izquierda
                        if (newNode.value.CompareTo(actualroot.left.value) < 0)
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
                else if (newNode.value.CompareTo(actualroot.value) > 0)
                {
                    actualroot.right = this.insertNode(actualroot.right, newNode);//se manda a la nodo derecho
                    if (this.node_Height(actualroot.right) - this.node_Height(actualroot.left) == 2)
                    {
                        //Entra a rotacion derecha
                        if (newNode.value.CompareTo(actualroot.right.value) > 0)
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
                else
                {

                }
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

        //Recorridos
        public void Inorder(AVLnode<T> actualRoot)
        {
            if(actualRoot != null)
            {
                this.Inorder(actualRoot.left);


            }
        }

    }
}
