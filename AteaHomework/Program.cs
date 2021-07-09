using HomeworkData;
using HomeworkParameters;
using HomeworkService;
using System;

namespace AteaHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new HomeworkDbContext())
            {
                try
                {
                    Console.WriteLine("Please enter two integer type parameters:");

                    //HomeworkParameters is as potential outer source for parameters in this case solved as user input
                    Console.Write("Parameter Nr.1 - ");
                    var parameterOne = Parameters.GetParameter();
                    Console.Write("Parameter Nr.2 - ");
                    var parameterTwo = Parameters.GetParameter();

                    //Inner logic as a Service
                    var result = AddArguments.GetResult(parameterOne, parameterTwo);

                    Console.WriteLine($"Sum of given parameters is - {result}");
                    Console.WriteLine("Uploading data to table ... wait");

                    //Handling Server
                    var sumOfParameters = new Result();
                    sumOfParameters.Sum = result;
                    dbContext.Results.Add(sumOfParameters);

                    Console.WriteLine("Added to Table.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.GetType() + "\n" + e.Message);
                }
                finally
                {
                    dbContext.SaveChanges();
                }
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
