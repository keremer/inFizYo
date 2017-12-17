
namespace inFizYon
{

    public partial class Comment
    {
        public int CommentID { get; set; }
        public string CommentTxt { get; set; }
        public virtual Phrase Commented { get; set; }
    }
}
