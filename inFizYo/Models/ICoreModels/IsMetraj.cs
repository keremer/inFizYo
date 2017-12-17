using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InFizYo.Models.ICoreModels
{
    public class IsMetraj
    {
        [Key]
        public int MID { get; set; }
        public string Origin { get; set; }
        public string Def { get; set; }
        public double Similar { get; set;}
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }
        public double Dia { get; set; }
        public double Area { get; set; }
        public double Volume { get; set; }
        public double Xponent { get; set; }
        public double Qty { get; set; }
        public string UnitofM { get; set; }
        public bool SWd { get; set; }
        public bool SLn { get; set; }
        public bool SHt { get; set; }
        public bool SDa { get; set; }
        public bool SAr { get; set; }
        public bool SVk { get; set; }
        public bool SVc { get; set; }
        public bool SKg { get; set; }
        public bool Ovr { get; set; }


    }
}
