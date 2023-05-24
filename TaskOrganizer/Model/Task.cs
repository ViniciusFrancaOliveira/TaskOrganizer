namespace TaskOrganizer.Model
{
    public class Task
    {
        public int TaskId { get; set; }
        public string Title { get; set; }
        public User CreatedBy { get; set; }
        public User? LastUpdatedBy { get; set; }
        public string Description { get; set; }
        public TaskStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public DateTime? PlannedStartDate { get; set; }
        public DateTime? PlannedEndDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public IList<Comment> Comments { get; set; }

        public Task(string title, string description, User createdBy, TaskStatus taskStatus = TaskStatus.New)
        {
            Title = title;
            Description = description;
            CreatedBy = createdBy;
            Status = taskStatus;
            CreatedDate = DateTime.UtcNow;
            LastUpdatedDate = DateTime.UtcNow;
            Comments = new List<Comment>();
        }

        public void AddComment(User user, string content)
        {
            LastUpdatedBy = user;
            Comment comment = new(user, content);
            Comments.Add(comment);
            LastUpdatedDate = DateTime.UtcNow;
        }
    }
}
