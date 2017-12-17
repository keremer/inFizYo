using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using inFizYon.Ontology;

namespace inFizYon.CIQModels
{
    public class PartyLegal
    {
        [Display(Name = "Kurum ID", Prompt = "Kurum ID")]
        [Key]
        public int CIQPtID { get; set; }

        [Display(Name = "Ticari Ünvan", Prompt = "Ticari Ünvan")]
        public string CIQPartyTuzelTicariUnvan { get; set; }

        [Display(Name = "Kayıt Giriş Tarihi", Prompt = "Kayıt Giriş Tarihi")]
        public DateTime CIQPartTuzelvalfrom { get; set; }

        [Display(Name = "Geçerlilik Tarihi", Prompt = "Geçerlilik Tarihi")]
        public Nullable<System.DateTime> CIQPartyvalto { get; set; }

        [Display(Name = "Vergi Dairesi", Prompt = "Vergi Dairesi")]
        public string CIQPartyvergid { get; set; }

        [Display(Name = "Vergi No", Prompt = "Vergi No")]
        public string CIQPartyTuzelvergino { get; set; }

        [Display(Name = "Kurum Türü", Prompt = "Kurum Türü")]
        public string CIQPartyTuzelintype { get; set; }

        public virtual ICollection<Affiliation> Labor { get; set; }
        
    }
}