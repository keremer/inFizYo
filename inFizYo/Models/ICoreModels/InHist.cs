using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InFizYo.Models.ICoreModels
{
    public class InHist
    {
        [Key]
        public int HID { get; set; }
        public string THolder { get; set; }
        public string TContainer { get; set; }
        public string NewVal { get; set; }
        public DateTime ChangedOn { get; set; }
        public string ValFrom { get; set; }
        public string ValNote { get; set; }
        public string ChgBy { get; set; }
        public Boolean Shw { get; set;}

    }
}
