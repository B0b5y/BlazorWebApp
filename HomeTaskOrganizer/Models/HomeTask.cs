namespace HomeTaskOrganizer.Models
{
    public class HomeTask
    {
        public int  HomeTaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string AssignedTo {  get; set; }
        public bool IsCompleted { get; set; }

    }
}
