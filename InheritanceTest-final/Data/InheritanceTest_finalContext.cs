#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InheritanceTest_final.Models;

namespace InheritanceTest_final.Data
{
    public class InheritanceTest_finalContext : DbContext
    {
        public InheritanceTest_finalContext (DbContextOptions<InheritanceTest_finalContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Comment>().HasDiscriminator<string>("Type")
                .HasValue<Comment>("C")//HasValue返回的结果是bool类型
                .HasValue<Answer>("A");
        }
        public DbSet<InheritanceTest_final.Models.Question> Question { get; set; }
        public DbSet<Answer> Answer { get; set; }
        public DbSet<Comment> Comment { get; set; }
    }
}
