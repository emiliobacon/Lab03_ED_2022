using Lab03_ED_2022.BST;
using Lab03_ED_2022.Models;

namespace Lab03_ED_2022.Comparison
{
    public delegate int Compare<T>(T a, T b);

    public class Comparison
    { 
        public static int CompareString(string a, string b)
        {
            if (a != b)
            {
                if (a.CompareTo(b) < 0)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 0;
            }
        }

        public static int CompareInt(int a, int b)
        {
            if (a != b)
            {
                if (a > b)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {

                return 0;

            }
        }

        public static int CompararID(ClientModel a, ClientModel b)
        {
            if (a.Id != b.Id)
            {
                if (a.Id < b.Id)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 0;
            }
        }

        public static int CompararSerial(ClientModel a, ClientModel b)
        {
            if (a.SerialNo != b.SerialNo)
            {
                if (a.SerialNo.CompareTo(b.SerialNo) < 0)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 0;
            }
        }

        public static int CompararEmail(ClientModel a, ClientModel b)
        {
            if (a.Email != b.Email)
            {
                if (a.Email.CompareTo(b.Email) < 0)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 0;
            }
        }

        public static ClientModel CompararEmail(string a)
        {
            ClientModel parametro = new ClientModel();
            parametro.Email = a;
            return parametro;
        }
        public static ClientModel CompararSerial(string a)
        {
            ClientModel parametro = new ClientModel();
            parametro.SerialNo = a;
            return parametro;
        }

        public static ClientModel CompararID(int a)
        {
            ClientModel parametro = new ClientModel();
            parametro.Id = a;
            return parametro;
        }


        
    }

   
}

