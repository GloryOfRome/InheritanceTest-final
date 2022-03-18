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

        public DbSet<InheritanceTest_final.Models.Question> Question { get; set; }
    }
}
