using Lab03_ED_2022.BST;
using Lab03_ED_2022.Helpers;
using Lab03_ED_2022.Comparison;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab03_ED_2022.Controllers;
using System.ComponentModel.DataAnnotations;

namespace Lab03_ED_2022.Models
{

    public class ClientModel
    {
        [Required]
        public long Id { get; set; } //aumentar mas digitos

        [Required]
        public string Email { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string CarColor { get; set; }
        [Required]
        public string CarModel { get; set; }
        [Required]
        public string SerialNo { get; set; }


        public static bool Save(ClientModel data)
        {
            Data.Instance.miArbolId.InsertarNodo(data);
            Data.Instance.miArbolEmail.InsertarNodo(data);
            Data.Instance.miArbolSerial.InsertarNodo(data);
         
            return true;
        }

        public static bool SaveAVLMode(ClientModel data)
        {
            Data.Instance.miArbolAvlId.insert(data);
            Data.Instance.miArbolAvlEmail.insert(data);
            Data.Instance.miArbolAvlSerial.insert(data);
            return true;
        }
    }
}
