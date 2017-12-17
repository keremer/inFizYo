using inFizYon.CIQModels;

namespace inFizYon.Ontology
{
    public class Affiliation
    {
        public int CIQPrID { get; set; }
        public PartyReal Worker { get; set; }

        public int CIQPtID { get; set; }
        public PartyLegal Employer { get; set; }
    }
}
