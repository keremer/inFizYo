using inFizYon.CIQModels;

namespace inFizYon.AcademyModels
{
    public class PartyEvaluation
    {
        public int EvaluationID { get; set; }
        public Assignment ForAssignment { get; set; }
        public PartyReal ForStudent { get; set; }
        public Criterion ForCriteria { get; set; }
        public int Counter { get; set; }
        public int Score { get; set; }
    }
}
