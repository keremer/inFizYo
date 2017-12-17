using System;
using System.ComponentModel.DataAnnotations;

namespace inFizYon.CIQModels
{
    public partial class PartyeMail
    {
        [Display(Name = "email ID", Prompt = "email ID")]
        [Key]
        public int CIQPartyepostaID { get; set; }
       
        public int CIQPrID { get; set; }

        public DateTime CIQPartyepostavalidfrom { get; set; }
        public DateTime? CIQPartyepostavalidto { get; set; }
        public string CIQPartyeposta { get; set; }

        public enum EPostaAttribute : byte
        {
            main = 0,
            secondary = 1,
            work = 2
        };

        public EPostaAttribute EPostis { get; set; } // main, secondary, work
                
        public virtual PartyReal EmailOwner { get; set; }
    }
}