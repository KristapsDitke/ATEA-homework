using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeworkData;

namespace HomeworkServices
{
    public interface IDbService
    {
       void AddToDb<T>(T received) where T : Result;
       T GetById<T>(int id) where T : Result;
       IEnumerable<T> GetAll<T>() where T : Result;
       void DeleteById<T>(int id) where T : Result;
    }
}
