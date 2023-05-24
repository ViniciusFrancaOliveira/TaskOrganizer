namespace TaskOrganizer.Model
{
    public class TaskGroup
    {
        public int TaskGroupId { get; set; }
        public IList<Task>? Tasks { get; set; }
    }
}
