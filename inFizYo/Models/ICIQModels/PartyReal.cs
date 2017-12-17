using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using inFizYon.Ontology;

namespace inFizYon.CIQModels
{
    public partial class PartyReal
    {
        [Display(Name = "studentID", Prompt = "student No")]
        [Key]
        public int CIQPrID { get; set; }

        [Display(Name = "Ünvan", Prompt = "Ünvan")]
        public int CIQPrtitle { get; set; }

        [Display(Name = "First Name", Prompt = "First Name")]
        public int CIQPrname { get; set; }

        [Display(Name = "Maiden Name", Prompt = "Maiden Name")]
        public int CIQPrmidname { get; set; }

        [Display(Name = "Surname", Prompt = "Surname")]
        public int CIQPrsurname { get; set; }

        [Display(Name = "Nationality", Prompt = "Nationality")]
        public int CIQPruyruk { get; set; }

        [Display(Name = "Birth Date", Prompt = "Birthday")]
        public DateTime CIQPrdt { get; set; }

        [Display(Name = "Place of Birth", Prompt = "Place of Birth")]
        public int CIQPrdy { get; set; }

        [Display(Name = "Father Name", Prompt = "Father Name")]
        public int CIQPrbabaad { get; set; }

        [Display(Name = "Mother Name", Prompt = "Mother Name")]
        public int CIQPrannead { get; set; }

        [Display(Name = "Social Security Nr", Prompt = "Social Security Number")]
        public string CIQPrssec { get; set; }

        [Display(Name = "TR ID Nr", Prompt = "TC Kimlik No")]
        public string CIQPrkimlikmaster { get; set; }

        [Display(Name = "Photo", Prompt = "Photo")]
        public byte[] CIQPrResim { get; set; }

        [Display(Name = "Notes", Prompt = "Notes")]
        public int Not { get; set; }

        //public virtual ICollection<PartyAffiliation> PartyAffiliations { get; set; }

        public virtual ICollection<Phrase> PhraseRepository { get; set; }

        public virtual ICollection<PartyPassport> PartyPassports { get; set; }
        public virtual ICollection<PartyVisa> PartyVisas { get; set; }
        public virtual ICollection<Affiliation> PartyEmployment { get; set; }
        public virtual ICollection<PartyeMail> PartyMails { get; set; }
        public virtual ICollection<PartyAdress> PAdressHost { get; set; }
        public virtual List<PhoneOwner> PPhoneNumber { get; set; }
        // public virtual ICollection<M3PCostItems> servemats { get; set; }
        // public virtual ICollection<PartyEmploymentData> partyEmploymentDetails { get; set; }
    }
}