using inFizYon.CIQModels;

namespace inFizYon.Ontology
{
    public class PartyAdress
    {
        public int CIQAdresPID { get; set; }
        public PartyPostalAdress PostalAdress { get; set; }

        public int CIQPrID { get; set; }
        public PartyReal AdressOwner { get; set; }
    }
}
