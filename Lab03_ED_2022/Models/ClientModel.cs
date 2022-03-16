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
        public int Id { get; set; } //aumentar mas digitos

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
            Data.Instance.miArbolId.InsertarNodo(data, Comparison.Comparison.CompararID);
            Data.Instance.miArbolEmail.InsertarNodo(data, Comparison.Comparison.CompararEmail);
            Data.Instance.miArbolSerial.InsertarNodo(data, Comparison.Comparison.CompararSerial);
            return true;
        }

        public static bool SaveAVLMode(ClientModel data)
        {
            Data.Instance.miArbolAvlId.insert(data, Comparison.Comparison.CompararID);
            Data.Instance.miArbolAvlEmail.insert(data, Comparison.Comparison.CompararEmail);
            Data.Instance.miArbolAvlSerial.insert(data, Comparison.Comparison.CompararSerial);
            return true;
        }
    }
}
