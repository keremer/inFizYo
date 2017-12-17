namespace inFizYon
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using Ontology;

    public partial class Phrase
    {
        [Key]
        public int PhrsID { get; set; }
        public string PhrsTRtxt { get; set; }
        public string PhrsENtxt { get; set; }
        public byte PhrsComp { get; set; }
        public byte PhrsReliance { get; set; }
    
        public virtual InMF InMFSection { get; set; }
        public virtual ICollection<InProject> InProjects { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<Package> InPackages { get; set; }

        public List<PhraseLabel> Phraselabels { get; set; }
    }
}
