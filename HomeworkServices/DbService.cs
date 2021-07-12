using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkData;

namespace HomeworkServices
{
    public class DbService
    {
        protected readonly HomeworkDbContext _context;
        public DbService(HomeworkDbContext context)
        {
            _context = context;
        }

        public void AddToDb(Result received)
        {
            _context.Results.Add(received);
        }

        public List<Result> GetAll()
        {
            var allResults = new List<Result>();

            foreach (var result in _context.Results)
            {
                allResults.Add(result);
            }

            return allResults;
        }

    }
}
