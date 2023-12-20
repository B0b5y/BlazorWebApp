namespace HomeTaskOrganizer.Models
{
    public class HomeTask
    {
        private int  TaskId { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private DateTime Deadline { get; set; }
        private string AsingetTo {  get; set; }
        private bool IsCompleted { get; set; }

    }
}
