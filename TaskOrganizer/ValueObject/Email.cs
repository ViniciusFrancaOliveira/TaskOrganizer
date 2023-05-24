namespace TaskOrganizer.ValueObject
{
    public class Email
    {
        public string EmailAddress { get; set; }
        public string EmailBody { get; set; }

        public Email(string emailAddress, string emailBody)
        {
            EmailAddress = emailAddress;
            EmailBody = emailBody;
        }
    }
}
