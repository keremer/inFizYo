﻿namespace inFizYon.AcademyModels
{
    public class Criterion
    {
        public enum CriteriaType
        { goodbad, pScore, pPercent, aScore, aPercent }
        public int CriteriaID { get; set; }
        public string CriteriaDef { get; set; }
        public CriteriaType? CrType { get; set; }

        public Assignment AssignmentCriterion { get; set; } 
    }
}
