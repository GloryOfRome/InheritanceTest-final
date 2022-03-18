namespace InheritanceTest_final.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public ICollection<Comment> Comments { get; set; }//1对多
    }
}
