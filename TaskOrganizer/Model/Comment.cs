namespace TaskOrganizer.Model
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Content { get; set; }
        public User CreadtedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }

        public Comment(User creator, string content)
        {
            CreadtedBy = creator;
            Content = content;
            CreatedDate = DateTime.UtcNow;
        }
    }
}
