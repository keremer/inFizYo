using System.Collections.Generic;

namespace inFizYon.Ontology
{
    public class Label
    {
        public string LabelID { get; set; }
        public enum metaData : byte
        {
            Custom = 0,
            MasterFormat = 1,
            UniFormat = 2
        };
        public metaData Origin { get; set; }

        public ICollection<Phrase> Phrases { get; set; }
        public List<PhraseLabel> Phraselabels { get; set; }
    }
}