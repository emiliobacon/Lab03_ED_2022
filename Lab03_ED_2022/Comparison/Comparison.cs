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

        public static int CompararEmail(ClientModel a, ClientModel b)
        {
            if (a.Email != b.Email)
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
    }
}

