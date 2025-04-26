namespace BugTracker.Core
{
    public class Bug
    {
        public int BugId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public BugStatus Status { get; set; }

        public Bug(int bugId, string title, string description)
        {
            // Guard clause for title
            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException("Title cannot be null, empty or whitespace.");
            }

            BugId = bugId;
            Title = title;
            Description = description;
            Status = BugStatus.Open;
        }

        public void UpdateStatus(BugStatus newStatus)
        {
            Status = newStatus;
        }

        
        private BugStatus AssignedToDeveloper(int bugId, BugStatus status)
        {
            BugId = bugId;
            Status = BugStatus.InProgress;
            return Status;
        }
    }
}
