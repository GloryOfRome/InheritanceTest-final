using InheritanceTest_final.Data;
using InheritanceTest_final.Models;
using Microsoft.EntityFrameworkCore;

namespace InheritanceTest_final
{
    public class SeedData//种子数据
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            var context = new InheritanceTest_finalContext(serviceProvider.GetRequiredService<DbContextOptions<InheritanceTest_finalContext>>());
            //GetRequiredService如果没有serviceType类型的服务，则抛出一个InvalidOperationException异常
            //InheritanceTest_finalContext这两个地方填代码在数据库中的文件名

            Question newQuestion = new Question
            {
                Title = "测试问题",
                Body = "我如何修复我的系统，当它坏了的时候"
            };
            context.Question.Add(newQuestion);//在context中添加newQuestion
            context.SaveChanges();//将改变保持

            Comment newComment = new Comment
            {
                Body = "你试过谷歌没有",
                Question = newQuestion
            };
            newQuestion.Comments.Add(newComment);
            context.Comment.Add(newComment);
            context.SaveChanges();//将改变保持

            Answer newAnswer = new Answer
            {
                Body = "卸载你的系统",
                Question = newQuestion,
                IsSelectedAnswer = true//选择答案
            };
            newQuestion.Comments.Add(newAnswer);
            context.Answer.Add(newAnswer);


            context.SaveChanges();//将改变保持
        }
    }
}
