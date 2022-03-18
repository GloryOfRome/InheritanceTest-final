using System.ComponentModel.DataAnnotations;

namespace InheritanceTest_final.Models
{
    public class Review : Comment//评价，打分
    {
        [Range(1, 10)]
        public int Score { get; set; }//得分
    }
}
