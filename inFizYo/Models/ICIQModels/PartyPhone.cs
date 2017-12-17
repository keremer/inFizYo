using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using inFizYon.Ontology;

namespace inFizYon.CIQModels
{
    public class PartyPhone
    {
        [Display(Name = "phone ID", Prompt = "phone ID")]
        [Key]
        public string CIQPhoneNrID { get; set; }

        public DateTime? CIQPhonevalto { get; set; }
        public DateTime CIQPhonevalfrom { get; set; }
        public string CIQPager { get; set; }
        public byte CIQPhonetype { get; set; }
        public byte CIQDatarel { get; set; }
        public byte CIQRelstate { get; set; } // not reachable, wrong number, phonetype mismatch
        public string CIQPswitchboard { get; set; } // i.e. PBX
        public string CIQPnrrange { get; set; } // i.e. PBX  - pool last two digits ie. 00 thru 40

        public virtual List<PhoneOwner> PhoneBelongsto { get; set; }
    }
}