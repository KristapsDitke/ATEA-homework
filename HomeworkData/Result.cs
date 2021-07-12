using System.ComponentModel.DataAnnotations;


namespace HomeworkData
{
    public class Result
    {
        [Key]
        public int Id { get; set; }
        public int Sum { get; set; }
    }
}
