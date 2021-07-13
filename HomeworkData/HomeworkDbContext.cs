using System;
using System.Data.Entity;

namespace HomeworkData
{
    public class HomeworkDbContext : DbContext, IDisposable
    {
        public HomeworkDbContext() : base(("TableOfResults"))
        {

        }
        public DbSet<Result> Results { get; set; }
    }
}
