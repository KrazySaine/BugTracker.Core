namespace BugTracker.Core
{
    public class Bug
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public BugStatus Status { get; set; }
        public Bug(int id, string title, string description)
        {
            //TODO: Add guard clause for title
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title cannot be null, empty or whitespace.");
                Id = id;
                Title= title;
                Description = description;
                Status = BugStatus.Open;
            }
        }
        public void UpdateStatus(BugStatus newStatus)
        {
            Status = newStatus;
        }

    }
}
