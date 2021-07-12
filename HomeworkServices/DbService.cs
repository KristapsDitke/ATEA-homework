using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkData;

namespace HomeworkServices
{
    public class DbService : IDbService
    {
        protected readonly HomeworkDbContext _context;
        public DbService(HomeworkDbContext context)
        {
            _context = context;
        }

       public void AddToDb<T>(T received) where T : Result
        {
            _context.Results.Add(received);
            _context.SaveChanges();
        }

       public T GetById<T>(int id) where T : Result
       {
          var requiredResult = _context.Results.SingleOrDefault(result => result.Id == id);
          return (T) requiredResult;
       }

       public IEnumerable<T> GetAll<T>() where T : Result
        {
            var allResults = new List<Result>();

            foreach (var result in _context.Results)
            {
                allResults.Add(result);
            }

            return (IEnumerable<T>) allResults;
        }

       public void DeleteById<T>(int id) where T : Result
       {
           _context.Results.Remove(_context.Results.SingleOrDefault(result => result.Id == id));
           _context.SaveChanges();
        }
    }
}
