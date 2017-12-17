using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace InFizYo.Models.ICoreModels
{
    public class IsAttach
    {
        [Key]
        public int AID { get; set; }
        public int OID { get; set; }
        public string APozNo { get; set; }
        public object AContent { get; set; }
        public bool Publishit { get; set; }
        public DateTime Datasman { get; set; }
    }
}
