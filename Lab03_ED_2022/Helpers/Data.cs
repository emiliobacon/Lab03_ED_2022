using Lab03_ED_2022.BST;
using Lab03_ED_2022.Models;

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

        public BST<ClientModel> miArbolId = new BST<ClientModel>
        {
            comparar = Comparison.Comparison.CompararID
        };


        public BST<ClientModel> miArbolSerial = new BST<ClientModel>
        {
            comparar = Comparison.Comparison.CompararSerial
        };

        public BST<ClientModel> miArbolEmail = new BST<ClientModel>
        {
            comparar = Comparison.Comparison.CompararEmail
        };


    }


}
