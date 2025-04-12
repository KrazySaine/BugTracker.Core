namespace BugTracker.Core
{
    public class Bug
    {
        public int id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public BugStatus Status { get; set; }
        public void UpdateStatus(BugStatus newStatus)
        {
            Status = newStatus;
        }

    }
    public enum BugStatus
    {
        Open,
        InProgress,
        Resolved,
        Closed
    }
}
