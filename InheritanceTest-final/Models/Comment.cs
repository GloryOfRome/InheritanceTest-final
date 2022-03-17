namespace InheritanceTest_final.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public Question Question { get; set; }//1对1
        public int QuestionId { get; set; }
    }
}
