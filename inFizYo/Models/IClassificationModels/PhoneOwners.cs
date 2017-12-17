using inFizYon.CIQModels;

namespace inFizYon.Ontology
{
    public class PhoneOwner
    {
        public int CIQPrID { get; set; }
        public PartyReal Person {get;set;}

        public string CIQPhoneNrID { get; set; }
        public PartyPhone PhoneNumber { get; set; }
    }
}
