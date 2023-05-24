using TaskOrganizer.ValueObject;

namespace TaskOrganizer.Model
{
    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Email Email { get; set; }
        public string Password { get; set; }
        public DateTime? RegisteredAt { get; set; }
        public IList<TaskGroup>? TaskGroupss { get; set; }

        public User(string username, string firstName, string lastName, string password, Email email)
        {
            Username = username;
            FirstName = firstName;
            LastName = lastName;
            Password = password;
            Email = email;
        }
    }
}
