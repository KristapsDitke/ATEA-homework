using HomeworkData;
using System.Collections.Generic;

namespace HomeworkServices
{
    public interface IDbService
    {
       void AddToDb<T>(T received) where T : Element;
       T GetById<T>(int id) where T : Element;
       IEnumerable<T> GetAll<T>() where T : Element;
       void DeleteById<T>(int id) where T : Element;
    }
}
