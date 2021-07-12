using System.ComponentModel.DataAnnotations;
using HomeworkServices;


namespace HomeworkData
{
    public class Result : IResult
    {
        [Key]
        public int Id { get; set; }
        public int Sum { get; set; }
    }
}
