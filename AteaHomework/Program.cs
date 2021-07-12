using HomeworkData;
using HomeworkService;
using HomeworkServices;
using System;

namespace AteaHomework
{
    class Program
    {
        public static DbService dbAccess = new DbService(new HomeworkDbContext());
        static void Main(string[] args)
        {
            bool noExit = true;
            int actionOption = 1;

            try
            {
                do
                {
                    switch (actionOption)
                    {
                        case 1:
                            ProvideNewValues();
                            break;
                        case 2:
                            GetAllData();
                            break;
                        case 3:
                            RemoveItem();
                            break;
                        default:
                            noExit = false;
                            break;
                    }

                    Console.WriteLine("\nType:\n1 -> to add more numbers;\n2 -> to see all data in table;\n3 -> to remove item\nOr type anything else to exit.");

                    if (!int.TryParse(Console.ReadKey().KeyChar.ToString(), out actionOption) || actionOption > 3 || actionOption == 0)
                    {
                        noExit = false;
                    }

                } while (noExit);

            }
            catch (Exception exceptionThrown)
            {
                Console.WriteLine(exceptionThrown.GetType() + "\n\n" + exceptionThrown.Message + "\n\n" + exceptionThrown.StackTrace);
                Console.ReadKey();
            }
        }

        private static void RemoveItem()
        {
            Console.WriteLine("\nEnter id for value to remove:");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                if (dbAccess.GetById<Result>(id) != null)
                {
                    dbAccess.DeleteById<Result>(id);
                }
            }
        }

        private static void GetAllData()
        {
            Console.WriteLine("\nData stored:");
            foreach (var result in dbAccess.GetAll<Result>())
            {
                Console.WriteLine("Nr." + result.Id + ") -> " + result.Sum);
            }
        }

        private static void ProvideNewValues()
        {
            Console.WriteLine("\nPlease enter two numbers separated by '/' :");
            var listOfValues = AddArgumentsService.GetResult(Console.ReadLine());

            Console.WriteLine($"Sum of given parameters {listOfValues[0]} and {listOfValues[1]} is - {listOfValues[2]}");
            Console.WriteLine("Uploading data to table ... please wait");

            var sumOfParameters = new Result();
            sumOfParameters.Sum = listOfValues[2];
            dbAccess.AddToDb(sumOfParameters);

            Console.WriteLine("Added to Table.");
        }
    }
}
