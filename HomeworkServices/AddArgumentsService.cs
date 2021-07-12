using System;
using System.Collections.Generic;
using HomeworkServices;
using Microsoft.SqlServer.Server;

namespace HomeworkService
{
    public static class AddArgumentsService
    {
        public static List<int> GetResult(string givenData)
        {
            var stringDataArr = givenData.Split('/');

            if (ContainsTwoValues(stringDataArr))
            {
                return GetAllDataList(stringDataArr);
            }
            else
            {
                throw new ArgumentException("Invalid data entry");
            }
        }

        private static bool ContainsTwoValues(string[] received)
        {
            return received.Length == 2;
        }

        private static List<int> GetAllDataList(string[] received)
        {
            var intDataList = new List<int>();
            int sum = 0;
            foreach (string part in received)
            {
                if (Int32.TryParse(part.Trim(), out int parameter))
                {
                    intDataList.Add(parameter);
                    sum += parameter;
                }
                else
                {
                    throw new ArgumentException("Invalid data entry");
                }
            }

            intDataList.Add(sum);

            return intDataList;
        }
    }
}
