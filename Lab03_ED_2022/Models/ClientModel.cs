﻿using Lab03_ED_2022.BST;
using Lab03_ED_2022.Helpers;
using Lab03_ED_2022.Comparison;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab03_ED_2022.Controllers;


namespace Lab03_ED_2022.Models
{

    public class ClientModel
    {
        public int Id { get; set; } //aumentar mas digitos
        public string Email { get; set; }
        public string FullName { get; set; }
        public string CarColor { get; set; }
        public string CarModel { get; set; }
        public string SerialNo { get; set; }


        public static bool Save(ClientModel data)
        {
            Data.Instance.miArbolId.InsertarNodo(data);
            Data.Instance.miArbolEmail.InsertarNodo(data);
            Data.Instance.miArbolSerial.InsertarNodo(data);
            return true;
        }

       


    }
}
