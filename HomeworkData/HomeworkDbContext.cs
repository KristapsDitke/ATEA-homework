using System.Data.Entity;

namespace HomeworkData
{
    public class HomeworkDbContext : DbContext
    {
        public HomeworkDbContext() : base("ResultTable")
        {

        }
        public DbSet<Result> Results { get; set; }
    }
}
