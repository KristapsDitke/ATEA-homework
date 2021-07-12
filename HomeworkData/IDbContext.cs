using System;
using System.Data.Entity;

namespace HomeworkData
{
    public interface IDbContext : IDisposable
    {
        DbSet<Result> Results { get; set; }
    }
}
