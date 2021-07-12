using HomeworkData;
using HomeworkService;
using System;
using HomeworkData.Migrations;
using HomeworkServices;

namespace AteaHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            DbService dbAccess = new DbService(new HomeworkDbContext());
            try
            {
                Console.WriteLine("Please enter two numbers separated by '/' :");
                
                //Inner logic as a Service
                var result = AddArgumentsService.GetResult(Console.ReadLine());

                Console.WriteLine($"Sum of given parameters {result[0]} and {result[1]} is - {result[2]}");
                Console.WriteLine("Uploading data to table ... wait");

                //Handling Server
                var sumOfParameters = new Result();
                sumOfParameters.Sum = result[2];
                
                dbAccess.AddToDb(sumOfParameters);
                Console.WriteLine("Added to Table.");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.GetType() + "\n\n" + e.Message + "\n\n" + e.StackTrace);
            }
            finally
            {
                Console.WriteLine("Data Stored:");
                foreach (var a in dbAccess.GetAll())
                {
                    Console.WriteLine(a.Sum);
                }
            }
            

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
