using Lab03_ED_2022.BST;
using Lab03_ED_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab03_ED_2022.Helpers
{
    public class Data
    {
       public static BST<ClientModel> miArbolId = new BST<ClientModel>();
       public static BST<ClientModel> miArbolSerial = new BST<ClientModel>();
       public static BST<ClientModel> miArbolEmail = new BST<ClientModel>();
    }
    
    
}
