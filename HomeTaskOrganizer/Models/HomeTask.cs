namespace HomeTaskOrganizer.Models
{
    public class HomeTask
    {
        public int  TaskId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public string AsingetTo {  get; set; }
        public bool IsCompleted { get; set; }

    }
}
