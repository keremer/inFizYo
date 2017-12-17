using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace InFizYo.Models.ICoreModels
{
    public class IsVelet
    {
        [Key]
        public int LID { get; set; }
        public string VePozNo { get; set; }
        public string XPozNo { get; set; }
        public string Def { get; set; }
        public string MUnit { get; set; }
        public string DUnit { get; set; }
        public double Cst { get; set; }
        public DateTime Dte { get; set; }
        public string Notes { get; set; }
        public bool Include { get; set; }
    }
}
