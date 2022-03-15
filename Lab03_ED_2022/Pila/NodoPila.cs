using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab03_ED_2022.Pila
{
    public class NodoPila<T>
    {
        public T Data { get; set; }
        public NodoPila<T> Siguiente { get; set; }
    }
}
