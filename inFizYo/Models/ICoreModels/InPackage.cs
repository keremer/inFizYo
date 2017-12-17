namespace inFizYon
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Package
    {
        [Key]
        public int InputID { get; set; }

        public int InPackageParent { get; set; }//Why? Documentation required
        public int ParentID { get; set; }       //Why? Documentation required
        public int InPackageChild { get; set; } //Why? Documentation required

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public enum ParLevel : byte //may not be necessary - data model changed to a recursive layout.
        {
            Package = 0,
            Division = 1,
            Section = 2,
            Part = 3,
            Article = 4,
            Indent1 = 5,
            Indent2 = 6,
            Indent3 = 7,
            Indent4 = 8,
            Indent5 = 9,            
            Smalltext = 10,
            Caption = 11,
            TableText = 12
        } 
        public enum ParType : byte //may not be necessary - data model changed to a recursive layout. 
        { 
            title = 0, 
            heading = 1, 
            article = 2,
            paragraph = 3, 
            nulst = 4,
            bulst = 5,
            standard = 6, 
            table = 7, 
            footnote = 8, 
            endnote = 9, 
            caption = 10, 
            reference = 11 
        }
        public ParLevel PLevel { get; set; }
        public ParType PType { get; set; }
        public short POrder { get; set; }

        public int InProjectID { get; set; }
        [ForeignKey("InProjectID")]
        public virtual InProject InProject { get; set; }

        public int childID { get; set; }
        [ForeignKey("ChildID")]
        public virtual Phrase Phrases { get; set; }
    }
}
