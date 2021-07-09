using System;

namespace HomeworkParameters
{
    public static class Parameters
    {
        public static int GetParameter()
        {
            if (Int32.TryParse(Console.ReadLine(), out int parameter))
            {
                return parameter;
            }
            else
            {
                throw new ArgumentException("Invalid data entry");
            }
        }
        
    }
}
