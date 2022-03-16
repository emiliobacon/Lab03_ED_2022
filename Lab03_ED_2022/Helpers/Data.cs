using Lab03_ED_2022.BST;
using Lab03_ED_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab03_ED_2022.Estructuras_de_datos;

namespace Lab03_ED_2022.Helpers
{
    public class Data
    {
        private static Data _instance = null;
        public static Data Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Data();
                }
                return _instance;
            }
        }

        public BST<ClientModel> miArbolId = new BST<ClientModel>(); //anadir singleton, quitar variable statica

        public BST<ClientModel> miArbolSerial = new BST<ClientModel>();

        public BST<ClientModel> miArbolEmail = new BST<ClientModel>();

        public AVLtree<ClientModel> miArbolAvlId = new AVLtree<ClientModel>();
        public AVLtree<ClientModel> miArbolAvlSerial = new AVLtree<ClientModel>();
        public AVLtree<ClientModel> miArbolAvlEmail = new AVLtree<ClientModel>();


    }
    
    
}
