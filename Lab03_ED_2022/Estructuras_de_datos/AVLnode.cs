using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab03_ED_2022.Estructuras_de_datos
{
    public class AVLnode<T>
    {
        public T value;
        public AVLnode<T> left;
        public AVLnode<T> right;
        public int height;
    
        //Constructor de mi clase AVLnode
        public AVLnode(T value)
        {
            this.value = value;
        }
    }
}
