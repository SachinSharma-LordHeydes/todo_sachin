using System.ComponentModel.DataAnnotations;

namespace todosachin.Models
{
    public class TaskList
    {

        public int Id { get; set; }
        [Required]
        [Display(Name = "Task")]
        public string Task { get; set; }

        [Required]
        [Display(Name = "Description")]
        public string Description{ get; set; }

        [Required]
        [Display(Name = "Status")]
        public string Status{ get; set; }

        [Required]
        [Display(Name = "Test")]
        public string Test { get; set; }


    }
}
