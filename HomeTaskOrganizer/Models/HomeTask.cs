using System.ComponentModel.DataAnnotations;

namespace HomeTaskOrganizer.Models
{
    public class HomeTask
    {
        public int  HomeTaskId { get; set; }
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Deadline is required")]
        public DateTime Deadline { get; set; }
        [Required(ErrorMessage = "AssignedTo is required")]
        public string AssignedTo {  get; set; }
        public bool IsCompleted { get; set; }

    }
}
