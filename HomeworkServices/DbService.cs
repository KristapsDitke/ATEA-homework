using HomeworkData;
using System.Collections.Generic;
using System.Linq;

namespace HomeworkServices
{
    public class DbService : IDbService
    {
        protected readonly HomeworkDbContext _context;
        
        public DbService(HomeworkDbContext context)
        {
            _context = context;
        }

       public void AddToDb<T>(T received) where T : Element
        {
            _context.Set<T>().Add(received);
            _context.SaveChanges();
        }

       public T GetById<T>(int id) where T : Element
       {
          var requiredResult = _context.Set<T>().SingleOrDefault(result => result.Id == id);
          return requiredResult;
       }

       public IEnumerable<T> GetAll<T>() where T : Element
        {
            return _context.Set<T>().ToList();
        }

       public void DeleteById<T>(int id) where T : Element
       {
           var item = _context.Set<T>().SingleOrDefault(result => result.Id == id);
           if (item == null) return;
           _context.Set<T>().Remove(item);
           _context.SaveChanges();
        }
    }
}
