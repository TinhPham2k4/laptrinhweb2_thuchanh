using System.ComponentModel.DataAnnotations;

namespace laptrinhweb2_thuchanh.Models.Domain
{
    public class Publishers
    {
        [Key]
        public int PublishersId { get; set; }
        public string? Name { get; set; }
        public List<Books>? Books { get; set; }
    }
}