using System.ComponentModel.DataAnnotations;
using HomeworkServices;

namespace HomeworkData
{
    public abstract class Element : IElement
    {
        [Key]
        public int Id { get; set; }
    }
}
